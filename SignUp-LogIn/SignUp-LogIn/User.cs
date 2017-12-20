using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp_LogIn
{
    //Class to store user objects
    class User
    {
        public string UserName { get; set; } //auto-implemented property
        public string Password { get; set; } //auto-implemented property

        public User (string u , string p) //User constructor
        {
            UserName = u;
            Password = p;
        }
    }
}
