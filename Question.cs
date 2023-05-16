using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Threading;

namespace LinguaLearn
{
    public class Question
    {
        public DateTime timeStarted;
        private bool muted = false;
        public string Name { get; set; }
        public int Grade { get; set; }
        public readonly int QUESTION_COUNT;
        SoundPlayer correct;
        SoundPlayer incorrect;
        public Random random = new Random();
        public Question(string name, int totalQuestions)
        {
            timeStarted = DateTime.Now;
            Name = name;
            Grade = totalQuestions;
            QUESTION_COUNT = totalQuestions;
            correct = new SoundPlayer(Path.Combine(Directory.GetCurrentDirectory(), "correct.wav"));
            incorrect = new SoundPlayer(Path.Combine(Directory.GetCurrentDirectory(),"incorrect.wav"));
        }

        public void CorrectAnswer() {
            
            if (!muted) {
                correct.Play();
                Thread.Sleep(800);
            }
            
        }
        public void IncorrectAnswer() {
            
            if (!muted) {
                incorrect.Play();
                Thread.Sleep(800);
            }
            Grade--;
        }

        public void ToggleMute() {
            muted = !muted;
        }

        public string Test() {
            IncorrectAnswer();
            return Path.Combine(Directory.GetCurrentDirectory());
        }

    }
}
