using System;
using System.Windows.Forms;
using PLCController.Services;
using PLCController.Services.IServices;

namespace PLCController.UI
{
    public partial class MainForm : Form
    {
        private readonly IPlcService _plc;

        public MainForm()
        {
            InitializeComponent();
            _plc = new MockPlcService(); // use your actual service here
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void btnToggleMotor_Click(object sender, EventArgs e)
        {
            var status = _plc.ReadInputsAndOutputs();
            var currentMotor = status["MotorOn"];
            _plc.WriteOutput("MotorOn", !currentMotor);
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            var status = _plc.ReadInputsAndOutputs();

            lblMotor.Text = status["MotorOn"] ? "✅ Motor: ON" : "❌ Motor: OFF";
            lblWarning.Text = status["WarningLightOn"] ? "⚠️ Warning active" : "🟢 All OK";
        }
    }
}
