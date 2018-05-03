using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Drawing;

namespace PH_Name_Calculator
{
    public partial class Prohardver : Form
    {
        private Settings s;
        private bool IsAvaible = false;
        private int _commentcount;
        private int _min;
        private PhStuff _ph;
        private List<Users> _users;

        public Prohardver()
        {
            InitializeComponent();
        }

        private void BtnKereses_Click(object sender, EventArgs e)
        {
            if ((TxtTopicName.Text != string.Empty))
            {
                _min = default(int);
                (sender as Button).Enabled = false;
                if (CheckExtended.Checked)
                {
                    _commentcount = Convert.ToInt32(_ph.maxComment(TxtTopicName.Text));
                    LblComment.Text = Convert.ToString(_commentcount);
                    _min = (_commentcount - (int)NumericLastComments.Value);
                }
                else
                {
                    _commentcount = Convert.ToInt32(LblComment.Text);
                }
                ProgressSearch.Visible = true;
                TxtTopicName.ReadOnly = true;
                DgvUsername.Rows.Clear();
                DgvUsername.Refresh();
                int index;
                Thread thread = new Thread(t =>
                {
                    _users = _ph.GetAllUser(TxtTopicName.Text, _commentcount, _min).OrderByDescending(o => o.commentcount).ToList();
                    Invoke(new Action(() =>
                    {
                        for (int i = 0; i < _users.Count; i++)
                        {
                            index = DgvUsername.Rows.Add();
                            DgvUsername.Rows[index].Cells[0].Value = _users[i].username;
                            DgvUsername.Rows[index].Cells[1].Value = _users[i].commentcount;
                        }
                        BtnSearch.Enabled = true;
                        ProgressSearch.Visible = false;
                        if (CheckSaveResults.Checked)
                        {
                            StreamWriter sw = new StreamWriter("eredmeny.txt");
                            for (int i = 0; i < _users.Count; i++)
                            {
                                sw.WriteLine(_users[i].username + " \t " + _users[i].commentcount);
                            }
                            sw.Close();
                        }
                        TxtTopicName.ReadOnly = false;
                        LblLink.Text = "Keresés befejezve!";
                    }));
                })
                {
                    IsBackground = true
                };
                thread.Start();
        }
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            s = new Settings();
            s.update += S_update;
            S_update(Properties.Settings.Default.ThemeColor);
            _ph = new PhStuff();
            _ph.UpdateProgress += _ph_UpdateProgress;
            ProgressSearch.Visible = false;
            PhToolTip.SetToolTip(TxtTopicName, "A kiválasztott topic url-jéből a topic nevének a helye: \n https://prohardver.hu/tema/re_sony_xperia_z_a_nagy_varazslo/hsz_1-50.html  \n --- \n  re_sony_xperia_z_a_nagy_varazslo");
        }

        private void S_update(Color c)
        {
            BackColor = c;
            StatusCurrent.BackColor = c;
            MenuStrip.BackColor = c;
            GroupAdatok.BackColor = c;
            GroupExtended.BackColor = c;
            GroupFelh.BackColor = c;
            DgvUsername.BackgroundColor = Color.LightGray;
        }

        private void _ph_UpdateProgress(string url)
        {
            Invoke(new Action(delegate { LblLink.Text = "Jelenleg vizsgált kommentek: \t " + url; }));
        }

        private void DatagridviewFelh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell clicked = DgvUsername.CurrentCell;
            try
            {
                if (clicked.ColumnIndex == 0)
                {
                    string username = _ph.Normalusername(clicked.Value.ToString().ToLower());
                    PictureProfile.ImageLocation = _ph.Profilepicture(username);
                    new Thread(delegate ()
                    {
                        Thread.CurrentThread.IsBackground = true;
                        Invoke((Action)delegate
                        {
                            List<string> comments = _ph.returnComments(username).ToList();
                            LblSzakmaiHsz.Text = comments[0];
                            LblKozossegiHsz.Text = comments[1];
                            LblPiaciHsz.Text = comments[2];
                        });
                    }).Start();
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void NumericLastComments_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown n = (sender as NumericUpDown);
            if (n.Value != n.Maximum)
            {
                n.Value = (decimal)(Math.Ceiling((int)n.Value / 1000d) * 1000d);
            }
        }

        private void MadeByToolStripItem_Click(object sender, EventArgs e)
        {
            new MadeBy().ShowDialog();
        }

        private void CheckExtended_Click(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (IsAvaible)
            {
                cb.Checked = !cb.Checked;
                GroupExtended.Visible = CheckExtended.Checked;
            }
        }

        private void TxtTopicName_TextChanged(object sender, EventArgs e)
        {
            string _commentcount = _ph.maxComment(TxtTopicName.Text);
            if (_commentcount != "")
            {
                IsAvaible = true;
                LblComment.Text = _commentcount;
                NumericLastComments.Maximum = Convert.ToDecimal(_commentcount);
            }
            else
            {
                LblComment.Text = string.Empty;
                IsAvaible = false;
            }
            BtnSearch.Enabled = IsAvaible;
            if (CheckExtended.Checked)
            {
                GroupExtended.Visible = IsAvaible;
            }
        }

        private void ToolStripItemSettings_Click(object sender, EventArgs e)
        {
            s.Show();
        }

        private void NotifyPH_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                NotifyPH.Visible = false;
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void Prohardver_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotifyPH.Icon = SystemIcons.Application;
                NotifyPH.Visible = true;
            }
            else
            {
                Show();
                NotifyPH.Visible = false;
            }
        }

    }
}