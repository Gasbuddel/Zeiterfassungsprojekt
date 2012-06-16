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
    public partial class Login : Form
    {
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void cancel_Butt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void login_Butt_Click(object sender, EventArgs e)
        {
            //Check, ob Name und Passwort eingegeben wurden
            if (login_Name_Box.Text != "" && login_PW_Box.Text != "")
            {
                try
                {
                    //Abfrage an die Tabelle Mitarbeiter wird erstellt nach Name und Passwort, um die Rolle herauszufinden
                    MySqlConnection con = SqlConnection.GetConnection();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT roID FROM tmitarbeiter WHERE miUsername LIKE '" + login_Name_Box.Text + "' AND miPasswort LIKE '" + login_PW_Box.Text + "'";
                    MySqlDataReader reader;

                    con.Open();

                    reader = cmd.ExecuteReader();

                    //Wurde kein Treffer gefunden, existiert der Mitarbeiter nicht, bzw falsches Passwort
                    if (reader.HasRows)
                    {
                        //Rolle abspeichern
                        reader.Read();
                        int rolle = Convert.ToInt32(reader.GetValue(0).ToString());

                        //Verbindung nach Verwendung immer schließen!
                        con.Close();

                        try
                        {
                            //Die Session mit der Rolle wird erstellt und die Hauptmaske geöffnet.
                            Session.CreateSession(rolle);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (FormatException)
                        {
                            //Falls der Benutzer nicht die Rolle 1, oder 2 hatte, was nicht passieren darf.
                            MessageBox.Show("Es scheint ein Fehlerhafter Benutzer angelegt worden zu sein.");
                        }
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Sie konnten nicht angemeldet werden.");
                    }
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Es kam zu einem Verbindungsproblem, bitte Überprüfen Sie ihre Verbindung.");
                }
            }
        }
    }
}
