using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//following namespaces added:
using System.Data.SqlClient;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;
using Event_Verse_Application.Organizer_Files;

namespace Event_Verse_Application
{
    public partial class UserRegistration : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");
        public UserRegistration()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        //Navigation methods:
        private void openUserLogin(object obj)
        {
            Application.Run(new UserLogin());
        }
        private void openOrganizerRegistration(object obj)
        {
            Application.Run(new OrganizerRegistration());
        }
        private void openAttendeeRegistration(object obj)
        {
            Application.Run(new AttendeeRegistration());
        }



        private void Login_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //should close this page and open login. 
            this.Close();
            threadObj = new Thread(openUserLogin);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //check all the information entered. 
            //if all the information is correct, then register the user.
            //based on the user type, open the respective page.

            //based on user type, windows opens to get the specific info for the particular user types. 

            //forwards the info entered by the user here to login page. => helps in the login process.

            //open attendee register page:
            //this.Close();
            //threadObj = new Thread(openAttendeeRegistration);
            //threadObj.SetApartmentState(ApartmentState.STA);
            //threadObj.Start();


            //open organizer register page:
            this.Close();
            threadObj = new Thread(openOrganizerRegistration);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
