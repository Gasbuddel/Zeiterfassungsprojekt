using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Zeiterfassung
{
    public partial class MitPie : Form
    {
        public MitPie(int miID, int akPro)
        {
            InitializeComponent();
            this.MinimumSize = new Size(300, 300);
            this.MaximumSize = new Size(800, 500);
            chart1.Size = new Size(this.Width - 10, this.Height - 10);
            DataTable arbeiter = SqlConnection.SelectStatement("SELECT prName,sum( zeDauer ) as sum,miName,miVorname FROM tzeiterfassung LEFT JOIN tProjekt using (prID) LEFT JOIN tMitarbeiter using (miID) WHERE miID =" + miID + " GROUP BY prID");
            DataTableReader reader = arbeiter.CreateDataReader();

            Series a = chart1.Series[0];
           

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                    DataPoint p = new DataPoint();
                    p.SetValueY(Convert.ToDouble(reader["sum"].ToString()));
                    p.AxisLabel = reader["prName"].ToString();
                    p.IsValueShownAsLabel = true;
                    a.Points.Add(p);
                    
                }
                Mitarbeiter.Text = reader["miVorname"].ToString() + " " + reader["miName"].ToString();
            }
            
        }

        private void MitPie_Resize(object sender, EventArgs e)
        {
            Mitarbeiter.Size = new Size(this.Width/40,this.Height / 40);            
                chart1.Size =  new Size(this.Width-10,this.Height-10);
            
        }
    }

}
