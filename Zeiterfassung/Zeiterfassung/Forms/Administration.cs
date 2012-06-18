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

        private void button1_Click(object sender, EventArgs e)
        {
            NeuKunde neuKund = new NeuKunde();
            neuKund.StartPosition = FormStartPosition.CenterParent;
            neuKund.ShowDialog();
        }

        private void bearb_Butt_Click(object sender, EventArgs e)
        {
            NeuKunde neuKund = new NeuKunde();
            neuKund.StartPosition = FormStartPosition.CenterParent;
            neuKund.ShowDialog();
        }

        private void close_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Methode zum Initialiseren der Kundenliste, die Namen werden in der Combobox gespeichert und die Ids in einem Dictionary hinterlegt.
        /// </summary>
        private void kundenInitialisieren()
        {
            kundenIds.Clear();

            MySqlConnection con = SqlConnection.GetConnection();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT  kuId, kuFirma, kuAnsprechpartner FROM tKunde";
            MySqlDataReader reader;

            con.Open();

            reader = cmd.ExecuteReader();

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

            con.Close();

        }

        private void kundenAktualisieren(int kuId)
        {
            MySqlConnection con = SqlConnection.GetConnection();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT  * FROM tKunde WHERE kuID =" + kuId;
            MySqlDataReader reader;

            con.Open();

            reader = cmd.ExecuteReader();

            reader.Read();

            ku_firma_box.Text = reader.GetString(1);
            ku_anspr_box.Text = reader.GetString(7);
            ku_mail_box.Text = reader.GetString(8);
            ku_str_box.Text = reader.GetString(2);
            ku_plz_box.Text = reader.GetString(3);
            ku_ort_box.Text = reader.GetString(4);
            ku_tel_box.Text = reader.GetString(5);
            ku_fax_box.Text = reader.GetString(6);

            con.Close();

        }

        private void kunden_Tab_Enter(object sender, EventArgs e)
        {
            kundenInitialisieren();
        }

        private void kunden_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            kundenAktualisieren(kundenIds[kunden_box.SelectedIndex]);
        }
    }
}
