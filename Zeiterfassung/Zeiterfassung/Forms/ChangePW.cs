using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zeiterfassung
{
    public partial class changepw : Form
    {
        public changepw()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            if (Session.GetSession().StartPw == true)
            {
                Session.GetSession().StartPwChange();
                this.Text = "Bitte Startpasswort ändern";
                this.newPW.Select();
                string startpw = "#start12";
                altesPW.Text = startpw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpw = md5.getMD5(altesPW.Text);
            string newpw1 = md5.getMD5(newPW.Text);
            string newpw2 = md5.getMD5(newPW2.Text);
            int userid = Session.GetSession().UserId;
            DataTable user = SqlConnection.SelectStatement("SELECT  miId, roID FROM tmitarbeiter WHERE miID = " + userid + " AND miPasswort = '" + oldpw + "'");

            DataTableReader reader = user.CreateDataReader();


            //Wurde kein Treffer gefunden, existiert der Mitarbeiter nicht, bzw falsches Passwort
            if (reader.HasRows)
            {
                //Rolle abspeichern

                try
                {

                    if (newpw1 == newpw2)
                    {
                        SqlConnection.SelectStatement("UPDATE tmitarbeiter SET miPasswort = '" + newpw1 + "' WHERE miID = " + userid + "");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                catch (FormatException)
                {
                    //Falls der Benutzer nicht die Rolle 1, oder 2 hatte, was nicht passieren darf.
                    MessageBox.Show("Die Passwort stimmen nicht überein!");
                }
            }
            else
            {
                MessageBox.Show("Altes Passwort ist falsch.");
            }

        }
    }
}
