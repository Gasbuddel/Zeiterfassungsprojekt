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
    public partial class NewTaet : Form
    {
        private int proID;

        public NewTaet(int proID)
        {
            InitializeComponent();

            this.proID = proID;
        }

        private void ok_Butt_Click(object sender, EventArgs e)
        {
            SqlConnection.ExecuteStatement("INSERT INTO ttaetigkeitenvorlage (taBeschreibung) " +
                "VALUES ( '" + tätDesc_Box.Text + "')");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_Butt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
