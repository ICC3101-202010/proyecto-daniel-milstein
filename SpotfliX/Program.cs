using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto;

namespace SpotfliX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Save(Dictionary<string, User> userDB, List<Media> mediaDB, List<Person> peopleDB, string name)
        {
            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, userDB);
            formatter.Serialize(stream, mediaDB);
            formatter.Serialize(stream, peopleDB);
            stream.Close();
        }

        public static (Dictionary<string, User>, List<Media>, List<Person>) Load(string name)
        {
            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            Dictionary<string, User> userDB = (Dictionary<string, User>)formatter.Deserialize(stream);
            List<Media> mediaDB = (List<Media>)formatter.Deserialize(stream);
            List<Person> peopleDB = (List<Person>)formatter.Deserialize(stream);
            stream.Close();

            return (userDB, mediaDB, peopleDB);
        }
    }
}
