using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Song : Media
    {
        
        private SongMetadata MetaData;

        public Song(string fileName, SongMetadata metadata) : base(fileName)
        {
            
            MetaData = metadata;
        }

       
        public override Metadata GetMetadata()
        {
            return MetaData;
        }
    }
}
