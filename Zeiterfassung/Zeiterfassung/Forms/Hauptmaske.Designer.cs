namespace Zeiterfassung
{
	partial class Hauptmaske
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptmaske));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buch_Butt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabelleGebuchteZeiten = new System.Windows.Forms.DataGridView();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reisekosten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tätigkeitsbeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zeit_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anzeigeTag = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pro_Box = new System.Windows.Forms.ComboBox();
            this.cancel_Butt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelleGebuchteZeiten)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kundenToolStripMenuItem,
            this.mitarbeiterToolStripMenuItem,
            this.projekteToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // kundenToolStripMenuItem
            // 
            this.kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
            this.kundenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.kundenToolStripMenuItem.Text = "Kunden";
            this.kundenToolStripMenuItem.Click += new System.EventHandler(this.kundenToolStripMenuItem_Click);
            // 
            // mitarbeiterToolStripMenuItem
            // 
            this.mitarbeiterToolStripMenuItem.Name = "mitarbeiterToolStripMenuItem";
            this.mitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mitarbeiterToolStripMenuItem.Text = "Mitarbeiter";
            this.mitarbeiterToolStripMenuItem.Click += new System.EventHandler(this.projekteToolStripMenuItem_Click);
            // 
            // projekteToolStripMenuItem
            // 
            this.projekteToolStripMenuItem.Name = "projekteToolStripMenuItem";
            this.projekteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.projekteToolStripMenuItem.Text = "Projekte";
            this.projekteToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeÖffnenToolStripMenuItem,
            this.überToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // hilfeÖffnenToolStripMenuItem
            // 
            this.hilfeÖffnenToolStripMenuItem.Name = "hilfeÖffnenToolStripMenuItem";
            this.hilfeÖffnenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hilfeÖffnenToolStripMenuItem.Text = "Hilfe öffnen";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buch_Butt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tabelleGebuchteZeiten);
            this.groupBox1.Controls.Add(this.cost_Box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.zeit_Box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.anzeigeTag);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pro_Box);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zeit erfassen";
            // 
            // buch_Butt
            // 
            this.buch_Butt.Location = new System.Drawing.Point(566, 299);
            this.buch_Butt.Name = "buch_Butt";
            this.buch_Butt.Size = new System.Drawing.Size(140, 23);
            this.buch_Butt.TabIndex = 11;
            this.buch_Butt.Text = "Zeit buchen";
            this.buch_Butt.UseVisualStyleBackColor = true;
            this.buch_Butt.Click += new System.EventHandler(this.buch_Butt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gebuchte Zeiten:";
            // 
            // tabelleGebuchteZeiten
            // 
            this.tabelleGebuchteZeiten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelleGebuchteZeiten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zeit,
            this.Reisekosten,
            this.Datum,
            this.Tätigkeitsbeschreibung});
            this.tabelleGebuchteZeiten.Location = new System.Drawing.Point(6, 105);
            this.tabelleGebuchteZeiten.Name = "tabelleGebuchteZeiten";
            this.tabelleGebuchteZeiten.Size = new System.Drawing.Size(700, 188);
            this.tabelleGebuchteZeiten.TabIndex = 8;
            // 
            // Zeit
            // 
            this.Zeit.Frozen = true;
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.Name = "Zeit";
            this.Zeit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Reisekosten
            // 
            this.Reisekosten.Frozen = true;
            this.Reisekosten.HeaderText = "Reisekosten";
            this.Reisekosten.Name = "Reisekosten";
            this.Reisekosten.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Datum
            // 
            this.Datum.Frozen = true;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tätigkeitsbeschreibung
            // 
            this.Tätigkeitsbeschreibung.Frozen = true;
            this.Tätigkeitsbeschreibung.HeaderText = "Tätigkeitsbeschreibung";
            this.Tätigkeitsbeschreibung.Name = "Tätigkeitsbeschreibung";
            this.Tätigkeitsbeschreibung.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tätigkeitsbeschreibung.Width = 400;
            // 
            // cost_Box
            // 
            this.cost_Box.Location = new System.Drawing.Point(292, 59);
            this.cost_Box.Name = "cost_Box";
            this.cost_Box.ReadOnly = true;
            this.cost_Box.Size = new System.Drawing.Size(100, 20);
            this.cost_Box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reisekosten:";
            // 
            // zeit_Box
            // 
            this.zeit_Box.Location = new System.Drawing.Point(90, 57);
            this.zeit_Box.Name = "zeit_Box";
            this.zeit_Box.ReadOnly = true;
            this.zeit_Box.Size = new System.Drawing.Size(100, 20);
            this.zeit_Box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gebuchte Zeit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum:";
            // 
            // anzeigeTag
            // 
            this.anzeigeTag.Location = new System.Drawing.Point(506, 20);
            this.anzeigeTag.Name = "anzeigeTag";
            this.anzeigeTag.Size = new System.Drawing.Size(200, 20);
            this.anzeigeTag.TabIndex = 2;
            this.anzeigeTag.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projekt:";
            // 
            // pro_Box
            // 
            this.pro_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pro_Box.FormattingEnabled = true;
            this.pro_Box.Location = new System.Drawing.Point(52, 17);
            this.pro_Box.Name = "pro_Box";
            this.pro_Box.Size = new System.Drawing.Size(199, 21);
            this.pro_Box.TabIndex = 0;
            this.pro_Box.SelectedValueChanged += new System.EventHandler(this.pro_Box_SelectedValueChanged);
            // 
            // cancel_Butt
            // 
            this.cancel_Butt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Butt.Location = new System.Drawing.Point(566, 368);
            this.cancel_Butt.Name = "cancel_Butt";
            this.cancel_Butt.Size = new System.Drawing.Size(159, 23);
            this.cancel_Butt.TabIndex = 10;
            this.cancel_Butt.Text = "Beenden";
            this.cancel_Butt.UseVisualStyleBackColor = true;
            this.cancel_Butt.Click += new System.EventHandler(this.cancel_Butt_Click);
            // 
            // Hauptmaske
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_Butt;
            this.ClientSize = new System.Drawing.Size(737, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel_Butt);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Hauptmaske";
            this.Text = "Zeiterfassung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelleGebuchteZeiten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mitarbeiterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem projekteToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView tabelleGebuchteZeiten;
		private System.Windows.Forms.TextBox cost_Box;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox zeit_Box;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker anzeigeTag;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox pro_Box;
		private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Reisekosten;
		private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tätigkeitsbeschreibung;
		private System.Windows.Forms.Button buch_Butt;
		private System.Windows.Forms.Button cancel_Butt;
		private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hilfeÖffnenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
	}
}