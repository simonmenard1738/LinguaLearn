using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace LinguaLearn
{
    
    internal class DictationQuestion : Question
    {
        public Dictionary<String, SoundPlayer> words = new Dictionary<string, SoundPlayer>();
        int lang = 0;
        
        public DictationQuestion(string name, int totalQuestions, int lang) : base( name, totalQuestions){
            this.lang = lang;
            GenerateQuestions();
            
        }
        public void GenerateQuestions() {
            var audioFolder = Path.Combine(Directory.GetCurrentDirectory(), $"Dictation\\{lang}");
            var files = Directory.GetFiles(audioFolder);
            foreach (var word in files)
            {
                int test = word.Length;
                var wordValue = word.Substring(word.LastIndexOf("\\")+1, word.LastIndexOf(".")- (word.LastIndexOf("\\") + 1)); 
                words.Add(wordValue, new SoundPlayer(word));
                
            }

        }

        
    }
}
