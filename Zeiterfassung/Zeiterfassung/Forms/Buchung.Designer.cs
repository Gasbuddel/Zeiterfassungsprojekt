namespace Zeiterfassung
{
	partial class Buchung
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buchung));
			this.label1 = new System.Windows.Forms.Label();
			this.buchungsDatum = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.stunden_Box = new System.Windows.Forms.TextBox();
			this.kosten_Box = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tätigkeits_Box = new System.Windows.Forms.ComboBox();
			this.custom_Box = new System.Windows.Forms.TextBox();
			this.book_Cancel_Butt = new System.Windows.Forms.Button();
			this.book_Booking_Butt = new System.Windows.Forms.Button();
			this.bu_Custom_CheckBox = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Datum:";
			// 
			// buchungsDatum
			// 
			this.buchungsDatum.Location = new System.Drawing.Point(61, 13);
			this.buchungsDatum.Name = "buchungsDatum";
			this.buchungsDatum.Size = new System.Drawing.Size(200, 20);
			this.buchungsDatum.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Stunden:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(192, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Reisekosten:";
			// 
			// stunden_Box
			// 
			this.stunden_Box.Location = new System.Drawing.Point(61, 37);
			this.stunden_Box.Name = "stunden_Box";
			this.stunden_Box.Size = new System.Drawing.Size(100, 20);
			this.stunden_Box.TabIndex = 4;
			this.stunden_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// kosten_Box
			// 
			this.kosten_Box.Location = new System.Drawing.Point(268, 40);
			this.kosten_Box.Name = "kosten_Box";
			this.kosten_Box.Size = new System.Drawing.Size(110, 20);
			this.kosten_Box.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Tätigkeitsbeschreibung:";
			// 
			// tätigkeits_Box
			// 
			this.tätigkeits_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tätigkeits_Box.FormattingEnabled = true;
			this.tätigkeits_Box.Location = new System.Drawing.Point(140, 70);
			this.tätigkeits_Box.Name = "tätigkeits_Box";
			this.tätigkeits_Box.Size = new System.Drawing.Size(397, 21);
			this.tätigkeits_Box.TabIndex = 7;
			// 
			// custom_Box
			// 
			this.custom_Box.Location = new System.Drawing.Point(16, 149);
			this.custom_Box.Multiline = true;
			this.custom_Box.Name = "custom_Box";
			this.custom_Box.Size = new System.Drawing.Size(521, 158);
			this.custom_Box.TabIndex = 8;
			// 
			// book_Cancel_Butt
			// 
			this.book_Cancel_Butt.Location = new System.Drawing.Point(418, 314);
			this.book_Cancel_Butt.Name = "book_Cancel_Butt";
			this.book_Cancel_Butt.Size = new System.Drawing.Size(118, 23);
			this.book_Cancel_Butt.TabIndex = 9;
			this.book_Cancel_Butt.Text = "Abbrechen";
			this.book_Cancel_Butt.UseVisualStyleBackColor = true;
			this.book_Cancel_Butt.Click += new System.EventHandler(this.book_Cancel_Butt_Click);
			// 
			// book_Booking_Butt
			// 
			this.book_Booking_Butt.Location = new System.Drawing.Point(290, 314);
			this.book_Booking_Butt.Name = "book_Booking_Butt";
			this.book_Booking_Butt.Size = new System.Drawing.Size(122, 23);
			this.book_Booking_Butt.TabIndex = 10;
			this.book_Booking_Butt.Text = "Buchen";
			this.book_Booking_Butt.UseVisualStyleBackColor = true;
			this.book_Booking_Butt.Click += new System.EventHandler(this.book_Booking_Butt_Click);
			// 
			// bu_Custom_CheckBox
			// 
			this.bu_Custom_CheckBox.AutoSize = true;
			this.bu_Custom_CheckBox.Location = new System.Drawing.Point(16, 126);
			this.bu_Custom_CheckBox.Name = "bu_Custom_CheckBox";
			this.bu_Custom_CheckBox.Size = new System.Drawing.Size(177, 17);
			this.bu_Custom_CheckBox.TabIndex = 11;
			this.bu_Custom_CheckBox.Text = "Eigene Beschreiung verwenden";
			this.bu_Custom_CheckBox.UseVisualStyleBackColor = true;
			this.bu_Custom_CheckBox.CheckedChanged += new System.EventHandler(this.bu_Custom_Checkbox_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(43, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "(Vorlagen)";
			// 
			// Buchung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 346);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bu_Custom_CheckBox);
			this.Controls.Add(this.book_Booking_Butt);
			this.Controls.Add(this.book_Cancel_Butt);
			this.Controls.Add(this.custom_Box);
			this.Controls.Add(this.tätigkeits_Box);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.kosten_Box);
			this.Controls.Add(this.stunden_Box);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buchungsDatum);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Buchung";
			this.Text = "Buchung";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker buchungsDatum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox stunden_Box;
		private System.Windows.Forms.TextBox kosten_Box;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox tätigkeits_Box;
		private System.Windows.Forms.TextBox custom_Box;
		private System.Windows.Forms.Button book_Cancel_Butt;
		private System.Windows.Forms.Button book_Booking_Butt;
		private System.Windows.Forms.CheckBox bu_Custom_CheckBox;
		private System.Windows.Forms.Label label5;

	}
}