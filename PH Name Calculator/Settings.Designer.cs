namespace PH_Name_Calculator
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTema = new System.Windows.Forms.Label();
            this.RadioLight = new System.Windows.Forms.RadioButton();
            this.RadioDark = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LblTema
            // 
            this.LblTema.AutoSize = true;
            this.LblTema.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblTema.Location = new System.Drawing.Point(12, 9);
            this.LblTema.Name = "LblTema";
            this.LblTema.Size = new System.Drawing.Size(88, 41);
            this.LblTema.TabIndex = 0;
            this.LblTema.Text = "Téma";
            // 
            // RadioLight
            // 
            this.RadioLight.AutoSize = true;
            this.RadioLight.Location = new System.Drawing.Point(143, 28);
            this.RadioLight.Name = "RadioLight";
            this.RadioLight.Size = new System.Drawing.Size(86, 27);
            this.RadioLight.TabIndex = 1;
            this.RadioLight.TabStop = true;
            this.RadioLight.Text = "Világos";
            this.RadioLight.UseVisualStyleBackColor = true;
            // 
            // RadioDark
            // 
            this.RadioDark.AutoSize = true;
            this.RadioDark.Location = new System.Drawing.Point(265, 28);
            this.RadioDark.Name = "RadioDark";
            this.RadioDark.Size = new System.Drawing.Size(71, 27);
            this.RadioDark.TabIndex = 2;
            this.RadioDark.TabStop = true;
            this.RadioDark.Text = "Sötét";
            this.RadioDark.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 87);
            this.Controls.Add(this.RadioDark);
            this.Controls.Add(this.RadioLight);
            this.Controls.Add(this.LblTema);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTema;
        private System.Windows.Forms.RadioButton RadioLight;
        private System.Windows.Forms.RadioButton RadioDark;
    }
}