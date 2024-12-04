using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Verse_Application
{
    public partial class EventFeedback : Form
    {
        public EventFeedback()
        {
            InitializeComponent();
        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //this will take the user to AttendeeDashboard page
        }

        private void provideFeedback_button_Click(object sender, EventArgs e)
        {
            //this will add the feedback against the attendee id and the event id to the DB

        }
    }
}
