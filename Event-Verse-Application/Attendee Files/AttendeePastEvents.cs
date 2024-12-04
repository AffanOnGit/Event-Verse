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
    public partial class AttendeePastEvents : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");


        public AttendeePastEvents()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void openProfile(object obj)
        {
            Application.Run(new AttendeeProfileManagement());
        }

        private void backToProfile_button_Click(object sender, EventArgs e)
        {
            //this will take the user to Attendee Profile page.
            this.Close();
            threadObj = new Thread(openProfile);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void AttendeePastEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
