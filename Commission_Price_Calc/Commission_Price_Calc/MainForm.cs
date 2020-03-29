using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commission_Price_Calc.Properties;

namespace Commission_Price_Calc
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class MainForm : Form
    {

        public double currentHours = 0.0;
        public double currentMinutes = 0.0;
        public double currentSeconds = 0.0;

        public bool timer_running = false;

        public string currency = "€";

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            changeCurrency();
            changeLabelLang();
            changeTimeLabel();
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

            if (hours == 0) { return; } //if u havent worked any time just exit this function

            //set label
            switch (getLang())
            {
                case "English":
                    LabelResult.Text = "Result: " + result.ToString() + currency;
                    break;
                case "Deutsch":
                    LabelResult.Text = "Ergebnis: " + result.ToString() + currency;
                    break;
            }
          

            //logging
            switch (getLang())
            {
                case "English":
                    addLog("[CALCULATE] " + "Time: " + currentHours + "h " + currentMinutes + "m, "
                     + "Basecosts: " + basecosts + currency + ", " + currency + " per h: " + wage + currency + ", " + "Tax: " + tax + "%, "
                     + "Result: " + result + currency );
                    break;
                case "Deutsch":
                    addLog("[BERECHNUNG] " + "Zeit: " + currentHours + "h " + currentMinutes + "m, "
                    + "Basiskosten: " + basecosts + currency +", " + currency + " pro Stunde: " + wage + currency +", " + "Steuern: " + tax + "%, "
                    + "Ergebnis: " + result + currency);
                    break;
            }
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
            if (minutes == 0 && hours == 0)
            {
                return;
            }
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
                
                switch (getLang())
                {
                    case "English":
                        addLog("[MANUAL ADD] " + "Time Before: " + beforeHours + "h " + beforeMinutes + "m, "
                            + "Added: " + hours + "h " + minutes + "m, "
                            + "Current Time: " + currentHours + "h " + currentMinutes + "m");
                        break;
                    case "Deutsch":
                        addLog("[ZEIT ADDITION] " + "Zeit davor: " + beforeHours + "h " + beforeMinutes + "m, "
                            + "Addierte Zeit: " + hours + "h " + minutes + "m, "
                            + "Momentane Zeit: " + currentHours + "h " + currentMinutes + "m");
                        break;
                }

                changeTimeLabel();

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

                switch (getLang())
                {
                    case "English":
                        addLog("[MANUAL REMOVE] " + "Time Before: " + beforeHours + "h " + beforeMinutes + "m, "
                            + "Removed: " + hours + "h " + minutes + "m, "
                            + "Current Time: " + currentHours + "h " + currentMinutes + "m");
                        break;
                    case "Deutsch":
                        addLog("[ZEIT SUBTRAKTION] " + "Zeit davor: " + beforeHours + "h " + beforeMinutes + "m, "
                            + "Subtrahierte Zeit: " + hours + "h " + minutes + "m, "
                            + "Momentane Zeit: " + currentHours + "m " + currentMinutes + "m");
                        break;
                }

                changeTimeLabel();
            }


        }

        #endregion

        #region Misc
        private void changeTimeLabel()
        {
            switch (getLang())
            {
                case "English": 
                                TotalTime.Text = "Total Time Worked: " + currentHours + "h " + currentMinutes + "m";
                                break;
                case "Deutsch":
                                TotalTime.Text = "Insgesamte Arbeitszeit: " + currentHours + "h " + currentMinutes + "m";
                                break;
            }
           
        }

        private void addLog(string text)
        {
            if (Log.Text == "") { Log.Text = "[" + DateTime.Now + "]: " + text; }
            else
            { //If logbox is empty dont create a new line
                Log.Text += Environment.NewLine + "[" + DateTime.Now + "]: " + text;
            }
        }
        
        private double validateNumber(string n)
        {
            // deleting all €$ type characters
            var charsToRemove = new string[] { "€", "$", " ", "%", "£"};
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

        private string getLang()
        {
            return Settings.Default["Language"].ToString();
        }

        private void changeLabelLang()
        {
            switch (getLang())
            {
                case "English":
                    ButtonCalculate.Text = "Calculate";
                    LabelResult.Text = "Result: 0" + currency;
                    LabelLog.Text = "Log: ";
                    LabelTax.Text = "% Tax";
                    LabelWage.Text = currency + " Per Hour";
                    LabelBaseCosts.Text = currency + " Base Costs";
                    LabelHours.Text = "Hours";
                    LabelMinutes.Text = "Minutes (max. 59)";
                    ButtonAccept.Text = "Accept";
                    Remove.Text = "Remove";
                    Add.Text = "Add";
                    break;
                case "Deutsch":
                    ButtonCalculate.Text = "Berechnen";
                    LabelResult.Text = "Ergebnis: 0" + currency;
                    LabelLog.Text = "Protokoll: ";
                    LabelTax.Text = "% Steuern";
                    LabelWage.Text = currency + " pro Stunde";
                    LabelBaseCosts.Text = currency + " Basiskosten";
                    LabelHours.Text = "Stunden";
                    LabelMinutes.Text = "Minuten (max. 59)";
                    ButtonAccept.Text = "Akzeptieren";
                    Remove.Text = "Subtrahieren";
                    Add.Text = "Addieren";
                    break;
            }
        }

        public void changeCurrency()
        {
            switch (Settings.Default.Currency.ToString())
            {
                case "€":
                    currency = "€";
                    break;
                case "$":
                    currency = "$";
                    break;
                case "£":
                    currency = "£";
                    break;
            }
        }

        #endregion

        #endregion
    }
}
