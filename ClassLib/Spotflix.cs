using System;using System.Collections.Generic;using System.Diagnostics;using System.IO;using System.Runtime.Serialization;using System.Runtime.Serialization.Formatters.Binary;using System.Threading;using System.Windows.Forms;namespace Proyecto{    [Serializable]    public static class Spotflix    {        private static Dictionary<string, User> UserDB;        private static List<Media> MediaDB;        private static Dictionary<string, Artist> PeopleDB;                static Spotflix()        {
            Dictionary<string, User> userDB = new Dictionary<string, User>();
            List<Media> mediaDB = new List<Media>();
            Dictionary<string, Artist> peopleDB = new Dictionary<string, Artist>();
            /*
            try
            {
                var load = Load("Spotflix.bin");

                userDB = load.Item1;
                mediaDB = load.Item2;
                peopleDB = load.Item3;

            }
            catch (Exception)
            {
                userDB = new Dictionary<string, User>();
                mediaDB = new List<Media>();
                peopleDB = new Dictionary<string, Artist>();
                
            }            */
            User admin = new User("admin", "dnmilstein@miuandes.cl", "admin", true, true, true);
            userDB.Add("admin", admin);            UserDB = userDB;            MediaDB = mediaDB;            PeopleDB = peopleDB;                    }                public static Dictionary<string, Artist> GetPeopleDB        {            get            {                return PeopleDB;            }        }        public static List<Media> GetMediaDB { get { return MediaDB; } }        public static void SetMediaDB(List<Media> mediaDB) { MediaDB = mediaDB; }        public static void SetUserDB(Dictionary<string, User> userDB) { UserDB = userDB; }        public static void SetPeopleDB(Dictionary<string, Artist> peopleDB) { PeopleDB = peopleDB; }        public static void AddPerson(Artist person)        {            PeopleDB.Add(person.GetName(), person);        }        public static void SaveMedia(Media media)        {            MediaDB.Add(media);        }        public static void AddUser(User user)        {            UserDB.Add(user.GetUsername(), user);        }        public static Dictionary<string, User> GetUserDB        {            get            {                return UserDB;            }        }        public static void ImportMedia(Media media)        {            //Media a = new Media();            MediaDB.Add(media);        }        public static string LogIn(string username, string password)        {            User user = UserDB[username];            try            {                if (user.GetPassword() == password)                {                    return username;                }                else                {                    return "";                }            }            catch (Exception)            {                return "";            }        }        public static string AdminLogIn(string username, string password)        {            string admin = LogIn(username, password);            User user = UserDB[admin];            if (user.GetAdmin() == true)            {                return username;            }            else            {                return "";            }        }               public static void Save(string name)        {            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);            IFormatter formatter = new BinaryFormatter();            formatter.Serialize(stream, UserDB);            formatter.Serialize(stream, MediaDB);            formatter.Serialize(stream, PeopleDB);            stream.Close();        }        public static (Dictionary<string, User>, List<Media>, Dictionary<string, Artist>) Load(string name)        {            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);            IFormatter formatter = new BinaryFormatter();            Dictionary<string, User> userDB = (Dictionary<string, User>)formatter.Deserialize(stream);            List<Media> mediaDB = (List<Media>)formatter.Deserialize(stream);            Dictionary<string, Artist> peopleDB = (Dictionary<string, Artist>)formatter.Deserialize(stream);            stream.Close();            return (userDB, mediaDB, peopleDB);        }        public static void Save(string name, List<Media> media)
        {
            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, UserDB);            formatter.Serialize(stream, media);            formatter.Serialize(stream, PeopleDB);            stream.Close();
        }        public static void Save(string name, Dictionary<string, User> users)
        {
            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite                );            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, users);            formatter.Serialize(stream, MediaDB);            formatter.Serialize(stream, PeopleDB);            stream.Close();
        }        public static void Save(string name, Dictionary<string, Artist> artists)        {            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);            IFormatter formatter = new BinaryFormatter();            formatter.Serialize(stream, UserDB);            formatter.Serialize(stream, MediaDB);            formatter.Serialize(stream, artists);            stream.Close();        }        public static void DeleteMedia(Song s)
        {
            MediaDB.Remove(s);
            Artist a = PeopleDB[s.GetMetadata().GetArtist()];
            List<Media> l = a.GetWork();
            l.Remove(s);
            a.SetWork(l);
            Album al = a.GetAlbums()[s.GetMetadata().GetAlbum()];
            List<Song> sl = al.GetSongs();
            sl.Remove(s);
            al.SetSongs(sl);
        }        public static void DeleteMedia(Video v)
        {
            MediaDB.Remove(v);
            Artist a = PeopleDB[v.GetMetadata().GetDirector()];
            List<Media> l = a.GetWork();
            l.Remove(v);
            a.SetWork(l);
            foreach (string item in v.GetMetadata().GetActors())
            {
                a = PeopleDB[item];
                l = a.GetWork();
                l.Remove(v);
                a.SetWork(l);
            }
        }    }}