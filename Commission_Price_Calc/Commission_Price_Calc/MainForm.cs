using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Commission_Price_Calc.Properties;

namespace Commission_Price_Calc
{
    public partial class MainForm : Form
    {
        public double time_current_hours = 0.0;
        public double time_current_minutes = 0.0;
        public double time_current_seconds = 0.0;

        public bool main_timer_active = false;

        string lang_label_resetproject_message = "";
        string lang_label_resetproject_title = "";

        #region Constructor
        public MainForm()
        {
            InitializeComponent();

            settingsLangLabelsSetter(); //write all the stuff on labels in correct language
            mainTimeLabelUpdate();
            
            switch (settingsLangSettingGetter())
            {
                case "English":
                    labelProject.Text = "New Project";
                    break;
                case "Deutsch":
                    labelProject.Text = "Neues Projekt";
                    break;
            }

            //set icon
            this.Icon = Properties.Resources.comission_price_calculator1;
        }
        
        #endregion

        #region Functions
            #region Settings Functions
                public string settingsLangSettingGetter() // returns string of the set language setting
                    {
                        return Settings.Default["Language"].ToString();
                    }

                public void settingsLangLabelsSetter() // applies every string for the selected language to labels
                    {
                        switch (settingsLangSettingGetter()){
                            case "English":
                                ButtonCalculate.Text = "Calculate";
                                LabelResult.Text = "Result: 0" + settingsCurrencySettingGetter();
                                LabelLog.Text = "Log: ";
                                LabelTax.Text = "% Tax";
                                LabelWage.Text = settingsCurrencySettingGetter() + " Per Hour";
                                LabelBaseCosts.Text = settingsCurrencySettingGetter() + " Base Costs";
                                LabelHours.Text = "Hours";
                                LabelMinutes.Text = "Minutes";
                                ButtonAccept.Text = "Accept";
                                Remove.Text = "Remove";
                                Add.Text = "Add";
                                ButtonReset.Text = "Reset Time";
                                lang_label_resetproject_message = "Do you really want to reset your Time?";
                                lang_label_resetproject_title = "Reset Time?";
                                closeProgramToolStripMenuItem.Text = "Close Program";
                                loadProjectToolStripMenuItem.Text = "Load Project";
                                saveProjectToolStripMenuItem.Text = "Save Project";
                                openPreferencesToolStripMenuItem.Text = "Open Preferences";
                                infoToolStripMenuItem.Text = "Info";
                                menuStrip1.Items[0].Text = "File";
                                menuStrip1.Items[1].Text = "Options";
                                menuStrip1.Items[2].Text = "Help";
                                ButtonSave.Text = "Save";
                                ButtonLoad.Text = "Load";
                                labelSettings.Text = "Settings";
                                break;
                            case "Deutsch":
                                ButtonCalculate.Text = "Berechnen";
                                LabelResult.Text = "Ergebnis: 0" + settingsCurrencySettingGetter();
                                LabelLog.Text = "Protokoll: ";
                                LabelTax.Text = "% Steuern";
                                LabelWage.Text = settingsCurrencySettingGetter() + " pro Stunde";
                                LabelBaseCosts.Text = settingsCurrencySettingGetter() + " Basiskosten";
                                LabelHours.Text = "Stunden";
                                LabelMinutes.Text = "Minuten";
                                ButtonAccept.Text = "Akzeptieren";
                                Remove.Text = "Subtrahieren";
                                Add.Text = "Addieren";
                                ButtonReset.Text = "Zeit Zurücksetzen";
                                lang_label_resetproject_message = "Wollen Sie Ihre Arbeitszeit wirklich zurücksetzen?";
                                lang_label_resetproject_title = "Arbeitszeit zurücksetzen?";
                                closeProgramToolStripMenuItem.Text = "Programm schließen";
                                loadProjectToolStripMenuItem.Text = "Projekt laden";
                                saveProjectToolStripMenuItem.Text = "Projekt speichern";
                                openPreferencesToolStripMenuItem.Text = "Einstellungen öffnen";
                                infoToolStripMenuItem.Text = "Info";
                                menuStrip1.Items[0].Text = "Datei";
                                menuStrip1.Items[1].Text = "Optionen";
                                menuStrip1.Items[2].Text = "Hilfe";
                                ButtonSave.Text = "Speichern";
                                ButtonLoad.Text = "Laden";
                                labelSettings.Text = "Einstellungen";
                                break;
                        }

                         mainTimeLabelUpdate();
                    }

