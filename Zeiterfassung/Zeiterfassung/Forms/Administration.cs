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


        public Administration()
        {
            InitializeComponent();

            kundenIds = new Dictionary<int, int>();
        }

        private void close_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 'Kundenadministration'

        //Dictionary mit KundenIds und Comboboxindixes
        private Dictionary<int, int> kundenIds;

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
            kundenIds.Clear();
            kunden_box.Items.Clear();

            DataTable kunden = SqlConnection.SelectStatement("SELECT  kuId, kuFirma, kuAnsprechpartner FROM tKunde");

            DataTableReader reader = kunden.CreateDataReader();

            if (reader.HasRows)
            {
                int index = 0;

                while (reader.Read())
                {
                    if (reader.GetString(1) != "")
                        kunden_box.Items.Add(reader.GetString(1));
                    else
                        kunden_box.Items.Add(reader.GetString(2));

                    //KundenID festhalten
                    kundenIds.Add(index, reader.GetInt32(0));

                    index++;
                }
                kunden_box.SelectedIndex = 0;
            }

        }

        //Kunde wurde in der Combobox ausgewählt
        private void kunden_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            kundenAktualisieren(kundenIds[kunden_box.SelectedIndex]);
        }

        private void kundenAktualisieren(int kuId)
        {

            DataTable kunden = SqlConnection.SelectStatement("SELECT  * FROM tKunde WHERE kuID =" + kuId);

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


        private void ku_Bearb_Butt_Click(object sender, EventArgs e)
        {
            setKundenTextboxReadonly(false);

            kunden_box.Enabled = false;

            ku_Ok_Butt.Enabled = true;

            ku_Cancel_Butt.Enabled = true;

			//Bearbeitungsstatus auf "Bearbeiten" setzen
			bearbeitungsStatus = 1;

            ku_New_Button.Enabled = false;

        }

		private void ku_Delete_Butt_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Möchten sie diesen Kunden wirklich löschen?","Warnung!",MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				SqlConnection.ExecuteStatement("DELETE FROM tkunde WHERE kuID = " + kundenIds[kunden_box.SelectedIndex]);
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
					"',kuAnsprechpartner = '" + ku_anspr_box.Text +
					"',`kuEMail` = '" + ku_mail_box.Text +
					"' WHERE kuID = " + kundenIds[kunden_box.SelectedIndex]);

                ku_New_Button.Enabled = true;
			}
            //Neuer Kunde
			else if(bearbeitungsStatus == 2)
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
            kundenAktualisieren(kundenIds[kunden_box.SelectedIndex]);

            ku_Bearb_Butt.Enabled = true;
            ku_New_Button.Enabled = true;

			bearbeitungsStatus = 0;
        }

        #endregion

        //Kann ersetzt werden mit dem Enter-Event des jeweiligen Tabs, ist sogar notwendig, wenn das jeweilige Tab direkt ausgewählt wird.
        private void tabbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mitarbeiter
            if (project_Tab.SelectedIndex == 1)
            {
                mi_Cancel_Butt.Visible = false;
                //Mitarbeiter einfügen
                userNameBox.Items.Clear();
                DataTable allema = SqlConnection.SelectStatement("SELECT  * FROM tMitarbeiter");

                DataTableReader reader = allema.CreateDataReader();

                if (reader.HasRows)
                {
                    int index = 0;

                    while (reader.Read())
                    {
                        if (userNameBox.Items.Contains(reader.GetString(4)) == false)
                        {
                            userNameBox.Items.Add(reader.GetString(4));
                        }
                        index++;
                    }
                    userNameBox.SelectedIndex = 0;
                }


                //Mitarbeiter einfügen
                DataTable alleRollen = SqlConnection.SelectStatement("SELECT  roBezeichnung FROM tRolle");

                DataTableReader roreader = alleRollen.CreateDataReader();

                if (roreader.HasRows)
                {
                    int index = 0;

                    while (roreader.Read())
                    {
                        roleBox.Items.Add(roreader.GetString(0));

                        index++;
                    }
                    userNameBox.SelectedIndex = 0;
                }
            }

            ////Projekte
            //if (project_Tab.SelectedIndex == 2)
            //{
            //    DataTable allema = SqlConnection.SelectStatement("SELECT  * FROM tProjekt");

            //    DataTableReader reader = allema.CreateDataReader();

            //    if (reader.HasRows)
            //    {
            //        int index = 0;

            //        while (reader.Read())
            //        {
            //            if (userNameBox.Items.Contains(reader.GetString(2)) == false)
            //            {

            //                cBProjekt.Items.Add(reader.GetString(2));
            //            }
            //            index++;
            //        }
            //        cBProjekt.SelectedIndex = 0;
            //    }

            //}
        }

        ////Gehört in die Projectregion
        //private void cBProjekt_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    cBProjekt.Select();
        //    listMitarbeiter.Items.Clear();
        //    //SELECT tmitarbeiter.miID, tmitarbeiter.miUsername FROM tmita_proj LEFT JOIN tmitarbeiter USING ( miID ) WHERE prID =1
        //    DataTable allema = SqlConnection.SelectStatement("SELECT tprojekt . * , tkunde.kufirma FROM tprojekt LEFT JOIN tkunde USING ( kuID ) where prName ='" + cBProjekt.SelectedItem.ToString() + "'");

        //    DataTableReader reader = allema.CreateDataReader();

        //    if (reader.HasRows)
        //    {
        //        int index = 0;

        //        while (reader.Read())
        //        {
        //            proID.Text = reader.GetInt32(0).ToString();
        //            textKunde.Text = reader.GetString(4);
        //            textPBeschreibung.Text = reader.GetString(3);
        //            index++;
        //        }
        //    }

        //    DataTable ma = SqlConnection.SelectStatement("SELECT tmitarbeiter.miID, tmitarbeiter.miUsername FROM tmita_proj LEFT JOIN tmitarbeiter USING ( miID ) WHERE prID =" + proID.Text + "");

        //    reader = ma.CreateDataReader();

        //    if (reader.HasRows)
        //    {
        //        int index = 0;

        //        while (reader.Read())
        //        {
        //            listMitarbeiter.Items.Add(reader.GetString(1));
        //            index++;
        //        }
        //    }


        //}


        #region 'Mitarbeiter'

        //Am besten eine eigene Methode zum aktualisieren schreiben
        private void userNameBox_SelectedValueChanged(object sender, EventArgs e)
        {
            nameTB.Enabled = false;
            vornameTB.Enabled = false;
            mailTB.Enabled = false;
            roleBox.Enabled = false;
            //Mitarbeiter lässt sich präziser bestimmen über den Index, siehe Kundenadministration, oder Hauptmaske
            DataTable mareader = SqlConnection.SelectStatement("SELECT  tMitarbeiter.*, roBezeichnung FROM tMitarbeiter left join trolle using (roID) where miUsername='" + userNameBox.SelectedItem.ToString() + "'");

            DataTableReader reader = mareader.CreateDataReader();

            if (reader.HasRows)
            {
                int index = 0;

                while (reader.Read())
                {
                    roleBox.Text = reader.GetString(7);
                    nameTB.Text = reader.GetString(2);
                    vornameTB.Text = reader.GetString(3);
                    mailTB.Text = reader.GetString(6);

                    //KundenID festhalten
                    // kundenIds.Add(index, reader.GetInt32(0));

                    index++;
                }

            }

        }


        private void mi_Save_Butt_Click(object sender, EventArgs e)
        {

            if (mi_Save_Butt.Text.Equals("Speichern"))
            {
                mi_Save_Butt.Text = "Ändern";
                userNameBox.Enabled = true;
                nameTB.Enabled = false;
                vornameTB.Enabled = false;
                mailTB.Enabled = false;
                roleBox.Enabled = false;
                SqlConnection.ExecuteStatement("UPDATE tmitarbeiter SET miVorname = '" + vornameTB.Text + "', miName = '" + nameTB.Text + "', miEmail = '" + mailTB.Text + "', roID=(select roID from trolle where roBezeichnung='" + roleBox.SelectedItem.ToString() + "')   where miUsername='" + userNameBox.SelectedItem.ToString() + "'");

            }

            else
            {
                mi_Cancel_Butt.Visible = true;
                userNameBox_SelectedValueChanged(null, null);
                mi_Save_Butt.Text = "Speichern";
                userNameBox.Enabled = false;
                nameTB.Enabled = true;
                vornameTB.Enabled = true;
                mailTB.Enabled = true;
                roleBox.Enabled = true;
            }



        }

        private void mi_PW_Butt_Click(object sender, EventArgs e)
        {
            string startpw = "#start12";
            SqlConnection.SelectStatement("UPDATE tmitarbeiter SET miPasswort = '" + Md5.GetMD5(startpw) + "' WHERE miUsername = '" + userNameBox.SelectedItem.ToString() + "'");
            MessageBox.Show("Das Passwort wurde auf " + startpw + " gesetzt");

        }

        private void mi_Del_Butt_Click(object sender, EventArgs e)
        {
            if (roleBox.Text == "Mitarbeiter")
            {
                userNameBox.Select();
                SqlConnection.SelectStatement("DELETE FROM tmitarbeiter WHERE miUsername = '" + userNameBox.SelectedItem.ToString() + "'");
                tabbi_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Sie können kein Geschäftsführer löschen");
            }
        }

        private void mit_New_Butt_Click(object sender, EventArgs e)
        {
            if (mit_New_Butt.Text.Equals("Neuer Mitarbeiter"))
            {
                mi_Cancel_Butt.Visible = true;
                mit_New_Butt.Text = "Anlegen";
                roleBox.Select();
                mi_Del_Butt.Enabled = false;
                mi_PW_Butt.Enabled = false;
                mi_Save_Butt.Enabled = false;
                userNameBox.Enabled = true;
                nameTB.Enabled = true;
                vornameTB.Enabled = true;
                mailTB.Enabled = true;
                roleBox.Enabled = true;
                userNameBox.Select();
                userNameBox.SelectedText = "";
                nameTB.Text = "";
                vornameTB.Text = "";
                mailTB.Text = "";
            }

            else
            {
                userNameBox.Select();
                if (nameTB.Text != "" && vornameTB.Text != "" && mailTB.Text != "" && userNameBox.SelectedText != "")
                {
                    roleBox.Select();
                    string rolle = roleBox.SelectedText;
                    userNameBox.Select();
                    SqlConnection.ExecuteStatement("INSERT INTO tmitarbeiter (`roID`, `miName`, `miVorname`, `miUsername`, `miPasswort`, `miEMail`) VALUES ((select roID from trolle where roBezeichnung='" + rolle + "'),'" + vornameTB.Text + "','" + nameTB.Text + "','" + userNameBox.SelectedText + "','83095e7ae40304e6c03c9da2f1ce2302','" + mailTB.Text + "')");
                    MessageBox.Show("Neuer User wurde angelegt. Passwort ist:");
                    mit_New_Butt.Text = "Neuer Mitarbeiter";
                    mi_Del_Butt.Enabled = true;
                    mi_PW_Butt.Enabled = true;
                    mi_Save_Butt.Enabled = true;
                    nameTB.Enabled = false;
                    vornameTB.Enabled = false;
                    mailTB.Enabled = false;
                    roleBox.Enabled = false;
                    tabbi_SelectedIndexChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Bitte alle Felder ausfüllen");
                }
            }
        }

        private void mit_New_Butt_Click_1(object sender, EventArgs e)
        {
            if (mit_New_Butt.Text == "Anlegen")
            {
                userNameBox.SelectedIndex = 0;
            }
            mit_New_Butt.Text = "Neuer Mitarbeiter";
            mi_Save_Butt.Text = "Ändern";
            mi_Del_Butt.Enabled = true;
            mi_PW_Butt.Enabled = true;
            mi_Save_Butt.Enabled = true;
            userNameBox.Enabled = true;
            nameTB.Enabled = false;
            vornameTB.Enabled = false;
            mailTB.Enabled = false;
            roleBox.Enabled = false;
            nameTB.Select();
            mi_Cancel_Butt.Visible = false;
        }

        #endregion


        #region 'Projektadministration'

        private void projekt_Tab_Enter(object sender, EventArgs e)
        {
            DataTable projekte = SqlConnection.SelectStatement("SELECT prName FROM tprojekt");

            DataTableReader dreader = projekte.CreateDataReader();
            selectBoxProjekt.Items.Clear();
            if (dreader.HasRows)
            {
                while (dreader.Read())
                {
                    selectBoxProjekt.Items.Add(dreader.GetString(0));
                }
            }
        }


        private void selectBoxProjekt_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        public void selectBoxProjekt_SelectedIndexChanged()
        {
            DataTable kunde = SqlConnection.SelectStatement("SELECT kuFirma FROM tkunde WHERE kuID = (SELECT kuID From tprojekt WHERE prName='" + selectBoxProjekt.Text + "') ");

            DataTableReader kunde_reader = kunde.CreateDataReader();

            if (kunde_reader.HasRows)
            {
                while (kunde_reader.Read())
                {
                    kund_Box.Text = kunde_reader.GetString(0);
                }
            }

            //projekte anzeigen
            DataTable projekte = SqlConnection.SelectStatement("SELECT prName FROM tprojekt");

            DataTableReader dreader = projekte.CreateDataReader();
            selectBoxProjekt.Items.Clear();
            if (dreader.HasRows)
            {
                while (dreader.Read())
                {
                    selectBoxProjekt.Items.Add(dreader.GetString(0));
                }
            }



            //projektbeschreibung anzeigen

            DataTable projektDesc = SqlConnection.SelectStatement("SELECT prBeschreibung FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "'");

            DataTableReader projektDesc_reader = projektDesc.CreateDataReader();

            if (kunde_reader.HasRows)
            {
                while (projektDesc_reader.Read())
                {
                    beschr_Box.Text = projektDesc_reader.GetString(0);
                }
            }

            //aktuell zuständige mitarbeiter anzeigen
            DataTable arbeiter = SqlConnection.SelectStatement("SELECT miName,miVorname FROM tmitarbeiter m LEFT JOIN tmita_proj mp ON m.miID=mp.miID LEFT JOIN tprojekt p ON p.prID=mp.prID WHERE p.prID = (SELECT prID FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "')");

            DataTableReader arbeiter_reader = arbeiter.CreateDataReader();

            mitarbeit_Box.Items.Clear();

            if (arbeiter_reader.HasRows)
            {


                while (arbeiter_reader.Read())
                {

                    mitarbeit_Box.Items.Add(arbeiter_reader.GetString(0) + ", " + arbeiter_reader.GetString(1));

                }
            }

            //tätigkeitsbeschr anzeigen

            DataTable taetDesc = SqlConnection.SelectStatement("SELECT taBeschreibung FROM ttaetigkeitenvorlage tv LEFT JOIN tproj_taet tp ON tp.taID=tv.taID LEFT JOIN tprojekt p ON p.prID=tp.prID WHERE p.prID =(SELECT prID FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "' )");

            DataTableReader taetDesc_reader = taetDesc.CreateDataReader();

            if (taetDesc_reader.HasRows)
            {
                thaet_Box.Items.Clear();
                while (taetDesc_reader.Read())
                {
                    thaet_Box.Items.Add(taetDesc_reader.GetString(0));
                }
            }

        }

        private void selectBoxProjekt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //entsprechenden Kunden anzeigen

            DataTable kunde = SqlConnection.SelectStatement("SELECT kuFirma FROM tkunde WHERE kuID = (SELECT kuID From tprojekt WHERE prName='" + selectBoxProjekt.Text + "') ");

            DataTableReader kunde_reader = kunde.CreateDataReader();

            if (kunde_reader.HasRows)
            {
                while (kunde_reader.Read())
                {
                    kund_Box.Text = kunde_reader.GetString(0);
                }
            }


            //projektbeschreibung anzeigen

            DataTable projektDesc = SqlConnection.SelectStatement("SELECT prBeschreibung FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "'");

            DataTableReader projektDesc_reader = projektDesc.CreateDataReader();

            if (kunde_reader.HasRows)
            {
                while (projektDesc_reader.Read())
                {
                    beschr_Box.Text = projektDesc_reader.GetString(0);
                }
            }

            //aktuell zuständige mitarbeiter anzeigen
            DataTable arbeiter = SqlConnection.SelectStatement("SELECT miName,miVorname FROM tmitarbeiter m LEFT JOIN tmita_proj mp ON m.miID=mp.miID LEFT JOIN tprojekt p ON p.prID=mp.prID WHERE p.prID = (SELECT prID FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "')");

            DataTableReader arbeiter_reader = arbeiter.CreateDataReader();

            mitarbeit_Box.Items.Clear();

            if (arbeiter_reader.HasRows)
            {


                while (arbeiter_reader.Read())
                {

                    mitarbeit_Box.Items.Add(arbeiter_reader.GetString(0) + ", " + arbeiter_reader.GetString(1));

                }
            }

            //tätigkeitsbeschr anzeigen

            DataTable taetDesc = SqlConnection.SelectStatement("SELECT taBeschreibung FROM ttaetigkeitenvorlage tv LEFT JOIN tproj_taet tp ON tp.taID=tv.taID LEFT JOIN tprojekt p ON p.prID=tp.prID WHERE p.prID =(SELECT prID FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "' )");

            DataTableReader taetDesc_reader = taetDesc.CreateDataReader();
            thaet_Box.Items.Clear();
            if (taetDesc_reader.HasRows)
            {

                while (taetDesc_reader.Read())
                {
                    thaet_Box.Items.Add(taetDesc_reader.GetString(0));
                }
            }



        }

        //Arbeiter aus dem Projekt löschen
        private void deleteArbeiter_Click(object sender, EventArgs e)
        {

            try
            {
                string ArbeiterToKill = mitarbeit_Box.SelectedItem.ToString();
                string[] split = ArbeiterToKill.Split(",".ToCharArray());
                string nachname = split[0];
                String delim = " ";
                string vorname = split[1].Trim(delim.ToCharArray());

                DataTable taetDesc = SqlConnection.SelectStatement("DELETE FROM `tmita_proj` WHERE `miID` = (SELECT miID FROM `tmitarbeiter` WHERE `miName`='" + nachname + "' AND miVorname='" + vorname + "')");

                DataTable arbeiter = SqlConnection.SelectStatement("SELECT miName,miVorname FROM tmitarbeiter m LEFT JOIN tmita_proj mp ON m.miID=mp.miID LEFT JOIN tprojekt p ON p.prID=mp.prID WHERE p.prID = (SELECT prID FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "')");

                DataTableReader arbeiter_reader = arbeiter.CreateDataReader();

                mitarbeit_Box.Items.Clear();

                if (arbeiter_reader.HasRows)
                {


                    while (arbeiter_reader.Read())
                    {

                        mitarbeit_Box.Items.Add(arbeiter_reader.GetString(0) + ", " + arbeiter_reader.GetString(1));

                    }
                }
            }
            catch
            {
                MessageBox.Show("Sie müssen einen Mitarbeiter auswählen");
            }
        }

        private void addWorkerToProject_butt_Click(object sender, EventArgs e)
        {

            DataTable prID = SqlConnection.SelectStatement("SELECT prID FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "'");

            DataTableReader prID_reader = prID.CreateDataReader();

            if (prID_reader.HasRows)
            {
                while (prID_reader.Read())
                {
                    int proj_id = prID_reader.GetInt32(0);
                    AddWorkerToProject AddWorkerForm = new AddWorkerToProject(proj_id, this);
                    AddWorkerForm.Show();
                }
            }



        }
        //neues projekt anlegen
        private void newPro_Butt_Click(object sender, EventArgs e)
        {
            CreateProject newPro = new CreateProject(this);
            newPro.Show();
        }
        //projekt bearbeiten
        private void pro_Bearb_Butt_Click(object sender, EventArgs e)
        {

            DataTable prID = SqlConnection.SelectStatement("SELECT prID FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "'");

            DataTableReader prID_reader = prID.CreateDataReader();

            if (prID_reader.HasRows)
            {
                while (prID_reader.Read())
                {
                    try
                    {
                        int proj_id = prID_reader.GetInt32(0);
                        EditProject editPr = new EditProject(proj_id, this);
                        editPr.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Sie müssen ein Projekt wählen.");
                    }
                }
            }



        }
        //tätigkeit hinzufügen
        private void button3_Click(object sender, EventArgs e)
        {

            DataTable prID = SqlConnection.SelectStatement("SELECT prID FROM tprojekt WHERE prName = '" + selectBoxProjekt.Text + "'");

            DataTableReader prID_reader = prID.CreateDataReader();

            if (prID_reader.HasRows)
            {
                while (prID_reader.Read())
                {
                    try
                    {
                        int proj_id = prID_reader.GetInt32(0);
                        AddTaetigkeit taetForm = new AddTaetigkeit(this, proj_id);
                        taetForm.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Es ist ein Fehler aufgetreten");
                    }
                }
            }

        }

        //tätigkeit entfernen
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable prID = SqlConnection.SelectStatement("DELETE FROM `tproj_taet` WHERE prID=(SELECT prID FROM tprojekt WHERE prName='" + selectBoxProjekt.Text + "' AND taID=(SELECT taID FROM ttaetigkeitenvorlage WHERE taBeschreibung='" + thaet_Box.Text + "'))");
                this.selectBoxProjekt_SelectedIndexChanged();
                MessageBox.Show("Tätigkeiten wurden entfernt");
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten");
            }
        }

        //tätigkeit bearbeiten
        private void button6_Click(object sender, EventArgs e)
        {
            DataTable taID = SqlConnection.SelectStatement("SELECT taID FROM ttaetigkeitenvorlage WHERE taBeschreibung = '" + thaet_Box.Text + "'");

            DataTableReader taID_reader = taID.CreateDataReader();

            if (taID_reader.HasRows)
            {
                while (taID_reader.Read())
                {

                    int taetID = taID_reader.GetInt32(0);
                    EditTaet EditTaetForm = new EditTaet(this, taetID, selectBoxProjekt.Text);
                    EditTaetForm.Show();


                }
            }

        }


        #endregion













    }
}
