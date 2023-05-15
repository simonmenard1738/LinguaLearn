using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinguaLearn
{
    public partial class mainForm : Form
    {
        Timer timer = new Timer();
        public mainForm()
        {
            InitializeComponent();
            // Set up the timer
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label with current date and time
            displayLabel.Text = DateTime.Now.ToString();
        }

    }
}
