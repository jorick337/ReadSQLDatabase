using MySql.Data.MySqlClient;
using System.ComponentModel.Design;
using System.Data;
using static System.Windows.Forms.LinkLabel;

namespace CityLibraryInfoSystem
{
    internal class BasicDatabaseValues
    {
        public static ActiveDatabase ActiveDatabase { get; set; }

        public BasicDatabaseValues() 
        {
            ActiveDatabase = new ActiveDatabase();
        }

        public static void LoadDatabase(string link)
        {
            ActiveDatabase = new ActiveDatabase(link);
        }
    }
}
