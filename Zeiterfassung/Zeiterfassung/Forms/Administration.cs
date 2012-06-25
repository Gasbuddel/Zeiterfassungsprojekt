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
    public partial class Administration : Form
    {
        //Delegate, um das aktuell augewählte Projekt zu aktualisieren
        public delegate void delAktualisiereProjekt(int projektId);

        public delAktualisiereProjekt ProjektAusgewählt;

        public Administration()
        {
            InitializeComponent();
        }

        private void close_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TabSelect(int tab)
        {
            if (tab >= 0 && tab <= 2)
                project_Tab.SelectedIndex = tab;
        }

        #region 'Kundenadministration'

		//Variable zum merken, welcher Vorgang gerade bearbeitet wird, 0 = Keiner, 1 = Bearbeiten, 2 = Neuer Kunde
		private int bearbeitungsStatus = 0;


        //KundenTab wird angezeigt
        private void kunden_Tab_Enter(object sender, EventArgs e)
        {
            kundenInitialisieren();
        }

        /// <summary>
        /// Methode zum Initialiseren der Kundenliste, die Namen werden in der Combobox gespeichert und die Ids in einem Dictionary hinterlegt.
        /// </summary>
        private void kundenInitialisieren()
        {
            //Saubermachen, sonst wirds schmutzig!
            kunden_box.Items.Clear();

            DataTable kunden = SqlConnection.SelectStatement("SELECT  kuId, kuFirma, kuAnsprechpartner FROM tKunde");

            DataTableReader reader = kunden.CreateDataReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(1) != "")
                        kunden_box.Items.Add(new ListItem(reader.GetInt32(0),reader.GetString(1)));
                    else
                        kunden_box.Items.Add(new ListItem(reader.GetInt32(0),reader.GetString(2)));
                }
                kunden_box.SelectedIndex = 0;
            }
        }

        //Kunde wurde in der Combobox ausgewählt
		private void kunden_box_SelectedIndexChanged(object sender, EventArgs e)
		{
			kundenAktualisieren();
		}

        private void kundenAktualisieren()
        {
            DataTable kunden = SqlConnection.SelectStatement("SELECT  * FROM tKunde WHERE kuID =" + ((ListItem)kunden_box.SelectedItem).DatabankID);

            DataTableReader reader = kunden.CreateDataReader();

            reader.Read();

            ku_firma_box.Text = reader.GetString(1);
            ku_anspr_box.Text = reader.GetString(7);
            ku_mail_box.Text = reader.GetString(8);
            ku_str_box.Text = reader.GetString(2);
            ku_plz_box.Text = reader.GetString(3);
            ku_ort_box.Text = reader.GetString(4);
            ku_tel_box.Text = reader.GetString(5);
            ku_fax_box.Text = reader.GetString(6);

            setKundenTextboxReadonly(true);
        }

        /// <summary>
        /// Setzt alle Textboxes auf dem Tab Kunde in Readonly.. oder nicht
        /// </summary>
        /// <param name="value">True = Readonly, False = Nicht-Readonly</param>
        private void setKundenTextboxReadonly(bool value)
        {
            ku_firma_box.ReadOnly = value;
            ku_anspr_box.ReadOnly = value;
            ku_mail_box.ReadOnly = value;
            ku_str_box.ReadOnly = value;
            ku_plz_box.ReadOnly = value;
            ku_ort_box.ReadOnly = value;
            ku_tel_box.ReadOnly = value;
            ku_fax_box.ReadOnly = value;
        }

        private void ku_New_Button_Click(object sender, EventArgs e)
        {
            if (bearbeitungsStatus == 0)
            {
                kunden_box.Enabled = false;

                ku_Ok_Butt.Enabled = true;
                ku_Cancel_Butt.Enabled = true;

                ku_firma_box.Text = "";
                ku_anspr_box.Text = "";
                ku_mail_box.Text = "";
                ku_str_box.Text = "";
                ku_plz_box.Text = "";
                ku_ort_box.Text = "";
                ku_tel_box.Text = "";
                ku_fax_box.Text = "";

                setKundenTextboxReadonly(false);

                ku_Bearb_Butt.Enabled = false;

                //Bearbeitungsstatus auf "Neuer Kunde" setzen
                bearbeitungsStatus = 2;
            }
            else
                ku_Cancel_Butt_Click(this, new EventArgs());
        }

		//Kunden bearbeiten
        private void ku_Bearb_Butt_Click(object sender, EventArgs e)
        {
            if (bearbeitungsStatus == 0)
            {
                setKundenTextboxReadonly(false);

                kunden_box.Enabled = false;

				if(validateKunden())
					ku_Ok_Butt.Enabled = true;

                ku_Cancel_Butt.Enabled = true;

                //Bearbeitungsstatus auf "Bearbeiten" setzen
                bearbeitungsStatus = 1;

                ku_New_Button.Enabled = false;
            }
            else
                ku_Cancel_Butt_Click(this, new EventArgs());
        }

		private void ku_Delete_Butt_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Möchten sie diesen Kunden wirklich löschen?","Warnung!",MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				SqlConnection.ExecuteStatement("DELETE FROM tkunde WHERE kuID = " + ((ListItem)kunden_box.SelectedItem).DatabankID);
				kundenInitialisieren();
				kunden_box.SelectedIndex = 0;
			}
		}

		//Änderungen annehmen
        private void ku_Ok_Butt_Click(object sender, EventArgs e)
        {
            kunden_box.Enabled = true;
            ku_Ok_Butt.Enabled = false;
            ku_Cancel_Butt.Enabled = false;
            setKundenTextboxReadonly(true);

            //Bearbeiten
            if (bearbeitungsStatus == 1)
            {
                SqlConnection.ExecuteStatement("UPDATE tkunde SET kuFirma = '" + ku_firma_box.Text +
                    "',kuStrasse = '" + ku_str_box.Text +
                    "',kuOrt = '" + ku_ort_box.Text +
                    "',kuTel = '" + ku_tel_box.Text +
                    "',kuFax = '" + ku_fax_box.Text +
					"',kuPLZ = '" + ku_plz_box.Text +
                    "',kuAnsprechpartner = '" + ku_anspr_box.Text +
                    "',`kuEMail` = '" + ku_mail_box.Text +
                    "' WHERE kuID = " + ((ListItem)kunden_box.SelectedItem).DatabankID);

                kundenAktualisieren();

                ku_New_Button.Enabled = true;
            }
            //Neuer Kunde
            else if (bearbeitungsStatus == 2)
            {
                SqlConnection.ExecuteStatement("INSERT INTO tkunde ( kuFirma, kuStrasse, kuPLz, kuOrt, kuTel, kuFax, kuAnsprechpartner, kuEMail)" +
                    "VALUES ( '" + ku_firma_box.Text + "', '" +
                    ku_str_box.Text + "', '" +
                    ku_plz_box.Text + "', '" +
                    ku_ort_box.Text + "', '" +
                    ku_tel_box.Text + "', '" +
                    ku_fax_box.Text + "', '" +
                    ku_anspr_box.Text + "', '" +
                    ku_mail_box.Text + "')");
                kundenInitialisieren();
                kunden_box.SelectedIndex = kunden_box.Items.Count - 1;

                ku_Bearb_Butt.Enabled = true;
            }
            bearbeitungsStatus = 0;


        }

        private void ku_Cancel_Butt_Click(object sender, EventArgs e)
        {
            kunden_box.Enabled = true;
            ku_Ok_Butt.Enabled = false;
            ku_Cancel_Butt.Enabled = false;
            setKundenTextboxReadonly(true);
            kundenAktualisieren();

            ku_Bearb_Butt.Enabled = true;
            ku_New_Button.Enabled = true;

			bearbeitungsStatus = 0;
        }

		#region 'KundenTextvalidierung'

		private void ku_firma_box_TextChanged(object sender, EventArgs e)
		{
			if (!ku_firma_box.IsValid)
				ku_Ok_Butt.Enabled = false;
			else if(bearbeitungsStatus != 0)
				ku_Ok_Butt.Enabled = true;
		}

		private void ku_anspr_box_TextChanged(object sender, EventArgs e)
		{
			if (!ku_anspr_box.IsValid)
				ku_Ok_Butt.Enabled = false;
			else if (bearbeitungsStatus != 0)
				ku_Ok_Butt.Enabled = true;
		}

		private void ku_mail_box_TextChanged(object sender, EventArgs e)
		{
			if (!ku_mail_box.IsValid)
				ku_Ok_Butt.Enabled = false;
			else if (bearbeitungsStatus != 0)
				ku_Ok_Butt.Enabled = true;
		}

		private void ku_str_box_TextChanged(object sender, EventArgs e)
		{
			if (!ku_str_box.IsValid)
				ku_Ok_Butt.Enabled = false;
			else if (bearbeitungsStatus != 0)
				ku_Ok_Butt.Enabled = true;
		}

		private void ku_plz_box_TextChanged(object sender, EventArgs e)
		{
			if (!ku_plz_box.IsValid)
				ku_Ok_Butt.Enabled = false;
			else if (bearbeitungsStatus != 0)
				ku_Ok_Butt.Enabled = true;
		}

		private void ku_ort_box_TextChanged(object sender, EventArgs e)
		{
			if (!ku_ort_box.IsValid)
				ku_Ok_Butt.Enabled = false;
			else if (bearbeitungsStatus != 0)
				ku_Ok_Butt.Enabled = true;
		}

		private void ku_tel_box_TextChanged(object sender, EventArgs e)
		{
			if (!ku_tel_box.IsValid)
				ku_Ok_Butt.Enabled = false;
			else if (bearbeitungsStatus != 0)
				ku_Ok_Butt.Enabled = true;
		}

		private void ku_fax_box_TextChanged(object sender, EventArgs e)
		{
			if (!ku_fax_box.IsValid)
				ku_Ok_Butt.Enabled = false;
			else if (bearbeitungsStatus != 0)
				ku_Ok_Butt.Enabled = true;
		}

		private bool validateKunden()
		{
			bool valid = true;
			if (!ku_firma_box.IsValid) { valid = false; }
			if (!ku_anspr_box.IsValid) { valid = false; }
			if (!ku_mail_box.IsValid) { valid = false; }
			if (!ku_str_box.IsValid) { valid = false; }
			if (!ku_plz_box.IsValid) { valid = false; }
			if (!ku_ort_box.IsValid) { valid = false; }
			if (!ku_tel_box.IsValid) { valid = false; }
			if (!ku_fax_box.IsValid) { valid = false; }

			return valid;
		}

		#endregion

		#endregion


        #region 'Mitarbeiter'

		//Bearbeitungsstatus, 0 = Keine Bearbeitung, 1 = Bearbeiten, 2 = Neuer Mitarbeiter
		private int mitarbeiterBearbStatus = 0;

		/// <summary>
		/// Initialisiert alle Mitarbeiter und holt alle verfügbaren Mitarbeiter und Rollen in die Liste.
		/// </summary>
		private void mitarbeiterInitialisieren()
		{
			//Mitarbeiterliste säubern
			userNameBox.Items.Clear();

			DataTable allema = SqlConnection.SelectStatement("SELECT miID ,miUsername FROM tMitarbeiter");

			DataTableReader reader = allema.CreateDataReader();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					userNameBox.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1)));
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
					roleBox.Items.Add(new ListItem(reader.GetInt32(0),reader.GetString(1)));
				}
			}

			roleBox.SelectedIndex = 0;

			userNameBox.SelectedIndex = 0;
		}

		/// <summary>
		/// Aktualisiert die Mitarbeiterdaten des ausgewählten Mitarbeiters.
		/// </summary>
		private void mitarbeiterAktualisieren()
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

		private void mitarbeiter_Tab_Enter(object sender, EventArgs e)
		{
			mitarbeiterInitialisieren();
		}

		private void userNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			mitarbeiterAktualisieren();
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

		//Benutze barbeiten
        private void mi_change_Butt_Click(object sender, EventArgs e)
        {
			//Keine Änderung aktiv
            if (mitarbeiterBearbStatus == 0)
            {
				mi_Cancel_Butt.Visible = true;
				mi_Save_Butt.Text = "Speichern";
				setMitarbeiterReadOnly(false);

				mitarbeiterBearbStatus = 1;
			}
			//Im Bearbeitungsstatus
            else if(mitarbeiterBearbStatus == 1)
            {
				if (mitarbeiterValid() && userNameTB.Text != "" && nameTB.Text != "" && vornameTB.Text != "" && mailTB.Text != "")
				{
					mi_Save_Butt.Text = "Ändern";
					setMitarbeiterReadOnly(true);
					SqlConnection.ExecuteStatement("UPDATE tmitarbeiter SET " +
						"miUsername = '" + userNameTB.Text +
						"', miVorname = '" + vornameTB.Text +
						"', miName = '" + nameTB.Text +
						"', miEmail = '" + mailTB.Text +
						"', roID= '" + ((ListItem)roleBox.SelectedItem).DatabankID +
						"'   where miID='" + ((ListItem)userNameBox.SelectedItem).DatabankID + "'");

					mi_Cancel_Butt.Visible = false;

					mitarbeiterBearbStatus = 0;
				}
            }
        }

		//Passwort zurücksetzen
        private void mi_PW_Butt_Click(object sender, EventArgs e)
        {
			//Standartpasswort wird gesetzt
            string startpw = "#start12";
            SqlConnection.SelectStatement("UPDATE tmitarbeiter SET miPasswort = '" + Md5.GetMD5(startpw) + 
				"' WHERE miID = '" + ((ListItem)userNameBox.SelectedItem).DatabankID + "'");
            MessageBox.Show("Das Passwort wurde auf " + startpw + " gesetzt");

        }

		//Mitarbeiter löschen
        private void mi_Del_Butt_Click(object sender, EventArgs e)
        {
			//Überprüfung, ob dem Mitarbeiter Projekte zugewiesen wurden
			DataTable result = SqlConnection.SelectStatement("SELECT miID FROM tmita_proj WHERE miID = " + 
				((ListItem)userNameBox.SelectedItem).DatabankID);

			if (result.Rows.Count == 0)
			{
				if (((ListItem)roleBox.SelectedItem).DatabankID == 2)
				{
					SqlConnection.SelectStatement("DELETE FROM tmitarbeiter WHERE miID = '" + ((ListItem)userNameBox.SelectedItem).DatabankID + "'");
					mitarbeiterInitialisieren();
				}
				else
				{
					MessageBox.Show("Sie können keine Geschäftsführer löschen");
				}
			}
			else
				MessageBox.Show("Sie können keine Mitarbeiter löschen, die in Projekten aktiv sind.");
        }

		//Neuen Mitarbeiter anlegen
        private void mit_New_Butt_Click(object sender, EventArgs e)
        {
			//Keine Bearbeitung aktiv
			if (mitarbeiterBearbStatus == 0)
            {
				mit_New_Butt.Text = "Anlegen";
                mi_Cancel_Butt.Visible = true;
                mi_Del_Butt.Enabled = false;
                mi_PW_Butt.Enabled = false;
                mi_Save_Butt.Enabled = false;

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
					//Benutzer abspeichern
                    SqlConnection.ExecuteStatement("INSERT INTO tmitarbeiter " +
						"(`roID`, `miName`, `miVorname`, `miUsername`, `miPasswort`, `miEMail`) " + 
						"VALUES ('"+ ((ListItem)roleBox.SelectedItem).DatabankID + "','" 
						+ vornameTB.Text + "','" + nameTB.Text + "','" 
						+ userNameTB.Text + "','83095e7ae40304e6c03c9da2f1ce2302','" 
						+ mailTB.Text + "')");

                    MessageBox.Show("Neuer User wurde angelegt. Passwort ist:");
					//Buttons enablen
                    mit_New_Butt.Text = "Neuer Mitarbeiter";
                    mi_Del_Butt.Enabled = true;
                    mi_PW_Butt.Enabled = true;
                    mi_Save_Butt.Enabled = true;

					mi_Cancel_Butt.Visible = false;

					setMitarbeiterReadOnly(true);
					
					mitarbeiterInitialisieren();

					mitarbeiterBearbStatus = 0;
                }
                else
                {
                    MessageBox.Show("Es wurden nicht alle Felder korrekt ausgefüllt.");
                }
            }
        }

		//Anlegen wird abgebrochen
        private void mit_Cancel_Click(object sender, EventArgs e)
        {
			userNameBox.Enabled = true;

			if (mitarbeiterBearbStatus == 2)
            {
                userNameBox.SelectedIndex = 0;
            }
			//Buttons zurücksetzen
            mit_New_Butt.Text = "Neuer Mitarbeiter";
            mi_Save_Butt.Text = "Ändern";
            mi_Del_Butt.Enabled = true;
            mi_PW_Butt.Enabled = true;
            mi_Save_Butt.Enabled = true;

			setMitarbeiterReadOnly(true);

			mi_Cancel_Butt.Visible = false;

			mitarbeiterBearbStatus = 0;

			mitarbeiterAktualisieren();
        }

		private bool mitarbeiterValid()
		{
			bool valid = true;
			if(!userNameTB.IsValid) {valid = false;}
			if(!nameTB.IsValid) {valid = false;}
			if(!vornameTB.IsValid) {valid = false;}
			if(!mailTB.IsValid) {valid = false;}

			return valid;
		}

        #endregion


        #region 'Projektadministration'

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
                    selectBoxProjekt.Items.Add(new ListItem(reader.GetInt32(0),reader.GetString(1)));
                }
            }

            selectBoxProjekt.SelectedIndex = 0;
        }

        //Aktualisiert die Informationen über das ausgewählte Projekt
        private void projekteAktualisieren()
        {

            //Nur einen allgemeinen Reader erstellen
            DataTableReader reader;

            //Kunde abfragen
            DataTable kunde = SqlConnection.SelectStatement("SELECT kuFirma FROM tkunde WHERE kuID = (SELECT kuID From tprojekt WHERE prId='" + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID + "') ");

            if(kunde.Rows.Count > 0)
                kund_Box.Text = kunde.Rows[0]["kuFirma"].ToString();

            //projektbeschreibung anzeigen
			DataTable projektDesc = SqlConnection.SelectStatement("SELECT prBeschreibung FROM tprojekt WHERE prId = '" + ((ListItem)selectBoxProjekt.SelectedItem).DatabankID + "'");

            if(projektDesc.Rows.Count > 0)
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
                    mitarbeit_List.Items.Add(new ListItem(reader.GetInt32(0),reader.GetString(1) + ", " + reader.GetString(2)));
                }
            }

            //tätigkeitsbeschr anzeigen
            DataTable taetDesc = SqlConnection.SelectStatement("SELECT taId, taBeschreibung " +
                "FROM ttaetigkeitenvorlage " +
                "WHERE taID IN (" +
                "SELECT taID " +
                "FROM tproj_taet "+
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


        private void projekt_Tab_Enter(object sender, EventArgs e)
        {
            projekteInitialisieren();
        }


        private void selectBoxProjekt_SelectedIndexChanged(object sender, EventArgs e)
        {
            projekteAktualisieren();
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

        //Neue Tätigkeit erstellen
        private void pro_New_Tät_Butt_Click(object sender, EventArgs e)
        {
			NewTaet neueTätigkeit = new NewTaet(((ListItem)selectBoxProjekt.SelectedItem).DatabankID);

            neueTätigkeit.StartPosition = FormStartPosition.CenterParent;

            if (neueTätigkeit.ShowDialog() == DialogResult.OK)
                projekteAktualisieren();
        }

        #endregion













 


























    }
}
