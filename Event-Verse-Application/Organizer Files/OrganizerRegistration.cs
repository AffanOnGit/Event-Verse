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

namespace Event_Verse_Application.Organizer_Files
{
    public partial class OrganizerRegistration : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public OrganizerRegistration()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void openUserRegistration(object obj)
        {
            Application.Run(new UserRegistration());
        }

        private void openUserLogin(object obj)
        {
            Application.Run(new UserLogin());
        }

        private void backToRegistration_button_Click(object sender, EventArgs e)
        {
            //go back to the user registration page.
            this.Close();
            threadObj = new Thread(openUserRegistration);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //since the registration info is already available, clicking this button will add the preference to the attendee in the DB. 
            //registration will be checked here, if user exists, then the user is taken to User Login



            //when the checks have been passed:
            this.Close();
            threadObj = new Thread(openUserLogin);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }
    }
}
