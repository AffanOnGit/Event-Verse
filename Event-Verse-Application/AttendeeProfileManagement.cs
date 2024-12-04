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
    public partial class AttendeeProfileManagement : Form
    {
        public AttendeeProfileManagement()
        {
            InitializeComponent();
        }

        private void updateInfo_button_Click(object sender, EventArgs e)
        {
            //this will update the information of the user in the DB.
                //this info will be changed in the text box.
        }

        private void deleteAttendee_button_Click(object sender, EventArgs e)
        {
            //this will delete the user from the DB.
                //after deletion query is done, the user is re-directed to the login page. 
        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //this will take the user to AttendeeDashboard page
        }

        private void pastEventsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open the past events page.
                //the attendee ID is forwared to get the past events for that User.
        }

        private void AttendeeProfileManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
