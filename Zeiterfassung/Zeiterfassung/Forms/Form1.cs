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
                    string startpw = "83095e7ae40304e6c03c9da2f1ce2302";
                    string pw = md5.getMD5(login_PW_Box.Text);
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
                                changepw changepwform = new changepw();
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