namespace Event_Verse_Application.Organizer_Files
{
    partial class OrganizerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizerDashboard));
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventFeedbackView_button = new System.Windows.Forms.Button();
            this.resourceAndVendorManagement_button = new System.Windows.Forms.Button();
            this.attendeeManagement_button = new System.Windows.Forms.Button();
            this.ticketAndSales_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.registerComplaint_button = new System.Windows.Forms.Button();
            this.createEvent_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eventSearch_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eventListGridView = new System.Windows.Forms.DataGridView();
            this.deleteSelectedEvent_button = new System.Windows.Forms.Button();
            this.updateSelectedEvent_button = new System.Windows.Forms.Button();
            this.ticket_filter = new System.Windows.Forms.CheckBox();
            this.category_filter = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name_filter = new System.Windows.Forms.CheckBox();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.date_filter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(941, 19);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(66, 55);
            this.profilePicture.TabIndex = 28;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eventFeedbackView_button);
            this.panel1.Controls.Add(this.resourceAndVendorManagement_button);
            this.panel1.Controls.Add(this.attendeeManagement_button);
            this.panel1.Controls.Add(this.ticketAndSales_button);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.registerComplaint_button);
            this.panel1.Controls.Add(this.createEvent_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 590);
            this.panel1.TabIndex = 29;
            // 
            // eventFeedbackView_button
            // 
            this.eventFeedbackView_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventFeedbackView_button.Location = new System.Drawing.Point(1, 385);
            this.eventFeedbackView_button.Name = "eventFeedbackView_button";
            this.eventFeedbackView_button.Size = new System.Drawing.Size(166, 52);
            this.eventFeedbackView_button.TabIndex = 12;
            this.eventFeedbackView_button.Text = "Event Feedback View";
            this.eventFeedbackView_button.UseVisualStyleBackColor = true;
            this.eventFeedbackView_button.Click += new System.EventHandler(this.eventAnalytics_button_Click);
            // 
            // resourceAndVendorManagement_button
            // 
            this.resourceAndVendorManagement_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceAndVendorManagement_button.Location = new System.Drawing.Point(0, 327);
            this.resourceAndVendorManagement_button.Name = "resourceAndVendorManagement_button";
            this.resourceAndVendorManagement_button.Size = new System.Drawing.Size(166, 52);
            this.resourceAndVendorManagement_button.TabIndex = 11;
            this.resourceAndVendorManagement_button.Text = "Resource And Vendor Management";
            this.resourceAndVendorManagement_button.UseVisualStyleBackColor = true;
            this.resourceAndVendorManagement_button.Click += new System.EventHandler(this.resourceAndVendorManagement_button_Click);
            // 
            // attendeeManagement_button
            // 
            this.attendeeManagement_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendeeManagement_button.Location = new System.Drawing.Point(2, 269);
            this.attendeeManagement_button.Name = "attendeeManagement_button";
            this.attendeeManagement_button.Size = new System.Drawing.Size(166, 52);
            this.attendeeManagement_button.TabIndex = 10;
            this.attendeeManagement_button.Text = "Attendee Management";
            this.attendeeManagement_button.UseVisualStyleBackColor = true;
            this.attendeeManagement_button.Click += new System.EventHandler(this.attendeeManagement_button_Click);
            // 
            // ticketAndSales_button
            // 
            this.ticketAndSales_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketAndSales_button.Location = new System.Drawing.Point(1, 208);
            this.ticketAndSales_button.Name = "ticketAndSales_button";
            this.ticketAndSales_button.Size = new System.Drawing.Size(166, 52);
            this.ticketAndSales_button.TabIndex = 9;
            this.ticketAndSales_button.Text = "Tickets and Sales";
            this.ticketAndSales_button.UseVisualStyleBackColor = true;
            this.ticketAndSales_button.Click += new System.EventHandler(this.ticketAndSales_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Organizer Dashboard";
            // 
            // registerComplaint_button
            // 
            this.registerComplaint_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerComplaint_button.Location = new System.Drawing.Point(3, 443);
            this.registerComplaint_button.Name = "registerComplaint_button";
            this.registerComplaint_button.Size = new System.Drawing.Size(163, 52);
            this.registerComplaint_button.TabIndex = 6;
            this.registerComplaint_button.Text = "Register Complaint";
            this.registerComplaint_button.UseVisualStyleBackColor = true;
            this.registerComplaint_button.Click += new System.EventHandler(this.registerComplaint_button_Click);
            // 
            // createEvent_button
            // 
            this.createEvent_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEvent_button.Location = new System.Drawing.Point(1, 150);
            this.createEvent_button.Name = "createEvent_button";
            this.createEvent_button.Size = new System.Drawing.Size(166, 52);
            this.createEvent_button.TabIndex = 2;
            this.createEvent_button.Text = "Create Event";
            this.createEvent_button.UseVisualStyleBackColor = true;
            this.createEvent_button.Click += new System.EventHandler(this.createEvent_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Verse";
            // 
            // eventSearch_box
            // 
            this.eventSearch_box.Location = new System.Drawing.Point(355, 81);
            this.eventSearch_box.Name = "eventSearch_box";
            this.eventSearch_box.Size = new System.Drawing.Size(253, 20);
            this.eventSearch_box.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search for Event :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(177, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 37);
            this.label6.TabIndex = 42;
            this.label6.Text = "Events List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eventListGridView);
            this.panel2.Location = new System.Drawing.Point(184, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 360);
            this.panel2.TabIndex = 43;
            // 
            // eventListGridView
            // 
            this.eventListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventListGridView.Location = new System.Drawing.Point(39, 9);
            this.eventListGridView.Name = "eventListGridView";
            this.eventListGridView.Size = new System.Drawing.Size(712, 351);
            this.eventListGridView.TabIndex = 0;
            // 
            // deleteSelectedEvent_button
            // 
            this.deleteSelectedEvent_button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedEvent_button.Location = new System.Drawing.Point(184, 554);
            this.deleteSelectedEvent_button.Name = "deleteSelectedEvent_button";
            this.deleteSelectedEvent_button.Size = new System.Drawing.Size(165, 30);
            this.deleteSelectedEvent_button.TabIndex = 44;
            this.deleteSelectedEvent_button.Text = "Delete Selected Event";
            this.deleteSelectedEvent_button.UseVisualStyleBackColor = true;
            this.deleteSelectedEvent_button.Click += new System.EventHandler(this.deleteSelectedEvent_button_Click);
            // 
            // updateSelectedEvent_button
            // 
            this.updateSelectedEvent_button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSelectedEvent_button.Location = new System.Drawing.Point(355, 554);
            this.updateSelectedEvent_button.Name = "updateSelectedEvent_button";
            this.updateSelectedEvent_button.Size = new System.Drawing.Size(184, 30);
            this.updateSelectedEvent_button.TabIndex = 45;
            this.updateSelectedEvent_button.Text = "Update Selected Event";
            this.updateSelectedEvent_button.UseVisualStyleBackColor = true;
            this.updateSelectedEvent_button.Click += new System.EventHandler(this.updateSelectedEvent_button_Click);
            // 
            // ticket_filter
            // 
            this.ticket_filter.AutoSize = true;
            this.ticket_filter.Location = new System.Drawing.Point(692, 86);
            this.ticket_filter.Name = "ticket_filter";
            this.ticket_filter.Size = new System.Drawing.Size(83, 17);
            this.ticket_filter.TabIndex = 55;
            this.ticket_filter.Text = "Ticket Type";
            this.ticket_filter.UseVisualStyleBackColor = true;
            // 
            // category_filter
            // 
            this.category_filter.AutoSize = true;
            this.category_filter.Location = new System.Drawing.Point(777, 66);
            this.category_filter.Name = "category_filter";
            this.category_filter.Size = new System.Drawing.Size(68, 17);
            this.category_filter.TabIndex = 54;
            this.category_filter.Text = "Category";
            this.category_filter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Set Filters:";
            // 
            // name_filter
            // 
            this.name_filter.AutoSize = true;
            this.name_filter.Location = new System.Drawing.Point(692, 66);
            this.name_filter.Name = "name_filter";
            this.name_filter.Size = new System.Drawing.Size(54, 17);
            this.name_filter.TabIndex = 51;
            this.name_filter.Text = "Name";
            this.name_filter.UseVisualStyleBackColor = true;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(622, 116);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "From:";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(379, 116);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 47;
            // 
            // date_filter
            // 
            this.date_filter.AutoSize = true;
            this.date_filter.Location = new System.Drawing.Point(224, 121);
            this.date_filter.Name = "date_filter";
            this.date_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_filter.Size = new System.Drawing.Size(88, 17);
            this.date_filter.TabIndex = 46;
            this.date_filter.Text = "Filter by Date";
            this.date_filter.UseVisualStyleBackColor = true;
            // 
            // OrganizerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 614);
            this.Controls.Add(this.ticket_filter);
            this.Controls.Add(this.category_filter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_filter);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.date_filter);
            this.Controls.Add(this.updateSelectedEvent_button);
            this.Controls.Add(this.deleteSelectedEvent_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eventSearch_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profilePicture);
            this.Name = "OrganizerDashboard";
            this.Text = "OrganizerDashboard";
            this.Load += new System.EventHandler(this.OrganizerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createEvent_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox eventSearch_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView eventListGridView;
        private System.Windows.Forms.Button registerComplaint_button;
        private System.Windows.Forms.Button ticketAndSales_button;
        private System.Windows.Forms.Button deleteSelectedEvent_button;
        private System.Windows.Forms.Button updateSelectedEvent_button;
        private System.Windows.Forms.Button attendeeManagement_button;
        private System.Windows.Forms.Button resourceAndVendorManagement_button;
        private System.Windows.Forms.Button eventFeedbackView_button;
        private System.Windows.Forms.CheckBox ticket_filter;
        private System.Windows.Forms.CheckBox category_filter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox name_filter;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.CheckBox date_filter;
    }
}