using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Verse_Application
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void Login_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //should close this page and open login. 
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //check all the information entered. 
            //if all the information is correct, then register the user.
            //based on the user type, open the respective page.

            //based on user type, windows opens to get the specific info for the particular user types. 

            //forwards the info entered by the user here to login page. => helps in the login process.
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
