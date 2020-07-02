using System;
using System.Collections.Generic;
using System.Linq;
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
            grid.Columns.Add("Artist", "Artist");
            grid.Columns.Add("Length", "Length");
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
                    grid.Rows.Add(username, "","","User");
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
                    long l = Convert.ToInt64(item.GetInfo()["duration"])*10000000;
                    
                    DateTime dt = new DateTime(l);
                    string dur = dt.ToString("HH:mm:ss");
                    grid.Rows.Add(name, artist, dur, "Song" );
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;
                }

                else if (ite.GetType() == typeof(Video) && types.Contains(typeof(Video)))
                {
                    Video item = (Video)ite;
                    string name, artist;
                    name = item.GetMetadata().GetName();
                    artist = item.GetMetadata().GetArtist();
                    if (artist == null)
                    {
                        artist = item.GetMetadata().GetCreator();
                    }
                    long l = Convert.ToInt64(item.GetInfo()["duration"]) * 10000000;
                    DateTime dt = new DateTime(l);
                    string dur = dt.ToString("HH:mm:ss");
                    grid.Rows.Add(name, artist, dur, "Video");
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;
                }

                else if (ite.GetType() == typeof(Artist) && types.Contains(typeof(Artist)))
                {
                    Artist item = (Artist)ite;
                    string name = item.GetName();
                    grid.Rows.Add(name, "", "","Artist");
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;

                }

                else if (ite.GetType() == typeof(Playlist) && types.Contains(typeof(Playlist)))
                {
                    Playlist item = (Playlist)ite;
                    string name = item.GetName();
                    long l = 0;
                    foreach (Media m in item.GetList())
                    {
                        l += Convert.ToInt64(m.GetInfo()["duration"]) * 10000000;
                    }
                    DateTime dt = new DateTime(l);
                    string dur = dt.ToString("HH:mm:ss");
                    grid.Rows.Add(name, item.GetCreator(),dur , "Playlist");
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;

                }
                else if (ite.GetType() == typeof(Album) && types.Contains(typeof(Album)))
                {
                    Album item = (Album)ite;
                    string name = item.GetName();
                    long l = 0;
                    foreach (Media m in item.GetSongs())
                    {
                        l += Convert.ToInt64(m.GetInfo()["duration"]) * 10000000;
                    }
                    DateTime dt = new DateTime(l);
                    string dur = dt.ToString("HH:mm:ss");
                    grid.Rows.Add(name, item.GetArtist().GetName() ,dur ,"Album");
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

            string key = Hkey.ToLower().Trim();



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
                    IN = meta.GetName().ToLower().Contains(key) 
                        || meta.GetGenre().ToLower().Contains(key) || meta.Actors4Search().Contains(key) || meta.GetAspectRatio().ToLower().Contains(key)
                        || meta.GetResolution().ToLower().Contains(key) || meta.GetDirector().ToLower().Contains(key) || meta.GetStudio().ToLower().Contains(key)
                        || meta.GetCategory().ToLower().Contains(key) || meta.GetCreator().ToLower().Contains(key);
                    
                    rIN = key.Contains(meta.GetName().ToLower()) || 
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
                    foreach (Album alb in item.GetAlbums().Values)
                    {
                        Res5.Add(alb);
                    }
                }
                foreach (Album al in e)
                {
                    if (al.GetName().ToLower().Contains(key.Trim()) || al.GetArtist().GetName().Contains(key))
                    {
                        Res5.Add(al);
                        Res2.Add(item);
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
                    if (item.GetPrivate() == false)
                    {
                        Res4.Add(item); 
                    }
                }
                foreach  (Media m in item.GetList())
                {
                    if (Res1.Contains(m) && !Res4.Contains(item) && item.GetPrivate() == false)
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
            HashSet<object> results = new HashSet<object>(result);


            return results.ToList();
        }
        public List<object> CastToObj(List<Song> a)
        {
            List<object> result = new List<object>();

            foreach (Song item in a)
            {
                object r = item;
                result.Add(r);
            }
            return result;
        }
        public List<object> CastToObj(List<Video> a)
        {
            List<object> result = new List<object>();

            foreach (Video item in a)
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

        public List<object> CastToObj(List<Playlist> a)
        {
            List<object> result = new List<object>();

            foreach (Playlist item in a)
            {
                object r = item;
                result.Add(r);
            }
            return result;
        }

        public List<object> CastToObj(Queue<Media> queues)
        {
            List<object> result = new List<object>();

            foreach (Media item in queues)
            {
                object r = item;
                result.Add(r);
            }
            return result;
        }

        public List<object> AndSearch(List<string> kWords)
        {
            List<object> res = new List<object>();
            List<List<object>> resList = new List<List<object>>();
            string item2;
            foreach (string item in kWords)
            {
                item2 = item.Trim();
                (List<Media>, List<Artist>, List<User>, List<Playlist>, List<Album>) x = Search(item2);
                List<object> re = CastToObj(x.Item1, x.Item2, x.Item3, x.Item4, x.Item5);
                foreach (object obj in re)
                {
                    res.Add(obj);
                }
                resList.Add(re);
            }
            List<object> res2 = new List<object>(res);
            foreach (object x in res)
            {
                
                foreach (List<object> ls in resList)
                {
                    if (!ls.Contains(x))
                    {
                        res2.Remove(x);
                    }
                }
            }

            HashSet<object> hash = new HashSet<object>(res2);

            return hash.ToList();
        }
    }

}
