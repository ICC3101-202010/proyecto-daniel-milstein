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
                foreach (object ite in list)
                {
                    if (ite.GetType() == typeof(User))
                    {
                        User item = (User)ite;
                        string username, followers, following;
                        username = item.GetUsername();
                        followers = item.GetFollowers().Count.ToString();
                        following = item.GetFollowing().Count.ToString();
                        grid.Rows.Add(username, followers, following);
                        grid.Rows[en].HeaderCell.Value = item;
                        en++;
                    }

                    else if (ite.GetType() == typeof(Song))
                    {
                        Song item = (Song)ite;
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

                    else if (ite.GetType() == typeof(Artist))
                    {
                        Artist item = (Artist)ite;
                        string name = item.GetName();
                        grid.Rows.Add(name);
                        grid.Rows[en].HeaderCell.Value = item;
                        en++;

                    }

                else if (ite.GetType() == typeof(Playlist))
                {
                    Playlist item = (Playlist)ite;
                    string name = item.GetName();
                    grid.Rows.Add(name);
                    grid.Rows[en].HeaderCell.Value = item;
                    en++;

                }

            }





        }
        public (List<Media>, List<Artist>, List<User>, List<Playlist>) Search(string Hkey)
        {
            List<Media> Res1 = new List<Media>();
            List<Artist> Res2 = new List<Artist>();
            List<User> Res3 = new List<User>();
            List<Playlist> Res4 = new List<Playlist>();

            List<Media> a = Spotflix.GetMediaDB;
            List<Artist> b = new List<Artist>();
            List<User> c = new List<User>();
            List<Playlist> d = new List<Playlist>();

            string key = Hkey.ToLower();



            foreach (Artist item in Spotflix.GetPeopleDB.Values)
            {
                b.Add(item);
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
                    IN = meta.GetName().Contains(key) || meta.GetArtist().Contains(key) || meta.GetAlbum().Contains(key)
                        || meta.GetGenre().Contains(key) || meta.GetLabel().Contains(key) || meta.GetLyrics().Contains(key);

                    rIN = key.Contains(meta.GetName()) || key.Contains(meta.GetArtist()) || key.Contains(meta.GetAlbum()) ||
                        key.Contains(meta.GetGenre()) || key.Contains(meta.GetLabel()) || key.Contains(meta.GetLyrics());
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
                    IN = meta.GetName().Contains(key) || meta.GetArtist().Contains(key) || meta.GetAlbum().Contains(key)
                        || meta.GetGenre().Contains(key) || meta.Actors4Search().Contains(key) || meta.GetAspectRatio().Contains(key)
                        || meta.GetResolution().Contains(key) || meta.GetDirector().Contains(key) || meta.GetStudio().Contains(key)
                        || meta.GetCategory().Contains(key) || meta.GetCreator().Contains(key);
                    
                    rIN = key.Contains(meta.GetName()) || key.Contains(meta.GetArtist()) || key.Contains(meta.GetAlbum()) ||
                        key.Contains(meta.GetGenre()) || key.Contains(meta.GetAspectRatio()) || key.Contains(meta.GetCategory())
                         || key.Contains(meta.GetResolution()) || key.Contains(meta.GetDirector()) || key.Contains(meta.GetStudio())
                          || key.Contains(meta.GetCreator());


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
                if (item.GetName().Contains(key) || key.Contains(item.GetName()))
                {
                    Res2.Add(item);
                }
            }

            foreach (User item in c)
            {
                if (item.GetUsername().Contains(key) || key.Contains(item.GetUsername()))
                {
                    Res3.Add(item);
                }
            }

            foreach (Playlist item in d)
            {
                if (item.GetName().Contains(key) || key.Contains(item.GetName()) && !item.GetPrivate() )
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








            (List<Media>, List<Artist>, List<User>, List<Playlist>) SearchResults = (Res1, Res2, Res3, Res4);
            return SearchResults;
        }


        //public List<Media> Search(string key)
        //{
        //    List<Media> SearchResults = new List<Media>();

        //    List<Media> SF = Spotflix.GetMediaDB;



        //    foreach(Media v in SF)
        //    {
        //        List<string> Options2 = new List<string>();
        //        string o1, o2, o3, o4, o5, o6, o7, o8;
        //        o1 = o2 = o3 = o4 = o5 = o6 = o7 = o8 = "";

        //        try
        //        {

        //            o1 = v.GetMetadata().GetName().ToLower();
        //        }
        //        catch { }
        //        try
        //        {
        //            o2 = v.GetMetadata().GetCreator().ToLower();
        //        }
        //        catch { }
        //        try { o3 = v.GetMetadata().GetGenre().ToLower(); }
        //        catch { }
        //        try { o4 = v.GetMetadata().GetCategory().ToLower(); }
        //        catch { }
        //        try { o5 = v.GetMetadata().GetDirector().GetName().ToLower(); }
        //        catch { }
        //        try { o6 = v.GetMetadata().GetStudio().ToLower(); }
        //        catch { }
        //        try { o7 = v.GetMetadata().GetArtist().GetName().ToLower(); }
        //        catch { }
        //        try { o8 = v.GetMetadata().GetAlbum().GetName().ToLower(); }
        //        catch { }

        //        Options2.Add(o1);
        //        Options2.Add(o2);
        //        Options2.Add(o3);
        //        Options2.Add(o4);
        //        Options2.Add(o5);
        //        Options2.Add(o6);
        //        Options2.Add(o7);
        //        Options2.Add(o8);
        //        try
        //        {
        //            foreach (Artist actor in v.GetMetadata().GetActors())
        //            {
        //                Options2.Add(actor.GetName());
        //            }
        //        }
        //        catch { }

        //        foreach (string i in Options2)
        //        {
        //            bool asd = i.Contains(key.ToLower());
        //            if (asd == true)
        //            {
        //                if (SearchResults.Contains(v) == false)
        //                {
        //                    SearchResults.Add(v);
        //                }


        //            }


        //        }

        //    }
        //    if (SearchResults.Count == 0)
        //    {
        //        Console.WriteLine("Your search has returned no results");
        //        return SearchResults;
        //    }
        //    else
        //    {
        //        return SearchResults;
        //    }

        //}

    }

}
