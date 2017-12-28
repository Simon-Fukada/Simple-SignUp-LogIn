using Xunit;
using SignUp_LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp_LogIn.Tests
{
    public class UserTests
    {
        [Fact()]
        public void UserTest()
        {
            User testUser = new User("testu","testp");//testing the User constructor
            Assert.IsType<User>(testUser);
        }
    }
}