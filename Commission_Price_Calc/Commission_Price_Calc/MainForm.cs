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

        public double currentHours = 0.0;
        public double currentMinutes = 0.0;

        public bool timer_running = false;

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ChangeTimeLabel();

        }
        #endregion


        #region Methods

        #region Buttons

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            //calculate result
            //get variables
            double wage = validateNumber(InputWage.Text);
            double tax = validateNumber(InputTax.Text);
            double basecosts = validateNumber(InputBaseCosts.Text);
            double hours = (currentMinutes / 60) + currentHours;
 
            Double result = (hours * wage); //calculate base result
            result = result + basecosts; //add basecosts
            result = result + (result * (tax / 100)); //add tax
            result = Math.Round(result, 2); //round

            //set label
            LabelResult.Text = "Result: " + result.ToString() + "€";

            //logging
            addLog("[CALCULATE] " + "Time: " + currentHours + "h " + currentMinutes + "m, "
                + "Basecosts: " + basecosts + "€, " + "€ per h: " + wage + "€, " + "Tax: " + tax + "%, "
                + "Result: " + result + "€");

        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            if(timer_running) { return; }
            double minutes = validateNumber(InputMinutes.Text);
            double hours = validateNumber(InputHours.Text);

            //delete decimals
            if(minutes >= 60) { minutes = 59; }
            minutes = Math.Floor(minutes);
            hours = Math.Floor(hours);

            bool add = Add.Checked;
            bool remove = Remove.Checked;

            double beforeHours = currentHours;
            double beforeMinutes = currentMinutes;

            //if nothings checked
            if (add == false && remove == false)
            {
                return;
            }else //if adds checked
            if(add == true)
            { 
                currentHours += hours;
                currentMinutes += minutes;

                //check if minutes over 59
                if(currentMinutes >= 60)
                { currentMinutes = 59; }

                addLog("[MANUAL ADD] " + "Time Before: " + beforeHours + "h " + beforeMinutes + "m, "
                    + "Added: " + hours + "h " + minutes + "m, "
                    + "Current Time: " + currentHours + "h " + currentMinutes + "m");

                ChangeTimeLabel();

            }else //if removes checked
            if(remove == true)
            {
                currentHours -= hours;
                currentMinutes -= minutes;

                //check if 0
                if(currentMinutes < 0)
                {
                    currentMinutes = 0;
                }
                if (currentHours < 0)
                {
                    currentHours = 0;
                }

                addLog("[MANUAL REMOVE] " + "Time Before: " + beforeHours + "h " + beforeMinutes + "m, "
                    + "Removed: " + hours + "h " + minutes + "m, " 
                    + "Current Time: " + currentHours + "h " + currentMinutes + "m");

                ChangeTimeLabel();
            }


        }

        #endregion

        #region Misc
        private void ChangeTimeLabel()
        {
            TotalTime.Text = "Total Time Worked: " + currentHours + "h " + currentMinutes + "m";
        }

        private void addLog(string text)
        {
            Log.Text += Environment.NewLine + "[" + DateTime.Now + "]: " + text;
        }
        private double validateNumber(string n)
        {
            // deleting all €$ type characters
            var charsToRemove = new string[] { "€", "$", " ", "%"};
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
