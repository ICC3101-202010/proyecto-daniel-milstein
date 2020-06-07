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
                Video video = new Video(filename);
            }
        }

        private void radioSong_CheckedChanged(object sender, EventArgs e)
        {
            MediaType = "song";
            Label nameLabel = new Label();
            nameLabel.Text = "Name: ";
            MetadataBox.Controls.Add(nameLabel);
        }

        private void radioVideo_CheckedChanged(object sender, EventArgs e)
        {
            MediaType = "video";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileNameLabel.Text = openFileDialog1.FileName;
            //string path = $@"{openFileDialog1.FileName}";

            //AddMediaMeta = Spotflix.ReadMeta(path);

            Dictionary<string, string> a = new Dictionary<string, string>();
            a.Add("Hola", "Chao");
            a.Add("Prueba", "Chato");
            MetaGrid.Columns.Add("Value", "Value");
            
            
            int en = 0;

            foreach  (var item in a)
            {
                MetaGrid.Rows.Add(item.Value);
                MetaGrid.Rows[en].HeaderCell.Value = item.Key;
                en++;
                

            }
            
        }
    }
}
