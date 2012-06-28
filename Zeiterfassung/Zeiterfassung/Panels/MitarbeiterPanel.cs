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
    public partial class MitarbeiterPanel : UserControl
    {
        public MitarbeiterPanel()
        {
            InitializeComponent();
        }

        private const string startpw = "#start12";


        #region 'Mitarbeiter'

        //Bearbeitungsstatus, 0 = Keine Bearbeitung, 1 = Bearbeiten, 2 = Neuer Mitarbeiter
        private int mitarbeiterBearbStatus = 0;

        private void MitarbeiterPanel_Enter(object sender, EventArgs e)
        {
            mitarbeiterInitialisieren();
        }

        /// <summary>
        /// Initialisiert alle Mitarbeiter und holt alle verfügbaren Mitarbeiter und Rollen in die Liste.
        /// </summary>
        private void mitarbeiterInitialisieren()
        {
            try
            {
                //Mitarbeiterliste säubern
                userNameBox.Items.Clear();

                string test = "SELECT miID ,miUsername, roBezeichnung FROM tMitarbeiter WHERE miID != " + Session.GetSession().UserId + " JOIN trolle USING(roID)";

                DataTable allema = SqlConnection.SelectStatement("SELECT miID ,miUsername, roBezeichnung FROM tMitarbeiter JOIN trolle USING(roID) WHERE miID != " + Session.GetSession().UserId);

                DataTableReader reader = allema.CreateDataReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userNameBox.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1) + ", " + reader.GetString(2)));
                    }
                }

                //Rollen säubern
                roleBox.Items.Clear();

                //Mitarbeiter einfügen
                DataTable alleRollen = SqlConnection.SelectStatement("SELECT roID ,roBezeichnung FROM tRolle");

                reader = alleRollen.CreateDataReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        roleBox.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1)));
                    }
                }

                roleBox.SelectedIndex = 0;

                userNameBox.SelectedIndex = 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                "Fehlernummer: " + ex.Number + Environment.NewLine +
                "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userNameBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mitarbeiterAktualisieren();
        }

        /// <summary>
        /// Aktualisiert die Mitarbeiterdaten des ausgewählten Mitarbeiters.
        /// </summary>
        private void mitarbeiterAktualisieren()
        {
            try
            {
                DataTable maTable = SqlConnection.SelectStatement("SELECT miUsername, miName, miVorname, miEmail, roID FROM tmitarbeiter WHERE miID = " + ((ListItem)userNameBox.SelectedItem).DatabankID);

                DataTableReader reader = maTable.CreateDataReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userNameTB.Text = reader.GetString(0);
                        nameTB.Text = reader.GetString(1);
                        vornameTB.Text = reader.GetString(2);
                        mailTB.Text = reader.GetString(3);

                        //Rolle festlegen
                        if (Convert.ToInt32(maTable.Rows[0]["roID"]) == 1)
                            roleBox.SelectedIndex = 0;
                        else
                            roleBox.SelectedIndex = 1;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                "Fehlernummer: " + ex.Number + Environment.NewLine +
                "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Textboxes aktivieren/deaktivieren
        private void setMitarbeiterReadOnly(bool readOnly)
        {
            userNameBox.Enabled = readOnly;

            nameTB.ReadOnly = readOnly;
            vornameTB.ReadOnly = readOnly;
            mailTB.ReadOnly = readOnly;
            userNameTB.ReadOnly = readOnly;

            roleBox.Enabled = !readOnly;
        }


        //Benutzer barbeiten
        private void mi_Change_Butt_Click(object sender, EventArgs e)
        {
            //Keine Änderung aktiv
            if (mitarbeiterBearbStatus == 0)
            {
                mi_Cancel_Butt.Visible = true;
                mi_Change_Butt.Text = "Speichern";
                setMitarbeiterReadOnly(false);

                mi_New_Butt.Enabled = false;
                mi_PW_Butt.Enabled = false;
                mi_Del_Butt.Enabled = false;

                mitarbeiterBearbStatus = 1;
            }
            //Im Bearbeitungsstatus
            else if (mitarbeiterBearbStatus == 1)
            {
                if (mitarbeiterValid() && userNameTB.Text != "" && nameTB.Text != "" && vornameTB.Text != "" && mailTB.Text != "")
                {
                    try
                    {
                        mi_Change_Butt.Text = "Bearbeiten";
                        setMitarbeiterReadOnly(true);
                        SqlConnection.ExecuteStatement("UPDATE tmitarbeiter SET " +
                            "miUsername = '" + userNameTB.Text +
                            "', miVorname = '" + vornameTB.Text +
                            "', miName = '" + nameTB.Text +
                            "', miEmail = '" + mailTB.Text +
                            "', roID= '" + ((ListItem)roleBox.SelectedItem).DatabankID +
                            "'   where miID='" + ((ListItem)userNameBox.SelectedItem).DatabankID + "'");

                        mi_Cancel_Butt.Visible = false;

                        mi_PW_Butt.Enabled = true;
                        mi_Del_Butt.Enabled = true;
                        mi_New_Butt.Enabled = true;

                        mitarbeiterBearbStatus = 0;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                        "Fehlernummer: " + ex.Number + Environment.NewLine +
                        "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ihre Eingaben entsprechen nicht den vorgegebenen Formaten.");
                }
            }
        }

        //Passwort zurücksetzen
        private void mi_PW_Butt_Click(object sender, EventArgs e)
        {
            try
            {
                //Standartpasswort wird gesetzt
                SqlConnection.ExecuteStatement("UPDATE tmitarbeiter SET miPasswort = '" + Md5.GetMD5("#10!?" + userNameTB.Text.ToLower() + startpw + "~^g2+3") +
                    "' WHERE miID = '" + ((ListItem)userNameBox.SelectedItem).DatabankID + "'");
                MessageBox.Show("Das Passwort wurde auf " + startpw + " gesetzt");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                "Fehlernummer: " + ex.Number + Environment.NewLine +
                "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Mitarbeiter löschen
        private void mi_Del_Butt_Click(object sender, EventArgs e)
        {
            if (((ListItem)roleBox.SelectedItem).DatabankID == 2)
            {
                try
                {
                    //Überprüfung, ob dem Mitarbeiter Projekte zugewiesen wurden
                    int result = SqlConnection.CountStatement("SELECT COUNT(miID) FROM tmita_proj WHERE miID = " +
                        ((ListItem)userNameBox.SelectedItem).DatabankID);

                    if (result <= 0)
                    {
                        //Mitarbeiter ist keine Projekt zugewiesen, daher nur Hinweis
                        if (MessageBox.Show("Mitarbeiter wirklich löschen?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlConnection.ExecuteStatement("DELETE FROM tmitarbeiter WHERE miID = '" + ((ListItem)userNameBox.SelectedItem).DatabankID + "'");
                            mitarbeiterInitialisieren();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Dieser Mitarbeiter ist in " + result + " Projekten aktiv. " + Environment.NewLine +
                            "Trotzdem löschen?", "Warnung", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            SqlConnection.ExecuteStatement("DELETE FROM tZeiterfassung WHERE miID = '" + ((ListItem)userNameBox.SelectedItem).DatabankID + "'");
                            SqlConnection.ExecuteStatement("DELETE FROM tmita_proj WHERE miID = '" + ((ListItem)userNameBox.SelectedItem).DatabankID + "'");
                            SqlConnection.ExecuteStatement("DELETE FROM tmitarbeiter WHERE miID = '" + ((ListItem)userNameBox.SelectedItem).DatabankID + "'");

                            mitarbeiterInitialisieren();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                    "Fehlernummer: " + ex.Number + Environment.NewLine +
                    "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Geschäftsführer dürfen nicht entfernt werden
            else
            {
                MessageBox.Show("Sie können keine Geschäftsführer löschen","Hinweis",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        //Neuen Mitarbeiter anlegen
        private void mit_New_Butt_Click(object sender, EventArgs e)
        {
            //Keine Bearbeitung aktiv
            if (mitarbeiterBearbStatus == 0)
            {
                mi_New_Butt.Text = "Anlegen";
                mi_Cancel_Butt.Visible = true;
                mi_Del_Butt.Enabled = false;
                mi_PW_Butt.Enabled = false;
                mi_Change_Butt.Enabled = false;
                roleBox.SelectedIndex = 1;

                //Textboxen enablen
                setMitarbeiterReadOnly(false);

                //Textboxen leeren
                userNameTB.Text = "";
                nameTB.Text = "";
                vornameTB.Text = "";
                mailTB.Text = "";

                mitarbeiterBearbStatus = 2;
            }
            //Neuer Mitarbeiter
            else if (mitarbeiterBearbStatus == 2)
            {
                if (mitarbeiterValid() && userNameTB.Text != "" && nameTB.Text != "" && vornameTB.Text != "" && mailTB.Text != "")
                {
                    string pwCoded = Md5.GetMD5("#10!?" + userNameTB.Text.ToLower() + startpw + "~^g2+3");

                    //Überprüfen, ob Benutzername bereits benutzt wird
                    if(SqlConnection.CountStatement("SELECT COUNT(miUsername) FROM tMitarbeiter WHERE miUsername LIKE '" + userNameTB.Text + "'") < 1)
                    {
                        try
                        {
                            //Benutzer abspeichern
                            SqlConnection.ExecuteStatement("INSERT INTO tmitarbeiter " +
                                "(`roID`, `miName`, `miVorname`, `miUsername`, `miPasswort`, `miEMail`) " +
                                "VALUES ('" + ((ListItem)roleBox.SelectedItem).DatabankID + "','"
                                + vornameTB.Text + "','" + nameTB.Text + "','"
                                + userNameTB.Text + "','" + pwCoded + "','"
                                + mailTB.Text + "')");

                            MessageBox.Show("Neuer User wurde angelegt. Passwort ist: " + startpw);
                            //Buttons enablen
                            mi_New_Butt.Text = "Neuer Mitarbeiter";
                            mi_Del_Butt.Enabled = true;
                            mi_PW_Butt.Enabled = true;
                            mi_Change_Butt.Enabled = true;

                            mi_Cancel_Butt.Visible = false;

                            setMitarbeiterReadOnly(true);

                            mitarbeiterInitialisieren();

                            mitarbeiterBearbStatus = 0;
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                            "Fehlernummer: " + ex.Number + Environment.NewLine +
                            "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("Dieser Benutzername wird bereits verwendet.","Hinweis",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Es wurden nicht alle Felder korrekt ausgefüllt.");
                }
            }
        }

        //Anlegen wird abgebrochen
        private void mi_Cancel_Butt_Click(object sender, EventArgs e)
        {
            userNameBox.Enabled = true;

            //Buttons zurücksetzen
            mi_New_Butt.Text = "Neuer Mitarbeiter";
            mi_Change_Butt.Text = "Bearbeiten";
            mi_Del_Butt.Enabled = true;
            mi_PW_Butt.Enabled = true;
            mi_Change_Butt.Enabled = true;
            mi_New_Butt.Enabled = true;

            setMitarbeiterReadOnly(true);

            mi_Cancel_Butt.Visible = false;

            mitarbeiterBearbStatus = 0;

            mitarbeiterAktualisieren();
        }

        private bool mitarbeiterValid()
        {
            bool valid = true;
			if (!userNameTB.IsValid) { valid = false; }
			if (!nameTB.IsValid) { valid = false; }
			if (!vornameTB.IsValid) { valid = false; }
			if (!mailTB.IsValid) { valid = false; }

            return valid;
        }

        #endregion

    }
}
