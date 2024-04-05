using MySql.Data.MySqlClient;
using System.Data;

namespace CityLibraryInfoSystem
{
    internal class ActiveDatabase
    {
        public string Link { get; set; }
        public MySqlConnection ConnectionToDatabase { get; set; }

        public ActiveDatabase()
        {
            Link = "";
            ConnectionToDatabase = new MySqlConnection();
        }

        public ActiveDatabase(string link)
        {
            Link = link;
            ConnectionToDatabase = new MySqlConnection(link);
        }

        public List<string> GetTableNames()
        {
            List<string> tableNames = new List<string>();

            var command = "SHOW TABLES";

            MySqlDataReader mySqlDataReader = SendCommandToDatabase(command).ExecuteReader();

            while (mySqlDataReader.Read())
            {
                tableNames.Add(mySqlDataReader[0].ToString()!);
            }
            mySqlDataReader.Close();

            return tableNames;
        }

        public DataTable GetTable(string nameTable)
        {
            DataTable dataTable = new DataTable();

            var command = $"SELECT * FROM {nameTable}";

            MySqlDataAdapter adapter = new MySqlDataAdapter(SendCommandToDatabase(command));
            adapter.Fill(dataTable);

            return dataTable;
        }

        private MySqlCommand SendCommandToDatabase(string command)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(command, ConnectionToDatabase);

            return mySqlCommand;
        }

        public void Open()
        {
            ConnectionToDatabase.Open();
        }
    }
}
