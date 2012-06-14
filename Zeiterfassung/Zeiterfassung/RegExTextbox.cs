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

        private string mRegularExpression;

        #endregion

        #region "Propperties"

        public string Regular_Expression 
        {
            get { return mRegularExpression; }
            set { mRegularExpression = value; }
        }

        #endregion

        #region "Constructor"

        public RegExTextbox()
        {
            InitializeComponent();
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

            // test text with expression
            if (expression.IsMatch(TextToValidate))
            {
                return true;
            }
            else
            {
                // no match
                return false;
            }
        }

        #endregion
    }
}
