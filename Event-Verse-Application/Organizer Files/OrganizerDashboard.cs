using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Verse_Application.Organizer_Files
{
    public partial class OrganizerDashboard : Form
    {
        public OrganizerDashboard()
        {
            InitializeComponent();
        }

        private void OrganizerDashboard_Load(object sender, EventArgs e)
        {

        }


        //IMPORTANT:
        //when the user double clicks on an event, then the values displayed will be stored in variables. 
            // then this info will be passed on to delete event button and update event form.

        //get all the organizer information from the initial registration. 
            //this will be stored in the dashboard and then sent as arguements when needed. 
    }
}
