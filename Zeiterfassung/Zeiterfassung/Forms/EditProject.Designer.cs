namespace Zeiterfassung
{
    partial class EditProject
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
            this.beschr_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beschr_Box
            // 
            this.beschr_Box.Location = new System.Drawing.Point(12, 28);
            this.beschr_Box.Multiline = true;
            this.beschr_Box.Name = "beschr_Box";
            this.beschr_Box.Size = new System.Drawing.Size(467, 142);
            this.beschr_Box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projektbeschreibung";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(318, 176);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(161, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "Änderung Speichern";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 207);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beschr_Box);
            this.Name = "EditProject";
            this.Text = "EditProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox beschr_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit;
    }
}