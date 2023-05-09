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
    public partial class Form2 : Form
    {
        //feed into form constructor 
        ThereQuestion quiz = new ThereQuestion("There question", 10);
        KeyValuePair<string, ThereQuestion.answer> currentQuestion;
        public Form2()
        {
            
            InitializeComponent();
            thereButton.Enabled= false;
            
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
            else { 
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
            else if (!thereButton.Enabled) { 
                thereButton.Enabled = true;
                theyreButton.Checked = false;
                theirButton.Checked = false;
                thereButton.Checked = false;
            }
        }

        private void AskQuestion() {
            if (quiz.questions.Count!=0) {
                this.currentQuestion = quiz.questions.ElementAt(quiz.random.Next(quiz.questions.Count));
                qLabel.Text = this.currentQuestion.Key;
                quiz.questions.Remove(currentQuestion.Key);
            }
        }

        public void ResetButtons() {
            foreach (Control button in Controls) {
                if (button.Name!="qLabel") {
                    (button as RadioButton).Checked = false;
                }
                
            }
        }

        private void qLabel_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
