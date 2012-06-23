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
        
        Administration admin {get; set;}
        int prID {get; set;}
        
        public AddTaetigkeit(Administration admin_test, int prID_temp)
        {
            InitializeComponent();

            this.admin= admin_test;
            this.prID= prID_temp;

            DataTable AllTaetig = SqlConnection.SelectStatement("SELECT taBeschreibung FROM `ttaetigkeitenvorlage`");

            DataTableReader AllTaetig_reader = AllTaetig.CreateDataReader();

            if (AllTaetig_reader.HasRows)
            {
                while (AllTaetig_reader.Read())
                {
                    checkedListBox1.Items.Add(AllTaetig_reader.GetString(0));
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
     
                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {
                    try
                    {
                        DataTable AddTaetig = SqlConnection.SelectStatement("INSERT INTO `tproj_taet`(`prID`, `taID`) VALUES (" + prID + ",(SELECT taID FROM ttaetigkeitenvorlage WHERE taBeschreibung='" + itemChecked.ToString() + "'))");
                        //MessageBox.Show("INSERT INTO `tproj_taet`(`prID`, `taID`) VALUES (" + prID + ",'" + itemChecked.ToString() + "'");
                        admin.selectBoxProjekt_SelectedIndexChanged();
                    }
                    catch
                    {
                        MessageBox.Show("'" + itemChecked.ToString() + "' existiert bereits");
                    }
                }
                MessageBox.Show("Tätigkeiten hinzugefügt");

           
        }
    }
}
