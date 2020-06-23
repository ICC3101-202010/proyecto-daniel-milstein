using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Proyecto
{
    [Serializable]
    public class User
    {

        private string UserName;
        private string Email;
        private string Password;
        private bool PrivateAccount;   
        private List<User> Followers;
        private List<Object> Following;
        private Queue<Media> Queue;
        private List<Song> FavoriteMusic;
        private List<Video> FavoriteVideos;
        private List<object> Likes;
        private bool Premium;
        private List<Playlist> Playlists;
        private bool Admin;

        public User(string name, string email, string password, bool privateAccount, bool premium, bool admin)
        {
            UserName = name;
            Email = email;
            Password = password;
            PrivateAccount = privateAccount;
            List<Song> favoriteMusic = new List<Song>();
            List<Video> favoriteVideos = new List<Video>();
            List<object> likes = new List<object>();
            Queue<Media> queue = new Queue<Media>();
            List<Playlist> playlists = new List<Playlist>();
            List<User> followers = new List<User>();
            List<Object> following = new List<object>();
            Followers = followers;
            Following = following;
            FavoriteMusic = favoriteMusic;
            FavoriteVideos = favoriteVideos;
            Likes = likes;
            Queue = queue;
            Playlists = playlists;
            Premium = premium;
            Admin = admin;
        }

        public string GetPassword()
        {
            return Password;
        }

        public void SetPass(string newpass)
        {
            Password = newpass;
        }

        public List<Song> GetFavoriteMusic()
        {
            return FavoriteMusic;
        }
        public List<Video> GetFavoriteVideos()
        {
            return FavoriteVideos;
        }

        public List<Media> GetFavs()
        {
            List<Media> ls = new List<Media>();
            foreach (Song item in FavoriteMusic)
            {
                Media i = (Media)item;
                ls.Add(i);
            }
            foreach (Video item in FavoriteVideos)
            {
                Media i = (Media)item;
                ls.Add(i);
            }
            return ls;
        }
        public bool GetAdmin()
        {
            return Admin;
        }

        public string GetUsername()
        {
            return UserName;
        }

        public string GetEmail()
        {
            return Email;
        }

        public bool GetPrivate()
        {
            return PrivateAccount;
        }

        public bool GetPremium()
        {
            return Premium;
        }

        public void MakeAdmin() { Admin = true; }

        public List<Playlist> GetPlaylist()
        {
            return Playlists;
        }

        public List<User> GetFollowers()
        {
            return Followers;
        }

        public List<object> GetFollowing()
        {
            return Following;
        }

        public void AddToQueue(Media nextMedia)
        {
            Queue.Enqueue(nextMedia);
        }

        public Queue<Media> GetQueue()
        {
            return Queue;
        }

        public void AddToPlaylist(Media media, Playlist plName)
        {
            
            Playlist a = Playlists.Find(x => x.GetName() == plName.GetName());

            if (a.GetList().Contains(media))
            {
                return;
            }
            
            else
            {
                a.AddMedia(media);
            }
            
        }

        public void LikeMedia(Media media)
        {
            if (Likes.Contains(media))
            {
                media.AddLike(false);
                Likes.Remove(media);
                if (media.GetType() == typeof(Song))
                {
                    Song s = (Song)media;
                    FavoriteMusic.Remove(s);
                }
                else if (media.GetType() == typeof(Video))
                {
                    Video v = (Video)media;
                    FavoriteVideos.Remove(v);
                }
            }
            else
            {
                media.AddLike(true);
                Likes.Add(media);
                if (media.GetType() == typeof(Song))
                {
                    Song s = (Song)media;
                    FavoriteMusic.Add(s);
                }
                else if (media.GetType() == typeof(Video))
                {
                    Video v = (Video)media;
                    FavoriteVideos.Add(v);
                }
            }
            
        }

        public void NewPlaylist(string name, bool privateList)
        {
            Playlist a = new Playlist(name, privateList, UserName);
            
            Playlists.Add(a);
        }

        public void FollowArtist(Artist follow)
        {
            if (Following.Contains(follow))
            {
                Following.Remove(follow);
                follow.AddFollower(this);
            }
            else
            {
                Following.Add(follow);
                follow.AddFollower(this);
            }
            
        }

        

        


        

        public void AddMedia(Media media)
        {
            Spotflix.ImportMedia(media);
        }
    }
}


