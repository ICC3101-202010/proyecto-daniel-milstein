using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    [Serializable]
    public class Filter
    {
        public Filter()
        {
        }
        

        public void MediaView(List<Media> list, DataGridView grid)
        {
            
            grid.Rows.Clear();
            int en = 0;
            grid.Columns.Add("NameC", "Name");
            grid.Columns.Add("ArtistC", "Artist");
            grid.RowHeadersVisible = false;
            foreach (Media item in list)
            {
                string name, artist;
                name = item.GetMetadata().GetName();
                artist = item.GetMetadata().GetArtist();
                if (artist == null)
                {
                    artist = item.GetMetadata().GetDirector();
                }


                grid.Rows.Add(name, artist);
                grid.Rows[en].HeaderCell.Value = item;
                en++;
            }
            
        }

        public void UserView(List<User> list, DataGridView grid)
        {
            
            grid.Rows.Clear();
            grid.Columns.Add("NameC", "Username");
            grid.Columns.Add("Followers", "Name");
            grid.Columns.Add("Following", "Name");
            int en = 0;
            foreach (User item in list)
            {
                string username, followers, following;
                username = item.GetUsername();
                followers = item.GetFollowers().Count.ToString();
                following = item.GetFollowing().Count.ToString();
                grid.Rows.Add(username, followers, following);
                grid.Rows[en].HeaderCell.Value = item;
                en++;
            }





        }

        public void ObjGrid(List<object> list, DataGridView grid, List<Type> types) 
        {
            
            grid.Rows.Clear();
            grid.RowHeadersVisible = false;
            grid.ForeColor = System.Drawing.Color.Black;
            grid.Columns.Clear();
            
            int en = 0;
            grid.Columns.Add("Name", "Name");
            grid.Columns.Add("Type", "Type");
            foreach (object ite in list)
            {
                if (ite.GetType() == typeof(User) && types.Contains(typeof(User)))
                {
                    User item = (User)ite;
                    string username, followers, following;
                    username = item.GetUsername();
                    followers = item.GetFollowers().Count.ToString();
                    following = item.GetFollowing().Count.ToString();
                    grid.Rows.Add(username, "User");
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;
                }

                else if (ite.GetType() == typeof(Song) && types.Contains(typeof(Song)))
                {
                    Song item = (Song)ite;
                    string name, artist;
                    name = item.GetMetadata().GetName();
                    artist = item.GetMetadata().GetArtist();
                    if (artist == null)
                    {
                        artist = item.GetMetadata().GetDirector();
                    }
                    grid.Rows.Add(name, "Song");
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;
                }

                else if (ite.GetType() == typeof(Artist) && types.Contains(typeof(Artist)))
                {
                    Artist item = (Artist)ite;
                    string name = item.GetName();
                    grid.Rows.Add(name, "Artist");
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;

                }

                else if (ite.GetType() == typeof(Playlist) && types.Contains(typeof(Playlist)))
                {
                    Playlist item = (Playlist)ite;
                    string name = item.GetName();
                    grid.Rows.Add(name, "Playlist");
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;

                }
                else if (ite.GetType() == typeof(Album) && types.Contains(typeof(Album)))
                {
                    Album item = (Album)ite;
                    string name = item.GetName();
                    grid.Rows.Add(name, "Album");
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;

                }
            }





        }
        public (List<Media>, List<Artist>, List<User>, List<Playlist>, List<Album>) Search(string Hkey)
        {
            List<Media> Res1 = new List<Media>();
            List<Artist> Res2 = new List<Artist>();
            List<User> Res3 = new List<User>();
            List<Playlist> Res4 = new List<Playlist>();
            List<Album> Res5 = new List<Album>();

            List<Media> a = Spotflix.GetMediaDB;
            List<Artist> b = new List<Artist>();
            List<User> c = new List<User>();
            List<Playlist> d = new List<Playlist>();
            List<Album> e = new List<Album>();

            string key = Hkey.ToLower();



            foreach (Artist item in Spotflix.GetPeopleDB.Values)
            {
                b.Add(item);
                foreach (Album al in item.GetAlbums().Values)
                {
                    e.Add(al);
                }
            }
            foreach (User item in Spotflix.GetUserDB.Values)
            {
                c.Add(item);
                foreach  (Playlist pl in item.GetPlaylist())
                {
                    d.Add(pl);
                }
            }

            foreach  (Media media in a)
            {
                if (media.GetType() == typeof(Song))
                {
                    SongMetadata meta = (SongMetadata)media.GetMetadata();
                    bool IN, Year, rIN;
                    IN = meta.GetName().ToLower().Contains(key) || meta.GetArtist().ToLower().Contains(key) || meta.GetAlbum().ToLower().Contains(key)
                        || meta.GetGenre().ToLower().Contains(key) || meta.GetLabel().ToLower().Contains(key);
                    if (key != "")
                    {
                        rIN = key.Contains(meta.GetName().ToLower()) || key.Contains(meta.GetArtist().ToLower()) || key.Contains(meta.GetAlbum().ToLower()) ||
                            key.Contains(meta.GetGenre().ToLower()) || key.Contains(meta.GetLabel().ToLower());
                    }
                    else
                    {
                        rIN = false;
                    }
                    string year = meta.GetPublicationYear().ToString();
                    Year = (year.Contains(key)||key.Contains(year));


                    if (IN || Year || rIN)
                    {
                        Res1.Add(media);
                    }
                    
                }
                else //video
                {
                    VideoMetadata meta = (VideoMetadata)media.GetMetadata();
                    bool IN, Year, rIN;
                    IN = meta.GetName().ToLower().Contains(key) || meta.GetArtist().ToLower().Contains(key) || meta.GetAlbum().ToLower().Contains(key)
                        || meta.GetGenre().ToLower().Contains(key) || meta.Actors4Search().Contains(key) || meta.GetAspectRatio().ToLower().Contains(key)
                        || meta.GetResolution().ToLower().Contains(key) || meta.GetDirector().ToLower().Contains(key) || meta.GetStudio().ToLower().Contains(key)
                        || meta.GetCategory().ToLower().Contains(key) || meta.GetCreator().ToLower().Contains(key);
                    
                    rIN = key.Contains(meta.GetName().ToLower()) || key.Contains(meta.GetArtist().ToLower()) || key.Contains(meta.GetAlbum().ToLower()) ||
                        key.Contains(meta.GetGenre().ToLower()) || key.Contains(meta.GetAspectRatio().ToLower()) || key.Contains(meta.GetCategory().ToLower())
                         || key.Contains(meta.GetResolution().ToLower()) || key.Contains(meta.GetDirector().ToLower()) || key.Contains(meta.GetStudio().ToLower())
                          || key.Contains(meta.GetCreator().ToLower());


                    string year = meta.GetPubYear().ToString();
                    Year = (year.Contains(key) || key.Contains(year));


                    if (IN || Year || rIN)
                    {
                        Res1.Add(media);
                    }
                }
            }

            foreach (Artist item in b)
            {
                if (item.GetName().ToLower().Contains(key) || key.Contains(item.GetName().ToLower()))
                {
                    Res2.Add(item);
                }
                foreach (Album al in e)
                {
                    if (al.GetName().ToLower().Contains(key))
                    {
                        Res5.Add(al);
                    }
                    foreach (Media m in al.GetSongs())
                    {
                        if (Res1.Contains(m) && !Res5.Contains(al))
                        {
                            Res5.Add(al);
                        }
                    }
                }
            }

            foreach (User item in c)
            {
                if (item.GetUsername().ToLower().Contains(key) || key.Contains(item.GetUsername().ToLower()))
                {
                    Res3.Add(item);
                }
            }

            foreach (Playlist item in d)
            {
                if (item.GetName().ToLower().Contains(key) || key.Contains(item.GetName().ToLower()) && !item.GetPrivate() )
                {
                    Res4.Add(item);
                }
                foreach  (Media m in item.GetList())
                {
                    if (Res1.Contains(m) && !Res4.Contains(item))
                    {
                        Res4.Add(item);
                    }
                }
            }








            (List<Media>, List<Artist>, List<User>, List<Playlist>, List<Album>) SearchResults = (Res1, Res2, Res3, Res4, Res5);
            return SearchResults;
        }



        public List<object> CastToObj(List<Media> a, List<Artist> b, List<User> c, List<Playlist> d, List<Album> e)
        {
            List<object> result = new List<object>();

            foreach (Media item in a)
            {
                object r = item;
                result.Add(r);
            }
            foreach (Artist item in b)
            {
                object r = item;
                result.Add(r);
            }
            foreach (User item in c)
            {
                object r = item;
                result.Add(r);
            }
            foreach (Playlist item in d)
            {
                object r = item;
                result.Add(r);
            }
            foreach (Album item in e)
            {
                object r = item;
                result.Add(r);
            }

            return result;
        }
        public List<object> CastToObj(List<Media> a)
        {
            List<object> result = new List<object>();

            foreach (Media item in a)
            {
                object r = item;
                result.Add(r);
            }
            return result;
        }

        public List<object> CastToObj(Artist a)
        {
            List<object> result = new List<object>();

            foreach (Album item in a.GetAlbums().Values)
            {
                object r = item;
                result.Add(r);
            }
            return result;
        }
    }

}
