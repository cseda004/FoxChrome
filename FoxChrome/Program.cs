using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxChrome
{
    static class Program
    {

        public static string a = "\"";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //foreach (var i in getProfiles()) MessageBox.Show(i);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(args, getProfiles()));
        }

        static string[] getProfiles() {

            var profiles = new ArrayList();

            string profileFolder =  Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+ @"\Mozilla\Firefox\Profiles";

            string[] subdirectoryEntries = Directory.GetDirectories(profileFolder);

            // Loop through them to see if they have any other subdirectories

            foreach (string subdirectory in subdirectoryEntries) {

                if (System.IO.File.Exists(subdirectory + @"\prefs.js")) { profiles.Add(subdirectory.Split('\\')[subdirectory.Split('\\').Length-1]);  }
            };

            return (string[])profiles.ToArray(typeof(string));

        }

    }
}
