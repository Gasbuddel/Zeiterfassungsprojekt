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
        //Dictionary mit KundenIds und Comboboxindixes
        private Dictionary<int, int> kundenIds;

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


        private void bearb_Butt_Click(object sender, EventArgs e)
        {
            setKundenTextboxReadonly(false);

            kunden_box.Enabled = false;

            ku_Ok_Butt.Enabled = true;

            ku_Cancel_Butt.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ku_firma_box.Text = "";
            ku_anspr_box.Text = "";
            ku_mail_box.Text = "";
            ku_str_box.Text = "";
            ku_plz_box.Text = "";
            ku_ort_box.Text = "";
            ku_tel_box.Text = "";
            ku_fax_box.Text = "";

            setKundenTextboxReadonly(false);
        }

        private void ku_Ok_Butt_Click(object sender, EventArgs e)
        {
            kunden_box.Enabled = true;
            ku_Ok_Butt.Enabled = false;
            ku_Cancel_Butt.Enabled = false;
            setKundenTextboxReadonly(true);

            SqlConnection.UpdateStatement("UPDATE tkunde SET kuFirma = '" + ku_firma_box.Text +
                "',kuStrasse = '" + ku_str_box.Text +
                "',kuOrt = '" + ku_ort_box.Text +
                "',kuTel = '" + ku_tel_box.Text +
                "',kuFax = '" + ku_fax_box.Text +
                "',kuAnsprechpartner = '" + ku_anspr_box.Text +
                "',`kuEMail` = '" + ku_mail_box.Text +
                "' WHERE kuID = " + kundenIds[kunden_box.SelectedIndex]);
        }

        private void ku_Cancel_Butt_Click(object sender, EventArgs e)
        {
            kunden_box.Enabled = true;
            ku_Ok_Butt.Enabled = false;
            ku_Cancel_Butt.Enabled = false;
            setKundenTextboxReadonly(true);
            kundenAktualisieren(kundenIds[kunden_box.SelectedIndex]);
            MessageBox.Show("No changes for you today!");
        }

        #endregion


        #region 'Mitarbeiter'

        private void tabbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mitarbeiter
            if (tabbi.SelectedIndex == 1)
            {

                //Mitarbeiter einfügen
                DataTable allema = SqlConnection.SelectStatement("SELECT  * FROM tMitarbeiter");

                DataTableReader reader = allema.CreateDataReader();

                if (reader.HasRows)
                {
                    int index = 0;

                    while (reader.Read())
                    {
                        userNameBox.Items.Add(reader.GetString(4));

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

            //Projekte
            if (tabbi.SelectedIndex == 2)
            {

                MessageBox.Show(tabbi.SelectedIndex.ToString());
            }
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable mareader = SqlConnection.SelectStatement("SELECT  tMitarbeiter.*, roBezeichnung FROM tMitarbeiter left join trolle using (roID) where miUsername='" + userNameBox.SelectedValue + "'");

            DataTableReader reader = mareader.CreateDataReader();

            if (reader.HasRows)
            {
                int index = 0;

                while (reader.Read())
                {
                    nameTB.Text = reader.GetString(2);
                    vornameTB.Text = reader.GetString(3);
                    mailTB.Text = reader.GetString(6);

                    //KundenID festhalten
                    // kundenIds.Add(index, reader.GetInt32(0));

                    index++;
                }

            }

        }

        #endregion




    }
}
