using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Proyecto
{
    [Serializable]
    public class VideoMetadata : Metadata
    {
        private string Name;
        private string Creator;
        private string Genre;
        private string Category;
        private string[] Actors;
        private string Director;
        private string Studio;
        private int PubYear;
        private string Description;
        private string Resolution;
        private string AspectRatio;

        public VideoMetadata(string name, string creator, string genre, string category, string studio, string description,
            string resolution, string aspecRatio, string director, string actors, string pubYear)
        {
            Name = name;
            Creator = creator;
            Genre = genre;
            Category = category;
            Studio = studio;
            Description = description;
            Resolution = resolution;
            AspectRatio = aspecRatio;
            PubYear = Convert.ToInt32(pubYear);
            Actors = actors.Split(':');
            Director = director;
        }

        public override string GetName() { return Name; }
        public override string GetCreator() { return Creator; }
        public override string GetGenre() { return Genre; }
        public override string GetCategory() { return Category; }
        public override string GetStudio() { return Studio; }
        public int GetPubYear() { return PubYear; }
        public string GetDescription() { return Description; }
        public override string[] GetActors() { return Actors; }
        public override string GetDirector() { return Director; }
        public string GetResolution() { return Resolution; }
        public string GetAspectRatio() { return AspectRatio; }




        

        public override string GetArtist()
        {
            return null;
        }

        public override string GetAlbum()
        {
            return null;
        }
    }
}
