namespace Event_Verse_Application.Admin_Files
{
    partial class ViewComplaint
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
            this.findComplaints_button = new System.Windows.Forms.Button();
            this.backToDashboard_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resolveComplaint_button = new System.Windows.Forms.Button();
            this.complaintsGridView = new System.Windows.Forms.DataGridView();
            this.attendee_filter = new System.Windows.Forms.CheckBox();
            this.organizer_filter = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // findComplaints_button
            // 
            this.findComplaints_button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findComplaints_button.Location = new System.Drawing.Point(623, 74);
            this.findComplaints_button.Name = "findComplaints_button";
            this.findComplaints_button.Size = new System.Drawing.Size(148, 26);
            this.findComplaints_button.TabIndex = 79;
            this.findComplaints_button.Text = "Find Complaints";
            this.findComplaints_button.UseVisualStyleBackColor = true;
            this.findComplaints_button.Click += new System.EventHandler(this.findComplaints_button_Click);
            // 
            // backToDashboard_button
            // 
            this.backToDashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToDashboard_button.Location = new System.Drawing.Point(19, 9);
            this.backToDashboard_button.Name = "backToDashboard_button";
            this.backToDashboard_button.Size = new System.Drawing.Size(103, 39);
            this.backToDashboard_button.TabIndex = 78;
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
            this.label6.Size = new System.Drawing.Size(322, 37);
            this.label6.TabIndex = 75;
            this.label6.Text = "Events Pending Approval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 44);
            this.label2.TabIndex = 74;
            this.label2.Text = "Event Verse";
            // 
            // resolveComplaint_button
            // 
            this.resolveComplaint_button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolveComplaint_button.Location = new System.Drawing.Point(621, 435);
            this.resolveComplaint_button.Name = "resolveComplaint_button";
            this.resolveComplaint_button.Size = new System.Drawing.Size(150, 35);
            this.resolveComplaint_button.TabIndex = 77;
            this.resolveComplaint_button.Text = "Resolve Complaint";
            this.resolveComplaint_button.UseVisualStyleBackColor = true;
            this.resolveComplaint_button.Click += new System.EventHandler(this.resolveComplaint_button_Click);
            // 
            // complaintsGridView
            // 
            this.complaintsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaintsGridView.Location = new System.Drawing.Point(19, 132);
            this.complaintsGridView.Name = "complaintsGridView";
            this.complaintsGridView.Size = new System.Drawing.Size(752, 293);
            this.complaintsGridView.TabIndex = 76;
            // 
            // attendee_filter
            // 
            this.attendee_filter.AutoSize = true;
            this.attendee_filter.Location = new System.Drawing.Point(406, 76);
            this.attendee_filter.Name = "attendee_filter";
            this.attendee_filter.Size = new System.Drawing.Size(84, 17);
            this.attendee_filter.TabIndex = 82;
            this.attendee_filter.Text = "By Attendee";
            this.attendee_filter.UseVisualStyleBackColor = true;
            // 
            // organizer_filter
            // 
            this.organizer_filter.AutoSize = true;
            this.organizer_filter.Location = new System.Drawing.Point(406, 99);
            this.organizer_filter.Name = "organizer_filter";
            this.organizer_filter.Size = new System.Drawing.Size(86, 17);
            this.organizer_filter.TabIndex = 81;
            this.organizer_filter.Text = "By Organizer";
            this.organizer_filter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Set Filters:";
            // 
            // ViewComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 482);
            this.Controls.Add(this.attendee_filter);
            this.Controls.Add(this.organizer_filter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.findComplaints_button);
            this.Controls.Add(this.backToDashboard_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resolveComplaint_button);
            this.Controls.Add(this.complaintsGridView);
            this.Name = "ViewComplaint";
            this.Text = "ViewComplaint";
            this.Load += new System.EventHandler(this.ViewComplaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.complaintsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findComplaints_button;
        private System.Windows.Forms.Button backToDashboard_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resolveComplaint_button;
        private System.Windows.Forms.DataGridView complaintsGridView;
        private System.Windows.Forms.CheckBox attendee_filter;
        private System.Windows.Forms.CheckBox organizer_filter;
        private System.Windows.Forms.Label label5;
    }
}