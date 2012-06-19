using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Zeiterfassung
{
    public class SqlConnection
    {
        /// <summary>
        /// Funktion zum erhalten der Datenbakverbindung
        /// </summary>
        /// <returns>Die Datenbankverbindung</returns>
        public static MySqlConnection GetConnection()
        {
            string myConnectionString = "SERVER=localhost;" +
                                        "DATABASE=zeiterfassung;" +
                                        "UID=root;";

            MySqlConnection connection = new MySqlConnection(myConnectionString);
            return connection;
        }

        public static DataTable SelectStatement(string sql)
        {
            MySqlConnection con = SqlConnection.GetConnection();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader;

            con.Open();

            reader = cmd.ExecuteReader();

            DataTable result = new DataTable();

            result.Load(reader);

            con.Close();

            return result;
        }
    }
}
