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
    public partial class OrganizerDashboard : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public OrganizerDashboard()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        //Navigation methods:
        private void openUpdateEventForm(object obj)
        {
            Application.Run(new UpdateEvent());
        }
        private void openCreateEventForm(object obj)
        {
            Application.Run(new CreateEvent());
        }
        private void openTicketAndSalesForm(object obj)
        {
            Application.Run(new TicketAndSalesManagement());
        }
        private void openAttendeeManagement(object obj) {
            Application.Run(new AttendeeManagament());
        }
        private void openResourceAndVendorManagement(object obj)
        {
            Application.Run(new ResourceAndVendorManagement());
        }
        private void openEventAnalytics(object obj)
        {
            Application.Run(new EventFeedbackView());
        }
        private void openComplaintForm(object obj)
        {
            Application.Run(new OrganizerComplaintForm());
        }
        private void openProfileManagement(object obj)
        {
            Application.Run(new OrganizerProfileManagement());
        }


        private void OrganizerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void deleteSelectedEvent_button_Click(object sender, EventArgs e)
        {
            //it will take the selected row and delete it from the database
        }

        private void updateSelectedEvent_button_Click(object sender, EventArgs e)
        {
            //pass the selected event id to the update event form.

            //open UpdateEvent form. 
            this.Close();
            threadObj = new Thread(openUpdateEventForm);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void createEvent_button_Click(object sender, EventArgs e)
        {
            //store the organizer id in a variable and pass it on to the create event form.

            //open CreateEvent form.
            this.Close();
            threadObj = new Thread(openCreateEventForm);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void ticketAndSales_button_Click(object sender, EventArgs e)
        {
            //store the selected event id in a variable and pass it on to the ticket and sales form.

            //open the ticket and sales form.
            this.Close();
            threadObj = new Thread(openTicketAndSalesForm);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void attendeeManagement_button_Click(object sender, EventArgs e)
        {
            //store the selected event id in a variable and pass it on to the attendee management form.

            //open the attendee management form.
            this.Close();
            threadObj = new Thread(openAttendeeManagement);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void resourceAndVendorManagement_button_Click(object sender, EventArgs e)
        {
            //store the selected event id in a variable and pass it on to the resource and vendor management form.

            //open the resource and vendor management form.
            this.Close();
            threadObj = new Thread(openResourceAndVendorManagement);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        //event feedback button
        private void eventAnalytics_button_Click(object sender, EventArgs e)
        {
            //store the selected event id in a variable and pass it on to the event analytics form.

            //open the event analytics form.
            this.Close();
            threadObj = new Thread(openEventAnalytics);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void registerComplaint_button_Click(object sender, EventArgs e)
        {
            //store the organizer id in a variable and pass it on to the complaint form.

            //open the complain form for organizer.
            this.Close();
            threadObj = new Thread(openComplaintForm);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            //store the organizer id, name, email, contact, organization name, and password in variables and pass them on to the profile management form.

            //open the profile management form.
            this.Close();
            threadObj = new Thread(openProfileManagement);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }




        //IMPORTANT:
        //when the user double clicks on an event, then the values displayed will be stored in variables. 
        // then this info will be passed on to delete event button and update event form.
            //also show if the event has been approved by admin or not. 

        //get all the organizer information from the initial registration. 
        //this will be stored in the dashboard and then sent as arguements when needed. 
    }
}
