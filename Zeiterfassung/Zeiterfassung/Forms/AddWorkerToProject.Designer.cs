namespace Zeiterfassung
{
    partial class AddWorkerToProject
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.AddWorkers = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(15, 32);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(405, 169);
            this.checkedListBox1.TabIndex = 0;
            // 
            // AddWorkers
            // 
            this.AddWorkers.Location = new System.Drawing.Point(48, 215);
            this.AddWorkers.Name = "AddWorkers";
            this.AddWorkers.Size = new System.Drawing.Size(162, 31);
            this.AddWorkers.TabIndex = 1;
            this.AddWorkers.Text = "OK";
            this.AddWorkers.UseVisualStyleBackColor = true;
            this.AddWorkers.Click += new System.EventHandler(this.AddWorkers_Click);
            // 
            // Abort
            // 
            this.Abort.Location = new System.Drawing.Point(216, 215);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(171, 31);
            this.Abort.TabIndex = 2;
            this.Abort.Text = "Abbrechen";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // AddWorkerToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 258);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.AddWorkers);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "AddWorkerToProject";
            this.Text = "AddWorkerToPrject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button AddWorkers;
        private System.Windows.Forms.Button Abort;
    }
}