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
    public partial class OrganizerProfileManagement : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public OrganizerProfileManagement()
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
        private void openUserLogin(object obj)
        {
            Application.Run(new UserLogin());
        }

        private void OrganizerProfileManagement_Load(object sender, EventArgs e)
        {

        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //open the OrganizerDashboard form
            this.Close();
            threadObj = new Thread(openOrganizerDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void logOut_button_Click(object sender, EventArgs e)
        {
            //open the userLogin page:
            this.Close();
            threadObj = new Thread(openUserLogin);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void deleteAttendee_button_Click(object sender, EventArgs e)
        {
            //the organizer ID will be transferred from the dashboard. 
            //based on id the organizer will be deleted from the DB.
                //IMPORTANT => the all events managed by the organizer will be deleted as well.



            //open the userLogin page:
            this.Close();
            threadObj = new Thread(openUserLogin);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void updateInfo_button_Click(object sender, EventArgs e)
        {
            //store the information from text in the form. 



            //open the OrganizerDashboard form
            this.Close();
            threadObj = new Thread(openOrganizerDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }
    }
}
