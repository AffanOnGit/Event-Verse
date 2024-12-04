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
    public partial class BookTicket : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public BookTicket()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void openAttendeeDashboard(object obj)
        {
            Application.Run(new AttendeeDashboard());
        }

        private void openTicketConfirmation(object obj)
        {
            Application.Run(new ConfirmTicket());
        }


        //IMPORTANT:
        //When user clicks on event in the data grid view, and if the event has been booked but the e-ticket has not been downloaded..then the user is taken to the e-ticket download page directly from the dashboard.


        private void bookTicketButton_Click(object sender, EventArgs e)
        {
            //when this is clicked the SQL query will be executed to reflect ticket has been booked against the user ID, which will be asked in confirmation. The event details will be forwarded to the confrimation window.
            //this will close the current form and open the Confirmation form
            //when datagrid view row is double clicked, i want to store the values of id and name in variables. these will then be sent to the confirmation page.

            //this will close the current form and open the ConfirmaTicket form
            this.Close();
            threadObj = new Thread(openTicketConfirmation);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //this will close the current form and open the AttendeeDashboard form
            this.Close();
            threadObj = new Thread(openAttendeeDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
