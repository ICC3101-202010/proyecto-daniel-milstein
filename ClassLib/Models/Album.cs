using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Proyecto
{
    [Serializable]
    public class Album
    {
        private string Name;
        private Artist Artist;
        private List<Song> SongList;
        private string CoverPhoto;

        

        public Album(string name, Artist artist)
        {
            Name = name;
            Artist = artist;
            List<Song> songs = new List<Song>();
            SongList = songs;
        }

        
        public void AddSong(Song song)
        {
            SongList.Add(song); //Event?
        }
        public void RemoveSong(Song s)
        {
            SongList.Remove(s);
        }

        public string GetName()
        {
            return Name;
        }

        public List<Song> GetSongs() { return SongList; }

        public void SetSongs(List<Song> songs)
        {
            SongList = songs;
        }

        public Artist GetArtist() { return Artist; }
    }
}
