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
    public partial class BookTicket : Form
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        private void bookTicketButton_Click(object sender, EventArgs e)
        {
            //when this is clicked the SQL query will be executed to reflect ticket has been booked against the user ID, which will be asked in confirmation. The event details will be forwarded to the confrimation window.
            //this will close the current form and open the Confirmation form
            //when datagrid view row is double clicked, i want to store the values of id and name in variables. these will then be sent to the confirmation page.
            //this will close the current form and open the ConfirmaTicket form
        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //this will close the current form and open the AttendeeDashboard form
        }
    }
}
