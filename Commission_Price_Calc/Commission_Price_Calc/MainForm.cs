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

        public String projectName = "";

        public double currentHours = 0.0;
        public double currentMinutes = 0.0;
        public double currentSeconds = 0.0;

        public bool timer_running = false;

        public string currency = "€";

        public string lang_resetmessage = "";
        public string lang_resettitle = "";
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

            //project label
            switch (getLang())
            {
                case "English":
                    projectName = "New Project";
                    break;
                case "Deutsch":
                    projectName = "Neues Projekt";
                    break;
            }
            labelProject.Text = projectName;
        }
        #endregion


        #region Methods

        #region Buttons

        #region Menu Strip
        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFile();
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences preferences = new Preferences(this);
            preferences.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            loadFile();
        }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (timer_running) { return; }
            if(MessageBox.Show(lang_resetmessage, lang_resettitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) 
                == DialogResult.Yes)
            {
                currentHours = 0.0;
                currentMinutes = 0.0;
                currentSeconds = 0.0;
                changeTimeLabel();
                //logging
                switch (getLang())
                {
                    case "English":
                        addLog("[RESET] " + "Time was reset!");
                        break;
                    case "Deutsch":
                        addLog("[ZURÜCKSETZEN] " + "Die Arbeitszeit wurde zurückgesetzt!");
                        break;
                }
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            ButtonStop.Enabled = false;
            ButtonStart.Enabled = true;

            ButtonReset.Enabled = true;
            ButtonCalculate.Enabled = true;
            ButtonAccept.Enabled = true;

            timer_running = false;
            timer1.Stop(); //stop timer

            //logging
            switch (getLang())
            {
                case "English":
                    addLog("[TIMER] " + "Timer has stopped!");
                    break;
                case "Deutsch":
                    addLog("[TIMER] " + "Der Timer wurde angehalten!");
                    break;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ButtonStop.Enabled = true;
            ButtonStart.Enabled = false;

            ButtonReset.Enabled = false;
            ButtonCalculate.Enabled = false;
            ButtonAccept.Enabled = false;

            timer_running = true;
            timer1.Start(); //start timer

            //logging
            switch (getLang())
            {
                case "English":
                    addLog("[TIMER] " + "Timer has started!");
                    break;
                case "Deutsch":
                    addLog("[TIMER] " + "Der Timer wurde gestarten!");
                    break;
            }
        }

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
            if(minutes >= 60) { //get hours from minutes
                var i = minutes / 60;
                var i_decimals = i - Math.Truncate(i);
                minutes = Math.Round(i_decimals * 60);
                hours += Math.Floor(i);
            }

            minutes = Math.Floor(minutes);
            hours = Math.Floor(hours);

            bool add = Add.Checked;
            bool remove = Remove.Checked;

            double beforeHours = currentHours;
            double beforeMinutes = currentMinutes;

            //if nothings checked
            if (hours == 0 && minutes == 0)
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
                {
                    var i = currentMinu

                    var i_decimals = i - Math.Truncate(i);
                    currentMinutes = Math.Round(i_decimals * 60);
                    currentHours = currentHours + Math.Floor(i);
                }

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
                if (currentMinutes < 0)
                {
                    if (currentHours >= 1)
                    {
                        currentMinutes = 60 + currentMinutes;
                        currentHours -= 1;
                    }
                    else
                    {
                        currentMinutes = 0;
                    }
                }
                if (currentHours < 0)
                {
                    currentHours = 0;
                    currentMinutes = 0;
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
        public void changeTimeLabel()
        {
            switch (getLang())
            {
                case "English": 
                                TotalTime.Text = "Total Time Worked: " + currentHours + "h " + currentMinutes + "m " + currentSeconds + "s";
                                break;
                case "Deutsch":
                                TotalTime.Text = "Insgesamte Arbeitszeit: " + currentHours + "h " + currentMinutes + "m " + currentSeconds + "s";
                                break;
            }
           
        }

        public void addLog(string text)
        {
            if (Log.Text == "") { Log.Text = "[" + DateTime.Now + "]: " + text; }
            else
            { //If logbox is empty dont create a new line
                Log.Text += Environment.NewLine + "[" + DateTime.Now + "]: " + text;
            }
        }
        
        public double validateNumber(string n)
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

        public string getLang()
        {
            return Settings.Default["Language"].ToString();
        }

        public void changeLabelLang()
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
                    LabelMinutes.Text = "Minutes";
                    ButtonAccept.Text = "Accept";
                    Remove.Text = "Remove";
                    Add.Text = "Add";
                    ButtonReset.Text = "Reset";
                    lang_resetmessage = "Do you really want to reset your Time?";
                    lang_resettitle = "Reset Time?";
                    closeProgramToolStripMenuItem.Text = "Close Program";
                    loadProjectToolStripMenuItem.Text = "Load Project";
                    saveProjectToolStripMenuItem.Text = "Save Project";
                    openPreferencesToolStripMenuItem.Text = "Open Preferences";
                    infoToolStripMenuItem.Text = "Info";
                    menuStrip1.Items[0].Text = "File";
                    menuStrip1.Items[1].Text = "Options";
                    menuStrip1.Items[2].Text = "Help";
                    break;
                case "Deutsch":
                    ButtonCalculate.Text = "Berechnen";
                    LabelResult.Text = "Ergebnis: 0" + currency;
                    LabelLog.Text = "Protokoll: ";
                    LabelTax.Text = "% Steuern";
                    LabelWage.Text = currency + " pro Stunde";
                    LabelBaseCosts.Text = currency + " Basiskosten";
                    LabelHours.Text = "Stunden";
                    LabelMinutes.Text = "Minuten";
                    ButtonAccept.Text = "Akzeptieren";
                    Remove.Text = "Subtrahieren";
                    Add.Text = "Addieren";
                    ButtonReset.Text = "Zurücksetzen";
                    lang_resetmessage = "Wollen Sie Ihre Arbeitszeit wirklich zurücksetzen?";
                    lang_resettitle = "Arbeitszeit zurücksetzen?";
                    closeProgramToolStripMenuItem.Text = "Programm schließen";
                    loadProjectToolStripMenuItem.Text = "Projekt laden";
                    saveProjectToolStripMenuItem.Text = "Projekt speichern";
                    openPreferencesToolStripMenuItem.Text = "Einstellungen öffnen";
                    infoToolStripMenuItem.Text = "Info"
                    menuStrip1.Items[0].Text = "Datei";
                    menuStrip1.Items[1].Text = "Optionen";
                    menuStrip1.Items[2].Text = "Hilfe";
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
        
        public void saveFile()
        {

        }
        
        public void loadFile()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentSeconds += 1;

            if (currentSeconds > 59)
            {
                currentMinutes++;
                currentSeconds = 0;
            }

            if (currentMinutes > 59)
            {
                currentHours++;
                currentMinutes = 0;
            }

            changeTimeLabel();
        }

        #endregion

        #endregion

    }
}
