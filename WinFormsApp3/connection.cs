using System;
using System.Data;
using System.Data.SQLite;

namespace WinFormsApp3
{
    public class Connection
    {
        private SQLiteConnection sqliteConnection;

        public Connection()
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            /* SQLiteConnection.CreateFile("mydatabase.db"); */
            sqliteConnection = new SQLiteConnection(connectionString);
            sqliteConnection.Open();
            /* CreateTable(); */
            Console.WriteLine("Database connection successful.");
        }



        public void InsertData(string date, string time, string action)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sqliteConnection))
            {
                cmd.CommandText = "INSERT INTO elevator (date, time, action) VALUES (@date, @time, @action)";
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@action", action);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Successfully inserted data");
            }

            GetDataFromDatabase();
        }




        public DataTable GetDataFromDatabase()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM elevator", sqliteConnection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }







        public void CloseConnection()
        {
            if (sqliteConnection != null)
            {
                sqliteConnection.Close();
                sqliteConnection.Dispose();
            }
        }
    }
}
