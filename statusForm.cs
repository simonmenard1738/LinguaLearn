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
    public partial class statusForm : Form
    {
        Record record;
        mainForm form;
        public statusForm(Record record, mainForm form)
        {
            this.form = form;
            this.record= record;
            InitializeComponent();
            foreach (string val in record.Exercises) { 
                recordListBox.Items.Add(val);
            }
        }

        private void statusForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void statusForm_Load(object sender, EventArgs e)
        {

        }

        private void langComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qType = (string) langComboBox.SelectedItem;
            recordListBox.Items.Clear();    
            foreach (string val in record.Exercises)
            {
                if (val.Contains(qType))
                {
                    recordListBox.Items.Add(val);
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
    }
}
