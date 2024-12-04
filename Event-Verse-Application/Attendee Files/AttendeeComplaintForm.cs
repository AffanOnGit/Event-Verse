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

namespace Event_Verse_Application.Attendee_Files
{
    public partial class AttendeeComplaintForm : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public AttendeeComplaintForm()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void openAttendeeDashboard(object obj)
        {
            Application.Run(new AttendeeDashboard());
        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //close the current form and open the AttendeeDashboard form:
            this.Close();
            threadObj = new Thread(openAttendeeDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void registerComplaint_button_Click(object sender, EventArgs e)
        {
            //get the complaint details from the user.
            //sql query to update the complaint table in the database.
        }
    }
}
