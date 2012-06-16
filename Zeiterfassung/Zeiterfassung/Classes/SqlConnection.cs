using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
