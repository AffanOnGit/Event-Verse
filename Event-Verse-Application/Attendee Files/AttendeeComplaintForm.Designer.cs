namespace Event_Verse_Application.Attendee_Files
{
    partial class AttendeeComplaintForm
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
            this.registerComplaint_button = new System.Windows.Forms.Button();
            this.feedback_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attendeeID_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backToDashboard_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerComplaint_button
            // 
            this.registerComplaint_button.BackColor = System.Drawing.Color.LightCoral;
            this.registerComplaint_button.Location = new System.Drawing.Point(106, 222);
            this.registerComplaint_button.Name = "registerComplaint_button";
            this.registerComplaint_button.Size = new System.Drawing.Size(123, 42);
            this.registerComplaint_button.TabIndex = 64;
            this.registerComplaint_button.Text = "Complain";
            this.registerComplaint_button.UseVisualStyleBackColor = false;
            this.registerComplaint_button.Click += new System.EventHandler(this.registerComplaint_button_Click);
            // 
            // feedback_box
            // 
            this.feedback_box.Location = new System.Drawing.Point(128, 175);
            this.feedback_box.Name = "feedback_box";
            this.feedback_box.Size = new System.Drawing.Size(142, 20);
            this.feedback_box.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Feedback :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Attendee ID :";
            // 
            // attendeeID_box
            // 
            this.attendeeID_box.Location = new System.Drawing.Point(128, 142);
            this.attendeeID_box.Name = "attendeeID_box";
            this.attendeeID_box.Size = new System.Drawing.Size(142, 20);
            this.attendeeID_box.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(53, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 37);
            this.label6.TabIndex = 59;
            this.label6.Text = "Register Complaint";
            // 
            // backToDashboard_button
            // 
            this.backToDashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToDashboard_button.Location = new System.Drawing.Point(6, 23);
            this.backToDashboard_button.Name = "backToDashboard_button";
            this.backToDashboard_button.Size = new System.Drawing.Size(103, 39);
            this.backToDashboard_button.TabIndex = 58;
            this.backToDashboard_button.Text = "<-- Go Back";
            this.backToDashboard_button.UseVisualStyleBackColor = false;
            this.backToDashboard_button.Click += new System.EventHandler(this.backToDashboard_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(197, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 57;
            this.label1.Text = "Event Verse";
            // 
            // AttendeeComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 374);
            this.Controls.Add(this.registerComplaint_button);
            this.Controls.Add(this.feedback_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendeeID_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backToDashboard_button);
            this.Controls.Add(this.label1);
            this.Name = "AttendeeComplaintForm";
            this.Text = "AttendeeComplaintForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerComplaint_button;
        private System.Windows.Forms.TextBox feedback_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox attendeeID_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backToDashboard_button;
        private System.Windows.Forms.Label label1;
    }
}