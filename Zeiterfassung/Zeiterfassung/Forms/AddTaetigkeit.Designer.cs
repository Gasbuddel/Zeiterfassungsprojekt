namespace Zeiterfassung
{
    partial class AddTaetigkeit
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
            this.tätigkeitListe = new System.Windows.Forms.CheckedListBox();
            this.abort = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tätigkeitListe
            // 
            this.tätigkeitListe.FormattingEnabled = true;
            this.tätigkeitListe.Location = new System.Drawing.Point(12, 37);
            this.tätigkeitListe.Name = "tätigkeitListe";
            this.tätigkeitListe.Size = new System.Drawing.Size(408, 169);
            this.tätigkeitListe.TabIndex = 0;
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(228, 227);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(144, 24);
            this.abort.TabIndex = 1;
            this.abort.Text = "Abbrechen";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(47, 227);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(142, 23);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // AddTaetigkeit
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.abort;
            this.ClientSize = new System.Drawing.Size(432, 262);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.tätigkeitListe);
            this.Name = "AddTaetigkeit";
            this.Text = "AddTaetigkeit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox tätigkeitListe;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.Button ok;
    }
}