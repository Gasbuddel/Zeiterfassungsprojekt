using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Zeiterfassung
{
    public partial class RegExTextbox : TextBox
    {
        #region "Declarations"

		//Regulärer Ausdruck
        private string mRegularExpression;

		//Tooltip, der Informationen über die Fehleingabe ausgibt
		private ToolTip tip;

		//Text, der im Tooltip steht
		private string infoText;

		//Boolean, ob aktueller Wert gültig ist
		private bool valid;

		private const int toolTipDuration = 2000;

        #endregion

        #region "Propperties"

		/// <summary>
		/// Regulärer Ausdruck, nach dem überprüft werden soll.
		/// </summary>
        public string Regular_Expression 
        {
            get { return mRegularExpression; }
            set { mRegularExpression = value; }
        }

		/// <summary>
		/// Anzeigetext des Tooltips
		/// </summary>
		public string ToolTipText
		{
			get { return infoText; }
			set { infoText = value; }
		}

		public bool IsValid
		{
			get { return valid; }
		}

        #endregion

        #region "Constructor"

        public RegExTextbox()
        {
            InitializeComponent();
			this.TextChanged += new EventHandler(RegexTextbox_TextChanged);
			this.Leave += new EventHandler(RegeexTextbox_Leave);
			tip = new ToolTip();
        }
        
        #endregion

        #region "Methods"

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public bool ValidateControl()
        {
            string TextToValidate;

            Regex expression;

            try
            {
                TextToValidate = this.Text;
                expression = new Regex(Regular_Expression);
            }
            catch
            {
                return false;
            }

            // Text auf richtigkeit überprüfen
            if (expression.IsMatch(TextToValidate))
            {
				valid = true;
				this.ForeColor = Color.Black;
                return true;
            }
            else
            {
                // Falscher Text
				valid = false;
				this.ForeColor = Color.RosyBrown;
                return false;
            }
        }

		private void ShowTip()
		{
			if (!valid && infoText != "")
			{
				Point anzeigepunkt = this.Location;
				tip.ToolTipTitle = "Fehlerhafte Eingabe";
				anzeigepunkt.X += this.Width - 5;
				anzeigepunkt.Y += 5;
				tip.Show(infoText, this.Parent, anzeigepunkt, toolTipDuration);
			}
			else
			{
				tip.Hide(this);
			}
		}

		void RegexTextbox_TextChanged(object sender, EventArgs e)
		{
			ValidateControl();
		}

		void RegeexTextbox_Leave(object sender, EventArgs e)
		{
			ValidateControl();
			ShowTip();
		}

        #endregion
    }
}
