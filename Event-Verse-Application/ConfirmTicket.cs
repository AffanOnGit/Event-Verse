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
    public partial class ConfirmTicket : Form
    {
        public ConfirmTicket()
        {
            InitializeComponent();
        }

        private void cancelConfirmation_button_Click(object sender, EventArgs e)
        {
            //this will cancel the confirmation of ticket. 
            //user redirected to the Book ticket page.
        }

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
        }
    }
}
