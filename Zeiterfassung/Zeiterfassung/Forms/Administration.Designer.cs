namespace Zeiterfassung
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.administrationTab = new System.Windows.Forms.TabControl();
            this.kunden_Tab = new System.Windows.Forms.TabPage();
            this.mitarbeiter_Tab = new System.Windows.Forms.TabPage();
            this.projekt_Tab = new System.Windows.Forms.TabPage();
            this.close_Butt = new System.Windows.Forms.Button();
            this.administrationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // administrationTab
            // 
            this.administrationTab.Controls.Add(this.kunden_Tab);
            this.administrationTab.Controls.Add(this.mitarbeiter_Tab);
            this.administrationTab.Controls.Add(this.projekt_Tab);
            this.administrationTab.Location = new System.Drawing.Point(6, 12);
            this.administrationTab.Name = "administrationTab";
            this.administrationTab.SelectedIndex = 0;
            this.administrationTab.Size = new System.Drawing.Size(533, 525);
            this.administrationTab.TabIndex = 0;
            // 
            // kunden_Tab
            // 
            this.kunden_Tab.Location = new System.Drawing.Point(4, 22);
            this.kunden_Tab.Name = "kunden_Tab";
            this.kunden_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.kunden_Tab.Size = new System.Drawing.Size(525, 499);
            this.kunden_Tab.TabIndex = 0;
            this.kunden_Tab.Text = "Kunden";
            this.kunden_Tab.UseVisualStyleBackColor = true;
            this.kunden_Tab.Enter += new System.EventHandler(this.kunden_Tab_Enter);
            // 
            // mitarbeiter_Tab
            // 
            this.mitarbeiter_Tab.Location = new System.Drawing.Point(4, 22);
            this.mitarbeiter_Tab.Name = "mitarbeiter_Tab";
            this.mitarbeiter_Tab.Size = new System.Drawing.Size(525, 499);
            this.mitarbeiter_Tab.TabIndex = 2;
            this.mitarbeiter_Tab.Text = "Mitarbeiter";
            this.mitarbeiter_Tab.UseVisualStyleBackColor = true;
            this.mitarbeiter_Tab.Enter += new System.EventHandler(this.mitarbeiter_Tab_Enter);
            // 
            // projekt_Tab
            // 
            this.projekt_Tab.Location = new System.Drawing.Point(4, 22);
            this.projekt_Tab.Name = "projekt_Tab";
            this.projekt_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.projekt_Tab.Size = new System.Drawing.Size(525, 499);
            this.projekt_Tab.TabIndex = 1;
            this.projekt_Tab.Text = "Projekte";
            this.projekt_Tab.UseVisualStyleBackColor = true;
            this.projekt_Tab.Enter += new System.EventHandler(this.projekt_Tab_Enter);
            // 
            // close_Butt
            // 
            this.close_Butt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_Butt.Location = new System.Drawing.Point(458, 543);
            this.close_Butt.Name = "close_Butt";
            this.close_Butt.Size = new System.Drawing.Size(75, 23);
            this.close_Butt.TabIndex = 1;
            this.close_Butt.Text = "Schließen";
            this.close_Butt.UseVisualStyleBackColor = true;
            this.close_Butt.Click += new System.EventHandler(this.close_Butt_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close_Butt;
            this.ClientSize = new System.Drawing.Size(538, 572);
            this.Controls.Add(this.close_Butt);
            this.Controls.Add(this.administrationTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administration";
            this.Text = "Administration";
            this.administrationTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl administrationTab;
        private System.Windows.Forms.TabPage kunden_Tab;
        private System.Windows.Forms.TabPage projekt_Tab;
        private System.Windows.Forms.TabPage mitarbeiter_Tab;
        private System.Windows.Forms.Button close_Butt;
    }
}