using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Zeiterfassung
{
	public partial class AddTaetigkeit : Form
	{

		int prID;

		public AddTaetigkeit(int prID_temp)
		{
			InitializeComponent();

			this.prID = prID_temp;

            try
            {

                DataTable AllTaetig = SqlConnection.SelectStatement("SELECT taID, taBeschreibung " +
                "FROM ttaetigkeitenvorlage " +
                "WHERE taID NOT IN (" +
                "SELECT taID " +
                "FROM tproj_taet " +
                "WHERE prID = " + prID + ")");

                DataTableReader reader = AllTaetig.CreateDataReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tätigkeitListe.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                "Fehlernummer: " + ex.Number + Environment.NewLine +
                "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

		private void ok_Click(object sender, EventArgs e)
		{
            try
            {
                foreach (object itemChecked in tätigkeitListe.CheckedItems)
                {
                    SqlConnection.ExecuteStatement("INSERT INTO `tproj_taet`(`prID`, `taID`) " +
                        "VALUES (" + prID + ", " + ((ListItem)itemChecked).DatabankID + ")");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                "Fehlernummer: " + ex.Number + Environment.NewLine +
                "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

		private void abort_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
