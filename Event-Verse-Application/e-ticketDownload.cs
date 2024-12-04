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
    public partial class e_ticketDownload : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");
        public e_ticketDownload()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void openbookTicket(object obj)
        {
            Application.Run(new BookTicket());
        }


        //this is actually the backToBookTicket_button
        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //this will take the user to AttendeeDashboard page
            //the user can access tickets download from the dashboard, when they double click a selected event being shown
            //only if the event has had ticket booked for the attendee and not downloaded

            //open the book ticket page:
            this.Close();
            threadObj = new Thread(openbookTicket);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }



        private void generateQR_button_Click(object sender, EventArgs e)
        {
            //this will generate QR code based on the ticket details.
            //we need to first store the ticket details in variables and then generate QR code.
        }

        private void e_ticketDownload_Load(object sender, EventArgs e)
        {

        }
    }
}
