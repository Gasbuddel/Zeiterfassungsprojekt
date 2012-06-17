using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Zeiterfassung.Classes
{
    class DataHauptmaske
    {
       private MySqlConnection con;
       private string user;
       private Dictionary<int, string> projects;

       DataHauptmaske(string userid)//der Konstruktor kriegt die miID vom angemeldeten Nutzer
       {

           user = userid;
           con = SqlConnection.GetConnection();//holen wir uns schonmal die DB-Verbindung
            
       }

       public void loadProjects(string user)
       {
          
           string sql = "SELECT prName, prID FROM tprojekt WHERE prID IN(SELECT prID FROM tmita_proj WHERE miID = " + user + ")";//sollte funzen oder?
           MySqlCommand cmd = con.CreateCommand();
           
           cmd.CommandText = sql;
           MySqlDataReader reader;
           con.Open();
           reader = cmd.ExecuteReader();
       
<<<<<<< HEAD
           for(int i =0;reader.Read();i++)
=======
          while(reader.Read())
>>>>>>> loadProjects fertig
           {
              projects.Add(reader.GetInt32(1), reader.GetString(0));
           }

<<<<<<< HEAD
           con.Close();
           return projects;
=======
          con.Close();    
       }

       public void loadBookings()
       {
           string sql = "Select";
           MySqlCommand cmd = con.CreateCommand();
           MySqlDataReader reader= new MySqlDataReader();
           con.Open();
           reader = cmd.ExecuteReader();

>>>>>>> loadProjects fertig
       }
    }
}
