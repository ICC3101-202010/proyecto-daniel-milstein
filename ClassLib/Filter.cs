using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Filter
    {
        public Filter()
        {
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
