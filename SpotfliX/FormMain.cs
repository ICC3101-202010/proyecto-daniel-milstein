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
        public FormMain()
        {
            
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Spotflix.Save("Spotflix.bin");
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
            string filename = openFileDialog1.FileName;
            
            
            if (MediaType == "song")
            {
                //Song song = new Song(filename);
            }
            
            else if (MediaType == "video")
            {
                //Video video = new Video(filename);
            }
        }

        private void radioSong_CheckedChanged(object sender, EventArgs e)
        {
            MediaType = "song";
            FileNameLabel.Text = openFileDialog1.FileName;
            string path = $@"{openFileDialog1.FileName}";
            MetaDataController m1 = new MetaDataController();
            AddMediaMeta = m1.ReadMeta(path, MediaType);
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
            AddMediaMeta = m1.ReadMeta(path, MediaType);
            MetaGrid.Rows.Clear();
            foreach (var item in AddMediaMeta)
            {
                MetaGrid.Rows.Add(item.Key, item.Value);

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileNameLabel.Text = openFileDialog1.FileName;
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
    }
}
