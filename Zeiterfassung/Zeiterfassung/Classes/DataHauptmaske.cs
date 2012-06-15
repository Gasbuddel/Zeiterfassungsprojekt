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
           string sql = "SELECT * FROM tprojekt WHERE prID IN(SELECT prID FROM tmita_proj WHERE miID = " + user + ")";//sollte funzen oder?
           MySqlCommand
               return projects;
       }
    }
}
