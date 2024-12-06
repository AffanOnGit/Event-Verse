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
using static QRCoder.PayloadGenerator;

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

        private bool UserExists(string id)
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE id = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //store the information in variables
            string id = id_box.Text;
            string name = name_box.Text;
            string email = email_box.Text;
            string contact = contact_box.Text;
            int age = Convert.ToInt32(age_box.Text);
            string gender = gender_box.Text;
            string password = pass_box.Text;
            string confirmPass = confirmPass_box.Text;

            string userType = "";

            //check if the user is an organizer or an attendee, both have filters and only one has to be checked.

            //check that there is only one filter checked. 
            if (organizer_filter.Checked && attendee_filter.Checked)
            {
                MessageBox.Show("Please select only one user type.");
                return;
            }
            else if (!organizer_filter.Checked && !attendee_filter.Checked)
            {
                MessageBox.Show("Please select a user type.");
                return;
            }

            if (organizer_filter.Checked)
            {
                userType = "Organizer";
            }
            else if (attendee_filter.Checked)
            {
                userType = "Attendee";
            }

            //check all the information entered. 
            //if all the information is correct, then register the user.
            if (UserExists(id))
            {
                MessageBox.Show("A user with this id already exists.");

                //open the login page:
                this.Close();
                threadObj = new Thread(openUserLogin);
                threadObj.SetApartmentState(ApartmentState.STA);
                threadObj.Start();
            }



            //based on the user type, open the respective page.

            //based on user type, windows opens to get the specific info for the particular user types. 
            if (userType == "Attendee")
            {
                //open attendee register page:
                this.Close();
                threadObj = new Thread(openAttendeeRegistration);
                threadObj.SetApartmentState(ApartmentState.STA);
                threadObj.Start();
            }
            else
            {
                //open organizer register page:
                this.Close();
                threadObj = new Thread(openOrganizerRegistration);
                threadObj.SetApartmentState(ApartmentState.STA);
                threadObj.Start();
            }

            //forwards the info entered by the user here to login page. => helps in the login process.



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
