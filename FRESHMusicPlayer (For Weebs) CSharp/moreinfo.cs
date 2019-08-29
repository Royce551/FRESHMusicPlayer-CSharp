using System;
using System.Windows.Forms;

namespace FRESHMusicPlayer__For_Weebs__CSharp
{
    public partial class moreinfo : Form
    {
        bool editmode = false;
        ATL.Track theTrack = new ATL.Track(MainGUI.filePath);
        public moreinfo()
        {
            InitializeComponent();
            this.Text = "About this song";
            
        }
        public void populatelist()
        {
            
            album.Text = "Album - " + theTrack.Album;
            genre.Text = "Genre - " + theTrack.Genre;
            year.Text = "Year Recorded - " + theTrack.Year.ToString();
            tracknumber.Text = "Track Number - " + theTrack.TrackNumber.ToString();
            disknumber.Text = "Disc Number - " + theTrack.DiscNumber.ToString();
            bitrate.Text = "Bitrate - " + theTrack.Bitrate.ToString() + "kbps";
        }
        private void Moreinfo_FormClosing(Object sender, FormClosingEventArgs e) => this.Dispose();

        private void Button1_Click(object sender, EventArgs e) //Edit button
        {
            if (!editmode)
            {
                button1.Text = "Save";
                albumbox.Visible = true;
                genrebox.Visible = true;
                yearbox.Visible = true;
                trackbox.Visible = true;
                diskbox.Visible = true;
                editmode = true;
            }
            else
            {
                button1.Text = "Edit Metadata";
                editmode = false;
                
                albumbox.Visible = false;
                genrebox.Visible = false;
                yearbox.Visible = false;
                trackbox.Visible = false;
                diskbox.Visible = false;
                theTrack.Album = "testing";
                theTrack.Genre = "testing";
                theTrack.Composer = "testing";
                //theTrack.Year = Int32.Parse(yearbox.Text);
                //theTrack.TrackNumber = Int32.Parse(trackbox.Text);
                //theTrack.DiscNumber = Int32.Parse(diskbox.Text);
                theTrack.Save();
                
            }
        }
    }
}
