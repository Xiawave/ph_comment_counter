namespace PH_Name_Calculator
{
    partial class Prohardver
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prohardver));
            this.TxtTopicName = new System.Windows.Forms.TextBox();
            this.LblSzakmaiHsz = new System.Windows.Forms.Label();
            this.LblKozossegiHsz = new System.Windows.Forms.Label();
            this.DgvUsername = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTopicName = new System.Windows.Forms.Label();
            this.LblCommentCount = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblPiaciHsz = new System.Windows.Forms.Label();
            this.LblSzakmai = new System.Windows.Forms.Label();
            this.LblKozossegi = new System.Windows.Forms.Label();
            this.LblPiaci = new System.Windows.Forms.Label();
            this.GroupAdatok = new System.Windows.Forms.GroupBox();
            this.LblComment = new System.Windows.Forms.Label();
            this.CheckExtended = new System.Windows.Forms.CheckBox();
            this.GroupFelh = new System.Windows.Forms.GroupBox();
            this.PictureProfile = new System.Windows.Forms.PictureBox();
            this.GroupExtended = new System.Windows.Forms.GroupBox();
            this.CheckSaveResults = new System.Windows.Forms.CheckBox();
            this.LBlUtolso2 = new System.Windows.Forms.Label();
            this.LblUtolso1 = new System.Windows.Forms.Label();
            this.NumericLastComments = new System.Windows.Forms.NumericUpDown();
            this.StatusCurrent = new System.Windows.Forms.StatusStrip();
            this.ProgressSearch = new System.Windows.Forms.ToolStripProgressBar();
            this.LblLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MadeByToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.PhToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NotifyPH = new System.Windows.Forms.NotifyIcon(this.components);
            this.LblUsrName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsername)).BeginInit();
            this.GroupAdatok.SuspendLayout();
            this.GroupFelh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProfile)).BeginInit();
            this.GroupExtended.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLastComments)).BeginInit();
            this.StatusCurrent.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTopicName
            // 
            this.TxtTopicName.BackColor = System.Drawing.Color.White;
            this.TxtTopicName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTopicName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtTopicName.ForeColor = System.Drawing.Color.Black;
            this.TxtTopicName.Location = new System.Drawing.Point(11, 65);
            this.TxtTopicName.Name = "TxtTopicName";
            this.TxtTopicName.Size = new System.Drawing.Size(376, 34);
            this.TxtTopicName.TabIndex = 0;
            this.TxtTopicName.TextChanged += new System.EventHandler(this.TxtTopicName_TextChanged);
            // 
            // LblSzakmaiHsz
            // 
            this.LblSzakmaiHsz.BackColor = System.Drawing.Color.LightGray;
            this.LblSzakmaiHsz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSzakmaiHsz.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.LblSzakmaiHsz.Location = new System.Drawing.Point(19, 144);
            this.LblSzakmaiHsz.Name = "LblSzakmaiHsz";
            this.LblSzakmaiHsz.Size = new System.Drawing.Size(250, 50);
            this.LblSzakmaiHsz.TabIndex = 2;
            this.LblSzakmaiHsz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblKozossegiHsz
            // 
            this.LblKozossegiHsz.BackColor = System.Drawing.Color.LightGray;
            this.LblKozossegiHsz.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.LblKozossegiHsz.Location = new System.Drawing.Point(19, 239);
            this.LblKozossegiHsz.Name = "LblKozossegiHsz";
            this.LblKozossegiHsz.Size = new System.Drawing.Size(250, 50);
            this.LblKozossegiHsz.TabIndex = 3;
            this.LblKozossegiHsz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatagridviewFelh
            // 
            this.DgvUsername.AllowUserToAddRows = false;
            this.DgvUsername.AllowUserToDeleteRows = false;
            this.DgvUsername.AllowUserToResizeColumns = false;
            this.DgvUsername.AllowUserToResizeRows = false;
            this.DgvUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvUsername.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsername.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvUsername.BackgroundColor = System.Drawing.Color.Silver;
            this.DgvUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvUsername.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvUsername.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsername.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsername.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsername.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.comment});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUsername.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUsername.Location = new System.Drawing.Point(12, 197);
            this.DgvUsername.Name = "DatagridviewFelh";
            this.DgvUsername.ReadOnly = true;
            this.DgvUsername.RowHeadersVisible = false;
            this.DgvUsername.RowTemplate.Height = 24;
            this.DgvUsername.Size = new System.Drawing.Size(531, 410);
            this.DgvUsername.TabIndex = 4;
            this.DgvUsername.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridviewFelh_CellClick);
            // 
            // username
            // 
            this.username.HeaderText = "Felhasználónév";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // comment
            // 
            this.comment.HeaderText = "Kommentek Száma";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            // 
            // LblTopicName
            // 
            this.LblTopicName.AutoSize = true;
            this.LblTopicName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTopicName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblTopicName.ForeColor = System.Drawing.Color.Black;
            this.LblTopicName.Location = new System.Drawing.Point(6, 30);
            this.LblTopicName.Name = "LblTopicName";
            this.LblTopicName.Size = new System.Drawing.Size(109, 28);
            this.LblTopicName.TabIndex = 5;
            this.LblTopicName.Text = "Topik neve:";
            this.LblTopicName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCommentCount
            // 
            this.LblCommentCount.AutoSize = true;
            this.LblCommentCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblCommentCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblCommentCount.ForeColor = System.Drawing.Color.Black;
            this.LblCommentCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCommentCount.Location = new System.Drawing.Point(6, 105);
            this.LblCommentCount.Name = "LblCommentCount";
            this.LblCommentCount.Size = new System.Drawing.Size(181, 28);
            this.LblCommentCount.TabIndex = 6;
            this.LblCommentCount.Text = "Kommentek száma:";
            this.LblCommentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnKereses
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.LightGray;
            this.BtnSearch.Enabled = false;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnSearch.Location = new System.Drawing.Point(393, 63);
            this.BtnSearch.Name = "BtnKereses";
            this.BtnSearch.Size = new System.Drawing.Size(119, 34);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "Keresés";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnKereses_Click);
            // 
            // LblPiaciHsz
            // 
            this.LblPiaciHsz.BackColor = System.Drawing.Color.LightGray;
            this.LblPiaciHsz.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.LblPiaciHsz.Location = new System.Drawing.Point(19, 334);
            this.LblPiaciHsz.Name = "LblPiaciHsz";
            this.LblPiaciHsz.Size = new System.Drawing.Size(250, 50);
            this.LblPiaciHsz.TabIndex = 8;
            this.LblPiaciHsz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSzakmai
            // 
            this.LblSzakmai.AutoSize = true;
            this.LblSzakmai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSzakmai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblSzakmai.ForeColor = System.Drawing.Color.Black;
            this.LblSzakmai.Location = new System.Drawing.Point(19, 110);
            this.LblSzakmai.Name = "LblSzakmai";
            this.LblSzakmai.Size = new System.Drawing.Size(167, 23);
            this.LblSzakmai.TabIndex = 10;
            this.LblSzakmai.Text = "Szakmai hozzászólás";
            // 
            // LblKozossegi
            // 
            this.LblKozossegi.AutoSize = true;
            this.LblKozossegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblKozossegi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblKozossegi.ForeColor = System.Drawing.Color.Black;
            this.LblKozossegi.Location = new System.Drawing.Point(19, 206);
            this.LblKozossegi.Name = "LblKozossegi";
            this.LblKozossegi.Size = new System.Drawing.Size(180, 23);
            this.LblKozossegi.TabIndex = 11;
            this.LblKozossegi.Text = "Közösségi hozzászólás";
            // 
            // LblPiaci
            // 
            this.LblPiaci.AutoSize = true;
            this.LblPiaci.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblPiaci.ForeColor = System.Drawing.Color.Black;
            this.LblPiaci.Location = new System.Drawing.Point(19, 302);
            this.LblPiaci.Name = "LblPiaci";
            this.LblPiaci.Size = new System.Drawing.Size(140, 23);
            this.LblPiaci.TabIndex = 12;
            this.LblPiaci.Text = "Piaci hozzászólás";
            // 
            // GroupAdatok
            // 
            this.GroupAdatok.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupAdatok.Controls.Add(this.LblComment);
            this.GroupAdatok.Controls.Add(this.CheckExtended);
            this.GroupAdatok.Controls.Add(this.LblTopicName);
            this.GroupAdatok.Controls.Add(this.TxtTopicName);
            this.GroupAdatok.Controls.Add(this.BtnSearch);
            this.GroupAdatok.Controls.Add(this.LblCommentCount);
            this.GroupAdatok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupAdatok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupAdatok.Location = new System.Drawing.Point(12, 33);
            this.GroupAdatok.Name = "GroupAdatok";
            this.GroupAdatok.Size = new System.Drawing.Size(531, 158);
            this.GroupAdatok.TabIndex = 11;
            this.GroupAdatok.TabStop = false;
            this.GroupAdatok.Text = "Adatok";
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Location = new System.Drawing.Point(193, 106);
            this.LblComment.Margin = new System.Windows.Forms.Padding(0);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(0, 28);
            this.LblComment.TabIndex = 9;
            this.LblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckExtended
            // 
            this.CheckExtended.AutoCheck = false;
            this.CheckExtended.AutoSize = true;
            this.CheckExtended.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckExtended.Location = new System.Drawing.Point(121, 26);
            this.CheckExtended.Name = "CheckExtended";
            this.CheckExtended.Size = new System.Drawing.Size(178, 32);
            this.CheckExtended.TabIndex = 8;
            this.CheckExtended.Text = "Részletes Keresés";
            this.CheckExtended.UseVisualStyleBackColor = true;
            this.CheckExtended.Click += new System.EventHandler(this.CheckExtended_Click);
            // 
            // GroupFelh
            // 
            this.GroupFelh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupFelh.Controls.Add(this.LblUsrName);
            this.GroupFelh.Controls.Add(this.PictureProfile);
            this.GroupFelh.Controls.Add(this.LblPiaci);
            this.GroupFelh.Controls.Add(this.LblKozossegi);
            this.GroupFelh.Controls.Add(this.LblPiaciHsz);
            this.GroupFelh.Controls.Add(this.LblSzakmai);
            this.GroupFelh.Controls.Add(this.LblKozossegiHsz);
            this.GroupFelh.Controls.Add(this.LblSzakmaiHsz);
            this.GroupFelh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupFelh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupFelh.Location = new System.Drawing.Point(561, 197);
            this.GroupFelh.Name = "GroupFelh";
            this.GroupFelh.Size = new System.Drawing.Size(506, 410);
            this.GroupFelh.TabIndex = 12;
            this.GroupFelh.TabStop = false;
            this.GroupFelh.Text = "Felhasználó adatai";
            // 
            // PictureProfile
            // 
            this.PictureProfile.Location = new System.Drawing.Point(85, 37);
            this.PictureProfile.Name = "PictureProfile";
            this.PictureProfile.Size = new System.Drawing.Size(50, 50);
            this.PictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureProfile.TabIndex = 13;
            this.PictureProfile.TabStop = false;
            // 
            // GroupExtended
            // 
            this.GroupExtended.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GroupExtended.Controls.Add(this.CheckSaveResults);
            this.GroupExtended.Controls.Add(this.LBlUtolso2);
            this.GroupExtended.Controls.Add(this.LblUtolso1);
            this.GroupExtended.Controls.Add(this.NumericLastComments);
            this.GroupExtended.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupExtended.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupExtended.ForeColor = System.Drawing.Color.Black;
            this.GroupExtended.Location = new System.Drawing.Point(561, 33);
            this.GroupExtended.Name = "GroupExtended";
            this.GroupExtended.Size = new System.Drawing.Size(506, 158);
            this.GroupExtended.TabIndex = 14;
            this.GroupExtended.TabStop = false;
            this.GroupExtended.Text = "Részletes keresés";
            this.GroupExtended.Visible = false;
            // 
            // CheckSaveResults
            // 
            this.CheckSaveResults.AutoSize = true;
            this.CheckSaveResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckSaveResults.Location = new System.Drawing.Point(23, 101);
            this.CheckSaveResults.Name = "CheckSaveResults";
            this.CheckSaveResults.Size = new System.Drawing.Size(316, 32);
            this.CheckSaveResults.TabIndex = 3;
            this.CheckSaveResults.Text = "Keresés  eredményeinek mentése";
            this.CheckSaveResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckSaveResults.UseVisualStyleBackColor = true;
            // 
            // LBlUtolso2
            // 
            this.LBlUtolso2.AutoSize = true;
            this.LBlUtolso2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBlUtolso2.Location = new System.Drawing.Point(316, 39);
            this.LBlUtolso2.Name = "LBlUtolso2";
            this.LBlUtolso2.Size = new System.Drawing.Size(96, 28);
            this.LBlUtolso2.TabIndex = 2;
            this.LBlUtolso2.Text = "komment";
            // 
            // LblUtolso1
            // 
            this.LblUtolso1.AutoSize = true;
            this.LblUtolso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblUtolso1.Location = new System.Drawing.Point(25, 39);
            this.LblUtolso1.Name = "LblUtolso1";
            this.LblUtolso1.Size = new System.Drawing.Size(70, 28);
            this.LblUtolso1.TabIndex = 1;
            this.LblUtolso1.Text = "Utolsó";
            // 
            // NumericLastComments
            // 
            this.NumericLastComments.BackColor = System.Drawing.Color.White;
            this.NumericLastComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumericLastComments.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericLastComments.ForeColor = System.Drawing.Color.Black;
            this.NumericLastComments.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericLastComments.Location = new System.Drawing.Point(101, 33);
            this.NumericLastComments.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericLastComments.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericLastComments.Name = "NumericLastComments";
            this.NumericLastComments.ReadOnly = true;
            this.NumericLastComments.Size = new System.Drawing.Size(200, 39);
            this.NumericLastComments.TabIndex = 0;
            this.NumericLastComments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericLastComments.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericLastComments.ValueChanged += new System.EventHandler(this.NumericLastComments_ValueChanged);
            // 
            // StatusCurrent
            // 
            this.StatusCurrent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusCurrent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressSearch,
            this.LblLink});
            this.StatusCurrent.Location = new System.Drawing.Point(0, 624);
            this.StatusCurrent.Name = "StatusCurrent";
            this.StatusCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusCurrent.Size = new System.Drawing.Size(1095, 43);
            this.StatusCurrent.SizingGrip = false;
            this.StatusCurrent.TabIndex = 15;
            this.StatusCurrent.Text = "statusStrip1";
            // 
            // ProgressSearch
            // 
            this.ProgressSearch.BackColor = System.Drawing.Color.Silver;
            this.ProgressSearch.Enabled = false;
            this.ProgressSearch.Name = "ProgressSearch";
            this.ProgressSearch.Size = new System.Drawing.Size(190, 37);
            this.ProgressSearch.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = false;
            this.LblLink.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LblLink.Name = "LblLink";
            this.LblLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblLink.Size = new System.Drawing.Size(1000, 38);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MadeByToolStripItem,
            this.ToolStripItemSettings});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1095, 28);
            this.MenuStrip.TabIndex = 16;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MadeByToolStripItem
            // 
            this.MadeByToolStripItem.Name = "MadeByToolStripItem";
            this.MadeByToolStripItem.Size = new System.Drawing.Size(86, 24);
            this.MadeByToolStripItem.Text = "Készítette";
            this.MadeByToolStripItem.Click += new System.EventHandler(this.MadeByToolStripItem_Click);
            // 
            // ToolStripItemSettings
            // 
            this.ToolStripItemSettings.Name = "ToolStripItemSettings";
            this.ToolStripItemSettings.Size = new System.Drawing.Size(93, 24);
            this.ToolStripItemSettings.Text = "Beállítások";
            this.ToolStripItemSettings.Click += new System.EventHandler(this.ToolStripItemSettings_Click);
            // 
            // NotifyPH
            // 
            this.NotifyPH.BalloonTipText = "hapipa";
            this.NotifyPH.BalloonTipTitle = "hapia";
            this.NotifyPH.Text = "PH!";
            this.NotifyPH.Visible = true;
            this.NotifyPH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyPH_MouseClick);
            // 
            // LblUsrName
            // 
            this.LblUsrName.AutoSize = true;
            this.LblUsrName.ForeColor = System.Drawing.Color.Black;
            this.LblUsrName.Location = new System.Drawing.Point(152, 51);
            this.LblUsrName.Name = "LblUsrName";
            this.LblUsrName.Size = new System.Drawing.Size(0, 28);
            this.LblUsrName.TabIndex = 14;
            // 
            // Prohardver
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1095, 667);
            this.Controls.Add(this.StatusCurrent);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.GroupExtended);
            this.Controls.Add(this.GroupFelh);
            this.Controls.Add(this.GroupAdatok);
            this.Controls.Add(this.DgvUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Prohardver";
            this.Text = "PH! Kommentek By Xiawave";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Prohardver_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsername)).EndInit();
            this.GroupAdatok.ResumeLayout(false);
            this.GroupAdatok.PerformLayout();
            this.GroupFelh.ResumeLayout(false);
            this.GroupFelh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProfile)).EndInit();
            this.GroupExtended.ResumeLayout(false);
            this.GroupExtended.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLastComments)).EndInit();
            this.StatusCurrent.ResumeLayout(false);
            this.StatusCurrent.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTopicName;
        private System.Windows.Forms.Label LblSzakmaiHsz;
        private System.Windows.Forms.Label LblKozossegiHsz;
        private System.Windows.Forms.DataGridView DgvUsername;
        private System.Windows.Forms.Label LblTopicName;
        private System.Windows.Forms.Label LblCommentCount;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblPiaciHsz;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.Label LblPiaci;
        private System.Windows.Forms.Label LblKozossegi;
        private System.Windows.Forms.Label LblSzakmai;
        private System.Windows.Forms.GroupBox GroupAdatok;
        private System.Windows.Forms.GroupBox GroupFelh;
        private System.Windows.Forms.GroupBox GroupExtended;
        private System.Windows.Forms.StatusStrip StatusCurrent;
        private System.Windows.Forms.ToolStripProgressBar ProgressSearch;
        private System.Windows.Forms.ToolStripStatusLabel LblLink;
        private System.Windows.Forms.NumericUpDown NumericLastComments;
        private System.Windows.Forms.CheckBox CheckExtended;
        private System.Windows.Forms.Label LBlUtolso2;
        private System.Windows.Forms.Label LblUtolso1;
        private System.Windows.Forms.CheckBox CheckSaveResults;
        private System.Windows.Forms.PictureBox PictureProfile;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MadeByToolStripItem;
        private System.Windows.Forms.ToolTip PhToolTip;
        private System.Windows.Forms.Label LblComment;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemSettings;
        private System.Windows.Forms.NotifyIcon NotifyPH;
        private System.Windows.Forms.Label LblUsrName;
    }
}

