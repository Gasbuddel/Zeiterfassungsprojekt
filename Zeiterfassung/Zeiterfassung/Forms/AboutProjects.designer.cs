namespace Zeiterfassung
{
    partial class AboutProjects
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectBoxProjekt = new System.Windows.Forms.ListBox();
            this.textgesZeit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMA = new System.Windows.Forms.TextBox();
            this.mitarbeit_List = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prozent = new System.Windows.Forms.TextBox();
            this.imProjekt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gesZeit = new System.Windows.Forms.TextBox();
            this.visualisieren = new System.Windows.Forms.Button();
            this.Projekt = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.abbr_Butt = new System.Windows.Forms.Button();
            this.Projekt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectBoxProjekt
            // 
            this.selectBoxProjekt.FormattingEnabled = true;
            this.selectBoxProjekt.Location = new System.Drawing.Point(2, 13);
            this.selectBoxProjekt.Name = "selectBoxProjekt";
            this.selectBoxProjekt.Size = new System.Drawing.Size(120, 212);
            this.selectBoxProjekt.TabIndex = 0;
            this.selectBoxProjekt.SelectedIndexChanged += new System.EventHandler(this.selectBoxProjekt_SelectedIndexChanged);
            // 
            // textgesZeit
            // 
            this.textgesZeit.Location = new System.Drawing.Point(140, 30);
            this.textgesZeit.Name = "textgesZeit";
            this.textgesZeit.ReadOnly = true;
            this.textgesZeit.Size = new System.Drawing.Size(100, 20);
            this.textgesZeit.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "gesamte geleistete Zeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anzahl Mitarbeiter";
            // 
            // textMA
            // 
            this.textMA.Location = new System.Drawing.Point(140, 81);
            this.textMA.Name = "textMA";
            this.textMA.ReadOnly = true;
            this.textMA.Size = new System.Drawing.Size(100, 20);
            this.textMA.TabIndex = 4;
            // 
            // mitarbeit_List
            // 
            this.mitarbeit_List.FormattingEnabled = true;
            this.mitarbeit_List.Location = new System.Drawing.Point(15, 19);
            this.mitarbeit_List.Name = "mitarbeit_List";
            this.mitarbeit_List.Size = new System.Drawing.Size(120, 212);
            this.mitarbeit_List.TabIndex = 8;
            this.mitarbeit_List.SelectedIndexChanged += new System.EventHandler(this.mitarbeit_List_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "gesamte geleistete Zeit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Anteil Projekt in Prozent";
            // 
            // prozent
            // 
            this.prozent.Location = new System.Drawing.Point(166, 110);
            this.prozent.Name = "prozent";
            this.prozent.ReadOnly = true;
            this.prozent.Size = new System.Drawing.Size(113, 20);
            this.prozent.TabIndex = 14;
            // 
            // imProjekt
            // 
            this.imProjekt.Location = new System.Drawing.Point(166, 68);
            this.imProjekt.Name = "imProjekt";
            this.imProjekt.ReadOnly = true;
            this.imProjekt.Size = new System.Drawing.Size(116, 20);
            this.imProjekt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "im Projekt";
            // 
            // gesZeit
            // 
            this.gesZeit.Location = new System.Drawing.Point(166, 29);
            this.gesZeit.Name = "gesZeit";
            this.gesZeit.ReadOnly = true;
            this.gesZeit.Size = new System.Drawing.Size(116, 20);
            this.gesZeit.TabIndex = 10;
            // 
            // visualisieren
            // 
            this.visualisieren.Location = new System.Drawing.Point(423, 266);
            this.visualisieren.Name = "visualisieren";
            this.visualisieren.Size = new System.Drawing.Size(75, 23);
            this.visualisieren.TabIndex = 16;
            this.visualisieren.Text = "Visualisieren";
            this.visualisieren.UseVisualStyleBackColor = true;
            this.visualisieren.Click += new System.EventHandler(this.visualisieren_Click);
            // 
            // Projekt
            // 
            this.Projekt.Controls.Add(this.label3);
            this.Projekt.Controls.Add(this.textMA);
            this.Projekt.Controls.Add(this.label2);
            this.Projekt.Controls.Add(this.textgesZeit);
            this.Projekt.Controls.Add(this.selectBoxProjekt);
            this.Projekt.Location = new System.Drawing.Point(10, 16);
            this.Projekt.Name = "Projekt";
            this.Projekt.Size = new System.Drawing.Size(271, 245);
            this.Projekt.TabIndex = 17;
            this.Projekt.TabStop = false;
            this.Projekt.Text = "Mitarbeiter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.prozent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.imProjekt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gesZeit);
            this.groupBox1.Controls.Add(this.mitarbeit_List);
            this.groupBox1.Location = new System.Drawing.Point(287, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 244);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mitarbeiter";
            // 
            // abbr_Butt
            // 
            this.abbr_Butt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abbr_Butt.Location = new System.Drawing.Point(504, 266);
            this.abbr_Butt.Name = "abbr_Butt";
            this.abbr_Butt.Size = new System.Drawing.Size(75, 23);
            this.abbr_Butt.TabIndex = 19;
            this.abbr_Butt.Text = "Abbrechen";
            this.abbr_Butt.UseVisualStyleBackColor = true;
            this.abbr_Butt.Click += new System.EventHandler(this.abbr_Butt_Click);
            // 
            // AboutProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.abbr_Butt;
            this.ClientSize = new System.Drawing.Size(597, 301);
            this.Controls.Add(this.abbr_Butt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Projekt);
            this.Controls.Add(this.visualisieren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutProjects";
            this.Text = "Projektübersicht";
            this.Projekt.ResumeLayout(false);
            this.Projekt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox selectBoxProjekt;
        private System.Windows.Forms.TextBox textgesZeit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMA;
        private System.Windows.Forms.ListBox mitarbeit_List;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prozent;
        private System.Windows.Forms.TextBox imProjekt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gesZeit;
        private System.Windows.Forms.Button visualisieren;
        private System.Windows.Forms.GroupBox Projekt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button abbr_Butt;
    }
}