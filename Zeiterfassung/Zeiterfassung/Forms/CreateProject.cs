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
    public partial class CreateProject : Form
    {
        private Dictionary<int, int> kundenIds;

        public CreateProject()
        {
            InitializeComponent();

            kundenIds = new Dictionary<int, int>();

            DataTable kunde = SqlConnection.SelectStatement("SELECT kuId ,kuFirma FROM tkunde");

            DataTableReader reader = kunde.CreateDataReader();

            int index = 0;
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    kunde_box.Items.Add(reader.GetString(1));
                    kundenIds.Add(index, reader.GetInt32(0));

                    index++;
                }
            }

            kunde_box.SelectedIndex = 0;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable arbeiter = SqlConnection.SelectStatement("INSERT INTO tprojekt( kuID, prName, prBeschreibung) " +
                "VALUES ( " + kundenIds[kunde_box.SelectedIndex] + ", '" + nameBox.Text + "','" + descBox.Text + "')");

                MessageBox.Show("Das Projekt" + " '" + nameBox.Text + "' wurde angelegt");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten.\nBitte überprüfen Sie ihre Eingaben.");
            } 
        }

    

    }
}