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

       DataHauptmaske(string userid)//der Konstruktor kriegt die miID vom angemeldeten Nutzer
       {

           user = userid;
           con = SqlConnection.GetConnection();//holen wir uns schonmal die DB-Verbindung
            
       }

       public List<string> getProjects(string user)
       {
           List<string> projects = new List<string>();
           string sql = "SELECT prName FROM tprojekt WHERE prID IN(SELECT prID FROM tmita_proj WHERE miID = " + user + ")";//sollte funzen oder?
           MySqlCommand cmd = con.CreateCommand();
           cmd.CommandText = sql;
           MySqlDataReader reader;
           con.Open();
           reader = cmd.ExecuteReader();
       
          for(int i =0;reader.Read();i++)
           {
              projects.Add(reader.GetValue(i).ToString());
           }

               return projects;
       }
    }
}
