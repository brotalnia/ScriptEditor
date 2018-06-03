using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ScriptEditor
{
    static class Program
    {
        // MySQL connection data.
        public static string connString = "Server=localhost;Database=mangos;Uid=root;Pwd=root;";
        public static string mysqlUser = "root";
        public static string mysqlPass = "root";
        public static string mysqlHost = "localhost";
        public static string mysqlDB = "mangos";

        // Highlight non-default values.
        public static bool highlight = false;

        internal sealed class NativeMethods
        {
            [DllImport("kernel32.dll")]
            public static extern bool AllocConsole();

            [DllImport("kernel32.dll")]
            public static extern bool FreeConsole();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadConfig();

            // Open a console window so the user can see loading progress.
            NativeMethods.AllocConsole();
            Console.WriteLine("Please wait while loading the database.\n");

            // Load content from the database.
            Console.WriteLine("Loading texts...");
            GameData.LoadBroadcastTexts(connString);
            Console.WriteLine("Loading quests...");
            GameData.LoadQuests(connString);
            Console.WriteLine("Loading gameobjects...");
            GameData.LoadGameObjects(connString);
            Console.WriteLine("Loading creatures...");
            GameData.LoadCreatures(connString);
            Console.WriteLine("Loading spells...");
            GameData.LoadSpells(connString);
            Console.WriteLine("Loading items...");
            GameData.LoadItems(connString);
            Console.WriteLine("Loading conditions...");
            GameData.LoadCondition(connString);
            Console.WriteLine("Loading areas...");
            GameData.LoadAreas(connString);
            Console.WriteLine("Loading sounds...");
            GameData.LoadSounds(connString);
            Console.WriteLine("Loading factions...");
            GameData.LoadFactions(connString);
            GameData.LoadFactionTemplates(connString);
            Console.WriteLine("Loading game events...");
            GameData.LoadGameEvents(connString);
            Console.WriteLine("Loading creature spells...");
            GameData.LoadCreatureSpells(connString);

            // Closes the temporary console window.
            NativeMethods.FreeConsole();

            // Start the main form.
            Application.Run(new Form1());
        }

        private static void LoadConfig()
        {
            if (!System.IO.File.Exists(@"config.ini"))
            {
                MessageBox.Show("Your config file seems to have vanished into the nether! But worry not, i shall use my ultra-safe mind reading device to guess your database connection details. Surely nothing can go wrong, gnomish inventions are renowned for their safety after all!", "No config found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"config.ini");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("User="))
                    mysqlUser = line.Replace("User=", "");
                else if (line.Contains("Pass="))
                    mysqlPass = line.Replace("Pass=", "");
                else if (line.Contains("Host="))
                    mysqlHost = line.Replace("Host=", "");
                else if (line.Contains("DB="))
                    mysqlDB = line.Replace("DB=", "");
                else if (line.Contains("Highlight=true"))
                    highlight = true;
            }

            connString = "Server=" + mysqlHost + ";Database=" + mysqlDB + ";Uid=" + mysqlUser + ";Pwd=" + mysqlPass + ";";
        }
    }
}
