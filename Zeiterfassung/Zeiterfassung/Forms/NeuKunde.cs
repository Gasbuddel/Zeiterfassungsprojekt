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
    public partial class NeuKunde : Form
    {
        public NeuKunde()
        {
            InitializeComponent();
        }

        private void NeuKunde_Load(object sender, EventArgs e)
        {

        }

        private void anl_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abbr_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
