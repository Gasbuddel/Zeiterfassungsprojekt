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
    public partial class AddTaetigkeit : Form
    {
        private Dictionary<int, int> tätikeitIds;

        int prID;
        
        public AddTaetigkeit(int prID_temp)
        {
            InitializeComponent();

            this.prID= prID_temp;

            tätikeitIds = new Dictionary<int, int>();

            DataTable AllTaetig = SqlConnection.SelectStatement("SELECT taID, taBeschreibung " +
            "FROM ttaetigkeitenvorlage " +
            "WHERE taID NOT IN (" +
            "SELECT taID " +
            "FROM tproj_taet " +
            "WHERE prID = " + prID + ")");

            DataTableReader reader = AllTaetig.CreateDataReader();

            int index = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tätigkeitListe.Items.Add(reader.GetString(1));
                    tätikeitIds.Add(index,reader.GetInt32(0));
                    index ++;
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
     
            foreach (object itemChecked in tätigkeitListe.CheckedItems)
            {
                SqlConnection.ExecuteStatement("INSERT INTO `tproj_taet`(`prID`, `taID`) " +
                    "VALUES (" + prID + ", " + tätikeitIds[tätigkeitListe.Items.IndexOf(itemChecked)] + ")");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();                    
        }

        private void abort_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }


    }
}
