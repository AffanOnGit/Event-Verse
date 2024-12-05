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

namespace Event_Verse_Application.Admin_Files
{
    public partial class EventApproval : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public EventApproval()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Navigation methods:
        private void openAdminDashboard(object obj)
        {
            Application.Run(new AdminDashboard());
        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //open the AdminDashboard form:
            this.Close();
            threadObj = new Thread(openAdminDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void approveEvent_button_Click(object sender, EventArgs e)
        {
            //when the user clicks this, the query will run against the selected event in the gird view, the event attribute for that event will be updated to approved


        }
    }
}
