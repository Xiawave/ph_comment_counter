using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace PH_Name_Calculator
{
    public partial class Settings : Form
    {
        public delegate void UpdateColor(Color c);
        public event UpdateColor update;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            RadioDark.CheckedChanged += Color_Click;
            RadioLight.CheckedChanged += Color_Click;
            if(Properties.Settings.Default.ThemeColor == Color.WhiteSmoke)
            {
                RadioLight.Checked = true;
            }
            else
            {
                RadioDark.Checked = true;
            }
        }
        
        private void Color_Click(object sender, EventArgs e)
        {
            switch((sender as RadioButton).Text)
            {
                case "Világos":
                    Properties.Settings.Default.ThemeColor = Color.WhiteSmoke;
                    SetColor(Color.WhiteSmoke);
                    break;
                case "Sötét":
                    Properties.Settings.Default.ThemeColor = Color.Silver;
                    SetColor(Color.Silver);
                    break;
            }
            Properties.Settings.Default.Save();
        }
        private void SetColor(Color c)
        {
            update(c);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
