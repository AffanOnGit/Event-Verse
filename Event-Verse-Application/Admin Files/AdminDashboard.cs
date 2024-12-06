﻿using System;
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
    public partial class AdminDashboard : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public AdminDashboard()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Navigation methods:
        private void openEventApproval(object obj)
        {
            Application.Run(new EventApproval());
        }
        private void openViewComplaint(object obj)
        {
            Application.Run(new ViewComplaint());
        }



        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void eventApproval_button_Click(object sender, EventArgs e)
        {
            //open the EventApproval form:
            this.Close();
            threadObj = new Thread(openEventApproval);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void viewComplaint_button_Click(object sender, EventArgs e)
        {
            //open the view complaint form:
            this.Close();
            threadObj = new Thread(openViewComplaint);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }
    }
}