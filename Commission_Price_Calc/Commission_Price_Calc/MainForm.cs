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

            settings_lang_settings_set(); //write all the stuff on labels in correct language
            main_time_label_update();
            
            switch (settings_lang_setting_get())
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
                public string settings_currency_setting_get() // returns current currency set in settings
                    {
                        return Settings.Default.Currency.ToString();
                    }

                public string settings_lang_setting_get() // returns string of the set language setting
                    {
                        return Settings.Default["Language"].ToString();
                    }

                public void settings_lang_settings_set() // applies every string for the selected language to labels
                    {
                        switch (settings_lang_setting_get()){
                            case "English":
                                ButtonCalculate.Text = "Calculate";
                                LabelResult.Text = "Result: 0" + settings_currency_setting_get();
                                LabelLog.Text = "Log: ";
                                LabelTax.Text = "% Tax";
                                LabelWage.Text = settings_currency_setting_get() + " Per Hour";
                                LabelBaseCosts.Text = settings_currency_setting_get() + " Base Costs";
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
                                LabelResult.Text = "Ergebnis: 0" + settings_currency_setting_get();
                                LabelLog.Text = "Protokoll: ";
                                LabelTax.Text = "% Steuern";
                                LabelWage.Text = settings_currency_setting_get() + " pro Stunde";
                                LabelBaseCosts.Text = settings_currency_setting_get() + " Basiskosten";
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

                         main_time_label_update();
                    }
            #endregion

            #region File I/O Functions
                public void file_save() // project file saving function
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


                    switch (settings_lang_setting_get())
                    {
                        case "English":
                            main_log_write("[SAVE] File has been saved at " + sfd.FileName);
                            break;
                        case "Deutsch":
                            main_log_write("[SPEICHERN] Datei wurde als " + sfd.FileName + " gespeichert");
                            break;
                    }

                    labelProject.Text = sfd.FileName.Split('\\').Last();
                }

                public void file_load()  // project file loading function
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


                    switch (settings_lang_setting_get())
                    {
                        case "English":
                            main_log_write("[LOAD] " + ofd.FileName + " has been loaded");
                            break;
                        case "Deutsch":
                            main_log_write("[LADEN] " + ofd.FileName + " wurde geladen");
                            break;
                    }

                    labelProject.Text = ofd.FileName.Split('\\').Last();
                    main_time_label_update();
                    settings_lang_settings_set();
                    settings_currency_setting_get();
                }
            #endregion
        
            #region Main Functions
                public void main_log_write(string text) // writes to the log
                {
                    if (Log.Text == "") { Log.Text = "[" + DateTime.Now + "]: " + text; }
                    else
                    { //If logbox is empty dont create a new line
                        Log.Text += Environment.NewLine + "[" + DateTime.Now + "]: " + text;
                    }
                }

                public double main_stringtodouble(string n) // convert string into double and removes any "weird symbols"
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

                public void main_time_label_update() // updates the label showing the current time
                {
                    switch (settings_lang_setting_get())
                    {
                        case "English":
                            TotalTime.Text = "Total Time Worked: " + time_current_hours + "h " + time_current_minutes + "m " + time_current_seconds + "s";
                            break;
                        case "Deutsch":
                            TotalTime.Text = "Insgesamte Arbeitszeit: " + time_current_hours + "h " + time_current_minutes + "m " + time_current_seconds + "s";
                            break;
                    }

                }

                private void main_timer_ontick(object sender, EventArgs e) // gets run every tick the timer makes (while on)
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

                    main_time_label_update();
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
                        file_load();
                    }

                    private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        file_save();
                    }

                    private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
                        {
                            time_current_hours = 0.0;
                            time_current_minutes = 0.0;
                            time_current_seconds = 0.0;
                            main_timer_active = false;

                            main_time_label_update();
                            settings_lang_settings_set();
                            settings_currency_setting_get();

                            InputTax.Text = "0.0";
                            InputWage.Text = "10.00";
                            InputBaseCosts.Text = "0.0";
            

                            switch (settings_lang_setting_get())
                                {
                                    case "English":
                                        labelProject.Text = "New Project";
                                        break;
                                    case "Deutsch":
                                        labelProject.Text = "Neues Projekt";
                                        break;
                                }


                            //logging
                            switch (settings_lang_setting_get())
                                {
                                    case "English":
                                        main_log_write("[RESET] The project file was reset!");
                                        break;
                                    case "Deutsch":
                                        main_log_write("[ZURÜCKSETZEN] Die Projektdatei wurde zurückgesetzt!");
                                        break;
                                }
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
                            main_time_label_update();

                            //logging
                            switch (settings_lang_setting_get())
                            {
                                case "English":
                                    main_log_write("[RESET] " + "Time was reset!");
                                    break;
                                case "Deutsch":
                                    main_log_write("[ZURÜCKSETZEN] " + "Die Arbeitszeit wurde zurückgesetzt!");
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
                        switch (settings_lang_setting_get())
                        {
                            case "English":
                                main_log_write("[TIMER] " + "Timer has stopped!");
                                break;
                            case "Deutsch":
                                main_log_write("[TIMER] " + "Der Timer wurde angehalten!");
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
                        switch (settings_lang_setting_get())
                        {
                            case "English":
                                main_log_write("[TIMER] " + "Timer has started!");
                                break;
                            case "Deutsch":
                                main_log_write("[TIMER] " + "Der Timer wurde gestarten!");
                                break;
                        }
                    }

                    private void ButtonCalculate_Click(object sender, EventArgs e)
                    {
                        //calculate result
                        //get variables
                        double wage = main_stringtodouble(InputWage.Text.Replace(".", ","));
                        double tax = main_stringtodouble(InputTax.Text.Replace(".", ","));
                        double basecosts = main_stringtodouble(InputBaseCosts.Text.Replace(".", ","));
                        double hours = (time_current_minutes / 60) + time_current_hours;

                        Double result = (hours * wage); //calculate base result
                        result = result + basecosts; //add basecosts
                        result = result + (result * (tax / 100)); //add tax
                        result = Math.Round(result, 2); //round

                        String export = result.ToString();

                        if (hours == 0)
                        {
                            switch (settings_lang_setting_get())
                            {
                                case "English":
                                    main_log_write("[CALCULATE] You need to add Time first!");
                                    break;
                                case "Deutsch":
                                    main_log_write("[BERECHNUNG] Sie müssen Zeit zuvor hinzufügen!");
                                    break;
                            }

                            return;
                        } //if u havent worked any time just exit this function

                        //set label
                        switch (settings_lang_setting_get())
                        {
                            case "English":
                                LabelResult.Text = "Result: " + export + settings_currency_setting_get();
                                break;
                            case "Deutsch":
                                LabelResult.Text = "Ergebnis: " + export + settings_currency_setting_get();
                                break;
                        }


                        //logging
                        switch (settings_lang_setting_get())
                        {
                            case "English":
                                main_log_write("[CALCULATE] " + "Time: " + time_current_hours + "h " + time_current_minutes + "m, "
                                 + "Basecosts: " + basecosts + settings_currency_setting_get() + ", " + settings_currency_setting_get() + " per h: " + wage + settings_currency_setting_get() + ", " + "Tax: " + tax + "%, "
                                 + "Result: " + export + settings_currency_setting_get());
                                break;
                            case "Deutsch":
                                main_log_write("[BERECHNUNG] " + "Zeit: " + time_current_hours + "h " + time_current_minutes + "m, "
                                + "Basiskosten: " + basecosts + settings_currency_setting_get() + ", " + settings_currency_setting_get() + " pro Stunde: " + wage + settings_currency_setting_get() + ", " + "Steuern: " + tax + "%, "
                                + "Ergebnis: " + export + settings_currency_setting_get());
                                break;
                        }
                    }

                    private void ButtonAccept_Click(object sender, EventArgs e)
                    {
                        if (main_timer_active) { return; }
                        double minutes = main_stringtodouble(InputMinutes.Text);
                        double hours = main_stringtodouble(InputHours.Text);

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

                            switch (settings_lang_setting_get())
                            {
                                case "English":
                                    main_log_write("[MANUAL ADD] " + "Time Before: " + beforeHours + "h " + beforeMinutes + "m, "
                                        + "Added: " + hours + "h " + minutes + "m, "
                                        + "Current Time: " + time_current_hours + "h " + time_current_minutes + "m");
                                    break;
                                case "Deutsch":
                                    main_log_write("[ZEIT ADDITION] " + "Zeit davor: " + beforeHours + "h " + beforeMinutes + "m, "
                                        + "Addierte Zeit: " + hours + "h " + minutes + "m, "
                                        + "Momentane Zeit: " + time_current_hours + "h " + time_current_minutes + "m");
                                    break;
                            }

                            main_time_label_update();

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

                            switch (settings_lang_setting_get())
                            {
                                case "English":
                                    main_log_write("[MANUAL REMOVE] " + "Time Before: " + beforeHours + "h " + beforeMinutes + "m, "
                                        + "Removed: " + hours + "h " + minutes + "m, "
                                        + "Current Time: " + time_current_hours + "h " + time_current_minutes + "m");
                                    break;
                                case "Deutsch":
                                    main_log_write("[ZEIT SUBTRAKTION] " + "Zeit davor: " + beforeHours + "h " + beforeMinutes + "m, "
                                        + "Subtrahierte Zeit: " + hours + "h " + minutes + "m, "
                                        + "Momentane Zeit: " + time_current_hours + "m " + time_current_minutes + "m");
                                    break;
                            }

                            main_time_label_update();
                        }


                    }

                    private void ButtonSave_Click(object sender, EventArgs e)
                    {
                        file_save();
                    }

                    private void ButtonLoad_Click(object sender, EventArgs e)
                    {
                        file_load();
                    }
                #endregion
            #endregion
        #endregion
    }

}
