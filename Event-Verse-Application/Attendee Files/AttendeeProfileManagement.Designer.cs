namespace Event_Verse_Application
{
    partial class AttendeeProfileManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendeeProfileManagement));
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.backToDashboard_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contact_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.eventName_box = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attendeeID_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updateInfo_button = new System.Windows.Forms.Button();
            this.deleteAttendee_button = new System.Windows.Forms.Button();
            this.preference_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pastEventsLink = new System.Windows.Forms.LinkLabel();
            this.logOut_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(12, 70);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(83, 71);
            this.profilePicture.TabIndex = 22;
            this.profilePicture.TabStop = false;
            // 
            // backToDashboard_button
            // 
            this.backToDashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToDashboard_button.Location = new System.Drawing.Point(12, 12);
            this.backToDashboard_button.Name = "backToDashboard_button";
            this.backToDashboard_button.Size = new System.Drawing.Size(103, 39);
            this.backToDashboard_button.TabIndex = 23;
            this.backToDashboard_button.Text = "<-- Go Back";
            this.backToDashboard_button.UseVisualStyleBackColor = false;
            this.backToDashboard_button.Click += new System.EventHandler(this.backToDashboard_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(166, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 24;
            this.label1.Text = "Event Verse";
            // 
            // contact_box
            // 
            this.contact_box.Location = new System.Drawing.Point(108, 253);
            this.contact_box.Name = "contact_box";
            this.contact_box.Size = new System.Drawing.Size(142, 20);
            this.contact_box.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Contact Number:";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(108, 193);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(142, 20);
            this.name_box.TabIndex = 60;
            // 
            // eventName_box
            // 
            this.eventName_box.AutoSize = true;
            this.eventName_box.Location = new System.Drawing.Point(15, 227);
            this.eventName_box.Name = "eventName_box";
            this.eventName_box.Size = new System.Drawing.Size(38, 13);
            this.eventName_box.TabIndex = 59;
            this.eventName_box.Text = "Email :";
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(108, 224);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(142, 20);
            this.email_box.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Attendee ID :";
            // 
            // attendeeID_box
            // 
            this.attendeeID_box.Location = new System.Drawing.Point(108, 159);
            this.attendeeID_box.Name = "attendeeID_box";
            this.attendeeID_box.Size = new System.Drawing.Size(142, 20);
            this.attendeeID_box.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Name :";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(108, 313);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(142, 20);
            this.password_box.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Password :";
            // 
            // updateInfo_button
            // 
            this.updateInfo_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateInfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateInfo_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateInfo_button.Location = new System.Drawing.Point(239, 408);
            this.updateInfo_button.Name = "updateInfo_button";
            this.updateInfo_button.Size = new System.Drawing.Size(94, 30);
            this.updateInfo_button.TabIndex = 66;
            this.updateInfo_button.Text = "Update Info";
            this.updateInfo_button.UseVisualStyleBackColor = false;
            this.updateInfo_button.Click += new System.EventHandler(this.updateInfo_button_Click);
            // 
            // deleteAttendee_button
            // 
            this.deleteAttendee_button.BackColor = System.Drawing.Color.Red;
            this.deleteAttendee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAttendee_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteAttendee_button.Location = new System.Drawing.Point(12, 408);
            this.deleteAttendee_button.Name = "deleteAttendee_button";
            this.deleteAttendee_button.Size = new System.Drawing.Size(138, 30);
            this.deleteAttendee_button.TabIndex = 67;
            this.deleteAttendee_button.Text = "Delete Attendee";
            this.deleteAttendee_button.UseVisualStyleBackColor = false;
            this.deleteAttendee_button.Click += new System.EventHandler(this.deleteAttendee_button_Click);
            // 
            // preference_box
            // 
            this.preference_box.Location = new System.Drawing.Point(108, 283);
            this.preference_box.Name = "preference_box";
            this.preference_box.Size = new System.Drawing.Size(142, 20);
            this.preference_box.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Event Preference:";
            // 
            // pastEventsLink
            // 
            this.pastEventsLink.AutoSize = true;
            this.pastEventsLink.Location = new System.Drawing.Point(236, 70);
            this.pastEventsLink.Name = "pastEventsLink";
            this.pastEventsLink.Size = new System.Drawing.Size(90, 13);
            this.pastEventsLink.TabIndex = 70;
            this.pastEventsLink.TabStop = true;
            this.pastEventsLink.Text = "View Past Events";
            this.pastEventsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pastEventsLink_LinkClicked);
            // 
            // logOut_button
            // 
            this.logOut_button.BackColor = System.Drawing.Color.LightCoral;
            this.logOut_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOut_button.Location = new System.Drawing.Point(12, 372);
            this.logOut_button.Name = "logOut_button";
            this.logOut_button.Size = new System.Drawing.Size(87, 30);
            this.logOut_button.TabIndex = 71;
            this.logOut_button.Text = "Log Out";
            this.logOut_button.UseVisualStyleBackColor = false;
            this.logOut_button.Click += new System.EventHandler(this.logOut_button_Click);
            // 
            // AttendeeProfileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.logOut_button);
            this.Controls.Add(this.pastEventsLink);
            this.Controls.Add(this.preference_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteAttendee_button);
            this.Controls.Add(this.updateInfo_button);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contact_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.eventName_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendeeID_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToDashboard_button);
            this.Controls.Add(this.profilePicture);
            this.Name = "AttendeeProfileManagement";
            this.Text = "AttendeeProfileManagement";
            this.Load += new System.EventHandler(this.AttendeeProfileManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button backToDashboard_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contact_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label eventName_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox attendeeID_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateInfo_button;
        private System.Windows.Forms.Button deleteAttendee_button;
        private System.Windows.Forms.TextBox preference_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel pastEventsLink;
        private System.Windows.Forms.Button logOut_button;
    }
}