namespace Zeiterfassung
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Name_Box = new System.Windows.Forms.TextBox();
            this.login_PW_Box = new System.Windows.Forms.TextBox();
            this.login_Butt = new System.Windows.Forms.Button();
            this.cancel_Butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort:";
            // 
            // login_Name_Box
            // 
            this.login_Name_Box.Location = new System.Drawing.Point(76, 13);
            this.login_Name_Box.Name = "login_Name_Box";
            this.login_Name_Box.Size = new System.Drawing.Size(205, 20);
            this.login_Name_Box.TabIndex = 2;
            // 
            // login_PW_Box
            // 
            this.login_PW_Box.Location = new System.Drawing.Point(76, 39);
            this.login_PW_Box.Name = "login_PW_Box";
            this.login_PW_Box.PasswordChar = '•';
            this.login_PW_Box.Size = new System.Drawing.Size(205, 20);
            this.login_PW_Box.TabIndex = 3;
            // 
            // login_Butt
            // 
            this.login_Butt.Location = new System.Drawing.Point(76, 70);
            this.login_Butt.Name = "login_Butt";
            this.login_Butt.Size = new System.Drawing.Size(98, 23);
            this.login_Butt.TabIndex = 4;
            this.login_Butt.Text = "Anmelden";
            this.login_Butt.UseVisualStyleBackColor = true;
            this.login_Butt.Click += new System.EventHandler(this.login_Butt_Click);
            // 
            // cancel_Butt
            // 
            this.cancel_Butt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Butt.Location = new System.Drawing.Point(180, 70);
            this.cancel_Butt.Name = "cancel_Butt";
            this.cancel_Butt.Size = new System.Drawing.Size(101, 23);
            this.cancel_Butt.TabIndex = 5;
            this.cancel_Butt.Text = "Abbrechen";
            this.cancel_Butt.UseVisualStyleBackColor = true;
            this.cancel_Butt.Click += new System.EventHandler(this.cancel_Butt_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.login_Butt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_Butt;
            this.ClientSize = new System.Drawing.Size(301, 112);
            this.Controls.Add(this.cancel_Butt);
            this.Controls.Add(this.login_Butt);
            this.Controls.Add(this.login_PW_Box);
            this.Controls.Add(this.login_Name_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Anmeldung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_Name_Box;
        private System.Windows.Forms.TextBox login_PW_Box;
        private System.Windows.Forms.Button login_Butt;
        private System.Windows.Forms.Button cancel_Butt;
    }
}

