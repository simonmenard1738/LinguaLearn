using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinguaLearn
{
    internal class ThereQuestion : Question
    {
        public enum answer { their, theyre, there, ERROR };
        public Dictionary<String, answer> questions = new Dictionary<String, answer>();
        public Random random = new Random();
        public ThereQuestion(string name, int totalQuestions) : base(name, totalQuestions)
        {
            GenerateQuestions();
        }
        public void GenerateQuestions()
        {
            StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Their" + "\\questions.txt");

            while (!reader.EndOfStream) {
                string[] question = reader.ReadLine().Split(';');
                questions.Add(question[0], GetAnswer(int.Parse(question[1])));
            }
        }

        public answer GetAnswer(int request = 0) {
            switch (request) {
                case 0:
                    return answer.their;
                case 1:
                    return answer.theyre;
                case 2:
                    return answer.there;
            }
            return answer.ERROR;
        }


                
    }

 }