                public string settingsCurrencySettingGetter() // returns current currency set in settings
                    {
                        return Settings.Default.Currency.ToString();
                    }
            #endregion

            #region File I/O Functions
                public void fileSave()
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Project File|*.xml";
                    if (!(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                    {
                        return;
                    }

                    XmlTextWriter textWriter = new XmlTextWriter(sfd.FileName, null);

                    textWriter.Formatting = Formatting.Indented;
                    textWriter.WriteStartDocument();
                    textWriter.WriteStartElement("ProjectFile");
                    textWriter.WriteElementString("currentMinutes", time_current_minutes.ToString());
                    textWriter.WriteElementString("currentHours", time_current_hours.ToString());
                    textWriter.WriteElementString("currentSeconds", time_current_seconds.ToString());
                    textWriter.WriteElementString("Wage", InputWage.Text);
                    textWriter.WriteElementString("BaseCosts", InputBaseCosts.Text);
                    textWriter.WriteElementString("Tax", InputTax.Text);
                    textWriter.WriteEndDocument();
                    textWriter.Close();


                    switch (settingsLangSettingGetter())
                    {
                        case "English":
                            mainLogWrite("[SAVE] File has been saved at " + sfd.FileName);
                            break;
                        case "Deutsch":
                            mainLogWrite("[SPEICHERN] Datei wurde als " + sfd.FileName + " gespeichert");
                            break;
                    }

                    labelProject.Text = sfd.FileName.Split('\\').Last();
                }

                public void fileLoad()
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Project File|*.xml";
                    if (!(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                    {
                        return;
                    }

                    XmlTextReader textReader = new XmlTextReader(ofd.FileName);
                    while (textReader.Read())
                    {
                        textReader.MoveToElement();
                        var name = textReader.Name;

                        if (name == "currentMinutes")
                        {
                            time_current_minutes = textReader.ReadElementContentAsDouble();
                        }

                        if (name == "currentHours")
                        {
                            time_current_hours = textReader.ReadElementContentAsDouble();
                        }

                        if (name == "currentSeconds")
                        {
                            time_current_seconds = textReader.ReadElementContentAsDouble();
                        }

                        if (name == "Tax")
                        {
                            InputTax.Text = textReader.ReadElementContentAsString();
                        }

                        if (name == "Wage")
                        {
                            InputWage.Text = textReader.ReadElementContentAsString();
                        }

                        if (name == "BaseCosts")
                        {
                            InputBaseCosts.Text = textReader.ReadElementContentAsString();
                        }
                    }
                    textReader.Close();


                    switch (settingsLangSettingGetter())
                    {
                        case "English":
                            mainLogWrite("[LOAD] " + ofd.FileName + " has been loaded");
                            break;
                        case "Deutsch":
                            mainLogWrite("[LADEN] " + ofd.FileName + " wurde geladen");
                            break;
                    }

                    labelProject.Text = ofd.FileName.Split('\\').Last();
                    mainTimeLabelUpdate();
                    settingsLangLabelsSetter();
                    settingsCurrencySettingGetter();
                }
            #endregion
        
            #region Main Functions
                public void mainLogWrite(string text) // writes to the log
                {
                    if (Log.Text == "") { Log.Text = "[" + DateTime.Now + "]: " + text; }
                    else
                    { //If logbox is empty dont create a new line
                        Log.Text += Environment.NewLine + "[" + DateTime.Now + "]: " + text;
                    }
                }

                public double mainStringToDouble(string n) // convert string into double and removes any "weird symbols"
                {
                    // deleting all €$ type characters
                    var charsToRemove = new string[] { "€", "$", " ", "%", "£" };
                    foreach (var c in charsToRemove)
                    {
                        n = n.Replace(c, string.Empty);
                    }

                    // parsing int
                    try
                    {
                        Double number = Double.Parse(n);
                        return number;
                    }
                    catch (Exception e)
                    {
                        //if there are normal characters return 0
                        return 0;
                    }
                }

                public void mainTimeLabelUpdate() // updates the label showing the current time
                {
                    switch (settingsLangSettingGetter())
                    {
                        case "English":
                            TotalTime.Text = "Total Time Worked: " + time_current_hours + "h " + time_current_minutes + "m " + time_current_seconds + "s";
                            break;
                        case "Deutsch":
                            TotalTime.Text = "Insgesamte Arbeitszeit: " + time_current_hours + "h " + time_current_minutes + "m " + time_current_seconds + "s";
                            break;
                    }

                }

                private void mainTimerOnTick(object sender, EventArgs e) // gets run every tick the timer makes (while on)
                {
                    time_current_seconds += 1;

                    if (time_current_seconds > 59)
                    {
                        time_current_minutes++;
                        time_current_seconds = 0;
                    }

                    if (time_current_minutes > 59)
                    {
                        time_current_hours++;
                        time_current_minutes = 0;
                    }

                    mainTimeLabelUpdate();
                }
        #endregion
        #endregion


        #region Events
            #region Keyboard KeyPress Events
                private void InputMinutes_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }

                private void InputHours_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }

