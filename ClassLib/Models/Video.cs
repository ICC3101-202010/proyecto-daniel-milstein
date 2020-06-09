using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Video : Media
    {

        private List<string> comments = new List<string>();
        private VideoMetadata MetaData;

        public Video(string fileName, VideoMetadata vm, string format, string duration) : base(fileName, format, duration)
        {
            MetaData = vm;
            Artist per;
            string director = vm.GetDirector();
            bool dirEx = Spotflix.GetPeopleDB.ContainsKey(director);
            if (dirEx)
            {
                per = Spotflix.GetPeopleDB[director];
                per.AddProfession("Director");
                per.AddWork(this);
            }
            else
            {
                per = new Artist(director);
                per.AddProfession("Director");
                per.AddWork(this);
                Spotflix.AddPerson(per);

            }
            string[] actorList = vm.GetActors();
            foreach (string act in actorList)
            {
                Artist art;
                bool acEx = Spotflix.GetPeopleDB.ContainsKey(act);
                if (acEx)
                {
                    art = Spotflix.GetPeopleDB[act];
                    art.AddProfession("Actor");
                    art.AddWork(this);
                }
                else
                {
                    art = new Artist(act);
                    art.AddProfession("Actor");
                    art.AddWork(this);
                    Spotflix.AddPerson(art);
                }
            }
            Spotflix.ImportMedia(this);
        }
        public override Metadata GetMetadata()
        { 
            return MetaData;
            
        }


        void Add_image()
        {
            return;
        }

    }
}
