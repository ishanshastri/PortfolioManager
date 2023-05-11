using System;
using System.IO;
using System.Windows.Forms;

namespace IA_Implementation_1
    {
    static class Program
        {
        /// <summary>
        /// The database (mirrors program files stored in memory, and can be read from and written to from the UI)
        /// </summary>
        public static Database TheDatabase;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
            {
            //If first run (or program folder not found), create new program folder
            if (!Directory.Exists(Program.GetFolder()))
                {
                TheDatabase = Database.Create(Program.GetFolder());
                }

            //Open the database
            TheDatabase = Database.Open(Program.GetFolder());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupMenuForm());
            }

        /// <summary>
        /// Gets the folder path (directory) for this app.
        /// </summary>
        /// <returns>a string</returns>
        public static string GetFolder()
            {
            string myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = Path.Combine(myDocumentsFolder, "Stock Lab");
            Directory.CreateDirectory(path);
            return path;
            }
        }
    }
