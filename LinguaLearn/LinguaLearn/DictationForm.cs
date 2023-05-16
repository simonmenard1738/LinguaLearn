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
        DictationQuestion quiz = new DictationQuestion("Spelling Bee", 8);
        string answer = "";
        Record record;
        mainForm form;
        static int count;
        public DictationForm(Record record, mainForm form)
        {
            this.form = form;
            this.record = record;
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
        }
        public void AskQuestion()
        {
            
            if (quiz.words.Count != 0 && quiz.QUESTION_COUNT<=count)
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
    }
}
