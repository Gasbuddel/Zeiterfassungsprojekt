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

		/// <summary>
		/// Führt Select-Abfragen aus und gibt diese als DataTable Objekt zurück
		/// </summary>
		/// <param name="sql">Select-Abfrage</param>
		/// <returns>Datatable mit den Ergebnissen</returns>
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

		/// <summary>
		/// Führt alle SQL-Aufträge ohne Rückgabe aus
		/// </summary>
		/// <param name="sql">SQL-Auftrag</param>
        public static int ExecuteStatement(string sql)
        {
            MySqlConnection con = SqlConnection.GetConnection();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;

            con.Open();

            int result = cmd.ExecuteNonQuery();

            con.Close();

            return result;
        }
    }
}
