using Xunit;
using SignUp_LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp_LogIn.Tests
{
    //Unit testing for UserDB class methods
    public class UserDBTests
    {
        [Fact()]
        public void UserDBTest() //Testing the UserDB Constructor
        {
            UserDB testList = new UserDB();
            Assert.IsType<UserDB>(testList);
        }

        [Fact()]
        public void AddToListTest()
        {
            UserDB testList = new UserDB();
            User testUser = new User("testUsername", "testPassword");
            testList.AddToList(testUser);

            Assert.NotEmpty(testList.List);//Testing the Add to List method in UserDB class
        }

        [Fact()]
        public void SaveListTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void LoadListTest()
        {
        }

        [Fact()]
        public void CheckTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}