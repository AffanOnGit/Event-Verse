using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//added the following namesapces:
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;
using Event_Verse_Application.Attendee_Files;


namespace Event_Verse_Application.Organizer_Files
{
    public partial class TicketAndSalesManagement : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public TicketAndSalesManagement()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Navigation methods:
        private void openOrganizerDashboard (object obj)
        {
            Application.Run(new OrganizerDashboard());
        }

        private void TicketAndSalesManagement_Load(object sender, EventArgs e)
        {
            //on loading i want you to calculate the total sale for each category, VIP and General. 
            //populate the respective text boxes with the total sales for each category.
            //use the events table and count those events for which the tickets have been booked. 
        }

        private void updateTicketInfo_button_Click(object sender, EventArgs e)
        {
            //this will store the text in the new text boxes and update ticked in SQL

            //open organizer dashboard:
            this.Close();
            threadObj = new Thread(openOrganizerDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();

        }

        private void searchEvent_button_Click(object sender, EventArgs e)
        {
            //on clicking this button, the event id will be used to search for the event's total sales and current ticket information through the ticket id in the event table.
            //this button ONLY has SQL queries associated with it. 
        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //open organizer dashboard:
            this.Close();
            threadObj = new Thread(openOrganizerDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        //IMPORTANT: 
        //this page will handle the ticket availability for the event, this will be done by using the eventID 
        //we can edit the ticket category (vip or general) for the whole event. 
        //the price of the tickets for the event can also be changed. 
        //total sales for the event can be viewed here. => done by counting the number of tickets sold for the event. (getting the number of attendees that have booked ticket for event)
    }
}