                private void InputWage_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }

                private void InputBaseCosts_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }

                private void InputTax_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            #endregion

            #region Object Click Events
                #region MenuStrip Click Events
                    private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        Application.Exit();
                    }

                    private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        fileLoad();

                    }

                    private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        fileSave();
                    }


                    private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        //TO:DO new project
                    }

                    private void openPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        Preferences preferences = new Preferences(this);
                        preferences.Show();
                    }

                    private void infoToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        Info info = new Info(this);
                        info.Show();
                    }
                #endregion

                #region Button Click Events
                    private void ButtonReset_Click(object sender, EventArgs e)
                    {
                        if (main_timer_active) { return; }
                        if (MessageBox.Show(lang_label_resetproject_message, lang_label_resetproject_title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            == DialogResult.Yes)
                        {
                            time_current_hours = 0.0;
                            time_current_minutes = 0.0;
                            time_current_seconds = 0.0;
                            mainTimeLabelUpdate();

                            //logging
                            switch (settingsLangSettingGetter())
                            {
                                case "English":
                                    mainLogWrite("[RESET] " + "Time was reset!");
                                    break;
                                case "Deutsch":
                                    mainLogWrite("[ZURÜCKSETZEN] " + "Die Arbeitszeit wurde zurückgesetzt!");
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

                        main_timer_active = false;
                        timer.Stop(); //stop timer

                        //logging
                        switch (settingsLangSettingGetter())
                        {
                            case "English":
                                mainLogWrite("[TIMER] " + "Timer has stopped!");
                                break;
                            case "Deutsch":
                                mainLogWrite("[TIMER] " + "Der Timer wurde angehalten!");
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

                        main_timer_active = true;
                        timer.Start(); //start timer

                        //logging
                        switch (settingsLangSettingGetter())
                        {
                            case "English":
                                mainLogWrite("[TIMER] " + "Timer has started!");
                                break;
                            case "Deutsch":
                                mainLogWrite("[TIMER] " + "Der Timer wurde gestarten!");
                                break;
                        }
                    }

                    private void ButtonCalculate_Click(object sender, EventArgs e)
                    {
                        //calculate result
                        //get variables
                        double wage = mainStringToDouble(InputWage.Text.Replace(".", ","));
                        double tax = mainStringToDouble(InputTax.Text.Replace(".", ","));
                        double basecosts = mainStringToDouble(InputBaseCosts.Text.Replace(".", ","));
                        double hours = (time_current_minutes / 60) + time_current_hours;

                        Double result = (hours * wage); //calculate base result
                        result = result + basecosts; //add basecosts
                        result = result + (result * (tax / 100)); //add tax
                        result = Math.Round(result, 2); //round

                        String export = result.ToString();

                        if (hours == 0)
                        {
                            switch (settingsLangSettingGetter())
                            {
                                case "English":
                                    mainLogWrite("[CALCULATE] You need to add Time first!");
                                    break;
                                case "Deutsch":
                                    mainLogWrite("[BERECHNUNG] Sie müssen Zeit zuvor hinzufügen!");
                                    break;
                            }

                            return;
                        } //if u havent worked any time just exit this function

                        //set label
                        switch (settingsLangSettingGetter())
                        {
                            case "English":
                                LabelResult.Text = "Result: " + export + settingsCurrencySettingGetter();
                                break;
                            case "Deutsch":
                                LabelResult.Text = "Ergebnis: " + export + settingsCurrencySettingGetter();
                                break;
                        }


                        //logging
                        switch (settingsLangSettingGetter())
                        {
                            case "English":
                                mainLogWrite("[CALCULATE] " + "Time: " + time_current_hours + "h " + time_current_minutes + "m, "
                                 + "Basecosts: " + basecosts + settingsCurrencySettingGetter() + ", " + settingsCurrencySettingGetter() + " per h: " + wage + settingsCurrencySettingGetter() + ", " + "Tax: " + tax + "%, "
                                 + "Result: " + export + settingsCurrencySettingGetter());
                                break;
                            case "Deutsch":
                                mainLogWrite("[BERECHNUNG] " + "Zeit: " + time_current_hours + "h " + time_current_minutes + "m, "
                                + "Basiskosten: " + basecosts + settingsCurrencySettingGetter() + ", " + settingsCurrencySettingGetter() + " pro Stunde: " + wage + settingsCurrencySettingGetter() + ", " + "Steuern: " + tax + "%, "
                                + "Ergebnis: " + export + settingsCurrencySettingGetter());
                                break;
                        }
                    }

                    private void ButtonAccept_Click(object sender, EventArgs e)
                    {
                        if (main_timer_active) { return; }
                        double minutes = mainStringToDouble(InputMinutes.Text);
                        double hours = mainStringToDouble(InputHours.Text);

                        //delete decimals
                        if (minutes >= 60)
                            { //get hours from minutes
                                var i = minutes / 60;
                                var i_decimals = i - Math.Truncate(i);
                                minutes = Math.Round(i_decimals * 60);
                                hours += Math.Floor(i);
                            }
                        minutes = Math.Floor(minutes);
                        hours = Math.Floor(hours);

                        bool add = Add.Checked;
                        bool remove = Remove.Checked;

                        double beforeHours = time_current_hours;
                        double beforeMinutes = time_current_minutes;

                        //if nothings checked
                        if (hours == 0 && minutes == 0)
                        {
                            return;
                        }
                        if (add == false && remove == false)
                        {
                            return;
                        }

                        else //if adds checked
                        if (add == true)
                        {
                            time_current_hours += hours;
                            time_current_minutes += minutes;

                            //check if minutes over 59
                            if (time_current_minutes >= 60)
                            {
                                var i = time_current_minutes;

                                var i_decimals = i - Math.Truncate(i);
                                time_current_minutes = Math.Round(i_decimals * 60);
                                time_current_hours = time_current_hours + Math.Floor(i);
                            }

                            switch (settingsLangSettingGetter())
                            {
                                case "English":
                                    mainLogWrite("[MANUAL ADD] " + "Time Before: " + beforeHours + "h " + beforeMinutes + "m, "
                                        + "Added: " + hours + "h " + minutes + "m, "
                                        + "Current Time: " + time_current_hours + "h " + time_current_minutes + "m");
                                    break;
                                case "Deutsch":
                                    mainLogWrite("[ZEIT ADDITION] " + "Zeit davor: " + beforeHours + "h " + beforeMinutes + "m, "
                                        + "Addierte Zeit: " + hours + "h " + minutes + "m, "
                                        + "Momentane Zeit: " + time_current_hours + "h " + time_current_minutes + "m");
                                    break;
                            }

                            mainTimeLabelUpdate();

                        }
                        else //if removes checked
                        if (remove == true)
                        {
                            time_current_hours -= hours;
                            time_current_minutes -= minutes;

                            //check if 0
                            if (time_current_minutes < 0)
                            {
                                if (time_current_hours >= 1)
                                {
                                    time_current_minutes = 60 + time_current_minutes;
                                    time_current_hours -= 1;
                                }
                                else
                                {
                                    time_current_minutes = 0;
                                }
                            }
                            if (time_current_hours < 0)
                            {
                                time_current_hours = 0;
                                time_current_minutes = 0;
                            }

                            switch (settingsLangSettingGetter())
                            {
                                case "English":
                                    mainLogWrite("[MANUAL REMOVE] " + "Time Before: " + beforeHours + "h " + beforeMinutes + "m, "
                                        + "Removed: " + hours + "h " + minutes + "m, "
                                        + "Current Time: " + time_current_hours + "h " + time_current_minutes + "m");
                                    break;
                                case "Deutsch":
                                    mainLogWrite("[ZEIT SUBTRAKTION] " + "Zeit davor: " + beforeHours + "h " + beforeMinutes + "m, "
                                        + "Subtrahierte Zeit: " + hours + "h " + minutes + "m, "
                                        + "Momentane Zeit: " + time_current_hours + "m " + time_current_minutes + "m");
                                    break;
                            }

                            mainTimeLabelUpdate();
                        }


                    }

                    private void ButtonSave_Click(object sender, EventArgs e)
                    {
                        fileSave();
                    }

                    private void ButtonLoad_Click(object sender, EventArgs e)
                    {
                        fileLoad();
                    }
                #endregion
            #endregion
        #endregion
    }

}
