namespace PH_Name_Calculator
{
    partial class MadeBy
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
            this.LinkXiawave = new System.Windows.Forms.LinkLabel();
            this.LblName = new System.Windows.Forms.Label();
            this.PictureBorg = new System.Windows.Forms.PictureBox();
            this.LblChanges = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBorg)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkXiawave
            // 
            this.LinkXiawave.AutoSize = true;
            this.LinkXiawave.Location = new System.Drawing.Point(181, 36);
            this.LinkXiawave.Name = "LinkXiawave";
            this.LinkXiawave.Size = new System.Drawing.Size(249, 19);
            this.LinkXiawave.TabIndex = 1;
            this.LinkXiawave.TabStop = true;
            this.LinkXiawave.Text = "https://prohardver.hu/tag/xiawave.html";
            this.LinkXiawave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.LblName.Location = new System.Drawing.Point(192, 71);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(207, 67);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Xiawave";
            // 
            // PictureBorg
            // 
            this.PictureBorg.Image = global::PH_Name_Calculator.Properties.Resources.borg;
            this.PictureBorg.Location = new System.Drawing.Point(35, 36);
            this.PictureBorg.Name = "PictureBorg";
            this.PictureBorg.Size = new System.Drawing.Size(100, 100);
            this.PictureBorg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBorg.TabIndex = 0;
            this.PictureBorg.TabStop = false;
            // 
            // LblChanges
            // 
            this.LblChanges.BackColor = System.Drawing.SystemColors.Control;
            this.LblChanges.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LblChanges.ForeColor = System.Drawing.Color.Black;
            this.LblChanges.Location = new System.Drawing.Point(-13, 168);
            this.LblChanges.Name = "LblChanges";
            this.LblChanges.Size = new System.Drawing.Size(452, 183);
            this.LblChanges.TabIndex = 3;
            this.LblChanges.Text = "Javítások\r\n\r\n-Felhasználó avatárjának megjelenítése\r\n- Több felhasználó adatlapjá" +
    "nak elérése\r\n- Hibakezelések";
            this.LblChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MadeBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 423);
            this.Controls.Add(this.LblChanges);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LinkXiawave);
            this.Controls.Add(this.PictureBorg);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MadeBy";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PH Kommentek 1.1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBorg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBorg;
        private System.Windows.Forms.LinkLabel LinkXiawave;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblChanges;
    }
}