namespace Event_Verse_Application
{
    partial class BookTicket
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
            this.backToDashboard_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.date_filter = new System.Windows.Forms.CheckBox();
            this.eventSearch_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ticket_filter = new System.Windows.Forms.CheckBox();
            this.category_filter = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.type_filter = new System.Windows.Forms.CheckBox();
            this.name_filter = new System.Windows.Forms.CheckBox();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventsDataGridView = new System.Windows.Forms.DataGridView();
            this.bookTicketButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backToDashboard_button
            // 
            this.backToDashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToDashboard_button.Location = new System.Drawing.Point(12, 14);
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
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "Event Verse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "From:";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(183, 147);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 27;
            // 
            // date_filter
            // 
            this.date_filter.AutoSize = true;
            this.date_filter.Location = new System.Drawing.Point(28, 152);
            this.date_filter.Name = "date_filter";
            this.date_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_filter.Size = new System.Drawing.Size(88, 17);
            this.date_filter.TabIndex = 26;
            this.date_filter.Text = "Filter by Date";
            this.date_filter.UseVisualStyleBackColor = true;
            // 
            // eventSearch_box
            // 
            this.eventSearch_box.Location = new System.Drawing.Point(157, 112);
            this.eventSearch_box.Name = "eventSearch_box";
            this.eventSearch_box.Size = new System.Drawing.Size(253, 20);
            this.eventSearch_box.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Search for Event :";
            // 
            // ticket_filter
            // 
            this.ticket_filter.AutoSize = true;
            this.ticket_filter.Location = new System.Drawing.Point(491, 91);
            this.ticket_filter.Name = "ticket_filter";
            this.ticket_filter.Size = new System.Drawing.Size(83, 17);
            this.ticket_filter.TabIndex = 35;
            this.ticket_filter.Text = "Ticket Type";
            this.ticket_filter.UseVisualStyleBackColor = true;
            // 
            // category_filter
            // 
            this.category_filter.AutoSize = true;
            this.category_filter.Location = new System.Drawing.Point(580, 111);
            this.category_filter.Name = "category_filter";
            this.category_filter.Size = new System.Drawing.Size(68, 17);
            this.category_filter.TabIndex = 34;
            this.category_filter.Text = "Category";
            this.category_filter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Set Filters:";
            // 
            // type_filter
            // 
            this.type_filter.AutoSize = true;
            this.type_filter.Location = new System.Drawing.Point(491, 114);
            this.type_filter.Name = "type_filter";
            this.type_filter.Size = new System.Drawing.Size(81, 17);
            this.type_filter.TabIndex = 32;
            this.type_filter.Text = "Event Type";
            this.type_filter.UseVisualStyleBackColor = true;
            // 
            // name_filter
            // 
            this.name_filter.AutoSize = true;
            this.name_filter.Location = new System.Drawing.Point(580, 91);
            this.name_filter.Name = "name_filter";
            this.name_filter.Size = new System.Drawing.Size(54, 17);
            this.name_filter.TabIndex = 31;
            this.name_filter.Text = "Name";
            this.name_filter.UseVisualStyleBackColor = true;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(423, 147);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "To:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eventsDataGridView);
            this.panel1.Location = new System.Drawing.Point(25, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 372);
            this.panel1.TabIndex = 36;
            // 
            // eventsDataGridView
            // 
            this.eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGridView.Location = new System.Drawing.Point(21, 16);
            this.eventsDataGridView.Name = "eventsDataGridView";
            this.eventsDataGridView.Size = new System.Drawing.Size(707, 341);
            this.eventsDataGridView.TabIndex = 0;
            // 
            // bookTicketButton
            // 
            this.bookTicketButton.Location = new System.Drawing.Point(631, 565);
            this.bookTicketButton.Name = "bookTicketButton";
            this.bookTicketButton.Size = new System.Drawing.Size(164, 37);
            this.bookTicketButton.TabIndex = 37;
            this.bookTicketButton.Text = "Book Ticket";
            this.bookTicketButton.UseVisualStyleBackColor = true;
            this.bookTicketButton.Click += new System.EventHandler(this.bookTicketButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(727, 246);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(296, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 37);
            this.label6.TabIndex = 39;
            this.label6.Text = "Book Ticket";
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 614);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.bookTicketButton);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.backToDashboard_button);
            this.Controls.Add(this.label1);
            this.Name = "BookTicket";
            this.Text = "BookTicket";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToDashboard_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.CheckBox date_filter;
        private System.Windows.Forms.TextBox eventSearch_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ticket_filter;
        private System.Windows.Forms.CheckBox category_filter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox type_filter;
        private System.Windows.Forms.CheckBox name_filter;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView eventsDataGridView;
        private System.Windows.Forms.Button bookTicketButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
    }
}