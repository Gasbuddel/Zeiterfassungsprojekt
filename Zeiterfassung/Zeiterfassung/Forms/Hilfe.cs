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
    public partial class Hilfe : Form
    {
        public Hilfe()
        {
            InitializeComponent();
            string address = Application.StartupPath + "hilfe\\hilfe-login.html"; 
                
            webBrowser1.Navigate(new Uri(address));

            int role = Session.GetSession().Authorization;

            if (role == 1)
            {
                treeView1.Nodes.Add("Administration");
                treeView1.Nodes.Add("Kunde");
                treeView1.Nodes.Add("Mitarbeiter");
                treeView1.Nodes.Add("Projekte");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.ToString() == "TreeNode: Hauptmenü") 
            {
                string address = Application.StartupPath + "\\hilfe\\hilfe-haupt.html";
                webBrowser1.Navigate(new Uri(address));
            }

            if (treeView1.SelectedNode.ToString() == "TreeNode: Login")
            {
                string address = Application.StartupPath + "\\hilfe\\hilfe-login.html";
                webBrowser1.Navigate(new Uri(address));
            }

            if (treeView1.SelectedNode.ToString() == "TreeNode: Hilfe")
            {
                string address = Application.StartupPath + "\\hilfe\\hilfe-hilfe.html";
                webBrowser1.Navigate(new Uri(address));
            }

            if (treeView1.SelectedNode.ToString() == "TreeNode: Hilfe")
            {
                string address = Application.StartupPath + "\\hilfe\\hilfe-hilfe.html";
                webBrowser1.Navigate(new Uri(address));
            }
            
            if (treeView1.SelectedNode.ToString() == "TreeNode: Administration")
            {
                string address = Application.StartupPath + "\\hilfe\\hilfe-admin.html";
                webBrowser1.Navigate(new Uri(address));
            }

            if (treeView1.SelectedNode.ToString() == "TreeNode: Kunde")
            {
                string address = Application.StartupPath + "\\hilfe\\hilfe-kunde.html";
                webBrowser1.Navigate(new Uri(address));
            }

            if (treeView1.SelectedNode.ToString() == "TreeNode: Mitarbeiter")
            {
                string address = Application.StartupPath + "\\hilfe\\hilfe-mitarbeiter.html";
                webBrowser1.Navigate(new Uri(address));
            }

            if (treeView1.SelectedNode.ToString() == "TreeNode: Projekte")
            {
                string address = Application.StartupPath + "\\hilfe\\hilfe-projekte.html";
                webBrowser1.Navigate(new Uri(address));
            }
        }

        private void help_Close_Butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
