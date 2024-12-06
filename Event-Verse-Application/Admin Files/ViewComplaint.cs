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
    public partial class ViewComplaint : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public ViewComplaint()
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


        private void ViewComplaint_Load(object sender, EventArgs e)
        {

        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //open the AdminDashboard form:
            this.Close();
            threadObj = new Thread(openAdminDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void findComplaints_button_Click(object sender, EventArgs e)
        {
            //query the complaint table and display it in the grid view based on the filter selected. 
        }

        private void resolveComplaint_button_Click(object sender, EventArgs e)
        {
            //this will delete the record from the complaint table based on the selected complaint in the grid view
        }
    }
}
