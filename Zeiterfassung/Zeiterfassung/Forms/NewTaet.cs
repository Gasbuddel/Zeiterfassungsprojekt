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
    public partial class NewTaet : Form
    {
        private int proID;

        public NewTaet(int proID)
        {
            InitializeComponent();

            this.proID = proID;
        }

        private void ok_Butt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection.ExecuteStatement("INSERT INTO ttaetigkeitenvorlage (taBeschreibung) " +
                    "VALUES ( '" + tätDesc_Box.Text + "')");
                //ID der eingefügten Tätigkeit festhalten
                DataTable lastId = SqlConnection.SelectStatement("SELECT LAST_INSERT_ID( )FROM ttaetigkeitenvorlage");

                //Projekt und Tätigkeit verknüpfen
                SqlConnection.ExecuteStatement("INSERT INTO tproj_taet (prID, taID) " +
                    "VALUES (" + proID + ", " + lastId.Rows[0][0].ToString() + ")");

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                "Fehlernummer: " + ex.Number + Environment.NewLine +
                "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_Butt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
