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
using System.Data.SqlClient;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;
using Event_Verse_Application.Attendee_Files;

namespace Event_Verse_Application.Organizer_Files
{
    public partial class CreateEvent : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public CreateEvent()
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

        private void create_button_Click(object sender, EventArgs e)
        {
            //store the input given in variables.
            //sql query to insert the data into the database.
            //once inserted the approval flag must be made false. so that admin can approve it.

            //return to the dashboard.
            this.Close();
            threadObj = new Thread(openOrganizerDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //open the organizer dashboard:
            this.Close();
            threadObj = new Thread(openOrganizerDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }
    }
}
