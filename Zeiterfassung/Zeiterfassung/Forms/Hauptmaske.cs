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

        public Hauptmaske()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Login login = new Login();
            if (login.ShowDialog() != DialogResult.OK)
                Environment.Exit(0);
            //New
            if (Session.GetSession().Authorization == 2)
            {
                administrationToolStripMenuItem.Enabled = false;
                administrationToolStripMenuItem.Visible = false;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancel_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buch_Butt_Click(object sender, EventArgs e)
        {
            Buchung buch = new Buchung();
            buch.StartPosition = FormStartPosition.CenterParent;
            buch.ShowDialog(this);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kundenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration admin = new Administration();
            admin.StartPosition = FormStartPosition.CenterParent;
            admin.ShowDialog();
        }
    }
}
