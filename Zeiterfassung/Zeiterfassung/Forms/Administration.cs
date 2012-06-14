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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NeuKunde neuKund = new NeuKunde();
            neuKund.StartPosition = FormStartPosition.CenterParent;
            neuKund.ShowDialog();
        }

        private void bearb_Butt_Click(object sender, EventArgs e)
        {
            NeuKunde neuKund = new NeuKunde();
            neuKund.StartPosition = FormStartPosition.CenterParent;
            neuKund.ShowDialog();
        }

        private void close_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mitarbeiter_Tab_Click(object sender, EventArgs e)
        {

        }
    }
}
