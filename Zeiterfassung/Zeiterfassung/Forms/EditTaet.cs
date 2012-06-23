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
    public partial class EditTaet : Form
    {
       private Administration admin {get; set;}
       private int taID {get; set;}
       private string prName { get; set; }

        public EditTaet(Administration admin_temp, int taID_temp, string prName_temp)
        {
            InitializeComponent();

            this.admin = admin_temp;
            this.taID = taID_temp;
            this.prName = prName_temp;
            //projektbeschreibung anzeigen

            DataTable teattDesc = SqlConnection.SelectStatement("SELECT taBeschreibung FROM ttaetigkeitenvorlage WHERE taID = '" + taID + "'");

            DataTableReader teattDesc_reader = teattDesc.CreateDataReader();
            // beschr_Box.Text = "kaka";
            if (teattDesc_reader.HasRows)
            {
                while (teattDesc_reader.Read())
                {

                    beschr_Box.Text = teattDesc_reader.GetString(0);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable insert_taet = SqlConnection.SelectStatement("INSERT INTO `ttaetigkeitenvorlage`(`taBeschreibung`) VALUES ('" + beschr_Box.Text + "')");
                DataTable inser_taet_pr = SqlConnection.SelectStatement("INSERT INTO `tproj_taet`(`prID`, `taID`) VALUES ((SELECT prID FROM tprojekt WHERE prName='" + prName + "'),(SELECT taID FROM ttaetigkeitenvorlage WHERE taBeschreibung='" + beschr_Box.Text + "'))");
                admin.selectBoxProjekt_SelectedIndexChanged();
                MessageBox.Show("Tätigkeit wurde hinzugefügt");
            }
            catch
            {
                MessageBox.Show("Tätigkeit konnte nich hinzugefügt werden");
            }
        }
    }
}
