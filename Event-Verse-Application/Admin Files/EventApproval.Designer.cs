namespace Event_Verse_Application.Admin_Files
{
    partial class EventApproval
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.approveEvent_button = new System.Windows.Forms.Button();
            this.eventGridView = new System.Windows.Forms.DataGridView();
            this.ticketType_filter = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eventSearch_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.organizerID_filter = new System.Windows.Forms.CheckBox();
            this.name_filter = new System.Windows.Forms.CheckBox();
            this.backToDashboard_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 37);
            this.label6.TabIndex = 65;
            this.label6.Text = "Events Pending Approval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(338, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 44);
            this.label2.TabIndex = 64;
            this.label2.Text = "Event Verse";
            // 
            // approveEvent_button
            // 
            this.approveEvent_button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveEvent_button.Location = new System.Drawing.Point(19, 455);
            this.approveEvent_button.Name = "approveEvent_button";
            this.approveEvent_button.Size = new System.Drawing.Size(150, 35);
            this.approveEvent_button.TabIndex = 71;
            this.approveEvent_button.Text = "Approve Event";
            this.approveEvent_button.UseVisualStyleBackColor = true;
            this.approveEvent_button.Click += new System.EventHandler(this.approveEvent_button_Click);
            // 
            // eventGridView
            // 
            this.eventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGridView.Location = new System.Drawing.Point(19, 146);
            this.eventGridView.Name = "eventGridView";
            this.eventGridView.Size = new System.Drawing.Size(752, 293);
            this.eventGridView.TabIndex = 70;
            // 
            // ticketType_filter
            // 
            this.ticketType_filter.AutoSize = true;
            this.ticketType_filter.Location = new System.Drawing.Point(488, 110);
            this.ticketType_filter.Name = "ticketType_filter";
            this.ticketType_filter.Size = new System.Drawing.Size(83, 17);
            this.ticketType_filter.TabIndex = 69;
            this.ticketType_filter.Text = "Ticket Type";
            this.ticketType_filter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Set Filters:";
            // 
            // eventSearch_box
            // 
            this.eventSearch_box.Location = new System.Drawing.Point(151, 105);
            this.eventSearch_box.Name = "eventSearch_box";
            this.eventSearch_box.Size = new System.Drawing.Size(253, 20);
            this.eventSearch_box.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Search for Event  :";
            // 
            // organizerID_filter
            // 
            this.organizerID_filter.AutoSize = true;
            this.organizerID_filter.Location = new System.Drawing.Point(577, 109);
            this.organizerID_filter.Name = "organizerID_filter";
            this.organizerID_filter.Size = new System.Drawing.Size(85, 17);
            this.organizerID_filter.TabIndex = 69;
            this.organizerID_filter.Text = "Organizer ID";
            this.organizerID_filter.UseVisualStyleBackColor = true;
            // 
            // name_filter
            // 
            this.name_filter.AutoSize = true;
            this.name_filter.Location = new System.Drawing.Point(488, 87);
            this.name_filter.Name = "name_filter";
            this.name_filter.Size = new System.Drawing.Size(54, 17);
            this.name_filter.TabIndex = 69;
            this.name_filter.Text = "Name";
            this.name_filter.UseVisualStyleBackColor = true;
            // 
            // backToDashboard_button
            // 
            this.backToDashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToDashboard_button.Location = new System.Drawing.Point(19, 9);
            this.backToDashboard_button.Name = "backToDashboard_button";
            this.backToDashboard_button.Size = new System.Drawing.Size(103, 39);
            this.backToDashboard_button.TabIndex = 72;
            this.backToDashboard_button.Text = "<-- Go Back";
            this.backToDashboard_button.UseVisualStyleBackColor = false;
            this.backToDashboard_button.Click += new System.EventHandler(this.backToDashboard_button_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(688, 87);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 26);
            this.search_button.TabIndex = 73;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // EventApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 512);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.backToDashboard_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.approveEvent_button);
            this.Controls.Add(this.eventGridView);
            this.Controls.Add(this.name_filter);
            this.Controls.Add(this.organizerID_filter);
            this.Controls.Add(this.ticketType_filter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eventSearch_box);
            this.Controls.Add(this.label1);
            this.Name = "EventApproval";
            this.Text = "EventApproval";
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button approveEvent_button;
        private System.Windows.Forms.DataGridView eventGridView;
        private System.Windows.Forms.CheckBox ticketType_filter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventSearch_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox organizerID_filter;
        private System.Windows.Forms.CheckBox name_filter;
        private System.Windows.Forms.Button backToDashboard_button;
        private System.Windows.Forms.Button search_button;
    }
}