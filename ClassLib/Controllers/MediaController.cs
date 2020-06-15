using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxWMPLib;

namespace Proyecto
{
    public class MediaController
    {
    


        public void PlayMedia(Media media, AxWindowsMediaPlayer player)
        {
            //play media
            // Media file = (Media)MediaGrid.SelectedRows[0].HeaderCell.Value;
            string fname = media.GetFileName();
            player.URL = fname;
            player.Ctlcontrols.play();
            player.windowlessVideo = false;
        } 
    
    }
}
