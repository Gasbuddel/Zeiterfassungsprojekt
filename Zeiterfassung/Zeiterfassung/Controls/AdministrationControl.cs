using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Zeiterfassung
{
    public class AdministrationControl
    {
        private Administration administration;

        public AdministrationControl()
        {
            administration = new Administration(this);
            administration.StartPosition = FormStartPosition.CenterScreen;

            administration.ProjektAusgewählt = new Administration.delAktualisiereProjekt(delAktualisiereProjekt);
        }

        //Ausgewählten Tab direkt anzeigen
        public void ShowAdministration(int tab)
        {
            administration.TabSelect(tab);
            administration.ShowDialog();
        }

        #region 'ProjektAdministration'

        //Ausgewähltes Projekt
        private int selectedProject;

        public int SelectedProject 
        {
            get { return selectedProject; }
        }

        private void delAktualisiereProjekt(int projektId)
        {
            this.selectedProject = projektId;
        }

        #endregion


    }
}
