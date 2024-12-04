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
    public partial class e_ticketDownload : Form
    {
        public e_ticketDownload()
        {
            InitializeComponent();
        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //this will take the user to AttendeeDashboard page

        }

        private void generateQR_button_Click(object sender, EventArgs e)
        {
            //this will generate QR code based on the ticket details.
            //we need to first store the ticket details in variables and then generate QR code.
        }
    }
}
