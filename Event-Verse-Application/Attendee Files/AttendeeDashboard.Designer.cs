namespace Event_Verse_Application
{
    partial class AttendeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendeeDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.upcomingEvents_button = new System.Windows.Forms.Button();
            this.eventBooking_button = new System.Windows.Forms.Button();
            this.giveFeedback_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.eventSearch_box = new System.Windows.Forms.TextBox();
            this.date_filter = new System.Windows.Forms.CheckBox();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.name_filter = new System.Windows.Forms.CheckBox();
            this.type_filter = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.category_filter = new System.Windows.Forms.CheckBox();
            this.ticket_filter = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registeredEventsView = new System.Windows.Forms.DataGridView();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.registerComplaint_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registeredEventsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Verse";
            // 
            // upcomingEvents_button
            // 
            this.upcomingEvents_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingEvents_button.Location = new System.Drawing.Point(0, 166);
            this.upcomingEvents_button.Name = "upcomingEvents_button";
            this.upcomingEvents_button.Size = new System.Drawing.Size(166, 52);
            this.upcomingEvents_button.TabIndex = 2;
            this.upcomingEvents_button.Text = "Upcoming Events";
            this.upcomingEvents_button.UseVisualStyleBackColor = true;
            this.upcomingEvents_button.Click += new System.EventHandler(this.upcomingEvents_button_Click);
            // 
            // eventBooking_button
            // 
            this.eventBooking_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBooking_button.Location = new System.Drawing.Point(0, 224);
            this.eventBooking_button.Name = "eventBooking_button";
            this.eventBooking_button.Size = new System.Drawing.Size(166, 52);
            this.eventBooking_button.TabIndex = 4;
            this.eventBooking_button.Text = "Event Booking";
            this.eventBooking_button.UseVisualStyleBackColor = true;
            this.eventBooking_button.Click += new System.EventHandler(this.eventBooking_button_Click);
            // 
            // giveFeedback_button
            // 
            this.giveFeedback_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveFeedback_button.Location = new System.Drawing.Point(3, 282);
            this.giveFeedback_button.Name = "giveFeedback_button";
            this.giveFeedback_button.Size = new System.Drawing.Size(163, 52);
            this.giveFeedback_button.TabIndex = 5;
            this.giveFeedback_button.Text = "Give Feedback";
            this.giveFeedback_button.UseVisualStyleBackColor = true;
            this.giveFeedback_button.Click += new System.EventHandler(this.giveFeedback_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.registerComplaint_button);
            this.panel1.Controls.Add(this.upcomingEvents_button);
            this.panel1.Controls.Add(this.eventBooking_button);
            this.panel1.Controls.Add(this.giveFeedback_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 590);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search for Event :";
            // 
            // eventSearch_box
            // 
            this.eventSearch_box.Location = new System.Drawing.Point(367, 81);
            this.eventSearch_box.Name = "eventSearch_box";
            this.eventSearch_box.Size = new System.Drawing.Size(253, 22);
            this.eventSearch_box.TabIndex = 8;
            // 
            // date_filter
            // 
            this.date_filter.AutoSize = true;
            this.date_filter.Location = new System.Drawing.Point(238, 121);
            this.date_filter.Name = "date_filter";
            this.date_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_filter.Size = new System.Drawing.Size(94, 17);
            this.date_filter.TabIndex = 9;
            this.date_filter.Text = "Filter by Date";
            this.date_filter.UseVisualStyleBackColor = true;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(393, 116);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 22);
            this.fromDatePicker.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To:";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(636, 116);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 22);
            this.toDatePicker.TabIndex = 13;
            // 
            // name_filter
            // 
            this.name_filter.AutoSize = true;
            this.name_filter.Location = new System.Drawing.Point(706, 66);
            this.name_filter.Name = "name_filter";
            this.name_filter.Size = new System.Drawing.Size(55, 17);
            this.name_filter.TabIndex = 14;
            this.name_filter.Text = "Name";
            this.name_filter.UseVisualStyleBackColor = true;
            // 
            // type_filter
            // 
            this.type_filter.AutoSize = true;
            this.type_filter.Location = new System.Drawing.Point(706, 89);
            this.type_filter.Name = "type_filter";
            this.type_filter.Size = new System.Drawing.Size(79, 17);
            this.type_filter.TabIndex = 15;
            this.type_filter.Text = "Event Type";
            this.type_filter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Set Filters:";
            // 
            // category_filter
            // 
            this.category_filter.AutoSize = true;
            this.category_filter.Location = new System.Drawing.Point(791, 66);
            this.category_filter.Name = "category_filter";
            this.category_filter.Size = new System.Drawing.Size(72, 17);
            this.category_filter.TabIndex = 17;
            this.category_filter.Text = "Category";
            this.category_filter.UseVisualStyleBackColor = true;
            // 
            // ticket_filter
            // 
            this.ticket_filter.AutoSize = true;
            this.ticket_filter.Location = new System.Drawing.Point(791, 89);
            this.ticket_filter.Name = "ticket_filter";
            this.ticket_filter.Size = new System.Drawing.Size(80, 17);
            this.ticket_filter.TabIndex = 18;
            this.ticket_filter.Text = "Ticket Type";
            this.ticket_filter.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(420, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "Registered Events";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.registeredEventsView);
            this.panel2.Location = new System.Drawing.Point(196, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 410);
            this.panel2.TabIndex = 20;
            // 
            // registeredEventsView
            // 
            this.registeredEventsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registeredEventsView.Location = new System.Drawing.Point(21, 15);
            this.registeredEventsView.Name = "registeredEventsView";
            this.registeredEventsView.Size = new System.Drawing.Size(730, 380);
            this.registeredEventsView.TabIndex = 0;
            // 
            // profilePicture
            // 
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(932, 12);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(66, 55);
            this.profilePicture.TabIndex = 21;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // registerComplaint_button
            // 
            this.registerComplaint_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerComplaint_button.Location = new System.Drawing.Point(3, 340);
            this.registerComplaint_button.Name = "registerComplaint_button";
            this.registerComplaint_button.Size = new System.Drawing.Size(163, 52);
            this.registerComplaint_button.TabIndex = 6;
            this.registerComplaint_button.Text = "Register Complaint";
            this.registerComplaint_button.UseVisualStyleBackColor = true;
            this.registerComplaint_button.Click += new System.EventHandler(this.registerComplaint_button_Click);
            // 
            // AttendeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 614);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ticket_filter);
            this.Controls.Add(this.category_filter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type_filter);
            this.Controls.Add(this.name_filter);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.date_filter);
            this.Controls.Add(this.eventSearch_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AttendeeDashboard";
            this.Text = "AttendeeDashboard";
            this.Load += new System.EventHandler(this.AttendeeDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registeredEventsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upcomingEvents_button;
        private System.Windows.Forms.Button eventBooking_button;
        private System.Windows.Forms.Button giveFeedback_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eventSearch_box;
        private System.Windows.Forms.CheckBox date_filter;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.CheckBox name_filter;
        private System.Windows.Forms.CheckBox type_filter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox category_filter;
        private System.Windows.Forms.CheckBox ticket_filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView registeredEventsView;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button registerComplaint_button;
    }
}