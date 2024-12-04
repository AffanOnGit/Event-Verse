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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void Register_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //should close this page and open registration.
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //the information for ID and password is queried. 
            //according to ID, the user will be directed to their respective dashboard.
            //for each user type, a different dashboard will be shown.
            //info for users will be queried and then forwarded to the dashboard. => helps in the profile management section of the Users.

        }
    }
}
