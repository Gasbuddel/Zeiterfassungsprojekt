namespace Zeiterfassung
{
    partial class Hilfe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Login");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hauptmenü");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Hilfe");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.help_Close_Butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Login";
            treeNode1.Text = "Login";
            treeNode2.Name = "Haupt";
            treeNode2.Text = "Hauptmenü";
            treeNode3.Name = "Hilfe";
            treeNode3.Text = "Hilfe";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(143, 616);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(161, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(480, 616);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // help_Close_Butt
            // 
            this.help_Close_Butt.Location = new System.Drawing.Point(566, 635);
            this.help_Close_Butt.Name = "help_Close_Butt";
            this.help_Close_Butt.Size = new System.Drawing.Size(75, 23);
            this.help_Close_Butt.TabIndex = 2;
            this.help_Close_Butt.Text = "Schließen";
            this.help_Close_Butt.UseVisualStyleBackColor = true;
            this.help_Close_Butt.Click += new System.EventHandler(this.help_Close_Butt_Click);
            // 
            // Hilfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 666);
            this.Controls.Add(this.help_Close_Butt);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hilfe";
            this.Text = "Hilfe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button help_Close_Butt;
    }
}