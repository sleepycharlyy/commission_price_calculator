using Commission_Price_Calc.Properties;
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
    public partial class Preferences : Form
    {
        private MainForm _mainForm;
        public Preferences(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            comboBoxCurrency.Text = Settings.Default.Currency;
            comboBoxLanguage.Text = Settings.Default.Language;

            changeLabelLang();
        }

        #region Design and Interactivity
            private void buttonOK_Click(object sender, EventArgs e)
                {
                    this.Close();
                }

            private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
                {
                    Settings.Default.Language = comboBoxLanguage.Text;
                    Settings.Default.Save();
                    changeLabelLang();
                    _mainForm.settings_lang_settings_set();
                }

            private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
                {
                    Settings.Default.Currency = comboBoxCurrency.Text;
                    Settings.Default.Save();
                    _mainForm.settings_currency_setting_get();
                    _mainForm.settings_lang_settings_set();
                }

            public void changeLabelLang()
                {
                    switch (_mainForm.settings_lang_setting_get())
                    {
                        case "English":
                            labelCurrency.Text = "Currency";
                            labelLanguage.Text = "Language";
                            this.Text = "Preferences";
                            break;
                        case "Deutsch":
                            labelCurrency.Text = "Währung";
                            labelLanguage.Text = "Sprachen";
                            this.Text = "Einstellungen";
                            break;
                    }
                }
        #endregion

    }
}
