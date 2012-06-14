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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_Cancel_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void book_Booking_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
