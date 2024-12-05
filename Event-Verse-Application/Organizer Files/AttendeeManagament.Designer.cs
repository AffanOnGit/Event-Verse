namespace Event_Verse_Application.Organizer_Files
{
    partial class AttendeeManagament
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
            this.label1 = new System.Windows.Forms.Label();
            this.backToDashboard_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eventAttendeeGridView = new System.Windows.Forms.DataGridView();
            this.deleteSelectedAttendee_button = new System.Windows.Forms.Button();
            this.searchAttendee_button = new System.Windows.Forms.Button();
            this.totalAttendees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.attendenceRatio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventAttendeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(328, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 77;
            this.label1.Text = "Event Verse";
            // 
            // backToDashboard_button
            // 
            this.backToDashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToDashboard_button.Location = new System.Drawing.Point(12, 12);
            this.backToDashboard_button.Name = "backToDashboard_button";
            this.backToDashboard_button.Size = new System.Drawing.Size(103, 39);
            this.backToDashboard_button.TabIndex = 76;
            this.backToDashboard_button.Text = "<-- Go Back";
            this.backToDashboard_button.UseVisualStyleBackColor = false;
            this.backToDashboard_button.Click += new System.EventHandler(this.backToDashboard_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 37);
            this.label6.TabIndex = 79;
            this.label6.Text = "Attendee Management";
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(151, 109);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(253, 20);
            this.id_box.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "Enter Event ID :";
            // 
            // eventAttendeeGridView
            // 
            this.eventAttendeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventAttendeeGridView.Location = new System.Drawing.Point(19, 145);
            this.eventAttendeeGridView.Name = "eventAttendeeGridView";
            this.eventAttendeeGridView.Size = new System.Drawing.Size(769, 189);
            this.eventAttendeeGridView.TabIndex = 82;
            // 
            // deleteSelectedAttendee_button
            // 
            this.deleteSelectedAttendee_button.BackColor = System.Drawing.Color.LightCoral;
            this.deleteSelectedAttendee_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedAttendee_button.Location = new System.Drawing.Point(577, 413);
            this.deleteSelectedAttendee_button.Name = "deleteSelectedAttendee_button";
            this.deleteSelectedAttendee_button.Size = new System.Drawing.Size(211, 25);
            this.deleteSelectedAttendee_button.TabIndex = 83;
            this.deleteSelectedAttendee_button.Text = "Delete Selected Attendee";
            this.deleteSelectedAttendee_button.UseVisualStyleBackColor = false;
            this.deleteSelectedAttendee_button.Click += new System.EventHandler(this.deleteSelectedAttendee_button_Click);
            // 
            // searchAttendee_button
            // 
            this.searchAttendee_button.BackColor = System.Drawing.Color.Lime;
            this.searchAttendee_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAttendee_button.Location = new System.Drawing.Point(427, 93);
            this.searchAttendee_button.Name = "searchAttendee_button";
            this.searchAttendee_button.Size = new System.Drawing.Size(211, 36);
            this.searchAttendee_button.TabIndex = 84;
            this.searchAttendee_button.Text = "Search Attendees";
            this.searchAttendee_button.UseVisualStyleBackColor = false;
            this.searchAttendee_button.Click += new System.EventHandler(this.searchAttendee_button_Click);
            // 
            // totalAttendees
            // 
            this.totalAttendees.Location = new System.Drawing.Point(151, 348);
            this.totalAttendees.Name = "totalAttendees";
            this.totalAttendees.Size = new System.Drawing.Size(253, 20);
            this.totalAttendees.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 85;
            this.label3.Text = "Total Attendees:";
            // 
            // attendenceRatio
            // 
            this.attendenceRatio.Location = new System.Drawing.Point(155, 378);
            this.attendenceRatio.Name = "attendenceRatio";
            this.attendenceRatio.Size = new System.Drawing.Size(253, 20);
            this.attendenceRatio.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "Attendance Ratio";
            // 
            // AttendeeManagament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.attendenceRatio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalAttendees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchAttendee_button);
            this.Controls.Add(this.deleteSelectedAttendee_button);
            this.Controls.Add(this.eventAttendeeGridView);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToDashboard_button);
            this.Name = "AttendeeManagament";
            this.Text = "AttendeeManagament";
            this.Load += new System.EventHandler(this.AttendeeManagament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventAttendeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToDashboard_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView eventAttendeeGridView;
        private System.Windows.Forms.Button deleteSelectedAttendee_button;
        private System.Windows.Forms.Button searchAttendee_button;
        private System.Windows.Forms.TextBox totalAttendees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox attendenceRatio;
        private System.Windows.Forms.Label label4;
    }
}