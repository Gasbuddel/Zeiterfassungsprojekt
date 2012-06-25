namespace Zeiterfassung
{
    partial class ProjektePanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.beschr_Box = new Zeiterfassung.RegExTextbox();
            this.pro_Bearb_Abbr_Butt = new System.Windows.Forms.Button();
            this.pro_New_Tät_Butt = new System.Windows.Forms.Button();
            this.pro_Tät_Entf_Butt = new System.Windows.Forms.Button();
            this.deleteArbeiter = new System.Windows.Forms.Button();
            this.pro_Add_Tät_Butt = new System.Windows.Forms.Button();
            this.addWorkerToProject_butt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kund_Box = new Zeiterfassung.RegExTextbox();
            this.taet_List = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mitarbeit_List = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pro_Bearb_Butt = new System.Windows.Forms.Button();
            this.newPro_Butt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selectBoxProjekt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // beschr_Box
            // 
            this.beschr_Box.Location = new System.Drawing.Point(136, 102);
            this.beschr_Box.MaxLength = 128;
            this.beschr_Box.Multiline = true;
            this.beschr_Box.Name = "beschr_Box";
            this.beschr_Box.ReadOnly = true;
            this.beschr_Box.Regular_Expression = "";
            this.beschr_Box.Size = new System.Drawing.Size(366, 75);
            this.beschr_Box.TabIndex = 54;
            this.beschr_Box.ToolTipText = "";
            // 
            // pro_Bearb_Abbr_Butt
            // 
            this.pro_Bearb_Abbr_Butt.Location = new System.Drawing.Point(425, 43);
            this.pro_Bearb_Abbr_Butt.Name = "pro_Bearb_Abbr_Butt";
            this.pro_Bearb_Abbr_Butt.Size = new System.Drawing.Size(75, 23);
            this.pro_Bearb_Abbr_Butt.TabIndex = 53;
            this.pro_Bearb_Abbr_Butt.Text = "Abbrechen";
            this.pro_Bearb_Abbr_Butt.UseVisualStyleBackColor = true;
            this.pro_Bearb_Abbr_Butt.Visible = false;
            this.pro_Bearb_Abbr_Butt.Click += new System.EventHandler(this.pro_Bearb_Abbr_Butt_Click);
            // 
            // pro_New_Tät_Butt
            // 
            this.pro_New_Tät_Butt.Location = new System.Drawing.Point(269, 459);
            this.pro_New_Tät_Butt.Name = "pro_New_Tät_Butt";
            this.pro_New_Tät_Butt.Size = new System.Drawing.Size(112, 26);
            this.pro_New_Tät_Butt.TabIndex = 51;
            this.pro_New_Tät_Butt.Text = "Neue Tätigkeit";
            this.pro_New_Tät_Butt.UseVisualStyleBackColor = true;
            this.pro_New_Tät_Butt.Click += new System.EventHandler(this.pro_New_Tät_Butt_Click);
            // 
            // pro_Tät_Entf_Butt
            // 
            this.pro_Tät_Entf_Butt.Location = new System.Drawing.Point(398, 459);
            this.pro_Tät_Entf_Butt.Name = "pro_Tät_Entf_Butt";
            this.pro_Tät_Entf_Butt.Size = new System.Drawing.Size(104, 26);
            this.pro_Tät_Entf_Butt.TabIndex = 50;
            this.pro_Tät_Entf_Butt.Text = "Tätigkeit entfernen";
            this.pro_Tät_Entf_Butt.UseVisualStyleBackColor = true;
            this.pro_Tät_Entf_Butt.Click += new System.EventHandler(this.pro_Tät_Entf_Butt_Click);
            // 
            // deleteArbeiter
            // 
            this.deleteArbeiter.Location = new System.Drawing.Point(347, 311);
            this.deleteArbeiter.Name = "deleteArbeiter";
            this.deleteArbeiter.Size = new System.Drawing.Size(155, 25);
            this.deleteArbeiter.TabIndex = 49;
            this.deleteArbeiter.Text = "Mitarbeiter entfernen";
            this.deleteArbeiter.UseVisualStyleBackColor = true;
            this.deleteArbeiter.Click += new System.EventHandler(this.deleteArbeiter_Click);
            // 
            // pro_Add_Tät_Butt
            // 
            this.pro_Add_Tät_Butt.Location = new System.Drawing.Point(135, 459);
            this.pro_Add_Tät_Butt.Name = "pro_Add_Tät_Butt";
            this.pro_Add_Tät_Butt.Size = new System.Drawing.Size(118, 26);
            this.pro_Add_Tät_Butt.TabIndex = 48;
            this.pro_Add_Tät_Butt.Text = "Tätigkeit hinzufügen";
            this.pro_Add_Tät_Butt.UseVisualStyleBackColor = true;
            this.pro_Add_Tät_Butt.Click += new System.EventHandler(this.pro_Add_Tät_Butt_Click);
            // 
            // addWorkerToProject_butt
            // 
            this.addWorkerToProject_butt.Location = new System.Drawing.Point(135, 311);
            this.addWorkerToProject_butt.Name = "addWorkerToProject_butt";
            this.addWorkerToProject_butt.Size = new System.Drawing.Size(155, 24);
            this.addWorkerToProject_butt.TabIndex = 47;
            this.addWorkerToProject_butt.Text = "Mitarbeiter zuweisen";
            this.addWorkerToProject_butt.UseVisualStyleBackColor = true;
            this.addWorkerToProject_butt.Click += new System.EventHandler(this.addWorkerToProject_butt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Tätigkeiten:";
            // 
            // kund_Box
            // 
            this.kund_Box.Location = new System.Drawing.Point(135, 73);
            this.kund_Box.Name = "kund_Box";
            this.kund_Box.ReadOnly = true;
            this.kund_Box.Regular_Expression = null;
            this.kund_Box.Size = new System.Drawing.Size(367, 20);
            this.kund_Box.TabIndex = 52;
            this.kund_Box.ToolTipText = null;
            // 
            // taet_List
            // 
            this.taet_List.FormattingEnabled = true;
            this.taet_List.Location = new System.Drawing.Point(135, 363);
            this.taet_List.Name = "taet_List";
            this.taet_List.Size = new System.Drawing.Size(367, 82);
            this.taet_List.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Mitarbeiter:";
            // 
            // mitarbeit_List
            // 
            this.mitarbeit_List.FormattingEnabled = true;
            this.mitarbeit_List.Location = new System.Drawing.Point(135, 183);
            this.mitarbeit_List.Name = "mitarbeit_List";
            this.mitarbeit_List.Size = new System.Drawing.Size(367, 121);
            this.mitarbeit_List.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Projektbeschreibung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Kunde:";
            // 
            // pro_Bearb_Butt
            // 
            this.pro_Bearb_Butt.Location = new System.Drawing.Point(425, 13);
            this.pro_Bearb_Butt.Name = "pro_Bearb_Butt";
            this.pro_Bearb_Butt.Size = new System.Drawing.Size(77, 23);
            this.pro_Bearb_Butt.TabIndex = 40;
            this.pro_Bearb_Butt.Text = "Bearbeiten";
            this.pro_Bearb_Butt.UseVisualStyleBackColor = true;
            this.pro_Bearb_Butt.Click += new System.EventHandler(this.pro_Bearb_Butt_Click);
            // 
            // newPro_Butt
            // 
            this.newPro_Butt.Location = new System.Drawing.Point(325, 13);
            this.newPro_Butt.Name = "newPro_Butt";
            this.newPro_Butt.Size = new System.Drawing.Size(94, 23);
            this.newPro_Butt.TabIndex = 39;
            this.newPro_Butt.Text = "Projekt anlegen";
            this.newPro_Butt.UseVisualStyleBackColor = true;
            this.newPro_Butt.Click += new System.EventHandler(this.newPro_Butt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Projekt:";
            // 
            // selectBoxProjekt
            // 
            this.selectBoxProjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBoxProjekt.FormattingEnabled = true;
            this.selectBoxProjekt.Location = new System.Drawing.Point(135, 13);
            this.selectBoxProjekt.Name = "selectBoxProjekt";
            this.selectBoxProjekt.Size = new System.Drawing.Size(184, 21);
            this.selectBoxProjekt.TabIndex = 37;
            this.selectBoxProjekt.SelectedIndexChanged += new System.EventHandler(this.selectBoxProjekt_SelectedIndexChanged);
            // 
            // ProjektePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.beschr_Box);
            this.Controls.Add(this.pro_Bearb_Abbr_Butt);
            this.Controls.Add(this.pro_New_Tät_Butt);
            this.Controls.Add(this.pro_Tät_Entf_Butt);
            this.Controls.Add(this.deleteArbeiter);
            this.Controls.Add(this.pro_Add_Tät_Butt);
            this.Controls.Add(this.addWorkerToProject_butt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kund_Box);
            this.Controls.Add(this.taet_List);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mitarbeit_List);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pro_Bearb_Butt);
            this.Controls.Add(this.newPro_Butt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectBoxProjekt);
            this.Name = "ProjektePanel";
            this.Size = new System.Drawing.Size(525, 499);
            this.Enter += new System.EventHandler(this.ProjektePanel_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegExTextbox beschr_Box;
        private System.Windows.Forms.Button pro_Bearb_Abbr_Butt;
        private System.Windows.Forms.Button pro_New_Tät_Butt;
        private System.Windows.Forms.Button pro_Tät_Entf_Butt;
        private System.Windows.Forms.Button deleteArbeiter;
        private System.Windows.Forms.Button pro_Add_Tät_Butt;
        private System.Windows.Forms.Button addWorkerToProject_butt;
        private System.Windows.Forms.Label label7;
        private RegExTextbox kund_Box;
        private System.Windows.Forms.ListBox taet_List;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox mitarbeit_List;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pro_Bearb_Butt;
        private System.Windows.Forms.Button newPro_Butt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectBoxProjekt;
    }
}
