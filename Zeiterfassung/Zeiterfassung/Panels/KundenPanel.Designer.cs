namespace Zeiterfassung
{
    partial class KundenPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ku_Delete_Butt = new System.Windows.Forms.Button();
            this.ku_Ok_Butt = new System.Windows.Forms.Button();
            this.ku_Cancel_Butt = new System.Windows.Forms.Button();
            this.ku_fax_box = new Zeiterfassung.RegExTextbox();
            this.ku_tel_box = new Zeiterfassung.RegExTextbox();
            this.ku_ort_box = new Zeiterfassung.RegExTextbox();
            this.ku_plz_box = new Zeiterfassung.RegExTextbox();
            this.ku_str_box = new Zeiterfassung.RegExTextbox();
            this.ku_mail_box = new Zeiterfassung.RegExTextbox();
            this.ku_anspr_box = new Zeiterfassung.RegExTextbox();
            this.ku_firma_box = new Zeiterfassung.RegExTextbox();
            this.label20 = new System.Windows.Forms.Label();
            this.label_anspr = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ku_Bearb_Butt = new System.Windows.Forms.Button();
            this.ku_New_Button = new System.Windows.Forms.Button();
            this.kunden_box = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ku_Delete_Butt);
            this.groupBox1.Controls.Add(this.ku_Ok_Butt);
            this.groupBox1.Controls.Add(this.ku_Cancel_Butt);
            this.groupBox1.Controls.Add(this.ku_fax_box);
            this.groupBox1.Controls.Add(this.ku_tel_box);
            this.groupBox1.Controls.Add(this.ku_ort_box);
            this.groupBox1.Controls.Add(this.ku_plz_box);
            this.groupBox1.Controls.Add(this.ku_str_box);
            this.groupBox1.Controls.Add(this.ku_mail_box);
            this.groupBox1.Controls.Add(this.ku_anspr_box);
            this.groupBox1.Controls.Add(this.ku_firma_box);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label_anspr);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ku_Bearb_Butt);
            this.groupBox1.Controls.Add(this.ku_New_Button);
            this.groupBox1.Location = new System.Drawing.Point(10, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 281);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunden bearbeiten";
            // 
            // ku_Delete_Butt
            // 
            this.ku_Delete_Butt.Location = new System.Drawing.Point(379, 73);
            this.ku_Delete_Butt.Name = "ku_Delete_Butt";
            this.ku_Delete_Butt.Size = new System.Drawing.Size(120, 23);
            this.ku_Delete_Butt.TabIndex = 24;
            this.ku_Delete_Butt.Text = "Kunde entfernen";
            this.ku_Delete_Butt.UseVisualStyleBackColor = true;
            this.ku_Delete_Butt.Click += new System.EventHandler(this.ku_Delete_Butt_Click);
            // 
            // ku_Ok_Butt
            // 
            this.ku_Ok_Butt.Enabled = false;
            this.ku_Ok_Butt.Location = new System.Drawing.Point(345, 252);
            this.ku_Ok_Butt.Name = "ku_Ok_Butt";
            this.ku_Ok_Butt.Size = new System.Drawing.Size(75, 23);
            this.ku_Ok_Butt.TabIndex = 23;
            this.ku_Ok_Butt.Text = "Annehmen";
            this.ku_Ok_Butt.UseVisualStyleBackColor = true;
            this.ku_Ok_Butt.Click += new System.EventHandler(this.ku_Ok_Butt_Click);
            // 
            // ku_Cancel_Butt
            // 
            this.ku_Cancel_Butt.Enabled = false;
            this.ku_Cancel_Butt.Location = new System.Drawing.Point(426, 252);
            this.ku_Cancel_Butt.Name = "ku_Cancel_Butt";
            this.ku_Cancel_Butt.Size = new System.Drawing.Size(75, 23);
            this.ku_Cancel_Butt.TabIndex = 22;
            this.ku_Cancel_Butt.Text = "Abbrechen";
            this.ku_Cancel_Butt.UseVisualStyleBackColor = true;
            this.ku_Cancel_Butt.Click += new System.EventHandler(this.ku_Cancel_Butt_Click);
            // 
            // ku_fax_box
            // 
            this.ku_fax_box.Location = new System.Drawing.Point(108, 224);
            this.ku_fax_box.MaxLength = 32;
            this.ku_fax_box.Name = "ku_fax_box";
            this.ku_fax_box.Regular_Expression = "^\\d*$";
            this.ku_fax_box.Size = new System.Drawing.Size(208, 20);
            this.ku_fax_box.TabIndex = 21;
            this.ku_fax_box.ToolTipText = "Es sind nur Zahlen erlaubt.";
            this.ku_fax_box.TextChanged += new System.EventHandler(this.ku_fax_box_TextChanged);
            // 
            // ku_tel_box
            // 
            this.ku_tel_box.Location = new System.Drawing.Point(108, 198);
            this.ku_tel_box.MaxLength = 32;
            this.ku_tel_box.Name = "ku_tel_box";
            this.ku_tel_box.Regular_Expression = "^\\d*$";
            this.ku_tel_box.Size = new System.Drawing.Size(208, 20);
            this.ku_tel_box.TabIndex = 20;
            this.ku_tel_box.ToolTipText = "Es sind nur Zahlen erlaubt.";
            this.ku_tel_box.TextChanged += new System.EventHandler(this.ku_tel_box_TextChanged);
            // 
            // ku_ort_box
            // 
            this.ku_ort_box.Location = new System.Drawing.Point(107, 172);
            this.ku_ort_box.MaxLength = 64;
            this.ku_ort_box.Name = "ku_ort_box";
            this.ku_ort_box.Regular_Expression = "^[\\w|\\s\\.\\-\\,\\&]*$";
            this.ku_ort_box.Size = new System.Drawing.Size(209, 20);
            this.ku_ort_box.TabIndex = 19;
            this.ku_ort_box.ToolTipText = "Es sind keine Sonderzeichen erlaubt.";
            this.ku_ort_box.TextChanged += new System.EventHandler(this.ku_ort_box_TextChanged);
            // 
            // ku_plz_box
            // 
            this.ku_plz_box.Location = new System.Drawing.Point(107, 146);
            this.ku_plz_box.MaxLength = 5;
            this.ku_plz_box.Name = "ku_plz_box";
            this.ku_plz_box.Regular_Expression = "^\\d{5,5}$";
            this.ku_plz_box.Size = new System.Drawing.Size(82, 20);
            this.ku_plz_box.TabIndex = 18;
            this.ku_plz_box.ToolTipText = "Es sind nur Zahlen erlaubt und die Postleitzahl besteht aus mindestens 5 Zeichen." +
                "";
            this.ku_plz_box.TextChanged += new System.EventHandler(this.ku_plz_box_TextChanged);
            // 
            // ku_str_box
            // 
            this.ku_str_box.Location = new System.Drawing.Point(107, 114);
            this.ku_str_box.MaxLength = 65;
            this.ku_str_box.Name = "ku_str_box";
            this.ku_str_box.Regular_Expression = "^[\\w|\\s\\.\\-\\,\\&]*$";
            this.ku_str_box.Size = new System.Drawing.Size(209, 20);
            this.ku_str_box.TabIndex = 17;
            this.ku_str_box.ToolTipText = "Es sind keine Sonderzeichen erlaubt.";
            this.ku_str_box.TextChanged += new System.EventHandler(this.ku_str_box_TextChanged);
            // 
            // ku_mail_box
            // 
            this.ku_mail_box.Location = new System.Drawing.Point(108, 82);
            this.ku_mail_box.MaxLength = 32;
            this.ku_mail_box.Name = "ku_mail_box";
            this.ku_mail_box.Regular_Expression = "^[\\-_\\.\\w\\d]+@[\\-_\\.\\w\\d]+\\.\\w+$";
            this.ku_mail_box.Size = new System.Drawing.Size(208, 20);
            this.ku_mail_box.TabIndex = 16;
            this.ku_mail_box.ToolTipText = "Falsches Format, Beispiel: horst@horst.de";
            this.ku_mail_box.TextChanged += new System.EventHandler(this.ku_mail_box_TextChanged);
            // 
            // ku_anspr_box
            // 
            this.ku_anspr_box.Location = new System.Drawing.Point(107, 52);
            this.ku_anspr_box.MaxLength = 64;
            this.ku_anspr_box.Name = "ku_anspr_box";
            this.ku_anspr_box.Regular_Expression = "^[\\w|\\s\\.\\-\\,\\&]*$";
            this.ku_anspr_box.Size = new System.Drawing.Size(209, 20);
            this.ku_anspr_box.TabIndex = 15;
            this.ku_anspr_box.ToolTipText = "Es sind keine Sonderzeichen erlaubt.";
            this.ku_anspr_box.TextChanged += new System.EventHandler(this.ku_anspr_box_TextChanged);
            // 
            // ku_firma_box
            // 
            this.ku_firma_box.Location = new System.Drawing.Point(108, 19);
            this.ku_firma_box.MaxLength = 64;
            this.ku_firma_box.Name = "ku_firma_box";
            this.ku_firma_box.Regular_Expression = "^[\\w|\\s\\.\\-\\,\\&]*$";
            this.ku_firma_box.Size = new System.Drawing.Size(208, 20);
            this.ku_firma_box.TabIndex = 14;
            this.ku_firma_box.ToolTipText = "Es sind keine Sonderzeichen erlaubt.";
            this.ku_firma_box.TextChanged += new System.EventHandler(this.ku_firma_box_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "E-Mail";
            // 
            // label_anspr
            // 
            this.label_anspr.AutoSize = true;
            this.label_anspr.Location = new System.Drawing.Point(13, 52);
            this.label_anspr.Name = "label_anspr";
            this.label_anspr.Size = new System.Drawing.Size(88, 13);
            this.label_anspr.TabIndex = 12;
            this.label_anspr.Text = "Ansprechpartner:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 227);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Fax:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Tel:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Ort:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "PLZ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Straße:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Firma:";
            // 
            // ku_Bearb_Butt
            // 
            this.ku_Bearb_Butt.Location = new System.Drawing.Point(379, 43);
            this.ku_Bearb_Butt.Name = "ku_Bearb_Butt";
            this.ku_Bearb_Butt.Size = new System.Drawing.Size(120, 23);
            this.ku_Bearb_Butt.TabIndex = 5;
            this.ku_Bearb_Butt.Text = "Bearbeiten";
            this.ku_Bearb_Butt.UseVisualStyleBackColor = true;
            this.ku_Bearb_Butt.Click += new System.EventHandler(this.ku_Bearb_Butt_Click);
            // 
            // ku_New_Button
            // 
            this.ku_New_Button.Location = new System.Drawing.Point(379, 14);
            this.ku_New_Button.Name = "ku_New_Button";
            this.ku_New_Button.Size = new System.Drawing.Size(120, 23);
            this.ku_New_Button.TabIndex = 2;
            this.ku_New_Button.Text = "Neuer Kunde";
            this.ku_New_Button.UseVisualStyleBackColor = true;
            this.ku_New_Button.Click += new System.EventHandler(this.ku_New_Button_Click);
            // 
            // kunden_box
            // 
            this.kunden_box.FormattingEnabled = true;
            this.kunden_box.Location = new System.Drawing.Point(9, 25);
            this.kunden_box.Name = "kunden_box";
            this.kunden_box.Size = new System.Drawing.Size(509, 173);
            this.kunden_box.TabIndex = 27;
            this.kunden_box.SelectedIndexChanged += new System.EventHandler(this.kunden_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kundenübersicht:";
            // 
            // KundenPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kunden_box);
            this.Controls.Add(this.label1);
            this.Name = "KundenPanel";
            this.Size = new System.Drawing.Size(525, 499);
            this.Enter += new System.EventHandler(this.KundenPanel_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ku_Ok_Butt;
        private System.Windows.Forms.Button ku_Cancel_Butt;
        private RegExTextbox ku_fax_box;
        private RegExTextbox ku_tel_box;
        private RegExTextbox ku_ort_box;
        private RegExTextbox ku_plz_box;
        private RegExTextbox ku_str_box;
        private RegExTextbox ku_mail_box;
        private RegExTextbox ku_anspr_box;
        private RegExTextbox ku_firma_box;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label_anspr;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ku_Bearb_Butt;
        private System.Windows.Forms.Button ku_New_Button;
        private System.Windows.Forms.ListBox kunden_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ku_Delete_Butt;
    }
}
