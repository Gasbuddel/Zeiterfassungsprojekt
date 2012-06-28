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
    public partial class KundenPanel : UserControl
    {
        public KundenPanel()
        {
            InitializeComponent();
        }


        #region 'Kundenadministration'

        //Variable zum merken, welcher Vorgang gerade bearbeitet wird, 0 = Keiner, 1 = Bearbeiten, 2 = Neuer Kunde
        private int bearbeitungsStatus = 0;

        //Das Panel wurde ausgewählt
        private void KundenPanel_Enter(object sender, EventArgs e)
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

            try
            {

                DataTable kunden = SqlConnection.SelectStatement("SELECT  kuId, kuFirma, kuAnsprechpartner FROM tKunde");

                DataTableReader reader = kunden.CreateDataReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Wenn eine Firma angegeben wurde, Firmenname benutzen
                        if (reader["kuFirma"].ToString() != "")
                            kunden_box.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1)));
                        //Sonst Ansprechpartner benutzen
                        else
                            kunden_box.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(2)));
                    }
                    kunden_box.SelectedIndex = 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                "Fehlernummer: " + ex.Number + Environment.NewLine +
                "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Kunde wurde in der Combobox ausgewählt
        private void kunden_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            kundenAktualisieren();
        }

        private void kundenAktualisieren()
        {
            try
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                "Fehlernummer: " + ex.Number + Environment.NewLine +
                "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        //Neuen Kunden anlegen
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
				ku_Delete_Butt.Enabled = false;

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

                if (validateKunden())
                    ku_Ok_Butt.Enabled = true;

                ku_Cancel_Butt.Enabled = true;

                //Bearbeitungsstatus auf "Bearbeiten" setzen
                bearbeitungsStatus = 1;

                ku_New_Button.Enabled = false;
				ku_Delete_Butt.Enabled = false;
            }
            else
                ku_Cancel_Butt_Click(this, new EventArgs());
        }

        //Änderungen annehmen
        private void ku_Ok_Butt_Click(object sender, EventArgs e)
        {
            kunden_box.Enabled = true;
            ku_Ok_Butt.Enabled = false;
            ku_Cancel_Butt.Enabled = false;
            setKundenTextboxReadonly(true);

            try
            {
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Es kam zu einem Problem mit der Datenbank." + Environment.NewLine +
                "Fehlernummer: " + ex.Number + Environment.NewLine +
                "Fehlerbeschreibung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Änderungen verwerfen
        private void ku_Cancel_Butt_Click(object sender, EventArgs e)
        {
            bearbeitungsStatus = 0;

            kunden_box.Enabled = true;
            ku_Ok_Butt.Enabled = false;
            ku_Cancel_Butt.Enabled = false;
            setKundenTextboxReadonly(true);
            kundenAktualisieren();

            ku_Bearb_Butt.Enabled = true;
            ku_New_Button.Enabled = true;
			ku_Delete_Butt.Enabled = true;
        }

        private void ku_Delete_Butt_Click(object sender, EventArgs e)
        {
            try
            {
                //Herrausfinden, ob der Kunde bereits ein Projekt hat
                int projectCount = SqlConnection.CountStatement("SELECT kuID FROM tProjekt WHERE kuID = " +
                    ((ListItem)kunden_box.SelectedItem).DatabankID);
                if (projectCount > 0)
                {
                    if (MessageBox.Show("Wenn sie diesen Kunden löschen, werden Projekte mitgelöscht. \n Fortfahren?", "Warnung!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        SqlConnection.ExecuteStatement("DELETE FROM tkunde WHERE kuID = " + ((ListItem)kunden_box.SelectedItem).DatabankID);
                        kundenInitialisieren();
                        kunden_box.SelectedIndex = 0;
                    }
                }
                else
                {
                    if (MessageBox.Show("Kunde wird gelöscht \n Fortfahren?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        SqlConnection.ExecuteStatement("DELETE FROM tkunde WHERE kuID = " + ((ListItem)kunden_box.SelectedItem).DatabankID);
                        kundenInitialisieren();
                        kunden_box.SelectedIndex = 0;
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



        #region 'KundenTextvalidierung'

        private void ku_firma_box_TextChanged(object sender, EventArgs e)
        {
            if (!validateKunden())
                ku_Ok_Butt.Enabled = false;
            else if (bearbeitungsStatus != 0)
                ku_Ok_Butt.Enabled = true;
        }

        private void ku_anspr_box_TextChanged(object sender, EventArgs e)
        {
            if (!validateKunden())
                ku_Ok_Butt.Enabled = false;
            else if (bearbeitungsStatus != 0)
                ku_Ok_Butt.Enabled = true;
        }

        private void ku_mail_box_TextChanged(object sender, EventArgs e)
        {
            if (!validateKunden())
                ku_Ok_Butt.Enabled = false;
            else if (bearbeitungsStatus != 0)
                ku_Ok_Butt.Enabled = true;
        }

        private void ku_str_box_TextChanged(object sender, EventArgs e)
        {
            if (!validateKunden())
                ku_Ok_Butt.Enabled = false;
            else if (bearbeitungsStatus != 0)
                ku_Ok_Butt.Enabled = true;
        }

        private void ku_plz_box_TextChanged(object sender, EventArgs e)
        {
            if (!validateKunden())
                ku_Ok_Butt.Enabled = false;
            else if (bearbeitungsStatus != 0)
                ku_Ok_Butt.Enabled = true;
        }

        private void ku_ort_box_TextChanged(object sender, EventArgs e)
        {
            if (!validateKunden())
                ku_Ok_Butt.Enabled = false;
            else if (bearbeitungsStatus != 0)
                ku_Ok_Butt.Enabled = true;
        }

        private void ku_tel_box_TextChanged(object sender, EventArgs e)
        {
            if (!validateKunden())
                ku_Ok_Butt.Enabled = false;
            else if (bearbeitungsStatus != 0)
                ku_Ok_Butt.Enabled = true;
        }

        private void ku_fax_box_TextChanged(object sender, EventArgs e)
        {
            if (!validateKunden())
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







    }
}
