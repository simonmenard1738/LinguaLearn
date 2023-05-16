using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LinguaLearn
{
    
    public partial class mainForm : Form
    {
        User currentUser;
        Record currentRecord;
        Timer timer = new Timer();
        public mainForm(User currentUser)
        {
            this.currentUser = currentUser;
            currentRecord = LoadRecord(currentUser.Username);
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

        public static Record LoadRecord(string username)
        {
            string json = File.ReadAllText("..\\..\\recordsJSON");
            List<Record> records = JsonConvert.DeserializeObject<List<Record>>(json);
            Record record = records.FirstOrDefault(u => u.Username == username);
            if (record == null)
            {
                MessageBox.Show($"No record was found for user '{username}'.");
                return null;
            }
            else
            {
                return record;
            }
        }

    }
}
