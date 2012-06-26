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
	public partial class Buchung : Form
	{
		public Buchung()
		{
			InitializeComponent();
			tätigkeitenInitialisieren();
		}

		private void tätigkeitenInitialisieren()
		{
			DataTable tätigkeiten = SqlConnection.SelectStatement("SELECT taID, taBeschreibung " +
				"FROM ttaetigkeitenvorlage " +
				"WHERE taID IN (" +
				"SELECT taID FROM tproj_taet " +
				"WHERE prID = " + Session.GetSession().ProId + ")");

			DataTableReader reader = tätigkeiten.CreateDataReader();

			if(reader.HasRows)
			{
				while(reader.Read())
				{
					tätigkeits_Box.Items.Add(new ListItem(reader.GetInt32(0), reader.GetString(1)));
				}
				tätigkeits_Box.SelectedIndex = 0;
			}
		}

		private void book_Cancel_Butt_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void book_Booking_Butt_Click(object sender, EventArgs e)
		{
			decimal stunden = stunden_Box.Value;
			decimal kosten = Convert.ToDecimal(kosten_Box.Text);
			string tätigkeit = tätigkeits_Box.Text.ToString();

			DateTime da = buchungsDatum.Value;
			string date = da.ToString("yyyy-MM-dd");
			string customTätigkeit = custom_Box.Text.ToString();

			if (bu_Custom_CheckBox.Checked == true)
			{
				SqlConnection.ExecuteStatement("insert into tzeiterfassung (miID, prID, zeTag, zeTaetigkeit, zeDauer, zeReisekosten) " +
					" values(" + Session.GetSession().UserId + "," + Session.GetSession().ProId + 
					",'" + date + "','" + customTätigkeit + "','" + stunden + "' ,'" + kosten + "')");
			}

			else
			{
				SqlConnection.ExecuteStatement("insert into tzeiterfassung (miID, prID, zeTag, zeTaetigkeit, zeDauer, zeReisekosten) " +
					" values(" + Session.GetSession().UserId + "," + Session.GetSession().ProId + 
					",'" + date + "','" + tätigkeit + "','" + stunden + "' ,'" + kosten + "')");
			}

			this.DialogResult = DialogResult.OK;


			this.Close();
		}


		private void bu_Custom_Checkbox_CheckedChanged(object sender, EventArgs e)
		{
			if (bu_Custom_CheckBox.Checked == true)
			{
				custom_Box.Enabled = true;
				tätigkeits_Box.Enabled = false;
			}
			else
			{
				custom_Box.Enabled = false;
				tätigkeits_Box.Enabled = true;
			}
		}

		private bool isValid()
		{
			bool valid = true;

			if (stunden_Box.Text == "")
				valid = false;
			if (stunden_Box.Value <= 0)
				valid = false;
			if (!kosten_Box.IsValid) 
				valid = false; 

			return valid;
		}

		private void kosten_Box_TextChanged(object sender, EventArgs e)
		{
			if (isValid())
				book_Booking_Butt.Enabled = true;
			else
				book_Booking_Butt.Enabled = false;
		}

		private void stunden_Box_ValueChanged(object sender, EventArgs e)
		{
			if (isValid())
				book_Booking_Butt.Enabled = true;
			else
				book_Booking_Butt.Enabled = false;
		}

	}
}
