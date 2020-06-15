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
        public MediaController MediaControl = new MediaController();
        public int SelectedRow;
        public List<Type> SearchTypes = new List<Type>();



        public FormMain()
        {
            
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            panelProfile.Show();
            userProfilelabel.Text = ActiveUser.GetUsername();
            emailProfileLabel.Text = ActiveUser.GetEmail();
            PassProfilelabel.Text = "************";
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
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
            tb.Text = "";
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
            //SelectedRow =  e.RowIndex;
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
                MediaGrid.Rows[en].HeaderCell.Value = item;
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
            DataGridView grid = (DataGridView)sender;
            if (SelectedRow != -1)
            {
                
                Media file = (Media)grid.Rows[SelectedRow].HeaderCell.Value;
                MediaControl.PlayMedia(file, axWindowsMediaPlayer1); 
            }

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
            panelAdmin.Hide();
        }

        private void linkLabelEditEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            emailProfileLabel.Hide();
            emailProfileBox.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OldpassBox.Text == ActiveUser.GetPassword() && Newpass1.Text == Newpass2.Text)
            {
                ActiveUser.SetPass(Newpass1.Text);
                panelChangePass.Hide();
                panelProfile.Show();
            }
            else
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelChangePass.Hide();
            panelProfile.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter f = new Filter();
            
            f.ObjGrid(f.Search(aSearchBox.Text.ToLower()), ResultGrid, SearchTypes);
        }

        private void aSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aSearchBox_MouseLeave(object sender, EventArgs e)
        {
            if (aSearchBox.Text == "")
            {
                aSearchBox.Text = "Search";
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackaSearchButton_Click(object sender, EventArgs e)
        {
            panelSearch.Hide();
            ResultGrid.Rows.Clear();
            panelAdmin.Show();
        }

        private void BackProfileButton_Click(object sender, EventArgs e)
        {
            panelProfile.Hide();
            panelAdmin.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Pending
            panelProfile.Hide();
            panelAdmin.Show();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menu = (ContextMenuStrip)menuItem.Owner;
            DataGridView grid = (DataGridView)menu.SourceControl; //csm
            Media file = (Media)grid.Rows[SelectedRow].HeaderCell.Value;
            MediaControl.PlayMedia(file, axWindowsMediaPlayer1);
        }

        private void MediaGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Cambiar color
        }

        private void MediaGrid_MouseClick(object sender, MouseEventArgs e)
        {
            //No sirve
            //int mouseLoc = MediaGrid.HitTest(e.X, e.Y).RowIndex;
            //SelectedRow = mouseLoc;
        }

        private void MediaGrid_MouseClick(object sender, EventArgs e)
        {
            //Nada
        }

        private void MediaGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
            if (e.Button == MouseButtons.Right)
            {
                SelectedRow = e.RowIndex;
            }*/
            
        }

        private void MediaGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
                
            //}
            SelectedRow = e.RowIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                SearchTypes.Add(typeof(Song));
            }
            else
            {
                SearchTypes.Remove(typeof(Song));
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                SearchTypes.Add(typeof(Video));
            }
            else
            {
                SearchTypes.Remove(typeof(Video));
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                SearchTypes.Add(typeof(Artist));
            }
            else
            {
                SearchTypes.Remove(typeof(Artist));
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                SearchTypes.Add(typeof(Album));
            }
            else
            {
                SearchTypes.Remove(typeof(Album));
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                SearchTypes.Add(typeof(User));
            }
            else
            {
                SearchTypes.Remove(typeof(User));
            }
        }
    }
}
