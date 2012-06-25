namespace Zeiterfassung
{
    partial class CreateProject
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
            this.ok = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kunde_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descBox = new Zeiterfassung.RegExTextbox();
            this.nameBox = new Zeiterfassung.RegExTextbox();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(12, 240);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(142, 24);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // abort
            // 
            this.abort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abort.Location = new System.Drawing.Point(160, 240);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(140, 24);
            this.abort.TabIndex = 3;
            this.abort.Text = "Abbrechen";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Projektname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Projektbeschreibung:";
            // 
            // kunde_box
            // 
            this.kunde_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kunde_box.FormattingEnabled = true;
            this.kunde_box.Location = new System.Drawing.Point(12, 29);
            this.kunde_box.Name = "kunde_box";
            this.kunde_box.Size = new System.Drawing.Size(288, 21);
            this.kunde_box.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kunde";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(13, 109);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Regular_Expression = null;
            this.descBox.Size = new System.Drawing.Size(287, 125);
            this.descBox.TabIndex = 9;
            this.descBox.ToolTipText = null;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 69);
            this.nameBox.Name = "nameBox";
            this.nameBox.Regular_Expression = null;
            this.nameBox.Size = new System.Drawing.Size(288, 20);
            this.nameBox.TabIndex = 8;
            this.nameBox.ToolTipText = null;
            // 
            // CreateProject
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.abort;
            this.ClientSize = new System.Drawing.Size(314, 274);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kunde_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProject";
            this.Text = "Projekt anlegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kunde_box;
        private System.Windows.Forms.Label label3;
        private RegExTextbox nameBox;
        private RegExTextbox descBox;
    }
}