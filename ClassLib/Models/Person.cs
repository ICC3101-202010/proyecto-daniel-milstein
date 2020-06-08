using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Person
    {
        protected string Name;
        protected List<string> Professions;
        protected string Gender;
        protected List<Media> Work;


        public Person(string name)
        {
            Name = name;
            List<string> professions = new List<string>();
            Professions = professions;

        }


    }
}
