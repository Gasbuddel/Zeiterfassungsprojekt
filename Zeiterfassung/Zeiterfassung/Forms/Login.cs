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
            this.StartPosition = FormStartPosition.CenterParent;
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
                    string startpw = Md5.GetMD5("#10!?" + login_Name_Box.Text + "#start12~^g2+3");
                    string pw = Md5.GetMD5("#10!?" + login_Name_Box.Text.ToLower() + login_PW_Box.Text + "~^g2+3");

                    DataTable user = SqlConnection.SelectStatement("SELECT  miId, roID FROM tmitarbeiter WHERE miUsername = '" + login_Name_Box.Text + "' AND miPasswort = '" + pw + "'");

                    DataTableReader reader = user.CreateDataReader();


                    //Wurde kein Treffer gefunden, existiert der Mitarbeiter nicht, bzw falsches Passwort
                    if (reader.HasRows)
                    {
                        //Rolle abspeichern
                        reader.Read();

                        //Vorrübegehende Lösung weil das so ist!
                        int rolle = Convert.ToInt32(reader[1].ToString());
                        //int rolle = reader.GetInt32(1);
                        int userId = reader.GetInt32(0);

                        try
                        {
                            //Die Session mit der Rolle wird erstellt und die Hauptmaske geöffnet.

                            Session.CreateSession(rolle, userId);
                            if (startpw == pw)
                            {
                                Session.GetSession().StartPwChange();
                                ChangePW changepwform = new ChangePW();
                                // changepwform.ShowDialog();
                                if (changepwform.ShowDialog() != DialogResult.OK)
                                    Environment.Exit(0);
                            }
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
                        MessageBox.Show("Sie haben einen falschen Benutzername/Passwort eingegeben.");
                    }
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Datenbank konnte nicht erreicht werden.");
                            break;

                        case 1045:
                            MessageBox.Show("Falscher Datenbankbenutzer/Passwort.");
                            break;

                        default:
                            MessageBox.Show("Es kam zu einem unerwarteten Fehler mit der Datenbank.");
                            break;
                    }
                }
            }
        }
    }
}