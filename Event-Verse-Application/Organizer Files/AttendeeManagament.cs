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

namespace Event_Verse_Application.Organizer_Files
{
    public partial class AttendeeManagament : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public AttendeeManagament()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Navigation methods:
        private void openOrganizerDashboard(object obj)
        {
            Application.Run(new OrganizerDashboard());
        }


        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //open organizer dashboard:
            this.Close();
            threadObj = new Thread(openOrganizerDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void searchAttendee_button_Click(object sender, EventArgs e)
        {
            //when clicked, used the event id entered in the search box to query for the attendees that have booked ticket for this event. 
            //this query needs there to be seperate table called "attending" where only the attendee id and event id are used to list the people attending every event.
            //the qury table will also have the columns for ticketBooked (boolean) and ticketDonwloaded (boolean)

            //count the total number of attendess for the event searched and display it in the textbox
            //store the total count for attendees and then query to find how many attendees have not downloaded the e-ticket for the event id searched, this is the way we will calculate if the attendee really did come. 

        }
        private void deleteSelectedAttendee_button_Click(object sender, EventArgs e)
        {
            //needs the user to select a row in the data grid 
            //this attendee will be removed from the attending table.
        }

        private void AttendeeManagament_Load(object sender, EventArgs e)
        {

        }

    }
}
