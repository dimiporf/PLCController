namespace PLCController.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnToggleMotor;
        private System.Windows.Forms.Button btnRefreshLogs;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ListBox lstLogs;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnToggleMotor = new System.Windows.Forms.Button();
            this.btnRefreshLogs = new System.Windows.Forms.Button();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnToggleMotor
            // 
            this.btnToggleMotor.Location = new System.Drawing.Point(30, 30);
            this.btnToggleMotor.Name = "btnToggleMotor";
            this.btnToggleMotor.Size = new System.Drawing.Size(120, 30);
            this.btnToggleMotor.TabIndex = 0;
            this.btnToggleMotor.Text = "Toggle Motor";
            this.btnToggleMotor.UseVisualStyleBackColor = true;
            this.btnToggleMotor.Click += new System.EventHandler(this.btnToggleMotor_Click);
            // 
            // btnRefreshLogs
            // 
            this.btnRefreshLogs.Location = new System.Drawing.Point(160, 30);
            this.btnRefreshLogs.Name = "btnRefreshLogs";
            this.btnRefreshLogs.Size = new System.Drawing.Size(120, 30);
            this.btnRefreshLogs.TabIndex = 1;
            this.btnRefreshLogs.Text = "Refresh Logs";
            this.btnRefreshLogs.UseVisualStyleBackColor = true;
            this.btnRefreshLogs.Click += new System.EventHandler(this.btnRefreshLogs_Click);
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(30, 80);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(71, 15);
            this.lblMotor.TabIndex = 2;
            this.lblMotor.Text = "Motor: OFF";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(30, 110);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(92, 15);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "Warning: NONE";
            // 
            // lstLogs
            // 
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.ItemHeight = 15;
            this.lstLogs.Location = new System.Drawing.Point(30, 140);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(500, 300); // enlarged
            this.lstLogs.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.btnRefreshLogs);
            this.Controls.Add(this.btnToggleMotor);
            this.Name = "MainForm";
            this.Text = "PLC WinForms UI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
