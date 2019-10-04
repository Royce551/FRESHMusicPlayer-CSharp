using System;
using System.Windows.Forms;
using System.Drawing;
using NAudio.Wave;
using ATL.Playlist;
namespace FRESHMusicPlayer__For_Weebs__CSharp
{

    public partial class MainGUI : Form
    {
        public static string filePath = "";
        public string fileContent = "";
        public bool playing = false;
        public float currentvolume = 1;
        public int position = 0;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public bool playlistmode = false;
        public int playsong = 0;
        System.Collections.Generic.IList<string> playlist = new System.Collections.Generic.List<string>();
        public MainGUI()
        {
            
            InitializeComponent();
            if (Properties.Settings.Default.WaifuChanged) pictureBox1.Image = Image.FromFile(Properties.Settings.Default.Waifu);
            Text = "FRESHMusicPlayer (For Weebs) C# Edition";
            if (Properties.Settings.Default.Image == false)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
            if (Properties.Settings.Default.DarkMode)
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
                button1.ForeColor = Color.Black; button2.ForeColor = Color.Black;button3.ForeColor = Color.Black;button4.ForeColor = Color.Black;button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black; button7.ForeColor = Color.Black;nextbutton.ForeColor = Color.Black; previoussong.ForeColor = Color.Black;
                groupBox1.ForeColor = Color.White;
            }
        }


        private void OnPlaybackStopped(object sender, StoppedEventArgs args) => StopMusic();
        
        public void StopMusic()
        {
            
            try
            {
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
                playing = false;
                nowplaying.Text = "Nothing";
                position = 0;
                label5.Text = "(nothing playing)";
                moreinfo.Visible = false;
                Text = "FRESHMusicPlayer (For Weebs) C# Edition";
                if (Properties.Settings.Default.GC_CollectOnSFinish == true) { GC.Collect(); }
                if (playlistmode)
                {
                    PlayPlaylist();
                }

            }
            catch (System.NullReferenceException)
            {
                PlayMusic(filePath);
            }
            
        }
        
        
        public void PlayMusic(string path)
        {
            void PMusic()
            {
                ATL.Track theTrack = new ATL.Track(filePath);
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }
                if (audioFile == null)
                {
                    
                    audioFile = new AudioFileReader(path);
                    outputDevice.Init(audioFile);                                                                            
                }
                nowplaying.Text = $"{theTrack.Artist} - {theTrack.Title}";
                Text = $"{theTrack.Artist} - {theTrack.Title} | FRESHMusicPlayer";
                outputDevice.Play();
                outputDevice.Volume = currentvolume;
                moreinfo.Visible = true;
                playing = true;
            }
            try 
            {
                if (playing != true)
                {
                    PMusic();
                }
                else
                {
                    StopMusic();
                    PMusic();
                }
            }
            catch (System.IO.FileNotFoundException)
            {

                MessageBox.Show("Onee-Chan~~! That's not a valid file path, you BAKA! (or it's not a supported file type!)", "Incorrect file path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Onee-Chan~~! You BAKA! You're supposed to actually put something in the box!", "Nothing typed in file path box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Onee-Chan~! That's not a valid audio file!", "File Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Onee-Chan~! This audio file must be corrupt! I can't play it!", "Format Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            

            
        }
        

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("THIS IS THE FBI! STOP RIGHT NOW YOU LOLICON!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

       
        private void Button2_Click(object sender, EventArgs e)
        {
            filePath = textBox1.Text;
            PlayMusic(filePath);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            if (playlistmode) playlistmode = false;
            playing = false;
        }

        private void Button4_Click(object sender, EventArgs e) /* *Notice Bulge* OwO What's This? */
        {
            if (playing == true)
            {
                outputDevice?.Pause();
                button4.Text = "Resume";
                playing = false;
            }
            else
            {
                outputDevice?.Play();
                button4.Text = "Pause";
                playing = true;
            }
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)           //uwu, is that code i see?
        {
            currentvolume = (float)trackBar1.Value / 100.0f;
            if (playing) outputDevice.Volume = currentvolume;
        }

        private void Button5_Click(object sender, EventArgs e) //Options button
        {
            Options op = new Options();
            op.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())
                
            {
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    playlistmode = false;
                    filePath = selectFileDialog.FileName;
                    PlayMusic(filePath);
                    
                }
                if (Properties.Settings.Default.GC_CollectOnDClose == true) { GC.Collect(); }
            }
        }

