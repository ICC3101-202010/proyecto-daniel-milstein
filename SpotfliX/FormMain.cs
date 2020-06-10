using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Proyecto;


namespace SpotfliX
{
    public partial class FormMain : Form
    {
        public User ActiveUser;
        public string MediaType;
        public Dictionary<string, string> AddMediaMeta;
        string NewPath;
        public FormMain()
        {
            
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            panelProfile.Show();
        }

        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Spotflix.Save("Spotflix.bin");
            Application.Exit();
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void AddMedia_Click(object sender, EventArgs e)
        {
            string ofilename = openFileDialog1.FileName;
            string filename = $"{NewPath}{Path.GetFileName(ofilename)}";
            File.Copy(ofilename,filename , true);
            
            if (MediaType == "song")
            {
                string format, duration, name, artist, album, genre, pubYear, label;

                format = MetaGrid.Rows[1].Cells[1].Value.ToString();
                duration = MetaGrid.Rows[2].Cells[1].Value.ToString();
                name = MetaGrid.Rows[3].Cells[1].Value.ToString();
                artist = MetaGrid.Rows[4].Cells[1].Value.ToString();
                album = MetaGrid.Rows[5].Cells[1].Value.ToString();
                genre = MetaGrid.Rows[6].Cells[1].Value.ToString();
                pubYear = MetaGrid.Rows[7].Cells[1].Value.ToString();
                label = MetaGrid.Rows[8].Cells[1].Value.ToString();



                SongMetadata meta = new SongMetadata(name, artist, album, genre, pubYear, label);
                Song song = new Song(filename, meta, format, duration);

            }
            
            else if (MediaType == "video")
            {
                string format, duration, name, creator, genre, category, studio, description, resolution, aspect, director, actors, pubYear;
                format = MetaGrid.Rows[1].Cells[1].Value.ToString();
                duration = MetaGrid.Rows[2].Cells[1].Value.ToString();
                name = MetaGrid.Rows[3].Cells[1].Value.ToString();
                creator = MetaGrid.Rows[4].Cells[1].Value.ToString();
                genre = MetaGrid.Rows[5].Cells[1].Value.ToString();
                category = MetaGrid.Rows[6].Cells[1].Value.ToString();
                actors = MetaGrid.Rows[7].Cells[1].Value.ToString();
                director = MetaGrid.Rows[8].Cells[1].Value.ToString();
                studio = MetaGrid.Rows[9].Cells[1].Value.ToString();
                pubYear = MetaGrid.Rows[10].Cells[1].Value.ToString();
                description = MetaGrid.Rows[11].Cells[1].Value.ToString();
                resolution = MetaGrid.Rows[12].Cells[1].Value.ToString();
                aspect  = MetaGrid.Rows[13].Cells[1].Value.ToString();



                VideoMetadata meta = new VideoMetadata(name, creator, genre, category, studio, description, resolution, aspect, director, actors, pubYear);
                Video video = new Video(filename, meta, format, duration);
            }
            Spotflix.Save("Spotflix.bin");
            panelAddMedia.Hide();
            MetaGrid.Rows.Clear();
            panelAdmin.Show();
        }

        private void radioSong_CheckedChanged(object sender, EventArgs e)
        {
            MediaType = "song";
            FileNameLabel.Text = openFileDialog1.FileName;
            string path = $@"{openFileDialog1.FileName}";
            MetaDataController m1 = new MetaDataController();
            AddMediaMeta = m1.MetaManual(path, MediaType);
            MetaGrid.Rows.Clear();
            foreach (var item in AddMediaMeta)
            {
                MetaGrid.Rows.Add(item.Key, item.Value);

            }

        }

        private void radioVideo_CheckedChanged(object sender, EventArgs e)
        {
            MediaType = "video";
            FileNameLabel.Text = openFileDialog1.FileName;
            string path = $@"{openFileDialog1.FileName}";
            MetaDataController m1 = new MetaDataController();
            AddMediaMeta = m1.MetaManual(path, MediaType);
            MetaGrid.Rows.Clear();
            foreach (var item in AddMediaMeta)
            {
                MetaGrid.Rows.Add(item.Key, item.Value);

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileNameLabel.Text = openFileDialog1.FileName;
            NewPath = Directory.GetCurrentDirectory() + "\\";
            //string path = $@"{openFileDialog1.FileName}";
            //MetaDataController m1 = new MetaDataController();
            //AddMediaMeta = m1.ReadMeta(path, MediaType);
            //MetaGrid.Rows.Clear();
            //foreach  (var item in AddMediaMeta)
            //{
            //    MetaGrid.Rows.Add(item.Key, item.Value);

            //}
            
        }

        private void MetaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = "Search";
            }
        }

        private void AdminAddMedia_Click(object sender, EventArgs e)
        {
            panelAddMedia.Show();
            panelAdmin.Hide();
        }

        private void BackAddMedia_Click(object sender, EventArgs e)
        {
            panelAddMedia.Hide();
            panelAdmin.Show();
            MetaGrid.Rows.Clear();
            radioSong.Checked = false;
            radioVideo.Checked = false;
            openFileDialog1.FileName = null;
            FileNameLabel.Text = "";
        }

        private void ShowMediaButton_Click(object sender, EventArgs e)
        {
            MediaGrid.Rows.Clear();
            panelShowMedia.Show();
            List<Media> every = Spotflix.GetMediaDB;
            int en = 0;
            foreach  (Media item in every)
            {
                string name, artist;
                name = item.GetMetadata().GetName();
                artist = item.GetMetadata().GetArtist();
                
                
                MediaGrid.Rows.Add(name, artist);
                MediaGrid.Rows[en].HeaderCell.Value = item.GetFileName();;
                en++;
            }
            panelAdmin.Hide();
        }

        private void BackMediaButton_Click(object sender, EventArgs e)
        {
            panelShowMedia.Hide();
            MediaGrid.Rows.Clear();
            panelAdmin.Show();
        }

        private void MediaGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //play media
            string fname = MediaGrid.SelectedRows[0].HeaderCell.Value.ToString(); ;
            axWindowsMediaPlayer1.URL = fname;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.windowlessVideo = true;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabelEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelChangePass.Show();
        }

        private void linkLabelSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSearch.Show();
        }

        private void linkLabelEditEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OldpassBox.Text == ActiveUser.GetPassword() && Newpass1.Text == Newpass2.Text)
            {
                ActiveUser.SetPass(Newpass1.Text);
                panelChangePass.Hide();
                panelProfile.Show();
            }
        }
    }
}
