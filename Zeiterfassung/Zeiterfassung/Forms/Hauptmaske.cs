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
	public partial class Hauptmaske : Form
	{
		private Dictionary<int, int> pojektIds;

		public Hauptmaske()
		{
			InitializeComponent();

			pojektIds = new Dictionary<int, int>();
			this.StartPosition = FormStartPosition.CenterScreen;
			Login login = new Login();
			if (login.ShowDialog() != DialogResult.OK)
				Environment.Exit(0);

			//Prüft welche art von user eingelogt ist und enabelt/disabelt administration
			if (Session.GetSession().Authorization == 2)
			{
				administrationToolStripMenuItem.Enabled = false;
				administrationToolStripMenuItem.Visible = false;
			}
			initialisierenProj();
		}

		//Projekte des mitarbeiters laden
		private void initialisierenProj()
		{
			pro_Box.Items.Clear();

			DataTable projekt = SqlConnection.SelectStatement("SELECT prID, prName FROM tprojekt " + 
				"WHERE prID IN(SELECT prID FROM tmita_proj " + 
				"WHERE miID = " + Session.GetSession().UserId + " AND mpAktiv = 1)");
			DataTableReader reader = projekt.CreateDataReader();


			if (reader.HasRows)
			{
				while (reader.Read())
				{

					if (pro_Box.Items.Contains(reader.GetString(1)) == false)
					{
						pro_Box.Items.Add(new ListItem(reader.GetInt32(0),reader.GetString(1)));
					}
				}
				pro_Box.SelectedIndex = 0;
			}

			if (pro_Box.Items.Count == 0)
			{
				groupBox1.Enabled = false;
			}
			else
				groupBox1.Enabled = true;
		}


		private void cancel_Butt_Click(object sender, EventArgs e)
		{
			this.Close();
		}



		private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void kundenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Administration admin = new Administration();
			admin.TabSelect(0);
			admin.StartPosition = FormStartPosition.CenterParent;

			admin.ShowDialog();

			initialisierenProj();
		}

        private void projekteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Administration admin = new Administration();
			admin.TabSelect(1);
			admin.StartPosition = FormStartPosition.CenterParent;

			admin.ShowDialog();

			initialisierenProj();
        }

        private void mitarbeiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Administration admin = new Administration();
			admin.TabSelect(2);
			admin.StartPosition = FormStartPosition.CenterParent;

			admin.ShowDialog();

			initialisierenProj();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zeiterfassung.Forms.AboutBox ueber = new Zeiterfassung.Forms.AboutBox();
            ueber.StartPosition = FormStartPosition.CenterParent;
            ueber.ShowDialog();
        }


        //Passwort ändern
        private void passwortÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePW changepwform = new ChangePW();
            changepwform.ShowDialog();

            changepwform.Dispose();
        }

        //Hilfe öffnen
        private void hilfeÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prüft welche Rolle der Nutzer hat und öffnet das entsprechende Handbuch
            if (Session.GetSession().Authorization == 1)
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\admin.pdf");
            }
            else
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\manual.pdf");
            }
        }


        #region 'Buchung'

        private void buch_Butt_Click(object sender, EventArgs e)
        {
            Buchung buch = new Buchung();
            buch.StartPosition = FormStartPosition.CenterParent;
            if (buch.ShowDialog() == DialogResult.OK)
            {
                showAll.Checked = true;
                getBuchungen();
                getSumStunden();
                getReisekosten();
            }
        }

        private void pro_Box_SelectedValueChanged(object sender, EventArgs e)
        {
            Session.GetSession().ProId = ((ListItem)pro_Box.SelectedItem).DatabankID;
            showAll.Checked = true;
            getBuchungen();
            getSumStunden();
            getReisekosten();
        }

        //Verbuchte Zeit laden
        private void getBuchungen(string von, string bis)
        {
            DataTable buchung = SqlConnection.SelectStatement("SELECT zeDauer,zeReisekosten, DATE_FORMAT(zeTag,GET_FORMAT(DATE,'EUR')) as zeTag,zeTaetigkeit " +
                " FROM tzeiterfassung WHERE miID=" + Session.GetSession().UserId +
                " AND prID=" + Session.GetSession().ProId + " AND zeTag>='" + von + "' AND zeTag<='" + bis + "' ORDER BY zeTag");
            DataTableReader reader = buchung.CreateDataReader();

            tabelleGebuchteZeiten.Rows.Clear();

            if (reader.HasRows)
            {
                List<string> temp = new List<string>();
                while (reader.Read())
                {
                    int n = tabelleGebuchteZeiten.Rows.Add();
                    tabelleGebuchteZeiten.Rows[n].Cells["Zeit"].Value = reader.GetDecimal(0);
                    tabelleGebuchteZeiten.Rows[n].Cells["Reisekosten"].Value = reader.GetDecimal(1);
                    tabelleGebuchteZeiten.Rows[n].Cells["Datum"].Value = reader.GetString(2);
                    tabelleGebuchteZeiten.Rows[n].Cells["Tätigkeitsbeschreibung"].Value = reader.GetString(3);

                }
            }
        }

        private void getBuchungen()
        {
            DataTable buchung = SqlConnection.SelectStatement("SELECT zeDauer,zeReisekosten, DATE_FORMAT(zeTag,GET_FORMAT(DATE,'EUR')) as zeTag,zeTaetigkeit " +
                " FROM tzeiterfassung WHERE miID=" + Session.GetSession().UserId +
                " AND prID=" + Session.GetSession().ProId + " ORDER BY zeTag");
            DataTableReader reader = buchung.CreateDataReader();

            tabelleGebuchteZeiten.Rows.Clear();

            if (reader.HasRows)
            {
                List<string> temp = new List<string>();
                while (reader.Read())
                {
                    int n = tabelleGebuchteZeiten.Rows.Add();
                    tabelleGebuchteZeiten.Rows[n].Cells["Zeit"].Value = reader.GetDecimal(0);
                    tabelleGebuchteZeiten.Rows[n].Cells["Reisekosten"].Value = reader.GetDecimal(1);
                    tabelleGebuchteZeiten.Rows[n].Cells["Datum"].Value = reader.GetString(2);
                    tabelleGebuchteZeiten.Rows[n].Cells["Tätigkeitsbeschreibung"].Value = reader.GetString(3);
                }
            }
        }

        private void getSumStunden()
        {
            DataTable sql = SqlConnection.SelectStatement("SELECT sum(zeDauer)FROM tzeiterfassung WHERE miID=" +
                Session.GetSession().UserId +
                " AND prID=" + Session.GetSession().ProId + "");
            DataTableReader reader = sql.CreateDataReader();

            reader.Read();

            if (reader.HasRows)
            {

                if (reader.IsDBNull(0) == false)
                {
                    zeit_Box.Text = reader.GetDecimal(0).ToString();
                }
                else
                {
                    zeit_Box.Text = "00.00";
                }
            }
        }

        private void getReisekosten()
        {
            DataTable sql = SqlConnection.SelectStatement("SELECT sum(zeReisekosten)FROM tzeiterfassung WHERE miID=" +
                Session.GetSession().UserId +
                " AND prID=" + Session.GetSession().ProId + "");
            DataTableReader reader = sql.CreateDataReader();

            reader.Read();

            if (reader.HasRows)
            {

                if (reader.IsDBNull(0) == false)
                {
                    cost_Box.Text = reader.GetDecimal(0).ToString();
                }
                else
                {
                    cost_Box.Text = "00.00";
                }
            }
        }

        private void vonTag_ValueChanged(object sender, EventArgs e)
        {

            if (showAll.Checked == false)
            {
                if (vonTag.Value > bisTag.Value)
                {
                    bisTag.Value = vonTag.Value;
                }

                string von = vonTag.Value.ToString("yyyy-MM-dd");
                string bis = bisTag.Value.ToString("yyyy-MM-dd");
                getBuchungen(von, bis);
            }

        }


        private void showAll_CheckedChanged(object sender, EventArgs e)
        {
            if (showAll.Checked == true)
            {
                vonTag.Enabled = false;
                bisTag.Enabled = false;
                getBuchungen();
            }

            if (showAll.Checked == false)
            {
                vonTag.Enabled = true;
                bisTag.Enabled = true;
                string von = vonTag.Value.ToString("yyyy-MM-dd");
                string bis = bisTag.Value.ToString("yyyy-MM-dd");

                getBuchungen(von, bis);
            }
        }

        private void bisTag_ValueChanged(object sender, EventArgs e)
        {
            if (showAll.Checked == false)
            {
                if (vonTag.Value > bisTag.Value)
                {
                    vonTag.Value = bisTag.Value;
                }

                string von = vonTag.Value.ToString("yyyy-MM-dd");
                string bis = bisTag.Value.ToString("yyyy-MM-dd");

                getBuchungen(von, bis);
            }
        }


        #endregion






















    }
}
