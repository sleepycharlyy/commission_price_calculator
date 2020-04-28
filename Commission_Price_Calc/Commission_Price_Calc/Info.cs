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
    public partial class Info : Form
    {
        private MainForm _mainForm;
        public Info(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void buttonSourceCode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sleepycharlyy/commission_price_calculator");
        }

        private void buttonBugs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sleepycharlyy/commission_price_calculator/issues");
        }

        private void buttonTumblr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sleepycharlyy.tumblr.com");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
