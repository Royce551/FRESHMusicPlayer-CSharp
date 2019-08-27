namespace FRESHMusicPlayer__For_Weebs__CSharp
{
    partial class moreinfo
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
            this.nowplaying = new System.Windows.Forms.Label();
            this.album = new System.Windows.Forms.Label();
            this.tracknumber = new System.Windows.Forms.Label();
            this.disknumber = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.bitrate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.albumbox = new System.Windows.Forms.TextBox();
            this.genrebox = new System.Windows.Forms.TextBox();
            this.yearbox = new System.Windows.Forms.TextBox();
            this.trackbox = new System.Windows.Forms.TextBox();
            this.diskbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nowplaying
            // 
            this.nowplaying.AutoSize = true;
            this.nowplaying.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.nowplaying.Location = new System.Drawing.Point(17, 15);
            this.nowplaying.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nowplaying.Name = "nowplaying";
            this.nowplaying.Size = new System.Drawing.Size(197, 32);
            this.nowplaying.TabIndex = 33;
            this.nowplaying.Text = "About this song";
            // 
            // album
            // 
            this.album.AutoSize = true;
            this.album.Location = new System.Drawing.Point(7, 25);
            this.album.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.album.Name = "album";
            this.album.Size = new System.Drawing.Size(71, 21);
            this.album.TabIndex = 34;
            this.album.Text = "Album -";
            // 
            // tracknumber
            // 
            this.tracknumber.AutoSize = true;
            this.tracknumber.Location = new System.Drawing.Point(7, 25);
            this.tracknumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tracknumber.Name = "tracknumber";
            this.tracknumber.Size = new System.Drawing.Size(127, 21);
            this.tracknumber.TabIndex = 35;
            this.tracknumber.Text = "Track Number -";
            // 
            // disknumber
            // 
            this.disknumber.AutoSize = true;
            this.disknumber.Location = new System.Drawing.Point(7, 46);
            this.disknumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disknumber.Name = "disknumber";
            this.disknumber.Size = new System.Drawing.Size(120, 21);
            this.disknumber.TabIndex = 36;
            this.disknumber.Text = "Disk Number -";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(7, 46);
            this.genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(65, 21);
            this.genre.TabIndex = 37;
            this.genre.Text = "Genre -";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(7, 67);
            this.year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(129, 21);
            this.year.TabIndex = 38;
            this.year.Text = "Year Recorded -";
            // 
            // bitrate
            // 
            this.bitrate.AutoSize = true;
            this.bitrate.Location = new System.Drawing.Point(7, 25);
            this.bitrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitrate.Name = "bitrate";
            this.bitrate.Size = new System.Drawing.Size(71, 21);
            this.bitrate.TabIndex = 39;
            this.bitrate.Text = "Bitrate -";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yearbox);
            this.groupBox1.Controls.Add(this.genrebox);
            this.groupBox1.Controls.Add(this.albumbox);
            this.groupBox1.Controls.Add(this.album);
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Location = new System.Drawing.Point(23, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 97);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "More Song Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.diskbox);
            this.groupBox2.Controls.Add(this.trackbox);
            this.groupBox2.Controls.Add(this.tracknumber);
            this.groupBox2.Controls.Add(this.disknumber);
            this.groupBox2.Location = new System.Drawing.Point(23, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 75);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Album Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bitrate);
            this.groupBox3.Location = new System.Drawing.Point(23, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 63);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Technical Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 43;
            this.button1.Text = "Edit Metadata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // albumbox
            // 
            this.albumbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumbox.Location = new System.Drawing.Point(85, 24);
            this.albumbox.Name = "albumbox";
            this.albumbox.Size = new System.Drawing.Size(410, 22);
            this.albumbox.TabIndex = 39;
            this.albumbox.Visible = false;
            // 
            // genrebox
            // 
            this.genrebox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genrebox.Location = new System.Drawing.Point(85, 45);
            this.genrebox.Name = "genrebox";
            this.genrebox.Size = new System.Drawing.Size(410, 22);
            this.genrebox.TabIndex = 40;
            this.genrebox.Visible = false;
            // 
            // yearbox
            // 
            this.yearbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearbox.Location = new System.Drawing.Point(143, 67);
            this.yearbox.Name = "yearbox";
            this.yearbox.Size = new System.Drawing.Size(352, 22);
            this.yearbox.TabIndex = 41;
            this.yearbox.Visible = false;
            // 
            // trackbox
            // 
            this.trackbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbox.Location = new System.Drawing.Point(143, 24);
            this.trackbox.Name = "trackbox";
            this.trackbox.Size = new System.Drawing.Size(352, 22);
            this.trackbox.TabIndex = 42;
            this.trackbox.Visible = false;
            // 
            // diskbox
            // 
            this.diskbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskbox.Location = new System.Drawing.Point(143, 45);
            this.diskbox.Name = "diskbox";
            this.diskbox.Size = new System.Drawing.Size(352, 22);
            this.diskbox.TabIndex = 43;
            this.diskbox.Visible = false;
            // 
            // moreinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nowplaying);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "moreinfo";
            this.Text = "moreinfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nowplaying;
        private System.Windows.Forms.Label album;
        private System.Windows.Forms.Label tracknumber;
        private System.Windows.Forms.Label disknumber;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label bitrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox yearbox;
        private System.Windows.Forms.TextBox genrebox;
        private System.Windows.Forms.TextBox albumbox;
        private System.Windows.Forms.TextBox diskbox;
        private System.Windows.Forms.TextBox trackbox;
        private System.Windows.Forms.Button button1;
    }
}