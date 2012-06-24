namespace Zeiterfassung
{
    partial class ChangePW
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
            this.altesPW = new System.Windows.Forms.TextBox();
            this.newPW = new System.Windows.Forms.TextBox();
            this.newPW2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // altesPW
            // 
            this.altesPW.Location = new System.Drawing.Point(88, 28);
            this.altesPW.Name = "altesPW";
            this.altesPW.PasswordChar = '*';
            this.altesPW.Size = new System.Drawing.Size(100, 20);
            this.altesPW.TabIndex = 1;
            // 
            // newPW
            // 
            this.newPW.Location = new System.Drawing.Point(88, 68);
            this.newPW.Name = "newPW";
            this.newPW.PasswordChar = '*';
            this.newPW.Size = new System.Drawing.Size(100, 20);
            this.newPW.TabIndex = 2;
            // 
            // newPW2
            // 
            this.newPW2.Location = new System.Drawing.Point(88, 107);
            this.newPW2.Name = "newPW2";
            this.newPW2.PasswordChar = '*';
            this.newPW2.Size = new System.Drawing.Size(100, 20);
            this.newPW2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(85, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altes Passwort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Neues Passwort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Passwort wiederholen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Passwort ändern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPW2);
            this.Controls.Add(this.newPW);
            this.Controls.Add(this.altesPW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePW";
            this.ShowInTaskbar = false;
            this.Text = "Passwört ändern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox altesPW;
        private System.Windows.Forms.TextBox newPW;
        private System.Windows.Forms.TextBox newPW2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;

    }
}