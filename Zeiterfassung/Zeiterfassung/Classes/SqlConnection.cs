using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Zeiterfassung
{
    public class SqlConnection
    {
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
