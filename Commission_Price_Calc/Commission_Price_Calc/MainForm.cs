using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commission_Price_Calc
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class MainForm : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        #region Buttons
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double wage = validateNumber(InputWage.Text);
            double minutes = validateNumber(InputMinutes.Text);
            double hours = (minutes / 60) + validateNumber(InputHours.Text);
  

            Double result = (hours * wage);
            result = Math.Round(result, 2);
            LabelResult.Text = result.ToString() + "€";
        }
        #endregion
        #region Misc
        private double validateNumber(string n)
        {
            // deleting all €$ type characters
            var charsToRemove = new string[] { "€", "$", " " };
            foreach (var c in charsToRemove)
            {
                n = n.Replace(c, string.Empty);
            }

            // parsing int
            try
            {
                Double number = Double.Parse(n);
                return number;
            }   catch (Exception e)
            {
                //if there are normal characters return 0
                return 0;
            }
        }
        #endregion

        #endregion
    }
}
