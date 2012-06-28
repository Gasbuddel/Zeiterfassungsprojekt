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
    public partial class CreateProject : Form
    {
        public CreateProject()
        {
            InitializeComponent();

            try
            {

                DataTable kunde = SqlConnection.SelectStatement("SELECT kuId ,kuFirma, kuAnsprechpartner FROM tkunde");

                DataTableReader reader = kunde.CreateDataReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["kuFirma"].ToString() == "")
                            kunde_box.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(2)));
                        else
                            kunde_box.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1)));
                    }
                }

                kunde_box.SelectedIndex = 0;
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
                DataTable arbeiter = SqlConnection.SelectStatement("INSERT INTO tprojekt( kuID, prName, prBeschreibung) " +
                "VALUES ( " + ((ListItem)kunde_box.SelectedItem).DatabankID + ", '" + nameBox.Text + "','" + descBox.Text + "')");

                MessageBox.Show("Das Projekt" + " '" + nameBox.Text + "' wurde angelegt");

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