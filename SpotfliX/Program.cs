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
            /* Agregar admin
            User admin = new User("admin", "dnmilstein@miuandes.cl", "admin", true, true, true);
            Spotflix.AddUser(admin);
            Spotflix.Save(Spotflix.GetUserDB, Spotflix.GetMediaDB,Spotflix.GetPeopleDB, "Spotflix.bin");
            */
            
            Form1 f1 = new Form1();
            f1.Show();

            Application.Run();




        }

        
    }
}
