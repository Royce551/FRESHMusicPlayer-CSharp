using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRESHMusicPlayer__For_Weebs__CSharp
{
    public partial class moreinfo : Form
    {
        public moreinfo()
        {
            InitializeComponent();
            this.Text = "About this song";
        }
        public void populatelist()
        {
            ATL.Track theTrack = new ATL.Track(MainGUI.filePath);
            album.Text = "Album - " + theTrack.Album;
            genre.Text = "Genre - " + theTrack.Genre;
            year.Text = "Year Recorded - " + theTrack.Year.ToString();
            tracknumber.Text = "Track Number - " + theTrack.TrackNumber.ToString();
            disknumber.Text = "Disc Number - " + theTrack.DiscNumber.ToString();
            bitrate.Text = "Bitrate - " + theTrack.Bitrate.ToString() + "kbps";
        }
        private void Moreinfo_FormClosing(Object sender, FormClosingEventArgs e) => this.Dispose();

    }
}
