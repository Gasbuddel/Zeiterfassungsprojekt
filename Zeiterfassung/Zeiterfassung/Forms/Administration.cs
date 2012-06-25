using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zeiterfassung
{
    public partial class Administration : Form
    {
        //Delegate, um das aktuell augewählte Projekt zu aktualisieren
        public delegate void delAktualisiereProjekt(int projektId);

        public delAktualisiereProjekt ProjektAusgewählt;

        private KundenPanel kundPanel;
        private MitarbeiterPanel mitPanel;
        private ProjektePanel proPanel;

        public Administration()
        {
            InitializeComponent();
        }

        private void close_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TabSelect(int tab)
        {
            if (tab >= 0 && tab <= 2)
                administrationTab.SelectedIndex = tab;
        }


        //KundenTab wird angezeigt
        private void kunden_Tab_Enter(object sender, EventArgs e)
        {
            if (kundPanel == null)
            {
                kundPanel = new KundenPanel();
                kunden_Tab.Controls.Add(kundPanel);
                kundPanel.Select();
            }
            else
                kundPanel.Select();
        }

        private void mitarbeiter_Tab_Enter(object sender, EventArgs e)
        {
            if (mitPanel == null)
            {
                mitPanel = new MitarbeiterPanel();
                mitarbeiter_Tab.Controls.Add(mitPanel);
                mitPanel.Select();
            }
            else
                mitPanel.Select();
        }

        private void projekt_Tab_Enter(object sender, EventArgs e)
        {
            if (proPanel == null)
            {
                proPanel = new ProjektePanel();
                projekt_Tab.Controls.Add(proPanel);
                proPanel.Select();
            }
            else
                proPanel.Select();
        }












 


























    }
}
