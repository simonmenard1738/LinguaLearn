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
    public partial class GrammerForm : Form
    {//feed into form constructor 
        ThereQuestion quiz;
        KeyValuePair<string, ThereQuestion.answer> currentQuestion;
        Record record;
        mainForm form;
        public GrammerForm(Record record, mainForm form, int lang = 0)
        {
            this.record = record;
            this.form = form;
            string language = "";
            switch (lang) {
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
            quiz = new ThereQuestion($"{language} Grammar", 10, lang);

            InitializeComponent();
            if (lang == 1)
            {
                thereButton.Text = "çà";
                theirButton.Text = "ça";
                theyreButton.Text = "sa";
            }
            else if (lang == 2)
            {
                thereButton.Text = "el";
                theirButton.Text = "lo";
                theyreButton.Text = "la";
            }
            thereButton.Enabled = false;

            AskQuestion();
            ResetButtons();

        }

        private void Button_CheckedChanged(object sender, EventArgs e)
        {
            int index = 3;
            bool unCheck = false;

            if (theirButton.Checked)
            {
                index = 0;
            }
            else if (theyreButton.Checked)
            {
                index = 1;
            }
            else if (thereButton.Checked)
            {
                index = 2;
            }
            else
            {
                unCheck = true;
            }


            if (!unCheck && thereButton.Enabled)
            {
                if (quiz.GetAnswer(index) == currentQuestion.Value)
                {
                    quiz.CorrectAnswer();
                }
                else
                {
                    quiz.IncorrectAnswer();
                }
                AskQuestion();
                ResetButtons();
            }
            else if (!thereButton.Enabled)
            {
                thereButton.Enabled = true;
                theyreButton.Checked = false;
                theirButton.Checked = false;
                thereButton.Checked = false;
            }
        }

        private void AskQuestion()
        {
            if (quiz.questions.Count != 1)
            {
                this.currentQuestion = quiz.questions.ElementAt(quiz.random.Next(quiz.questions.Count));
                qLabel.Text = this.currentQuestion.Key;
                quiz.questions.Remove(currentQuestion.Key);
            }
            else
            {
                MessageBox.Show($"{quiz.Grade}/{quiz.QUESTION_COUNT}");
                record.AddExercise(quiz);
                form.Show();
                this.Hide();
            }
        }

        public void ResetButtons()
        {
            foreach (Control button in Controls)
            {
                if (button.Name != "qLabel")
                {
                    (button as RadioButton).Checked = false;
                }

            }
        }

        private void qLabel_Click(object sender, EventArgs e)
        {
            //
        }

        private void GrammerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
