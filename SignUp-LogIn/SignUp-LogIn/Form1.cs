using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp_LogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UserDB newUsers = new UserDB(); //Instantiate UserDB list object
        
        //Sign up event
        private void btnSignUp_Click(object sender, EventArgs e)
        { 
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            User newUser = new User(username,password);//Instantiate User object
            newUsers.AddToList(newUser); //Add newUser object to UserDB list

            //Clears text boxes and focuses on username
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus(); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            newUsers.SaveList();//Writes newUsers list to file on closing
        }
    }
}
