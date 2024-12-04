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
    public partial class AttendeeRegistration : Form
    {
        public AttendeeRegistration()
        {
            InitializeComponent();
        }

        private void backToRegistration_button_Click(object sender, EventArgs e)
        {
            //go back to the user registration page.
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //since the registration info is already available, clicking this button will add the preference to the attendee in the DB. 
            //registration will be checked here, if user exists, then the user is taken to User Login
        }
    }
}
