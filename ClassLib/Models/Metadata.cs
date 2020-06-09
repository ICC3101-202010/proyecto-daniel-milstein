using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public abstract class Metadata
    {
        public Metadata()
        {
          
        }

        public abstract string GetName();
        public abstract string GetCreator();
        public abstract string GetGenre();
        public abstract string GetCategory();
        public abstract string GetDirector();
        public abstract string GetStudio();
        public abstract string GetArtist();
        public abstract string GetAlbum();
        public abstract string[] GetActors();
    }
}
