using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLearn
{
    internal class User
    {
        private string FName { get; set; }
        private string LName { get; set; }
        private string Password { get; set; }
        public string Username { get; set; }

        public User(String fullName, String uName, String pWord, Record userRecord = null) { 
            
        }
    }
}
