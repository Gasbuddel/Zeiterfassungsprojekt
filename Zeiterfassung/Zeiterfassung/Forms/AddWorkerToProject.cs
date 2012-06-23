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
        private int prID;

        private Dictionary<int, int> mitarbeiterIds;

        public AddWorkerToProject(int proj_id_temp)
        {
            InitializeComponent();

            this.prID = proj_id_temp;

            mitarbeiterIds = new Dictionary<int, int>();

            DataTable AllWorkers = SqlConnection.SelectStatement("SELECT miID, miName, miVorname " +
            "FROM tmitarbeiter " +
            "WHERE miID NOT IN (" +
            "SELECT miID " + 
            "FROM tmita_proj " +
            "WHERE prID = " + prID +")");

            DataTableReader reader = AllWorkers.CreateDataReader();

            int index = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    arbeiterListe.Items.Add(reader.GetString(1) + ", " + reader.GetString(2));
                    mitarbeiterIds.Add(index,reader.GetInt32(0));
                    index++;
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
                foreach(object itemChecked in arbeiterListe.CheckedItems) 
                {
                    SqlConnection.ExecuteStatement("INSERT INTO tmita_proj(miID, prID, mpAktiv) " +
                        "VALUES (" + mitarbeiterIds[arbeiterListe.Items.IndexOf(itemChecked)] + ", " + prID + ",1)");
                  
                }
                this.DialogResult = DialogResult.OK;
                this.Close(); 
        }

       
    }
}
