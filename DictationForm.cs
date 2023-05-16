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
        DictationQuestion quiz;
        string answer = "";
        Record record;
        mainForm form;
        int count;
        int lang;
        public DictationForm(Record record, mainForm form, int lang = 0)
        {
            this.count = 0;
            this.form = form;
            this.record = record;
            this.lang = lang;
            string language = "";
            switch (lang)
            {
                case 0:
                    language = "English";
                    break;
                case 1:
                    language = "French";
                    break;
                case 2:
                    language = "Spanish";
                    break;
            }
            quiz = new DictationQuestion($"{language} Dictation", 8, lang);
            InitializeComponent();
            AskQuestion();
            
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.ToLower().Equals(answer))
            {
                quiz.CorrectAnswer();
                AskQuestion();
            }
            else { 
                quiz.IncorrectAnswer();
                AskQuestion();
            }
            inputTextBox.Text = "";
        }
        public void AskQuestion()
        {
            
            if (quiz.words.Count != 0)
            {
                //displayLabel.Text = a.words.ElementAt(a.random.Next(a.words.Count)).Key;
                var ask = quiz.words.ElementAt(quiz.random.Next(quiz.words.Count));
                answer = ask.Key;
                ask.Value.Play();
                quiz.words.Remove(answer);
                count++;
            }
            else {
                MessageBox.Show("Your result is" + quiz.Grade + "/" + quiz.QUESTION_COUNT);
                record.AddExercise(quiz);
                form.Show();
                this.Hide();
            }

            
        }

        private void DictationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
