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
        private Administration admin { get; set; }
        public CreateProject(Administration admin_temp)
        {
            InitializeComponent();

            this.admin = admin_temp;
            DataTable kunde = SqlConnection.SelectStatement("SELECT kuFirma FROM tkunde");

            DataTableReader kunde_reader = kunde.CreateDataReader();

            
            if (kunde_reader.HasRows)
            {
                while (kunde_reader.Read())
                {
                    kunde_box.Items.Add(kunde_reader.GetString(0));
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable arbeiter = SqlConnection.SelectStatement("INSERT INTO `tprojekt`( `kuID`, `prName`, `prBeschreibung`) VALUES ((Select kuID FROM tkunde WHERE kuFirma='" + kunde_box.Text + "'),'" + textBox1.Text + "','" + textBox2.Text + "')");
                MessageBox.Show("Das Projekt" + " '" + textBox1.Text + "' wurde angelegt");
                admin.selectBoxProjekt_SelectedIndexChanged();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten.\nBitte überprüfen Sie ihre Eingaben.");
            } 
        }

    

    }
}