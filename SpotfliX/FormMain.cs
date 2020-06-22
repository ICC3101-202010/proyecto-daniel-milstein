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
using WMPLib;
using AxWMPLib;

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
        public List<Type> SearchTypes = new List<Type>() { typeof(Song), typeof(Video), typeof(User), typeof(Artist), typeof(Playlist), typeof(Album) };
        public Media ActiveMedia;
        public int Vol;


        public FormMain(User user)
        {
            ActiveUser = user;
            InitializeComponent();
            if (ActiveUser.GetPremium())
            {
                DJButton.Show();
            }
            if (ActiveUser.GetAdmin())
            {
                AdminAddMedia.Show();
                UsersButton.Show();
            }
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
            TextBox tb = (TextBox)sender;
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



                VideoMetadata meta = new VideoMetadata(name, creator, genre, category, studio, description, 
                    resolution, aspect, director, actors, pubYear);
                Video video = new Video(filename, meta, format, duration);
            }
            Spotflix.Save("Spotflix.bin");
            panelAddMedia.Hide();
            MetaGrid.Rows.Clear();
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
            
        }

        private void AdminAddMedia_Click(object sender, EventArgs e)
        {
            if (!panelAddMedia.Visible)
            {
                panelAddMedia.Show(); 
            }
            else
            {
                panelAddMedia.Hide();
            }
        }

        private void BackAddMedia_Click(object sender, EventArgs e)
        {
            panelAddMedia.Hide();
            MetaGrid.Rows.Clear();
            radioSong.Checked = false;
            radioVideo.Checked = false;
            openFileDialog1.FileName = null;
            FileNameLabel.Text = "";
        }

        private void ShowMediaButton_Click(object sender, EventArgs e)
        {

            if (!panelShowMedia.Visible)
            {
                MediaGrid.Rows.Clear();
                panelShowMedia.Show();
                List<Media> every = Spotflix.GetMediaDB;
                int en = 0;
                foreach (Media item in every)
                {
                    string name, artist;
                    name = item.GetMetadata().GetName();
                    artist = item.GetMetadata().GetArtist();
                    if (artist == null)
                    {
                        artist = item.GetMetadata().GetCreator();
                    }

                    MediaGrid.Rows.Add(name, artist);
                    MediaGrid.Rows[en].HeaderCell.Value = item;
                    en++;
                } 
            }
            else
            {
                panelShowMedia.Hide();
            }
        }

        private void BackMediaButton_Click(object sender, EventArgs e)
        {
            panelShowMedia.Hide();
            MediaGrid.Rows.Clear();
        }

        private void MediaGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //play media
            DataGridView grid = (DataGridView)sender;
            Image img = Image.FromFile(@"Z:\proyecto-daniel-milstein\SpotfliX\icons8-pause-button-48.png");
            if (SelectedRow != -1)
            {
                object sel = grid.Rows[SelectedRow].HeaderCell.Value;
                if (sel.GetType() == typeof(Song))
                {
                    Song file = (Song)sel;
                    MediaControl.PlayMedia(file, axWindowsMediaPlayer1, MediaPlayingLabel, ArtistPlayingLabel, PlayButton, img);
                    ActiveMedia = file;
                }

                else if (sel.GetType() == typeof(Video))
                {
                    Video file = (Video)sel;
                    MediaControl.PlayMedia(file, axWindowsMediaPlayer1, MediaPlayingLabel, ArtistPlayingLabel, PlayButton, img);
                    ActiveMedia = file;
                }

                else if (sel.GetType() == typeof(Artist))
                {
                    Artist file = (Artist)sel;
                    panelArtist.Show();
                    ArtistNameLabel.Text = file.GetName();
                    FollowerQLabel.Text = file.GetFollowers().Count().ToString();
                    JobsBox.Text = "";
                    string jobs = "";
                    foreach (string item in file.GetProfessions())
                    {
                        jobs += $"{item}, ";
                    }
                    string njobs = jobs.Substring(0, jobs.Length - 2);
                    njobs += ".";
                    JobsBox.Text = njobs;

                    Filter f = new Filter();
                    f.ObjGrid(f.CastToObj(file.GetWork()), ArtistMediaGrid, new List<Type>() { typeof(Media), typeof(Song), typeof(Video) });
                    try
                    {
                        f.ObjGrid(f.CastToObj(file), ArtistAlbumGrid, new List<Type>() { typeof(Album) });
                    }
                    catch (Exception)
                    {
                    }
                    if (file.GetFollowers().Contains(ActiveUser))
                    {
                        //Boton unfollow
                        button6.Text = "Unfollow";
                        button6.BackColor = Color.CornflowerBlue;
                    }

                }
                else if (true)
                {

                }
                else if (true)
                {

                }

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
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter f = new Filter();
            (List<Media>, List<Artist>, List<User>, List<Playlist>, List<Album>) Results = f.Search(aSearchBox.Text.ToLower());
            List<object> res = f.CastToObj(Results.Item1, Results.Item2, Results.Item3, Results.Item4, Results.Item5);
            f.ObjGrid(res, ResultGrid, SearchTypes);
        }

        private void aSearchBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if(txt.Text != "")
            {
                Filter f = new Filter();
                (List<Media>, List<Artist>, List<User>, List<Playlist>, List<Album>) Results = f.Search(aSearchBox.Text.ToLower());
                List<object> res = f.CastToObj(Results.Item1, Results.Item2, Results.Item3, Results.Item4, Results.Item5);
                f.ObjGrid(res, ResultGrid, SearchTypes);
            }
            
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
        }

        private void BackProfileButton_Click(object sender, EventArgs e)
        {
            panelProfile.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Pending
            panelProfile.Hide();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menu = (ContextMenuStrip)menuItem.Owner;
            DataGridView grid = (DataGridView)menu.SourceControl; //csm
            Image img = Image.FromFile(@"Z:\proyecto-daniel-milstein\SpotfliX\icons8-pause-button-48.png");
            object sel = grid.Rows[SelectedRow].HeaderCell.Value;
            if (sel.GetType() == typeof(Song))
            {
                Song file = (Song)sel;
                MediaControl.PlayMedia(file, axWindowsMediaPlayer1, MediaPlayingLabel, ArtistPlayingLabel, PlayButton, img);
                ActiveMedia = file;
            }

            else if (sel.GetType() == typeof(Video))
            {
                Video file = (Video)sel;
                MediaControl.PlayMedia(file, axWindowsMediaPlayer1, MediaPlayingLabel, ArtistPlayingLabel, PlayButton, img);
                ActiveMedia = file;
            }

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

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                SearchTypes.Add(typeof(Playlist));
            }
            else
            {
                SearchTypes.Remove(typeof(Playlist));
            }
        }

        private void button6_Click(object sender, EventArgs e) //FollowButton
        {
            Artist art = Spotflix.GetPeopleDB[ArtistNameLabel.Text];
            if (button6.Text == "Follow")
            {
                
                ActiveUser.FollowArtist(art);
                button6.Text = "Unfollow";
                button6.BackColor = Color.CornflowerBlue;
            }
            else if(button6.Text == "Unfollow")
            {
                ActiveUser.FollowArtist(art);
                button6.Text = "Follow";
                button6.BackColor = Color.MidnightBlue;
            }

            FollowerQLabel.Text = art.GetFollowers().Count().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panelSearch.Visible)
            {
                panelSearch.Show(); 
            }
            else
            {
                panelSearch.Hide();
            }
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e) //DeleteMediaMenuItem
        {
            ToolStripMenuItem submenuItem = (ToolStripMenuItem)sender;
            ToolStripDropDownMenu submenudrop = (ToolStripDropDownMenu)submenuItem.Owner;

            ToolStripMenuItem menuItem = (ToolStripMenuItem)submenudrop.OwnerItem;
            ContextMenuStrip m = (ContextMenuStrip)menuItem.Owner;
            DataGridView grid = (DataGridView)m.SourceControl;

            object sel = grid.Rows[SelectedRow].HeaderCell.Value;
            if (sel.GetType() == typeof(Song))
            {
                Song file = (Song)sel;
                Spotflix.DeleteMedia(file);


            }

            else if (sel.GetType() == typeof(Video))
            {
                Video file = (Video)sel;
                Spotflix.DeleteMedia(file);
            }
        }

        private void queueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem submenuItem = (ToolStripMenuItem)sender;
            ToolStripDropDownMenu submenudrop = (ToolStripDropDownMenu)submenuItem.Owner;

            ToolStripMenuItem menuItem = (ToolStripMenuItem)submenudrop.OwnerItem;
            ContextMenuStrip m = (ContextMenuStrip)menuItem.Owner;
            DataGridView grid = (DataGridView)m.SourceControl;
            Media media = (Media)grid.Rows[SelectedRow].HeaderCell.Value;
            //IWMPMedia mediaF = axWindowsMediaPlayer1.newMedia(media.GetFileName());
            //axWindowsMediaPlayer1.currentPlaylist.appendItem(mediaF);
            ActiveUser.AddToQueue(media);

        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, _WMPOCXEvents_MediaChangeEvent e)
        {
            //AxWindowsMediaPlayer wmp = (AxWindowsMediaPlayer)sender;

            //if (ActiveUser.GetQueue().Count() != 0)
            //{
            //    ActiveMedia = ActiveUser.GetQueue().Dequeue();
            //}            
            //Media media = Spotflix.FindMedia(ActiveMedia.GetFileName());
            //MediaControl.PlayMedia(media, axWindowsMediaPlayer1, MediaPlayingLabel, ArtistPlayingLabel);
            //string mediaName = media.GetMetadata().GetName();
            //string creator;
            //if (media.GetType() == typeof(Song))
            //{
            //    creator = media.GetMetadata().GetArtist();
            //}
            //else
            //{
            //    creator = media.GetMetadata().GetCreator();
            //}


            //ArtistPlayingLabel.Text = creator;
            //MediaPlayingLabel.Text = mediaName;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"Z:\proyecto-daniel-milstein\SpotfliX\icons8-pause-button-48.png");
            if (ActiveUser.GetQueue().Count() != 0)
            {
                ActiveMedia = ActiveUser.GetQueue().Dequeue();
                Media media = Spotflix.FindMedia(ActiveMedia.GetFileName());
                MediaControl.PlayMedia(media, axWindowsMediaPlayer1, MediaPlayingLabel, ArtistPlayingLabel, PlayButton, img);
            }
            
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Image pauseImg = Image.FromFile(@"Z:\proyecto-daniel-milstein\SpotfliX\icons8-pause-button-48.png");
            Image playImg = Image.FromFile(@"Z:\proyecto-daniel-milstein\SpotfliX\icons8-play-button-48.png");
            Button pB = (Button)sender;
            bool playing = axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying;

            if (playing)
            {
                pB.Image = playImg;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                pB.Image = pauseImg;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            //axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (!axWindowsMediaPlayer1.settings.mute)
            {
                Vol = axWindowsMediaPlayer1.settings.volume;
                axWindowsMediaPlayer1.settings.mute = true;
                
                b.Image = Image.FromFile(@"Z:\proyecto-daniel-milstein\SpotfliX\icons8-mute-48.png");
            }

            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                axWindowsMediaPlayer1.settings.volume = Vol;
                b.Image = Image.FromFile(@"Z:\proyecto-daniel-milstein\SpotfliX\icons8-audio-48.png");
            }

            
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            axWindowsMediaPlayer1.settings.volume = tb.Value;
        }
    }
}
