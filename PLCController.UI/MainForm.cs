using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace PLCController.UI
{
    public partial class MainForm : Form
    {
        private readonly string apiBase = "https://localhost:54469/api"; // Προσαρμόστε ανάλογα το port

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await UpdateStatus();
        }

        private async void btnToggleMotor_Click(object sender, EventArgs e)
        {
            try
            {
                using var http = new HttpClient();

                // Get current status
                var status = await http.GetFromJsonAsync<Dictionary<string, bool>>($"{apiBase}/plc/status");
                bool currentMotor = status["MotorOn"];

                // Send toggle command
                var cmd = new
                {
                    outputName = "MotorOn",
                    state = !currentMotor
                };

                var response = await http.PostAsJsonAsync($"{apiBase}/plc/command", cmd);

                if (response.IsSuccessStatusCode)
                {
                    lblMotor.Text = cmd.state ? "✅ Motor: ON" : "❌ Motor: OFF";
                    await UpdateStatus();
                }
                else
                {
                    MessageBox.Show("Command failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnRefreshLogs_Click(object sender, EventArgs e)
        {
            try
            {
                using var http = new HttpClient();
                var logs = await http.GetFromJsonAsync<List<string>>($"{apiBase}/log");

                lstLogs.Items.Clear();

                if (logs != null && logs.Count > 0)
                {
                    foreach (var log in logs)
                        lstLogs.Items.Add(log);
                }
                else
                {
                    lstLogs.Items.Add("(no logs)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load logs: " + ex.Message);
            }
        }

        private async Task UpdateStatus()
        {
            try
            {
                using var http = new HttpClient();
                var status = await http.GetFromJsonAsync<Dictionary<string, bool>>($"{apiBase}/plc/status");

                lblMotor.Text = status["MotorOn"] ? "✅ Motor: ON" : "❌ Motor: OFF";
                lblWarning.Text = status["WarningLightOn"] ? "⚠️ Warning active" : "🟢 All OK";
            }
            catch
            {
                lblMotor.Text = "Motor: N/A";
                lblWarning.Text = "Warning: N/A";
            }
        }
    }
}
