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


            try
            {
                var load = Spotflix.Load("Spotflix.bin");

                Spotflix.SetUserDB(load.Item1);
                Spotflix.SetMediaDB(load.Item2);
                Spotflix.SetPeopleDB(load.Item3);
            }
            catch (Exception){}
            Form1 f1 = new Form1();
            f1.Show();
            
            Application.Run();




        }

        
    }
}
