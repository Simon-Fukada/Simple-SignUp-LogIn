using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp_LogIn
{
    //Class with methods to read and write list to file, and instantiate list objects
    class UserDB
    {
        const string path = "UserDB.txt"; 

        public List<User> List { get; set; }//auto-implemented property

        public UserDB() //User DB Constructor
        {
            List = new List<User>();
        } 

        public void AddToList (User x) //Method to add User objects to list 
        {
            List.Add(x);
        }

        public void SaveList() //Method to write list to file
        {
            string line;
            
            FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs); 
            
            //loop through list to write usernames and passwords to file
            foreach (User u in List)
            {
                line = u.UserName + "," + u.Password;
                sw.WriteLine(line);
            }
            sw.Close();
        }

        public List<User> LoadList()//Metod to load list from file
        {
            string line;
            string[] parts;
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while(!sr.EndOfStream)
            {
                line = sr.ReadLine();
                parts = line.Split(',');

                User existingUser = new User(parts[0],parts[1]);
                List.Add(existingUser);
            }
            sr.Close();
            return List;
        }

        //Compares username and password for sign in to list of existing usernames and passwords
        public bool Check (string user,string password)
        {
            bool confirm = false;
            foreach (User u in List)
            {
                if(u.UserName == user && u.Password == password)
                {
                    confirm = true;
                }
            }
            return confirm;
        }

    }
}
