using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace Proyecto
{
    public class MediaController
    {
    


        public void PlayMedia(Media media, AxWindowsMediaPlayer player, Label nameLabel, Label artistLabel)
        {
            //play media
            // Media file = (Media)MediaGrid.SelectedRows[0].HeaderCell.Value;
            string fname = media.GetFileName();
            player.URL = fname;
            player.Ctlcontrols.play();
            player.windowlessVideo = false;
            nameLabel.Show();
            artistLabel.Show();
            nameLabel.Text = media.GetMetadata().GetName();
            string artist = media.GetMetadata().GetArtist();
            if (artist == null)
            {
                artist = media.GetMetadata().GetCreator();
                
            }

            artistLabel.Text = artist;

            
        } 
    
    }
}
