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
        public enum answer { their, theyre, there, ça, sa, çà, lo, la, el, ERROR };
        public Dictionary<String, answer> questions = new Dictionary<String, answer>();
        public new Random random = new Random();
        int lang;
        public ThereQuestion(string name, int totalQuestions, int lang) : base(name, totalQuestions)
        {
            if (lang >= 0 && lang <= 2)
            {
                this.lang = lang;
            }
            GenerateQuestions();
        }
        public void GenerateQuestions()
        {
            StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + $"\\Their\\questions{lang}.txt");

            while (!reader.EndOfStream)
            {
                string[] question = reader.ReadLine().Split(';');
                questions.Add(question[0], GetAnswer(int.Parse(question[1])));
            }
        }

        public answer GetAnswer(int request = 0)
        {
            if (lang == 0)
            {
                switch (request)
                {
                    case 0:
                        return answer.their;
                    case 1:
                        return answer.theyre;
                    case 2:
                        return answer.there;
                }
                return answer.ERROR;
            }
            else if (lang == 1)
            {
                switch (request)
                {
                    case 0:
                        return answer.ça;
                    case 1:
                        return answer.sa;
                    case 2:
                        return answer.çà;
                }
                return answer.ERROR;
            }
            else if (lang == 2)
            {
                switch (request)
                {
                    case 0:
                        return answer.lo;
                    case 1:
                        return answer.la;
                    case 2:
                        return answer.el;
                }
                return answer.ERROR;
            }
            return answer.ERROR;
        }




    }

}

