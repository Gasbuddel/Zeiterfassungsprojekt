using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zeiterfassung
{
    public partial class AddWorkerToProject : Form
    {

        private int prID { get; set; }
        private Administration admin { get; set; }
        
        public AddWorkerToProject(int proj_id_temp, Administration admin_temp)
        {
            InitializeComponent();

            this.prID = proj_id_temp;
            this.admin = admin_temp;

            DataTable AllWorkers = SqlConnection.SelectStatement("SELECT miName,miVorname FROM `tmitarbeiter`");

            DataTableReader AllWorkers_reader = AllWorkers.CreateDataReader();

            if (AllWorkers_reader.HasRows)
            {
                while (AllWorkers_reader.Read())
                {
                    checkedListBox1.Items.Add(AllWorkers_reader.GetString(0) + ", " + AllWorkers_reader.GetString(1));
                }
            }

        }

        private void Abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWorkers_Click(object sender, EventArgs e)
        {
           

                // Next show the object title and check state for each item selected.
                foreach(object itemChecked in checkedListBox1.CheckedItems) 
                {
                    string ArbeiterToAdd = itemChecked.ToString();
                    string[] split = ArbeiterToAdd.Split(",".ToCharArray());
                    string nachname = split[0];
                    String delim = " ";
                    string vorname = split[1].Trim(delim.ToCharArray());

                    try
                    {
                        DataTable AddWorkers = SqlConnection.SelectStatement("INSERT INTO `tmita_proj`(`miID`, `prID`, `mpAktiv`) VALUES ((SELECT miID FROM tmitarbeiter WHERE miName='" + nachname + "' AND miVorname='" + vorname + "' )," + prID + ",1)");
                    }
                    catch
                    { 
                        //mitarbeiter ist wahrscheinlich schon zugewiesen?? egal weiter gehts...
                        MessageBox.Show( vorname + " " + nachname + " ist diesem Projekt bereits zugewiesen.");
                    }
                        
                    
                }


                admin.selectBoxProjekt_SelectedIndexChanged();
                this.Close();



             
         

        }

       
    }
}
