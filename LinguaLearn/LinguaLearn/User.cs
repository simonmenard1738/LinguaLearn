using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLearn
{
    public class User
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Username)}={Username}, {nameof(Password)}={Password}, {nameof(Email)}={Email}}}";
        }

        public User(string uname, string pword, string email) { 
            this.Username = uname ;
            this.Password = pword ;
            this.Email = email ;
        }
    }
}
