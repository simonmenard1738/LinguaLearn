using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLearn
{
    public class Record
    {
        public string Username { get; set; }
        public List<string> Exercises { get; set; }

        public Record(string Username) {
            this.Username = Username;
        }

        public void AddExercise(Question quiz) {
            Exercises.Add($"{quiz.Name}: Done on {quiz.timeStarted}. Result: {quiz.Grade}/{quiz.QUESTION_COUNT}");
        }

        public static void SaveRecord() { 
            
        }
    }
}
