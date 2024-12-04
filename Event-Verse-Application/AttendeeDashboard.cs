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
    public partial class AttendeeDashboard : Form
    {
        public AttendeeDashboard()
        {
            InitializeComponent();
        }

        private void AttendeeDashboard_Load(object sender, EventArgs e)
        {

        }

        private void upcomingEvents_button_Click(object sender, EventArgs e)
        {
            //this will take the user to UpcomingEvents page
        }

        private void eventBooking_button_Click(object sender, EventArgs e)
        {
            //this will redirect to BookTicket page.
        }

        private void giveFeedback_button_Click(object sender, EventArgs e)
        {
            //this option can only be selected if there is an event selected in the data grid. 
            //the selected event is already registered so the user can give feedback.
            //data of the event is also passed to the feedback form. => this will help in DB insertion.
            //this will redirect to EventFeedback page.
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            //this will take the user to Profile page
        }
    }
}