        private string formatSongPosition(int secs)
        {
            int hours = 0;
            int mins = 0;

            while (secs >= 60)
            {
                mins++;
                secs -= 60;
            }

            while (mins >= 60)
            {
                hours++;
                mins -= 60;
            }

            string hourStr = hours.ToString(); if (hourStr.Length < 2) hourStr = "0" + hourStr;
            string minStr = mins.ToString(); if (minStr.Length < 2) minStr = "0" + minStr;
            string secStr = secs.ToString(); if (secStr.Length < 2) secStr = "0" + secStr;

            string durStr = "";
            if (hourStr != "00") durStr += hourStr + ":";
            durStr = minStr + ":" + secStr;

            return durStr;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (playing == true)
            {
                ATL.Track theTrack = new ATL.Track(filePath);
                position += 1;

                // var thing = $"{position / 60}:{position} / {theTrack.Duration / 60}:{theTrack.Duration}";
                label5.Text = $"{formatSongPosition(position)} / {formatSongPosition(theTrack.Duration)}";// thing.ToString();

            }
        }
        public void PlayPlaylist()
        {
            if (playsong < playlist.Count)
            {
                filePath = playlist[playsong];
                PlayMusic(playlist[playsong]);
                playsong += 1;
            }
            else
            {
                playlistmode = false;
            }
        }
        private void Moreinfo_Click(object sender, EventArgs e)
        {
            moreinfo mi = new moreinfo();
            mi.populatelist();
            mi.ShowDialog();
            
            
        }

        public void PictureBox1_Click(object sender, EventArgs e)
        {
            //using (var selectFileDialog = new OpenFileDialog())
            OpenFileDialog selectFileDialog = new OpenFileDialog();
            selectFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            {
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var newimage = selectFileDialog.FileName;
                    Properties.Settings.Default.Waifu = selectFileDialog.FileName;
                    Properties.Settings.Default.WaifuChanged = true;
                    Properties.Settings.Default.Save();
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = Image.FromFile(newimage);

                }
                if (Properties.Settings.Default.GC_CollectOnDClose == true) { GC.Collect(); }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
            IPlaylistIO pls = PlaylistIOFactory.GetInstance().GetPlaylistIO("C:\\Users\\poohw\\OneDrive\\Desktop\\stuff on desktop\\playlist.xspf");

            // Option A : Writing file paths
            System.Collections.Generic.IList<string> pathsToWrite = new System.Collections.Generic.List<string>();
            pathsToWrite.Add("C:\\Users\\poohw\\OneDrive\\Music\\bgm.mp3");
            pathsToWrite.Add("C:\\Users\\poohw\\OneDrive\\Music\\headache.mp3");
            pls.FilePaths = pathsToWrite;

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFileDialog = new OpenFileDialog();
            selectFileDialog.Filter = "Playlist Files|*.xspf;*.asx;*.wax;*.wvx;*.b4s;*.m3u;*.m3u8;*.pls;*.smil;*.smi;*.zpl;";
            {
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    IPlaylistIO theReader = PlaylistIOFactory.GetInstance().GetPlaylistIO(selectFileDialog.FileName);

                    // Option A : Get file paths
                    foreach (string s in theReader.FilePaths)
                    {
                        playlist.Add(s);
                        ATL.Track track = new ATL.Track(s);
                        listBox1.Items.Add($"{track.Artist} - {track.Title}");
                    }
                    
                    playlistmode = true;
                    PlayPlaylist();
                }
                if (Properties.Settings.Default.GC_CollectOnDClose == true) { GC.Collect(); }
            }
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            if (playlistmode)
            {
                playsong += 1;
                outputDevice?.Stop();
            }
        }

        private void Previoussong_Click(object sender, EventArgs e)
        {
            if (playlistmode)
            {
                playsong -= 3;
                outputDevice?.Stop();
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            playlistmode = false;
            playing = true;
            playsong = listBox1.SelectedIndex;
            filePath = playlist[playsong];
            if (playing) PlayMusic(playlist[playsong]);

        }
    }
}
