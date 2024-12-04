using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//added the following namesapces:
using System.Data.SqlClient;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace Event_Verse_Application
{
    public partial class AttendeeProfileManagement : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public AttendeeProfileManagement()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void openAttendeeDashboard(object obj)
        {
            Application.Run(new AttendeeDashboard());
        }

        private void openPastEvents(object obj)
        {
            Application.Run(new AttendeePastEvents());
        }
        private void openUserLogin(object obj)
        {
            Application.Run(new UserLogin());
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
            this.Close();
            threadObj = new Thread(openAttendeeDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void pastEventsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //the attendee ID is forwared to get the past events for that User.
            //open the past events page.
            this.Close();
            threadObj = new Thread(openPastEvents);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();

        }

        private void AttendeeProfileManagement_Load(object sender, EventArgs e)
        {

        }

        private void logOut_button_Click(object sender, EventArgs e)
        {
            //this will log out the user and take them to the login page.
            this.Close();
            threadObj = new Thread(openUserLogin);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }
    }
}
