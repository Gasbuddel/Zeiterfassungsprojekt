using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zeiterfassung
{
    public partial class ProjektePanel : UserControl
    {
        public ProjektePanel()
        {
            InitializeComponent();
        }

        #region 'Projektadministration'

        //Beim aktivieren des Panels
        private void ProjektePanel_Enter(object sender, EventArgs e)
        {
            projekteInitialisieren();
        }

        //Aktualisiert die Liste aller möglichen Projekte
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

        //Bei Auswahl eine Projektes
        private void selectBoxProjekt_SelectedIndexChanged(object sender, EventArgs e)
        {
            projekteAktualisieren();
        }


        //Aktualisiert die Informationen über das ausgewählte Projekt
        private void projekteAktualisieren()
        {

            //Nur einen allgemeinen Reader erstellen
            DataTableReader reader;

            //Kunde abfragen
            DataTable kunde = SqlConnection.SelectStatement("SELECT kuFirma FROM tkunde WHERE kuID = (SELECT kuID From tprojekt WHERE prId='" + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID + "') ");

            if (kunde.Rows.Count > 0)
                kund_Box.Text = kunde.Rows[0]["kuFirma"].ToString();

            //projektbeschreibung anzeigen
            DataTable projektDesc = SqlConnection.SelectStatement("SELECT prBeschreibung FROM tprojekt WHERE prId = '" + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID + "'");

            if (projektDesc.Rows.Count > 0)
                beschr_Box.Text = projektDesc.Rows[0]["prBeschreibung"].ToString();

            //aktuell zuständige mitarbeiter anzeigen
            DataTable arbeiter = SqlConnection.SelectStatement("SELECT m.miID, m.miName, m.miVorname " +
                "FROM tmitarbeiter m " +
                "WHERE m.miID IN (" +
                "SELECT t.miID " +
                "FROM tmita_proj t " +
                "WHERE t.prID = " + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID + ")");

            reader = arbeiter.CreateDataReader();

            mitarbeit_List.Items.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mitarbeit_List.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1) + ", " + reader.GetString(2)));
                }
            }

            //tätigkeitsbeschr anzeigen
            DataTable taetDesc = SqlConnection.SelectStatement("SELECT taId, taBeschreibung " +
                "FROM ttaetigkeitenvorlage " +
                "WHERE taID IN (" +
                "SELECT taID " +
                "FROM tproj_taet " +
                "WHERE prID = " + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID + ")");

            reader = taetDesc.CreateDataReader();

            if (reader.HasRows)
            {
                taet_List.Items.Clear();
                while (reader.Read())
                {
                    taet_List.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1)));
                }
            }
        }

        //Arbeiter aus dem Projekt löschen
        private void deleteArbeiter_Click(object sender, EventArgs e)
        {
            if (mitarbeit_List.SelectedIndex != -1)
            {
                SqlConnection.ExecuteStatement("DELETE FROM tmita_proj WHERE miID = " + ((ListItem)mitarbeit_List.SelectedItem).DatabankID);
                projekteAktualisieren();
            }
        }

        //Arbeiter dem Projekt hinzufügen
        private void addWorkerToProject_butt_Click(object sender, EventArgs e)
        {
            AddWorkerToProject neueMitarbeiter = new AddWorkerToProject(((ListItem)selectBoxProjekt.SelectedItem).DatabankID);

            neueMitarbeiter.StartPosition = FormStartPosition.CenterParent;

            if (neueMitarbeiter.ShowDialog() == DialogResult.OK)
                projekteAktualisieren();
        }

        //neues projekt anlegen
        private void newPro_Butt_Click(object sender, EventArgs e)
        {
            CreateProject newPro = new CreateProject();
            newPro.StartPosition = FormStartPosition.CenterParent;

            if (newPro.ShowDialog() == DialogResult.OK)
                projekteInitialisieren();

            newPro.Dispose();
        }

        private bool isBearb = false;

        //projekt bearbeiten
        private void pro_Bearb_Butt_Click(object sender, EventArgs e)
        {
            if (!isBearb)
            {
                beschr_Box.ReadOnly = false;
                pro_Bearb_Butt.Text = "Annehmen";
                pro_Bearb_Abbr_Butt.Visible = true;
                isBearb = true;
            }
            else
            {
                try
                {
                    SqlConnection.ExecuteStatement("UPDATE tProjekt " +
                        "SET prBeschreibung = '" + beschr_Box.Text + "' " +
                        "WHERE prID = " + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID);
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Es scheint ein Problem mit der Datenbank vorzuliegen");
                }

                beschr_Box.ReadOnly = true;
                pro_Bearb_Butt.Text = "Bearbeiten";
                pro_Bearb_Abbr_Butt.Visible = false;
                isBearb = false;
            }
        }

        //Bearbeiten abbrechen
        private void pro_Bearb_Abbr_Butt_Click(object sender, EventArgs e)
        {
            beschr_Box.ReadOnly = true;
            pro_Bearb_Butt.Text = "Bearbeiten";
            pro_Bearb_Abbr_Butt.Visible = false;
            isBearb = false;

            projekteAktualisieren();
        }


        //tätigkeit hinzufügen
        private void pro_Add_Tät_Butt_Click(object sender, EventArgs e)
        {
            AddTaetigkeit neueTätigkeiten = new AddTaetigkeit(((ListItem)selectBoxProjekt.SelectedItem).DatabankID);

            neueTätigkeiten.StartPosition = FormStartPosition.CenterParent;

            if (neueTätigkeiten.ShowDialog() == DialogResult.OK)
                projekteAktualisieren();

            neueTätigkeiten.Dispose();
        }

        //Neue Tätigkeit erstellen
        private void pro_New_Tät_Butt_Click(object sender, EventArgs e)
        {
            NewTaet neueTätigkeit = new NewTaet(((ListItem)selectBoxProjekt.SelectedItem).DatabankID);

            neueTätigkeit.StartPosition = FormStartPosition.CenterParent;

            if (neueTätigkeit.ShowDialog() == DialogResult.OK)
                projekteAktualisieren();

            neueTätigkeit.Dispose();
        }

        //tätigkeit entfernen
        private void pro_Tät_Entf_Butt_Click(object sender, EventArgs e)
        {
            if (taet_List.SelectedIndex != -1)
            {
                DataTable prID = SqlConnection.SelectStatement("DELETE FROM tproj_taet " +
                    "WHERE prID= " + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID +
                    " AND taID= " + ((ListItem)taet_List.SelectedItem).DatabankID);
                projekteAktualisieren();
            }
        }

        #endregion







  








    }
}
