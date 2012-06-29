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
			//Reader erstellen
			DataTableReader reader;

            mitarbeit_List.Enabled = true;
			//Summe aller Mitarbeiter herausfinden
			int summeMitarbeiter = SqlConnection.CountStatement("SELECT count(miID) FROM tmita_proj" +
				" WHERE prID= " + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID);

			//Mitarbeiter und deren geleistete Stunden aktualisieren
			if (summeMitarbeiter > 0)
			{
				this.textMA.Text = summeMitarbeiter.ToString();

				DataTable sum = SqlConnection.SelectStatement("SELECT SUM(zeDauer) as sum FROM tzeiterfassung WHERE prID=(SELECT prID from tprojekt where prName='" + selectBoxProjekt.Text + "')");
				reader = sum.CreateDataReader();

				if (reader.HasRows)
				{
					reader.Read();

					if (reader["sum"].ToString() == "")
						this.textgesZeit.Text = "0";
					else
						this.textgesZeit.Text = reader.GetDecimal(0).ToString();
				}				
			}
			else
				textMA.Text = "0";

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
				mitarbeit_List.SelectedIndex = 0;
			}
			else
			{
				mitarbeit_List.Enabled = false;
				visualisieren.Enabled = false;
			}
        }

        private void mitarbeit_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal arbeitszeitGesamt = 0;
            decimal arbeitszeitProjekt = 0;
			//Summe der geleisteten Stunden des ausgewählten Mitarbeiters herausfinden
            DataTable arbeiter = SqlConnection.SelectStatement("SELECT sum( zeDauer ) as sum FROM tzeiterfassung WHERE miID = "
				+ ((ListItem)mitarbeit_List.SelectedItem).DatabankID +""); 
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
						//GesammteArbeitszeit
						arbeitszeitGesamt = reader.GetDecimal(0);
                    }
                        
                }
            }

			//Summe der geleisteten Stunden im Projekt herausfinden
			arbeiter = SqlConnection.SelectStatement("SELECT sum( zeDauer ) as sum FROM tzeiterfassung WHERE miID =" +
				((ListItem)mitarbeit_List.SelectedItem).DatabankID +
				" AND prID=" + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID + "");
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
						//Arbeitszeit im Projekt
						arbeitszeitProjekt = reader.GetDecimal(0);
					}
				}
			}

			//Prozentualen Anteil am Projekt ermitteln
            decimal temp = 0;

            if (arbeitszeitProjekt != 0)
				temp = arbeitszeitProjekt * 100 / arbeitszeitGesamt;
			else
                visualisieren.Enabled = false;
            temp = Math.Round(temp, 2);
            prozent.Text = temp.ToString();

			//Button visualisieren freigeben
			visualisieren.Enabled = true;
            
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
