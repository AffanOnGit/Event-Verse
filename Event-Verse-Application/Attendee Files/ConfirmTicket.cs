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

namespace Event_Verse_Application
{
    public partial class ConfirmTicket : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public ConfirmTicket()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void openEventBooking(object obj)
        {
            Application.Run(new BookTicket());
        }

        private void openTicketDownload(object obj)
        {
            Application.Run(new e_ticketDownload());
        }

        private void cancelConfirmation_button_Click(object sender, EventArgs e)
        {
            //this will cancel the confirmation of ticket. 

            //user redirected to the Book ticket page.
            this.Close();
            threadObj = new Thread(openEventBooking);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }


        //DO NOT USE THIS METHOD => DOES NOT WORK
        private void ConfirmTicket_Load(object sender, EventArgs e)
        {
            //this page should load the event ID, event name from the selected event.
            //the selected event will be in the Book ticket page, when user selects on the data grid view.

        }

        private void bookTicket_button_Click(object sender, EventArgs e)
        {
            //this will confirm the ticket.
            //the ticket will be booked against the user ID.
            //this will then close and will take user to the e-ticketDownload page.

            //the id that is generated for the ticked in the database is also forwarded to the e-ticketDownload page.


            //open e-ticket page:
            this.Close();
            threadObj = new Thread(openTicketDownload);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }
    }
}
