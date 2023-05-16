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
using System.Runtime.CompilerServices;

namespace LinguaLearn
{
    
    public partial class mainForm : Form
    {
        User currentUser;
        Record currentRecord;
        Timer timer = new Timer();
        int lang = 0;
        static List<Record> records;
        public mainForm(User currentUser)
        {
            records = JsonConvert.DeserializeObject<List<Record>>(File.ReadAllText("..\\..\\recordsJSON"));
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
            Record record = null;
            if (records != null)
            {
                record = records.FirstOrDefault(u => u.Username == username);
            }
            else { 
                records = new List<Record>();
            }
            
            
            if (record == null)
            {
                MessageBox.Show($"No record was found for user '{username}'.");
                record = new Record(username);
                record.Exercises = new List<string>();
                records.Add(record);
                SaveRecords(records);
                return record;

            }
            else
            {
                return record;
            }
        }

        public void UpdateRecord() {
            if (records == null) {
                records = new List<Record>();
            }
            foreach (Record record in records) {
                if (record.Username == this.currentUser.Username) {
                    record.Exercises = currentRecord.Exercises;
                }
            }
            SaveRecords(records);
        }

        public static void SaveRecords(List<Record> records)
        {
            string json = JsonConvert.SerializeObject(records);
            File.WriteAllText("..\\..\\recordsJSON", json);

        }

        private void grammerButton_Click(object sender, EventArgs e)
        {
            GrammerForm newGrammer = new GrammerForm(currentRecord, this, lang);
            newGrammer.Show();
            this.Hide();
        }

        private void vocabularyButton_Click(object sender, EventArgs e)
        {
            DictationForm newDictation = new DictationForm(currentRecord, this);
            newDictation.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            Application.Exit();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            string recordString = "";
            foreach (string exercise in currentRecord.Exercises) { 
                recordString += exercise +"\n";
            }
            MessageBox.Show(recordString, $"{currentUser.Username}'s Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lang = languageComboBox.SelectedIndex;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.Show();
        }
    }
}
