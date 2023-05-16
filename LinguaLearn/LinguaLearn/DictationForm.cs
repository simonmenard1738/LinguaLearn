using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LinguaLearn
{
    public partial class DictationForm : Form
    {
        DictationQuestion a = new DictationQuestion("What is what", 8);
        string answer = "";
        public DictationForm()
        {
            InitializeComponent();
            AskQuestion();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.ToLower().Equals(answer))
            {
                a.CorrectAnswer();
                AskQuestion();
            }
            else { 
                a.IncorrectAnswer();
                AskQuestion();
            }
        }
        public void AskQuestion()
        {
            if (a.words.Count != 0)
            {
                //displayLabel.Text = a.words.ElementAt(a.random.Next(a.words.Count)).Key;
                var ask = a.words.ElementAt(a.random.Next(a.words.Count));
                answer = ask.Key;
                ask.Value.Play();
                a.words.Remove(answer);
            }
            else {
                MessageBox.Show("Your result is" + a.Grade + "/" + a.QUESTION_COUNT);
            }
            
        }
    }
}
