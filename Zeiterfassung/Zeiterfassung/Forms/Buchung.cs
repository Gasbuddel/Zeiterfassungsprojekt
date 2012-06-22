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
		}

		private void book_Cancel_Butt_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void book_Booking_Butt_Click(object sender, EventArgs e)
		{

			decimal h = Convert.ToDecimal(stunden_Box.Text);
			decimal k = Convert.ToDecimal(kosten_Box.Text);
			string aktiv1 = tätigkeits_Box.Text.ToString();

			DateTime da = buchungsDatum.Value;
			string date = da.ToString("yyyy-MM-dd");
			string aktiv2 = custom_Box.Text.ToString();

			if (bu_Custom_CheckBox.Checked == true)
			{
				SqlConnection.ExecuteStatement("insert into tzeiterfassung (miID, prID, zeTag, zeTaetigkeit, zeDauer, zeReisekosten) values(" + Session.GetSession().UserId + "," + Session.GetSession().ProId + ",'" + date + "','" + aktiv2 + "'," + h + " ," + k + ")");
			}

			else
			{
				SqlConnection.ExecuteStatement("insert into tzeiterfassung (miID, prID, zeTag, zeTaetigkeit, zeDauer, zeReisekosten) values(" + Session.GetSession().UserId + "," + Session.GetSession().ProId + ",'" + date + "','" + aktiv1 + "'," + h + " ," + k + ")");
			}



			this.Close();
		}


		private void bu_Custom_Checkbox_CheckedChanged(object sender, EventArgs e)
		{

			if (bu_Custom_CheckBox.Checked == true)
			{

				tätigkeits_Box.Enabled = false;


			}

			else
			{
				tätigkeits_Box.Enabled = true;


			}

		}
	}
}
