using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Song : Media
    {
        
        private SongMetadata MetaData;

        public Song(string fileName, SongMetadata metadata, string format, string duration) : base(fileName, format, duration)
        {
            MetaData = metadata;
            Artist per;
            string artist = metadata.GetArtist();
            bool artEX = Spotflix.GetPeopleDB.ContainsKey(artist);
            if (artEX)
            {
                per = Spotflix.GetPeopleDB[artist];
                per.AddProfession("Musical Artist");
                per.AddWork(this);
            }
            else
            {
                per = new Artist(artist);
                per.AddProfession("Musical Artist");
                per.AddWork(this);
                Spotflix.AddPerson(per);
            }
            string album = metadata.GetAlbum();
            bool alEx = per.GetAlbums().ContainsKey(album);
            if (alEx)
            {
                per.GetAlbums()[album].AddSong(this);
            }
            else
            {
                Album newAl = new Album(album, per);
                newAl.AddSong(this);
                per.AddAlbum(album,newAl);
            }
            Spotflix.ImportMedia(this);
        }

       
        public override Metadata GetMetadata()
        {
            return MetaData;
        }
    }
}
