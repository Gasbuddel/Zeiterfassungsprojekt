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

		private void initialisierenProj()
		{
			DataTable projekt = SqlConnection.SelectStatement("SELECT prID, prName FROM tprojekt WHERE prID IN(SELECT prID FROM tmita_proj WHERE miID = " + Session.GetSession().UserId + " and mpAktiv=1)");
			DataTableReader reader = projekt.CreateDataReader();


			if (reader.HasRows)
			{
				int index = 0;

				while (reader.Read())
				{

					if (pro_Box.Items.Contains(reader.GetString(1)) == false)
					{

						pro_Box.Items.Add(reader.GetString(1));
						pojektIds.Add(index, reader.GetInt32(0));

						index++;
					}
				}

			}
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
		}

        private void projekteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Administration admin = new Administration();
			admin.TabSelect(1);
			admin.StartPosition = FormStartPosition.CenterParent;

			admin.ShowDialog();
        }

        private void mitarbeiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Administration admin = new Administration();
			admin.TabSelect(2);
			admin.StartPosition = FormStartPosition.CenterParent;

			admin.ShowDialog();
        }


        #region 'Buchung'

        private void buch_Butt_Click(object sender, EventArgs e)
        {
            Buchung buch = new Buchung();
            buch.StartPosition = FormStartPosition.CenterParent;
            buch.ShowDialog(this);
        }

        private void pro_Box_SelectedValueChanged(object sender, EventArgs e)
		{
			Session.GetSession().ProId = pojektIds[pro_Box.SelectedIndex];
			getBuchungen();
			getSumStunden();
			getReisekosten();


		}

		private void getBuchungen(string date)
		{
			DataTable buchung = SqlConnection.SelectStatement("SELECT zeDauer,zeReisekosten,zeTag,zeTaetigkeit FROM tzeiterfassung WHERE miID=" + Session.GetSession().UserId + " and prID=" + Session.GetSession().ProId + " and zeTag='" + date + "'");
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
					tabelleGebuchteZeiten.Rows[n].Cells["Datum"].Value = reader.GetDateTime(2);
					tabelleGebuchteZeiten.Rows[n].Cells["Tätigkeitsbeschreibung"].Value = reader.GetString(3);

				}
			}
		}

		private void getBuchungen()
		{
			DataTable buchung = SqlConnection.SelectStatement("SELECT zeDauer,zeReisekosten,zeTag,zeTaetigkeit FROM tzeiterfassung WHERE miID=" + Session.GetSession().UserId + " and prID=" + Session.GetSession().ProId + "");
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
					tabelleGebuchteZeiten.Rows[n].Cells["Datum"].Value = reader.GetDateTime(2);
					tabelleGebuchteZeiten.Rows[n].Cells["Tätigkeitsbeschreibung"].Value = reader.GetString(3);

				}
			}
		}

		private void getSumStunden()
		{
			DataTable sql = SqlConnection.SelectStatement("SELECT sum(zeDauer)FROM tzeiterfassung WHERE miID=" + Session.GetSession().UserId + " and prID=" + Session.GetSession().ProId + "");
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
			DataTable sql = SqlConnection.SelectStatement("SELECT sum(zeReisekosten)FROM tzeiterfassung WHERE miID=" + Session.GetSession().UserId + " and prID=" + Session.GetSession().ProId + "");
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

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			DateTime da = anzeigeTag.Value;

			string date = da.ToString("yyyy-MM-dd");
			getBuchungen(date);
        }

        #endregion


    }
}
