namespace Zeiterfassung
{
    partial class NewTaet
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
            this.tätDesc_Box = new Zeiterfassung.RegExTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_Butt = new System.Windows.Forms.Button();
            this.ok_Butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tätDesc_Box
            // 
            this.tätDesc_Box.Location = new System.Drawing.Point(87, 13);
            this.tätDesc_Box.Name = "tätDesc_Box";
            this.tätDesc_Box.Regular_Expression = null;
            this.tätDesc_Box.Size = new System.Drawing.Size(410, 20);
            this.tätDesc_Box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beschreibung:";
            // 
            // cancel_Butt
            // 
            this.cancel_Butt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Butt.Location = new System.Drawing.Point(422, 40);
            this.cancel_Butt.Name = "cancel_Butt";
            this.cancel_Butt.Size = new System.Drawing.Size(75, 23);
            this.cancel_Butt.TabIndex = 2;
            this.cancel_Butt.Text = "Abbrechen";
            this.cancel_Butt.UseVisualStyleBackColor = true;
            this.cancel_Butt.Click += new System.EventHandler(this.cancel_Butt_Click);
            // 
            // ok_Butt
            // 
            this.ok_Butt.Location = new System.Drawing.Point(341, 40);
            this.ok_Butt.Name = "ok_Butt";
            this.ok_Butt.Size = new System.Drawing.Size(75, 23);
            this.ok_Butt.TabIndex = 3;
            this.ok_Butt.Text = "Ok";
            this.ok_Butt.UseVisualStyleBackColor = true;
            this.ok_Butt.Click += new System.EventHandler(this.ok_Butt_Click);
            // 
            // NewTaet
            // 
            this.AcceptButton = this.ok_Butt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_Butt;
            this.ClientSize = new System.Drawing.Size(509, 73);
            this.Controls.Add(this.ok_Butt);
            this.Controls.Add(this.cancel_Butt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tätDesc_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTaet";
            this.Text = "Neue Tätigkeit erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegExTextbox tätDesc_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_Butt;
        private System.Windows.Forms.Button ok_Butt;
    }
}