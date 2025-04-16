
namespace PLCController.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnToggleMotor;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblWarning;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnToggleMotor = new System.Windows.Forms.Button();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
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
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(30, 80);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(71, 15);
            this.lblMotor.TabIndex = 1;
            this.lblMotor.Text = "Motor: OFF";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(30, 110);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(92, 15);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "Warning: NONE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.btnToggleMotor);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.lblWarning);
            this.Name = "MainForm";
            this.Text = "PLC WinForms UI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
