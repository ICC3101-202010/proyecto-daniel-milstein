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
        

        public DataGridView MediaView(List<Media> list)
        {
            DataGridView grid = new DataGridView();
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
            return grid;
        }

        public DataGridView UserView(List<User> list)
        {
            DataGridView grid = new DataGridView();
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





            return grid;
        }

        public DataGridView ObjGrid(List<object> list)
        {
            DataGridView grid = new DataGridView();
            grid.Rows.Clear();

            int en = 0;
            grid.Columns.Add("Name", "Name");
            foreach (object ite in list)
            {
                if(ite.GetType() == typeof(User))
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

                else if (ite.GetType() == typeof(Media))
                {
                    Media item = (Media)ite;
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







                
            }





            return grid;
        }
        public List<object> Search(string key)
        {
            List<object> SearchResults = new List<object>();
            var a = Spotflix.GetMediaDB;
            var b = Spotflix.GetPeopleDB;
            var c = Spotflix.GetUserDB;
            foreach (var item in a)
            {
                SearchResults.Add(item);
            }
            foreach (var item in b)
            {
                SearchResults.Add(item);
            }
            foreach (var item in c)
            {
                SearchResults.Add(item);
            }
            //Logica
            //   ||
            //   ||
            //   || 
            //   ||
            return SearchResults;
        }   //   ||
        //       ||
        //      \  /
        //       \/

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
