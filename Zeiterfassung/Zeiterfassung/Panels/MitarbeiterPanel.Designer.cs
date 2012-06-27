namespace Zeiterfassung
{
    partial class MitarbeiterPanel
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userNameTB = new Zeiterfassung.RegExTextbox();
            this.mi_Cancel_Butt = new System.Windows.Forms.Button();
            this.mi_PW_Butt = new System.Windows.Forms.Button();
            this.mi_Del_Butt = new System.Windows.Forms.Button();
            this.mi_New_Butt = new System.Windows.Forms.Button();
            this.mi_Change_Butt = new System.Windows.Forms.Button();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mailTB = new Zeiterfassung.RegExTextbox();
            this.vornameTB = new Zeiterfassung.RegExTextbox();
            this.nameTB = new Zeiterfassung.RegExTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userNameTB);
            this.groupBox2.Controls.Add(this.mi_Cancel_Butt);
            this.groupBox2.Controls.Add(this.mi_PW_Butt);
            this.groupBox2.Controls.Add(this.mi_Del_Butt);
            this.groupBox2.Controls.Add(this.mi_New_Butt);
            this.groupBox2.Controls.Add(this.mi_Change_Butt);
            this.groupBox2.Controls.Add(this.roleBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mailTB);
            this.groupBox2.Controls.Add(this.vornameTB);
            this.groupBox2.Controls.Add(this.nameTB);
            this.groupBox2.Location = new System.Drawing.Point(10, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 281);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Benutzer bearbeiten";
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(88, 20);
            this.userNameTB.MaxLength = 32;
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.ReadOnly = true;
            this.userNameTB.Regular_Expression = "^[\\w|\\s\\.\\-\\,\\&]*$";
            this.userNameTB.Size = new System.Drawing.Size(209, 20);
            this.userNameTB.TabIndex = 1;
            this.userNameTB.ToolTipText = "Es sind keine Sonderzeichen erlaubt.";
            // 
            // mi_Cancel_Butt
            // 
            this.mi_Cancel_Butt.Location = new System.Drawing.Point(13, 173);
            this.mi_Cancel_Butt.Name = "mi_Cancel_Butt";
            this.mi_Cancel_Butt.Size = new System.Drawing.Size(115, 34);
            this.mi_Cancel_Butt.TabIndex = 20;
            this.mi_Cancel_Butt.Text = "Abbrechen";
            this.mi_Cancel_Butt.UseVisualStyleBackColor = true;
            this.mi_Cancel_Butt.Visible = false;
            this.mi_Cancel_Butt.Click += new System.EventHandler(this.mi_Cancel_Butt_Click);
            // 
            // mi_PW_Butt
            // 
            this.mi_PW_Butt.Location = new System.Drawing.Point(252, 133);
            this.mi_PW_Butt.Name = "mi_PW_Butt";
            this.mi_PW_Butt.Size = new System.Drawing.Size(115, 34);
            this.mi_PW_Butt.TabIndex = 15;
            this.mi_PW_Butt.Text = "Passwort zurücksetzen";
            this.mi_PW_Butt.UseVisualStyleBackColor = true;
            this.mi_PW_Butt.Click += new System.EventHandler(this.mi_PW_Butt_Click);
            // 
            // mi_Del_Butt
            // 
            this.mi_Del_Butt.Location = new System.Drawing.Point(373, 133);
            this.mi_Del_Butt.Name = "mi_Del_Butt";
            this.mi_Del_Butt.Size = new System.Drawing.Size(115, 34);
            this.mi_Del_Butt.TabIndex = 14;
            this.mi_Del_Butt.Text = "Mitarbeiter entfernen";
            this.mi_Del_Butt.UseVisualStyleBackColor = true;
            this.mi_Del_Butt.Click += new System.EventHandler(this.mi_Del_Butt_Click);
            // 
            // mi_New_Butt
            // 
            this.mi_New_Butt.Location = new System.Drawing.Point(13, 133);
            this.mi_New_Butt.Name = "mi_New_Butt";
            this.mi_New_Butt.Size = new System.Drawing.Size(115, 34);
            this.mi_New_Butt.TabIndex = 13;
            this.mi_New_Butt.Text = "Neuer Mitarbeiter";
            this.mi_New_Butt.UseVisualStyleBackColor = true;
            this.mi_New_Butt.Click += new System.EventHandler(this.mit_New_Butt_Click);
            // 
            // mi_Change_Butt
            // 
            this.mi_Change_Butt.Location = new System.Drawing.Point(131, 133);
            this.mi_Change_Butt.Name = "mi_Change_Butt";
            this.mi_Change_Butt.Size = new System.Drawing.Size(115, 34);
            this.mi_Change_Butt.TabIndex = 12;
            this.mi_Change_Butt.Text = "Bearbeiten";
            this.mi_Change_Butt.UseVisualStyleBackColor = true;
            this.mi_Change_Butt.Click += new System.EventHandler(this.mi_Change_Butt_Click);
            // 
            // roleBox
            // 
            this.roleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleBox.Enabled = false;
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(342, 19);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(159, 21);
            this.roleBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Rolle:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "E-Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Vorname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Benutzername:";
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(88, 84);
            this.mailTB.MaxLength = 32;
            this.mailTB.Name = "mailTB";
            this.mailTB.ReadOnly = true;
            this.mailTB.Regular_Expression = "^[\\-_\\.\\w\\d]+@[\\-_\\.\\w\\d]+\\.\\w+$";
            this.mailTB.Size = new System.Drawing.Size(254, 20);
            this.mailTB.TabIndex = 4;
            this.mailTB.ToolTipText = "Falsches Format, Beispiel: horst@horst.de";
            // 
            // vornameTB
            // 
            this.vornameTB.Location = new System.Drawing.Point(345, 51);
            this.vornameTB.MaxLength = 32;
            this.vornameTB.Name = "vornameTB";
            this.vornameTB.ReadOnly = true;
            this.vornameTB.Regular_Expression = "^[\\w|\\s\\.\\-\\,\\&]*$";
            this.vornameTB.Size = new System.Drawing.Size(156, 20);
            this.vornameTB.TabIndex = 3;
            this.vornameTB.ToolTipText = "Es sind keine Sonderzeichen erlaubt.";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(88, 51);
            this.nameTB.MaxLength = 32;
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Regular_Expression = "^[\\w|\\s\\.\\-\\,\\&]*$";
            this.nameTB.Size = new System.Drawing.Size(130, 20);
            this.nameTB.TabIndex = 2;
            this.nameTB.ToolTipText = "Es sind keine Sonderzeichen erlaubt.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 101;
            this.label11.Text = "Mitarbeiterübersicht:";
            // 
            // userNameBox
            // 
            this.userNameBox.FormattingEnabled = true;
            this.userNameBox.Location = new System.Drawing.Point(9, 27);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(509, 173);
            this.userNameBox.TabIndex = 103;
            this.userNameBox.SelectedIndexChanged += new System.EventHandler(this.userNameBox_SelectedIndexChanged_1);
            // 
            // MitarbeiterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.userNameBox);
            this.Name = "MitarbeiterPanel";
            this.Size = new System.Drawing.Size(525, 499);
            this.Enter += new System.EventHandler(this.MitarbeiterPanel_Enter);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private RegExTextbox userNameTB;
        private System.Windows.Forms.Button mi_Cancel_Butt;
        private System.Windows.Forms.Button mi_PW_Butt;
        private System.Windows.Forms.Button mi_Del_Butt;
        private System.Windows.Forms.Button mi_New_Butt;
        private System.Windows.Forms.Button mi_Change_Butt;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private RegExTextbox mailTB;
        private RegExTextbox vornameTB;
        private RegExTextbox nameTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox userNameBox;
    }
}
