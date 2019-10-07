using System;
using System.Windows.Forms;

namespace FRESHMusicPlayer__For_Weebs__CSharp
{
    public partial class Options : Form
    {
        
        public Options()
        {
            InitializeComponent();
            checkBox1.Checked = Properties.Settings.Default.Image;
            checkBox4.Checked = Properties.Settings.Default.DarkMode;
            Text = "FRESHMusicPlayer Options";
            if (Properties.Settings.Default.DarkMode)
            {

                
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        private void Options_FormClosing(Object sender, FormClosingEventArgs e) => this.Dispose();

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.Image = true;
                
            }
            else
            {
                Properties.Settings.Default.Image = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.Save();
        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WaifuChanged = false;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Properties.Settings.Default.DarkMode = true;
            }
            else
            {
                Properties.Settings.Default.DarkMode = false;
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
