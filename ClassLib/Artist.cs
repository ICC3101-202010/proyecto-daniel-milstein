using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Artist : Person
    {
        private Dictionary<string, Album> Albums;
        private List<Song> Songs;
        private List<User> Followers;

        public Artist(string name) : base(name)
        {
            Name = name;
            Dictionary<string, Album> albums = new Dictionary<string, Album>();
            List<Song> songs = new List<Song>();
            List<User> followers = new List<User>();

            Albums = albums;
            Songs = songs;
            Followers = followers;

        }

        public List<Song> GetSongs()
        {
            return Songs;
        }

        public List<User> GetFollowers()
        {
            return Followers;
        }

        public Dictionary<string, Album> GetAlbums()
        {
            return Albums;
        }

        public void AddAlbum(string alName, Album album)
        {
            //Event
            Albums.Add(alName, album);
        }

        public void AddSong(Song song)
        {
            //Event
            Songs.Add(song);
        }

        public void AddFollower(User user)
        {
            //Event -> Remove en el mismo metodo?
            Followers.Add(user);
        }
    }
}
