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
using Event_Verse_Application.Organizer_Files;

namespace Event_Verse_Application
{
    public partial class UserLogin : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public UserLogin()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        //Navigation methods:
        private void openUserRegistration(object obj)
        {
            Application.Run(new UserRegistration());
        }
        private void openOrganizerDashboard(object obj)
        {
            Application.Run(new OrganizerDashboard());
        }
        private void openAttendeeDashboard(object obj)
        {
            Application.Run(new AttendeeDashboard());
        }


        private void Register_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //should close this page and open registration.
            this.Close();
            threadObj = new Thread(openUserRegistration);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //the information for ID and password is queried. 
            //according to ID, the user will be directed to their respective dashboard.
            //for each user type, a different dashboard will be shown.
            //info for users will be queried and then forwarded to the dashboard. => helps in the profile management section of the Users.


            //open the attendee dashboard;
            //this.Close();
            //threadObj = new Thread(openAttendeeDashboard);
            //threadObj.SetApartmentState(ApartmentState.STA);
            //threadObj.Start();

            //open the organizer dashboard;
            this.Close();
            threadObj = new Thread(openOrganizerDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
