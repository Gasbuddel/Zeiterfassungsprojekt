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
    public partial class EditProject : Form
    {  
        private int prID { get; set; }
        private Administration admin { get; set; }
        public EditProject(int prID_temp, Administration admin_temp)
        {
            InitializeComponent();

            this.admin = admin_temp;
            this.prID = prID_temp;
            //projektbeschreibung anzeigen

            DataTable projektDesc = SqlConnection.SelectStatement("SELECT prBeschreibung FROM tprojekt WHERE prID = '" +prID + "'");

            DataTableReader projektDesc_reader = projektDesc.CreateDataReader();
           // beschr_Box.Text = "kaka";
            if (projektDesc_reader.HasRows)
            {
                while (projektDesc_reader.Read())
                {
                    
                    beschr_Box.Text = projektDesc_reader.GetString(0);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable projektDesc = SqlConnection.SelectStatement("UPDATE `tprojekt` SET `prBeschreibung`='"+beschr_Box.Text+"' WHERE `prID` =" + prID + "");
                admin.selectBoxProjekt_SelectedIndexChanged();
                //beschr_Box.Text = "UPDATE `tprojekt` SET `prBeschreibung`='" + beschr_Box.Text + "' WHERE `prID` =" + prID + "";
                MessageBox.Show("Änderung gespeichert");
            }
            catch
            {
                MessageBox.Show("Die Änderung konnte nicht übernommen werden");
            }
         }

        //private void delete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataTable projektDesc = SqlConnection.SelectStatement("DELETE FROM `tprojekt` WHERE `prID`="+prID+"");
        //        admin.selectBoxProjekt_SelectedIndexChanged();
        //        MessageBox.Show("Das Projekt wurde gelöscht.");
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Das Projekt konnte nicht gelöscht werden.");
        //    }
        //}

     
           
        
    }
}
