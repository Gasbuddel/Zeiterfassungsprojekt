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
            this.tabbi = new System.Windows.Forms.TabControl();
            this.kunden_Tab = new System.Windows.Forms.TabPage();
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
            this.label1 = new System.Windows.Forms.Label();
            this.kunden_box = new System.Windows.Forms.ComboBox();
            this.mitarbeiter_Tab = new System.Windows.Forms.TabPage();
            this.mi_Cancel_Butt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mi_PW_Butt = new System.Windows.Forms.Button();
            this.mi_Del_Butt = new System.Windows.Forms.Button();
            this.mit_New_Butt = new System.Windows.Forms.Button();
            this.mi_Save_Butt = new System.Windows.Forms.Button();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mailTB = new Zeiterfassung.RegExTextbox();
            this.vornameTB = new Zeiterfassung.RegExTextbox();
            this.nameTB = new Zeiterfassung.RegExTextbox();
            this.projekt_Tab = new System.Windows.Forms.TabPage();
            this.proID = new System.Windows.Forms.Label();
            this.buttonTKEdit = new System.Windows.Forms.Button();
            this.buttonTKDelete = new System.Windows.Forms.Button();
            this.buttonMAdelete = new System.Windows.Forms.Button();
            this.buttonTKassign = new System.Windows.Forms.Button();
            this.buttonMAassign = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listTaetigkeit = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listMitarbeiter = new System.Windows.Forms.ListBox();
            this.textPBeschreibung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textKunde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttoneditPro = new System.Windows.Forms.Button();
            this.buttonnewPro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBProjekt = new System.Windows.Forms.ComboBox();
            this.close_Butt = new System.Windows.Forms.Button();
            this.tabbi.SuspendLayout();
            this.kunden_Tab.SuspendLayout();
            this.mitarbeiter_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.projekt_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabbi
            // 
            this.tabbi.Controls.Add(this.kunden_Tab);
            this.tabbi.Controls.Add(this.mitarbeiter_Tab);
            this.tabbi.Controls.Add(this.projekt_Tab);
            this.tabbi.Location = new System.Drawing.Point(4, 3);
            this.tabbi.Name = "tabbi";
            this.tabbi.SelectedIndex = 0;
            this.tabbi.Size = new System.Drawing.Size(533, 538);
            this.tabbi.TabIndex = 0;
            this.tabbi.SelectedIndexChanged += new System.EventHandler(this.tabbi_SelectedIndexChanged);
            // 
            // kunden_Tab
            // 
            this.kunden_Tab.Controls.Add(this.ku_Ok_Butt);
            this.kunden_Tab.Controls.Add(this.ku_Cancel_Butt);
            this.kunden_Tab.Controls.Add(this.ku_fax_box);
            this.kunden_Tab.Controls.Add(this.ku_tel_box);
            this.kunden_Tab.Controls.Add(this.ku_ort_box);
            this.kunden_Tab.Controls.Add(this.ku_plz_box);
            this.kunden_Tab.Controls.Add(this.ku_str_box);
            this.kunden_Tab.Controls.Add(this.ku_mail_box);
            this.kunden_Tab.Controls.Add(this.ku_anspr_box);
            this.kunden_Tab.Controls.Add(this.ku_firma_box);
            this.kunden_Tab.Controls.Add(this.label20);
            this.kunden_Tab.Controls.Add(this.label_anspr);
            this.kunden_Tab.Controls.Add(this.label18);
            this.kunden_Tab.Controls.Add(this.label17);
            this.kunden_Tab.Controls.Add(this.label16);
            this.kunden_Tab.Controls.Add(this.label15);
            this.kunden_Tab.Controls.Add(this.label14);
            this.kunden_Tab.Controls.Add(this.label3);
            this.kunden_Tab.Controls.Add(this.ku_Bearb_Butt);
            this.kunden_Tab.Controls.Add(this.ku_New_Button);
            this.kunden_Tab.Controls.Add(this.label1);
            this.kunden_Tab.Controls.Add(this.kunden_box);
            this.kunden_Tab.Location = new System.Drawing.Point(4, 22);
            this.kunden_Tab.Name = "kunden_Tab";
            this.kunden_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.kunden_Tab.Size = new System.Drawing.Size(525, 512);
            this.kunden_Tab.TabIndex = 0;
            this.kunden_Tab.Text = "Kunden";
            this.kunden_Tab.UseVisualStyleBackColor = true;
            this.kunden_Tab.Enter += new System.EventHandler(this.kunden_Tab_Enter);
            // 
            // ku_Ok_Butt
            // 
            this.ku_Ok_Butt.Location = new System.Drawing.Point(342, 385);
            this.ku_Ok_Butt.Name = "ku_Ok_Butt";
            this.ku_Ok_Butt.Size = new System.Drawing.Size(75, 23);
            this.ku_Ok_Butt.TabIndex = 23;
            this.ku_Ok_Butt.Text = "Annehmen";
            this.ku_Ok_Butt.UseVisualStyleBackColor = true;
            this.ku_Ok_Butt.Click += new System.EventHandler(this.ku_Ok_Butt_Click);
            // 
            // ku_Cancel_Butt
            // 
            this.ku_Cancel_Butt.Location = new System.Drawing.Point(423, 385);
            this.ku_Cancel_Butt.Name = "ku_Cancel_Butt";
            this.ku_Cancel_Butt.Size = new System.Drawing.Size(75, 23);
            this.ku_Cancel_Butt.TabIndex = 22;
            this.ku_Cancel_Butt.Text = "Abbrechen";
            this.ku_Cancel_Butt.UseVisualStyleBackColor = true;
            this.ku_Cancel_Butt.Click += new System.EventHandler(this.ku_Cancel_Butt_Click);
            // 
            // ku_fax_box
            // 
            this.ku_fax_box.Location = new System.Drawing.Point(101, 289);
            this.ku_fax_box.Name = "ku_fax_box";
            this.ku_fax_box.Regular_Expression = null;
            this.ku_fax_box.Size = new System.Drawing.Size(208, 20);
            this.ku_fax_box.TabIndex = 21;
            // 
            // ku_tel_box
            // 
            this.ku_tel_box.Location = new System.Drawing.Point(101, 243);
            this.ku_tel_box.Name = "ku_tel_box";
            this.ku_tel_box.Regular_Expression = null;
            this.ku_tel_box.Size = new System.Drawing.Size(208, 20);
            this.ku_tel_box.TabIndex = 20;
            // 
            // ku_ort_box
            // 
            this.ku_ort_box.Location = new System.Drawing.Point(100, 200);
            this.ku_ort_box.Name = "ku_ort_box";
            this.ku_ort_box.Regular_Expression = null;
            this.ku_ort_box.Size = new System.Drawing.Size(209, 20);
            this.ku_ort_box.TabIndex = 19;
            // 
            // ku_plz_box
            // 
            this.ku_plz_box.Location = new System.Drawing.Point(100, 174);
            this.ku_plz_box.Name = "ku_plz_box";
            this.ku_plz_box.Regular_Expression = null;
            this.ku_plz_box.Size = new System.Drawing.Size(82, 20);
            this.ku_plz_box.TabIndex = 18;
            // 
            // ku_str_box
            // 
            this.ku_str_box.Location = new System.Drawing.Point(100, 142);
            this.ku_str_box.Name = "ku_str_box";
            this.ku_str_box.Regular_Expression = null;
            this.ku_str_box.Size = new System.Drawing.Size(209, 20);
            this.ku_str_box.TabIndex = 17;
            // 
            // ku_mail_box
            // 
            this.ku_mail_box.Location = new System.Drawing.Point(101, 110);
            this.ku_mail_box.Name = "ku_mail_box";
            this.ku_mail_box.Regular_Expression = null;
            this.ku_mail_box.Size = new System.Drawing.Size(208, 20);
            this.ku_mail_box.TabIndex = 16;
            // 
            // ku_anspr_box
            // 
            this.ku_anspr_box.Location = new System.Drawing.Point(100, 80);
            this.ku_anspr_box.Name = "ku_anspr_box";
            this.ku_anspr_box.Regular_Expression = null;
            this.ku_anspr_box.Size = new System.Drawing.Size(209, 20);
            this.ku_anspr_box.TabIndex = 15;
            // 
            // ku_firma_box
            // 
            this.ku_firma_box.Location = new System.Drawing.Point(101, 47);
            this.ku_firma_box.Name = "ku_firma_box";
            this.ku_firma_box.Regular_Expression = null;
            this.ku_firma_box.Size = new System.Drawing.Size(208, 20);
            this.ku_firma_box.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "E-Mail";
            // 
            // label_anspr
            // 
            this.label_anspr.AutoSize = true;
            this.label_anspr.Location = new System.Drawing.Point(6, 80);
            this.label_anspr.Name = "label_anspr";
            this.label_anspr.Size = new System.Drawing.Size(88, 13);
            this.label_anspr.TabIndex = 12;
            this.label_anspr.Text = "Ansprechpartner:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Fax:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Tel:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Ort:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "PLZ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Straße:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Firma:";
            // 
            // ku_Bearb_Butt
            // 
            this.ku_Bearb_Butt.Location = new System.Drawing.Point(423, 37);
            this.ku_Bearb_Butt.Name = "ku_Bearb_Butt";
            this.ku_Bearb_Butt.Size = new System.Drawing.Size(95, 23);
            this.ku_Bearb_Butt.TabIndex = 5;
            this.ku_Bearb_Butt.Text = "Bearbeiten";
            this.ku_Bearb_Butt.UseVisualStyleBackColor = true;
            this.ku_Bearb_Butt.Click += new System.EventHandler(this.ku_Bearb_Butt_Click);
            // 
            // ku_New_Button
            // 
            this.ku_New_Button.Location = new System.Drawing.Point(423, 8);
            this.ku_New_Button.Name = "ku_New_Button";
            this.ku_New_Button.Size = new System.Drawing.Size(95, 23);
            this.ku_New_Button.TabIndex = 2;
            this.ku_New_Button.Text = "Neuer Kunde";
            this.ku_New_Button.UseVisualStyleBackColor = true;
            this.ku_New_Button.Click += new System.EventHandler(this.ku_New_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kunde:";
            // 
            // kunden_box
            // 
            this.kunden_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kunden_box.FormattingEnabled = true;
            this.kunden_box.Location = new System.Drawing.Point(53, 10);
            this.kunden_box.Name = "kunden_box";
            this.kunden_box.Size = new System.Drawing.Size(256, 21);
            this.kunden_box.TabIndex = 0;
            this.kunden_box.SelectedIndexChanged += new System.EventHandler(this.kunden_box_SelectedIndexChanged);
            // 
            // mitarbeiter_Tab
            // 
            this.mitarbeiter_Tab.Controls.Add(this.mi_Cancel_Butt);
            this.mitarbeiter_Tab.Controls.Add(this.pictureBox1);
            this.mitarbeiter_Tab.Controls.Add(this.mi_PW_Butt);
            this.mitarbeiter_Tab.Controls.Add(this.mi_Del_Butt);
            this.mitarbeiter_Tab.Controls.Add(this.mit_New_Butt);
            this.mitarbeiter_Tab.Controls.Add(this.mi_Save_Butt);
            this.mitarbeiter_Tab.Controls.Add(this.roleBox);
            this.mitarbeiter_Tab.Controls.Add(this.label13);
            this.mitarbeiter_Tab.Controls.Add(this.label12);
            this.mitarbeiter_Tab.Controls.Add(this.label10);
            this.mitarbeiter_Tab.Controls.Add(this.label9);
            this.mitarbeiter_Tab.Controls.Add(this.userNameBox);
            this.mitarbeiter_Tab.Controls.Add(this.label8);
            this.mitarbeiter_Tab.Controls.Add(this.mailTB);
            this.mitarbeiter_Tab.Controls.Add(this.vornameTB);
            this.mitarbeiter_Tab.Controls.Add(this.nameTB);
            this.mitarbeiter_Tab.Location = new System.Drawing.Point(4, 22);
            this.mitarbeiter_Tab.Name = "mitarbeiter_Tab";
            this.mitarbeiter_Tab.Size = new System.Drawing.Size(525, 512);
            this.mitarbeiter_Tab.TabIndex = 2;
            this.mitarbeiter_Tab.Text = "Mitarbeiter";
            this.mitarbeiter_Tab.UseVisualStyleBackColor = true;
            // 
            // mi_Cancel_Butt
            // 
            this.mi_Cancel_Butt.Location = new System.Drawing.Point(85, 137);
            this.mi_Cancel_Butt.Name = "mi_Cancel_Butt";
            this.mi_Cancel_Butt.Size = new System.Drawing.Size(112, 23);
            this.mi_Cancel_Butt.TabIndex = 20;
            this.mi_Cancel_Butt.Text = "Abbrechen";
            this.mi_Cancel_Butt.UseVisualStyleBackColor = true;
            this.mi_Cancel_Butt.Click += new System.EventHandler(this.mit_New_Butt_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zeiterfassung.Properties.Resources.work_in_progress;
            this.pictureBox1.Location = new System.Drawing.Point(10, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // mi_PW_Butt
            // 
            this.mi_PW_Butt.Location = new System.Drawing.Point(261, 97);
            this.mi_PW_Butt.Name = "mi_PW_Butt";
            this.mi_PW_Butt.Size = new System.Drawing.Size(115, 34);
            this.mi_PW_Butt.TabIndex = 15;
            this.mi_PW_Butt.Text = "Passwort zurücksetzen";
            this.mi_PW_Butt.UseVisualStyleBackColor = true;
            this.mi_PW_Butt.Click += new System.EventHandler(this.mi_PW_Butt_Click);
            // 
            // mi_Del_Butt
            // 
            this.mi_Del_Butt.Location = new System.Drawing.Point(394, 103);
            this.mi_Del_Butt.Name = "mi_Del_Butt";
            this.mi_Del_Butt.Size = new System.Drawing.Size(124, 23);
            this.mi_Del_Butt.TabIndex = 14;
            this.mi_Del_Butt.Text = "Mitarbeiter entfernen";
            this.mi_Del_Butt.UseVisualStyleBackColor = true;
            this.mi_Del_Butt.Click += new System.EventHandler(this.mi_Del_Butt_Click);
            // 
            // mit_New_Butt
            // 
            this.mit_New_Butt.Location = new System.Drawing.Point(10, 103);
            this.mit_New_Butt.Name = "mit_New_Butt";
            this.mit_New_Butt.Size = new System.Drawing.Size(112, 23);
            this.mit_New_Butt.TabIndex = 13;
            this.mit_New_Butt.Text = "Neuer Mitarbeiter";
            this.mit_New_Butt.UseVisualStyleBackColor = true;
            this.mit_New_Butt.Click += new System.EventHandler(this.mit_New_Butt_Click);
            // 
            // mi_Save_Butt
            // 
            this.mi_Save_Butt.Location = new System.Drawing.Point(140, 97);
            this.mi_Save_Butt.Name = "mi_Save_Butt";
            this.mi_Save_Butt.Size = new System.Drawing.Size(115, 34);
            this.mi_Save_Butt.TabIndex = 12;
            this.mi_Save_Butt.Text = "Ändern";
            this.mi_Save_Butt.UseVisualStyleBackColor = true;
            this.mi_Save_Butt.Click += new System.EventHandler(this.mi_Save_Butt_Click);
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(359, 6);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(159, 21);
            this.roleBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(318, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Rolle:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "E-Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Vorname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name:";
            // 
            // userNameBox
            // 
            this.userNameBox.FormattingEnabled = true;
            this.userNameBox.Location = new System.Drawing.Point(88, 6);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(222, 21);
            this.userNameBox.TabIndex = 1;
            this.userNameBox.SelectedValueChanged += new System.EventHandler(this.userNameBox_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Benutzername:";
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(85, 71);
            this.mailTB.Name = "mailTB";
            this.mailTB.Regular_Expression = null;
            this.mailTB.Size = new System.Drawing.Size(254, 20);
            this.mailTB.TabIndex = 19;
            // 
            // vornameTB
            // 
            this.vornameTB.Location = new System.Drawing.Point(360, 38);
            this.vornameTB.Name = "vornameTB";
            this.vornameTB.Regular_Expression = null;
            this.vornameTB.Size = new System.Drawing.Size(126, 20);
            this.vornameTB.TabIndex = 18;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(88, 38);
            this.nameTB.Name = "nameTB";
            this.nameTB.Regular_Expression = null;
            this.nameTB.Size = new System.Drawing.Size(127, 20);
            this.nameTB.TabIndex = 17;
            // 
            // projekt_Tab
            // 
            this.projekt_Tab.Controls.Add(this.proID);
            this.projekt_Tab.Controls.Add(this.buttonTKEdit);
            this.projekt_Tab.Controls.Add(this.buttonTKDelete);
            this.projekt_Tab.Controls.Add(this.buttonMAdelete);
            this.projekt_Tab.Controls.Add(this.buttonTKassign);
            this.projekt_Tab.Controls.Add(this.buttonMAassign);
            this.projekt_Tab.Controls.Add(this.label7);
            this.projekt_Tab.Controls.Add(this.listTaetigkeit);
            this.projekt_Tab.Controls.Add(this.label6);
            this.projekt_Tab.Controls.Add(this.listMitarbeiter);
            this.projekt_Tab.Controls.Add(this.textPBeschreibung);
            this.projekt_Tab.Controls.Add(this.label5);
            this.projekt_Tab.Controls.Add(this.textKunde);
            this.projekt_Tab.Controls.Add(this.label4);
            this.projekt_Tab.Controls.Add(this.buttoneditPro);
            this.projekt_Tab.Controls.Add(this.buttonnewPro);
            this.projekt_Tab.Controls.Add(this.label2);
            this.projekt_Tab.Controls.Add(this.cBProjekt);
            this.projekt_Tab.Location = new System.Drawing.Point(4, 22);
            this.projekt_Tab.Name = "projekt_Tab";
            this.projekt_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.projekt_Tab.Size = new System.Drawing.Size(525, 512);
            this.projekt_Tab.TabIndex = 1;
            this.projekt_Tab.Text = "Projekte";
            this.projekt_Tab.UseVisualStyleBackColor = true;
            // 
            // proID
            // 
            this.proID.AutoSize = true;
            this.proID.Location = new System.Drawing.Point(302, 12);
            this.proID.Name = "proID";
            this.proID.Size = new System.Drawing.Size(41, 13);
            this.proID.TabIndex = 17;
            this.proID.Text = "label11";
            // 
            // buttonTKEdit
            // 
            this.buttonTKEdit.Location = new System.Drawing.Point(418, 356);
            this.buttonTKEdit.Name = "buttonTKEdit";
            this.buttonTKEdit.Size = new System.Drawing.Size(99, 34);
            this.buttonTKEdit.TabIndex = 16;
            this.buttonTKEdit.Text = "Tätigkeit bearbeiten";
            this.buttonTKEdit.UseVisualStyleBackColor = true;
            // 
            // buttonTKDelete
            // 
            this.buttonTKDelete.Location = new System.Drawing.Point(419, 407);
            this.buttonTKDelete.Name = "buttonTKDelete";
            this.buttonTKDelete.Size = new System.Drawing.Size(99, 34);
            this.buttonTKDelete.TabIndex = 15;
            this.buttonTKDelete.Text = "Tätigkeit entfernen";
            this.buttonTKDelete.UseVisualStyleBackColor = true;
            // 
            // buttonMAdelete
            // 
            this.buttonMAdelete.Location = new System.Drawing.Point(418, 259);
            this.buttonMAdelete.Name = "buttonMAdelete";
            this.buttonMAdelete.Size = new System.Drawing.Size(99, 41);
            this.buttonMAdelete.TabIndex = 14;
            this.buttonMAdelete.Text = "Mitarbeiter entfernen";
            this.buttonMAdelete.UseVisualStyleBackColor = true;
            // 
            // buttonTKassign
            // 
            this.buttonTKassign.Location = new System.Drawing.Point(419, 307);
            this.buttonTKassign.Name = "buttonTKassign";
            this.buttonTKassign.Size = new System.Drawing.Size(99, 34);
            this.buttonTKassign.TabIndex = 13;
            this.buttonTKassign.Text = "Tätigkeit hinzufügen";
            this.buttonTKassign.UseVisualStyleBackColor = true;
            // 
            // buttonMAassign
            // 
            this.buttonMAassign.Location = new System.Drawing.Point(419, 205);
            this.buttonMAassign.Name = "buttonMAassign";
            this.buttonMAassign.Size = new System.Drawing.Size(99, 41);
            this.buttonMAassign.TabIndex = 12;
            this.buttonMAassign.Text = "Mitarbeiter zuweisen";
            this.buttonMAassign.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tätigkeiten:";
            // 
            // listTaetigkeit
            // 
            this.listTaetigkeit.FormattingEnabled = true;
            this.listTaetigkeit.Location = new System.Drawing.Point(119, 307);
            this.listTaetigkeit.Name = "listTaetigkeit";
            this.listTaetigkeit.Size = new System.Drawing.Size(293, 134);
            this.listTaetigkeit.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mitarbeiter:";
            // 
            // listMitarbeiter
            // 
            this.listMitarbeiter.FormattingEnabled = true;
            this.listMitarbeiter.Location = new System.Drawing.Point(119, 204);
            this.listMitarbeiter.Name = "listMitarbeiter";
            this.listMitarbeiter.Size = new System.Drawing.Size(293, 95);
            this.listMitarbeiter.TabIndex = 8;
            // 
            // textPBeschreibung
            // 
            this.textPBeschreibung.Location = new System.Drawing.Point(119, 95);
            this.textPBeschreibung.Multiline = true;
            this.textPBeschreibung.Name = "textPBeschreibung";
            this.textPBeschreibung.ReadOnly = true;
            this.textPBeschreibung.Size = new System.Drawing.Size(293, 103);
            this.textPBeschreibung.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Projektbeschreibung:";
            // 
            // textKunde
            // 
            this.textKunde.Location = new System.Drawing.Point(119, 66);
            this.textKunde.Name = "textKunde";
            this.textKunde.ReadOnly = true;
            this.textKunde.Size = new System.Drawing.Size(224, 20);
            this.textKunde.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kunde:";
            // 
            // buttoneditPro
            // 
            this.buttoneditPro.Location = new System.Drawing.Point(418, 36);
            this.buttoneditPro.Name = "buttoneditPro";
            this.buttoneditPro.Size = new System.Drawing.Size(100, 23);
            this.buttoneditPro.TabIndex = 3;
            this.buttoneditPro.Text = "Bearbeiten";
            this.buttoneditPro.UseVisualStyleBackColor = true;
            // 
            // buttonnewPro
            // 
            this.buttonnewPro.Location = new System.Drawing.Point(418, 7);
            this.buttonnewPro.Name = "buttonnewPro";
            this.buttonnewPro.Size = new System.Drawing.Size(100, 23);
            this.buttonnewPro.TabIndex = 2;
            this.buttonnewPro.Text = "Projekt anlegen";
            this.buttonnewPro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Projekt:";
            // 
            // cBProjekt
            // 
            this.cBProjekt.FormattingEnabled = true;
            this.cBProjekt.Location = new System.Drawing.Point(55, 9);
            this.cBProjekt.Name = "cBProjekt";
            this.cBProjekt.Size = new System.Drawing.Size(224, 21);
            this.cBProjekt.TabIndex = 0;
            this.cBProjekt.SelectedValueChanged += new System.EventHandler(this.cBProjekt_SelectedValueChanged);
            // 
            // close_Butt
            // 
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
            this.ClientSize = new System.Drawing.Size(538, 572);
            this.Controls.Add(this.close_Butt);
            this.Controls.Add(this.tabbi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administration";
            this.Text = "Administration";
            this.tabbi.ResumeLayout(false);
            this.kunden_Tab.ResumeLayout(false);
            this.kunden_Tab.PerformLayout();
            this.mitarbeiter_Tab.ResumeLayout(false);
            this.mitarbeiter_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.projekt_Tab.ResumeLayout(false);
            this.projekt_Tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabbi;
        private System.Windows.Forms.TabPage kunden_Tab;
        private System.Windows.Forms.TabPage projekt_Tab;
        private System.Windows.Forms.TabPage mitarbeiter_Tab;
        private System.Windows.Forms.Button close_Butt;
        private System.Windows.Forms.Button buttoneditPro;
        private System.Windows.Forms.Button buttonnewPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBProjekt;
        private System.Windows.Forms.Button buttonTKEdit;
        private System.Windows.Forms.Button buttonTKDelete;
        private System.Windows.Forms.Button buttonMAdelete;
        private System.Windows.Forms.Button buttonTKassign;
        private System.Windows.Forms.Button buttonMAassign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listTaetigkeit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listMitarbeiter;
        private System.Windows.Forms.TextBox textPBeschreibung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textKunde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox userNameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Button mi_Del_Butt;
        private System.Windows.Forms.Button mit_New_Butt;
        private System.Windows.Forms.Button mi_Save_Butt;
        private System.Windows.Forms.Button mi_PW_Butt;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kunden_box;
        private System.Windows.Forms.Button ku_Ok_Butt;
        private System.Windows.Forms.Button ku_Cancel_Butt;
        private RegExTextbox mailTB;
        private RegExTextbox vornameTB;
        private RegExTextbox nameTB;
        private System.Windows.Forms.Button mi_Cancel_Butt;
        private System.Windows.Forms.Label proID;
    }
}