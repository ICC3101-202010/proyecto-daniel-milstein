using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Proyecto
{
    [Serializable]
    public abstract class Media
    {
        protected Dictionary<string, string> Information;
        protected int UsersLike;
        protected double Score;
        protected int Views;
        protected string FileName;
        protected double Duration;


        public Media(string fileName, string format, string duration)
        {
            AddInfo(fileName, format, duration);
            FileName = fileName;
            UsersLike = 0;
            Score = 0;
            Views = 0;
        }

        public string GetFileName()
        {
            string fn = Information["filename"];
            return fn;
        }

        public void MetadataInfo()
        {

        }
        public void Scored()
        {
            //Event con score que saca promedio
        }

        public void Viewed()
        {
            //Event con play
        }

        public abstract Metadata GetMetadata();

        public void TiempoReproduccion()
        {

        }

        public void AddInfo(string fileName, string format, string duration)
        {

            double durNum = 0;
            FileInfo fi = new FileInfo(fileName);
            long size = fi.Length;
            string fileSize = $"{size}bytes";
            string[] hms = duration.Split(':');
            int hrs = Convert.ToInt32(hms[0]);
            int min = Convert.ToInt32(hms[1]);
            int sec = Convert.ToInt32(hms[2]);
            TimeSpan time = new TimeSpan(hrs, min, sec);
            durNum = time.TotalSeconds;
            Dictionary<string, string> info = new Dictionary<string, string>();
            info.Add("filename", fileName);
            info.Add("format", format);
            duration = $"{durNum}";
            info.Add("duration", duration);
            info.Add("size", fileSize);
            Duration = durNum;
            Information = info;
        }


        public void Play()
        {

            
            
        }

        public void AddToQueue()
        {

        }

        public void AddLike(bool a)
        {
            // Event

            if (a == true)
            {
                UsersLike += 1;
            }
            else
            {
                UsersLike -= 1;
            }
            
        }

        
        
    }
}
