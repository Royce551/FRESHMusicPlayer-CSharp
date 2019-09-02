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
            checkBox2.Checked = Properties.Settings.Default.GC_CollectOnSFinish;
            checkBox3.Checked = Properties.Settings.Default.GC_CollectOnDClose;
            Text = "FRESHMusicPlayer Options";
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

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Properties.Settings.Default.GC_CollectOnSFinish = true;
            }
            else
            {
                Properties.Settings.Default.GC_CollectOnSFinish = false;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Properties.Settings.Default.GC_CollectOnDClose = true;
            }
            else
            {
                Properties.Settings.Default.GC_CollectOnDClose = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WaifuChanged = false;
        }
    }
}
