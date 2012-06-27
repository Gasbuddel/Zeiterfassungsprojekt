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
    public partial class ChangePW : Form
    {
        public ChangePW()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            if (Session.GetSession().StartPw == true)
            {
                Session.GetSession().StartPwChange();
                this.Text = "Bitte das Passwort neu setzen.";
                this.newPW.Select();
                string startpw = "#start12";
                altesPW.Text = startpw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username;

            DataTable userNam = SqlConnection.SelectStatement("SELECT miUsername FROM tMitarbeiter WHERE miID = " + Session.GetSession().UserId);

            username = userNam.Rows[0]["miUsername"].ToString().ToLower();

            string oldpw = Md5.GetMD5("#10!?" + username + altesPW.Text + "~^g2+3");
            string newpw1 = Md5.GetMD5("#10!?" + username + newPW.Text + "~^g2+3");
            string newpw2 = Md5.GetMD5("#10!?" + username + newPW.Text + "~^g2+3");
            int userid = Session.GetSession().UserId;

            DataTable user = SqlConnection.SelectStatement("SELECT  miId, roID FROM tmitarbeiter WHERE miID = " + userid + " AND miPasswort = '" + oldpw + "'");

            DataTableReader reader = user.CreateDataReader();


            //Wurde kein Treffer gefunden, existiert der Mitarbeiter nicht, bzw falsches Passwort
            if (reader.HasRows)
            {
                try
                {
                    if (newpw1 == newpw2)
                    {
                        SqlConnection.SelectStatement("UPDATE tmitarbeiter SET miPasswort = '" + newpw1 + "' WHERE miID = " + userid + "");
                        MessageBox.Show("Passwort erfolgreich geändert");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Die Passwort stimmen nicht überein!");
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Datenbank konnte nicht erreicht werden.");
                            break;

                        default:
                            MessageBox.Show("Es kam zu einem unerwarteten Fehler mit der Datenbank.");
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Altes Passwort ist falsch.");
            }

        }
    }
}
