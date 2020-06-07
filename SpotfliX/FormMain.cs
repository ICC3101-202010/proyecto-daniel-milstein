using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            FileInfo info = new FileInfo(filename);
            File.Copy(filename, "Current directory+filedir");
            
            if (MediaType == "song")
            {
                Song song = new Song(filename);
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
        }
    }
}
