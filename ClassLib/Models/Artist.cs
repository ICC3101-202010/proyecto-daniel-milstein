using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Artist
    {
        
        private string Name;
        private List<string> Professions;
        private string Gender;
        private List<Media> Work;
        private Dictionary<string, Album> Albums;
        private List<User> Followers;

        public Artist(string name, string gender)
        {
            Name = name;
            Dictionary<string, Album> albums = new Dictionary<string, Album>();
            List<Media> songs = new List<Media>();
            List<User> followers = new List<User>();
            Work = songs;
            Albums = albums;
            Gender = gender;

            Followers = followers;

        }
        public string GetName()
        {
            return Name;
        }
        public string GetGender()
        {
            return Gender;
        }
        public List<string> GetProfessions()
        {
            return Professions;
        }

        public void AddProfession(string prof)
        {
            if (Professions.Contains(prof))
            {
                return;
            }
            else
            {
                Professions.Add(prof);
            }
        }

        public List<Media> GetWork()
        {
            return Work;
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



        public void AddFollower(User user)
        {
            if (Followers.Contains(user))
            {
                Followers.Remove(user);

            }
            else
            {
                Followers.Add(user);
            }
            
        }
    }
}
