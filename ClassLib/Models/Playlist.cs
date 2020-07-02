using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Playlist
    {
        private string Name;
        private bool PrivateList;
        private List<Media> PList;
        private string CreatedBy;

        public Playlist(string name, bool privateList, string createdBy)
        {

            Name = name;
            List<Media> pList = new List<Media>();
            PList = pList;
            PrivateList = privateList;
            CreatedBy = createdBy;

        }


        public string GetName() { return Name; }

        public void AddMedia(Media media)
        {
            if (PList.Count == 0)
            {
                PList.Add(media);
            }

            else if (PList.Count != 0 && media.GetType() == PList[0].GetType())
            {
                PList.Add(media);
            }
            
        }

        public List<Media> GetList()
        {
            return PList;
        }

        public bool GetPrivate() { return PrivateList; }

        public void SetPrivate(bool pvt) { PrivateList = pvt; }

        public string GetCreator()
        {
            return CreatedBy;
        }
    }
}
