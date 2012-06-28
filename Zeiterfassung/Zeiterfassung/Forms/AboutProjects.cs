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
    public partial class AboutProjects : Form
    {
        public AboutProjects()
        {
            InitializeComponent();
            projekteInitialisieren();
        }

        private void projekteInitialisieren()
        {
            selectBoxProjekt.Items.Clear();

            DataTable projekte = SqlConnection.SelectStatement("SELECT prId ,prName FROM tprojekt");

            DataTableReader reader = projekte.CreateDataReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    selectBoxProjekt.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1)));
                }
            }

            selectBoxProjekt.SelectedIndex = 0;
        }

        private void selectBoxProjekt_SelectedIndexChanged(object sender, EventArgs e)
        {
            mitarbeit_List.Enabled = true;
            DataTable projekteinfos = SqlConnection.SelectStatement("SELECT count(miID) FROM tmita_proj WHERE prID=(SELECT prID from tprojekt where prName='" + selectBoxProjekt.Text +"')");

            DataTableReader reader = projekteinfos.CreateDataReader();

            if (reader.HasRows)
            {
                reader.Read();
                    if (reader.GetInt64(0).ToString()==null)
                    {
                        this.textMA.Text = "0";
                    }
                    else
                    {
                        this.textMA.Text = reader.GetInt64(0).ToString();
                        //SELECT SUM(zeDauer) FROm tzeiterfassung where prID=1
                        DataTable sum = SqlConnection.SelectStatement("SELECT SUM(zeDauer) as sum FROM tzeiterfassung WHERE prID=(SELECT prID from tprojekt where prName='" + selectBoxProjekt.Text + "')");
                        DataTableReader sumreader = sum.CreateDataReader();
                        
                        if (sumreader.HasRows)
                        {
                            sumreader.Read();
                            Type test = sumreader.GetFieldType(0);
                            if (sumreader["sum"].ToString() == "")
                                this.textgesZeit.Text = "0";
                            else
                                this.textgesZeit.Text = sumreader.GetDecimal(0).ToString();
                        }
                    }
                
            }

            DataTable arbeiter = SqlConnection.SelectStatement("SELECT m.miID, m.miName, m.miVorname " +
              "FROM tmitarbeiter m " +
              "WHERE m.miID IN (" +
              "SELECT t.miID " +
              "FROM tmita_proj t " +
              "WHERE t.prID = " + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID +
              " AND mpAktiv = 1) ORDER BY miName");

            reader = arbeiter.CreateDataReader();

            mitarbeit_List.Items.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mitarbeit_List.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1) + ", " + reader.GetString(2)));
                }
            }
            if (mitarbeit_List.Items.Count == 0)
                mitarbeit_List.Enabled = false;
            else
                mitarbeit_List.SelectedIndex = 0;
        }

        private void mitarbeit_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal ges = 0;
            decimal pro = 0;
            DataTable arbeiter = SqlConnection.SelectStatement("SELECT sum( zeDauer ) as sum FROM tzeiterfassung WHERE miID ="+ ((ListItem)mitarbeit_List.SelectedItem).DatabankID +""); 
            DataTableReader reader = arbeiter.CreateDataReader();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader["sum"].ToString() == "")
                    {
                        gesZeit.Text = "0,00";
                    }
                    else
                    {
                        gesZeit.Text = reader["sum"].ToString();
                        ges = reader.GetDecimal(0);
                    }
                        
                }
            }
           arbeiter = SqlConnection.SelectStatement("SELECT sum( zeDauer ) as sum FROM tzeiterfassung WHERE miID =" + ((ListItem)mitarbeit_List.SelectedItem).DatabankID + " AND prID="+ ((ListItem)selectBoxProjekt.SelectedItem).DatabankID + "");
           reader = arbeiter.CreateDataReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader["sum"].ToString() == "")
                    {
                        imProjekt.Text = "0,00";
                    }
                    else
                    {
                        imProjekt.Text = reader["sum"].ToString();
                        pro = reader.GetDecimal(0);
                    }
                }
            }
             decimal temp = 0;
             visualisieren.Enabled = true;
            if (pro != 0)
                temp=pro * 100 / ges;

            if (ges == 0)
                visualisieren.Enabled = false;
            temp = Math.Round(temp, 2);
            prozent.Text = temp.ToString();
            
        }

        private void visualisieren_Click(object sender, EventArgs e)
        {
            MitPie cocoPie = new MitPie(((ListItem)mitarbeit_List.SelectedItem).DatabankID,((ListItem)selectBoxProjekt.SelectedItem).DatabankID);
            cocoPie.StartPosition = FormStartPosition.CenterParent;
            cocoPie.ShowDialog();
        }

        private void abbr_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
