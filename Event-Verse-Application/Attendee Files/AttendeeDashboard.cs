using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//added the following namesapces:
using System.Data.SqlClient;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;
using Event_Verse_Application.Attendee_Files;


namespace Event_Verse_Application
{
    public partial class AttendeeDashboard : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public AttendeeDashboard()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AttendeeDashboard_Load(object sender, EventArgs e)
        {

        }


        //helpful methods for navigation:
        private void openUpcomingEvents(object obj)
        {
            Application.Run(new UpcomingEvents());
        }
        private void openEventBooking(object obj)
        {
            Application.Run(new BookTicket());
        }
        private void openFeedback(object obj)
        {
            Application.Run(new EventFeedback());
        }
        private void openProfile(object obj)
        {
            Application.Run(new AttendeeProfileManagement());
        }
        private void openComplaintForm(object obj)
        {
            Application.Run(new AttendeeComplaintForm());
        }


        private void upcomingEvents_button_Click(object sender, EventArgs e)
        {
            //this will take the user to UpcomingEvents page
            this.Close();
            threadObj = new Thread(openUpcomingEvents);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void eventBooking_button_Click(object sender, EventArgs e)
        {
            //this will redirect to BookTicket page.
            this.Close();
            threadObj = new Thread(openEventBooking);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void giveFeedback_button_Click(object sender, EventArgs e)
        {
            //this option can only be selected if there is an event selected in the data grid. 
            //the selected event is already registered so the user can give feedback.
            //data of the event is also passed to the feedback form. => this will help in DB insertion.

            //this will redirect to EventFeedback page.
            this.Close();
            threadObj = new Thread(openFeedback);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            //this will take the user to Profile page
            this.Close();
            threadObj = new Thread(openProfile);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void registerComplaint_button_Click(object sender, EventArgs e)
        {
            //this will open the complaint form.
            this.Close();
            threadObj = new Thread(openComplaintForm);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }
    }
}
