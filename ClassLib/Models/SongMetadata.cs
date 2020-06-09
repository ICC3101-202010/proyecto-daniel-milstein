using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class SongMetadata : Metadata
    {
        private string Name;
        private string ArtistN;
        private string Album;
        private string Genre;
        private int PublicationYear;
        private string RecordLabel;
        private string Lyrics;

        public SongMetadata(string name, string artist, string album, string genre, string pubYear, string label) 
        {
            Name = name;
            Genre = genre;
            RecordLabel = label;
            PublicationYear = Convert.ToInt32(pubYear);
            ArtistN = artist;
            Album = album;
            
        }

        public SongMetadata(string name, string artist, string album, string genre, string pubYear, string label, string lyrics)
            :this(name, artist, album, genre, pubYear, label)
        {
            Lyrics = lyrics;
        }
        public override string GetName() { return Name; }
        public override string GetArtist() { return ArtistN; }
        public override string GetAlbum() { return Album; }
        public override string GetGenre() { return Genre; }
        public int GetPublicationYear() { return PublicationYear; }
        public string GetLabel() { return RecordLabel; }

        public void AddLyrics(string lyrics)
        {
            Lyrics = lyrics;
        }

        public string GetLyrics()
        {
            return Lyrics;
        }


        public override string GetCreator()
        {
            return null;
        }

        public override string GetCategory()
        {
            return null;
        }

        public override string GetDirector()
        {
            return null;
        }

        public override string GetStudio()
        {
            return null;
        }

        public override string[] GetActors()
        {
            return null;
        }
    }
}
