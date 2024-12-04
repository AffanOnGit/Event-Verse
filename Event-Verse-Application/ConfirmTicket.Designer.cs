namespace Event_Verse_Application
{
    partial class ConfirmTicket
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
            this.ticketUserID_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eventID_box = new System.Windows.Forms.TextBox();
            this.eventName_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketType_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelConfirmation_button = new System.Windows.Forms.Button();
            this.bookTicket_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(20, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 37);
            this.label6.TabIndex = 40;
            this.label6.Text = "Confirm Ticket";
            // 
            // ticketUserID_box
            // 
            this.ticketUserID_box.Location = new System.Drawing.Point(53, 103);
            this.ticketUserID_box.Name = "ticketUserID_box";
            this.ticketUserID_box.Size = new System.Drawing.Size(156, 22);
            this.ticketUserID_box.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "User ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Event ID : ";
            // 
            // eventID_box
            // 
            this.eventID_box.Location = new System.Drawing.Point(53, 183);
            this.eventID_box.Name = "eventID_box";
            this.eventID_box.Size = new System.Drawing.Size(156, 22);
            this.eventID_box.TabIndex = 44;
            // 
            // eventName_box
            // 
            this.eventName_box.Location = new System.Drawing.Point(252, 103);
            this.eventName_box.Name = "eventName_box";
            this.eventName_box.Size = new System.Drawing.Size(156, 22);
            this.eventName_box.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Event Name :";
            // 
            // ticketType_box
            // 
            this.ticketType_box.Location = new System.Drawing.Point(252, 184);
            this.ticketType_box.Name = "ticketType_box";
            this.ticketType_box.Size = new System.Drawing.Size(156, 22);
            this.ticketType_box.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ticket Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "( VIP / General  only!)";
            // 
            // cancelConfirmation_button
            // 
            this.cancelConfirmation_button.BackColor = System.Drawing.Color.Red;
            this.cancelConfirmation_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelConfirmation_button.Location = new System.Drawing.Point(96, 257);
            this.cancelConfirmation_button.Name = "cancelConfirmation_button";
            this.cancelConfirmation_button.Size = new System.Drawing.Size(113, 37);
            this.cancelConfirmation_button.TabIndex = 50;
            this.cancelConfirmation_button.Text = "Cancel";
            this.cancelConfirmation_button.UseVisualStyleBackColor = false;
            this.cancelConfirmation_button.Click += new System.EventHandler(this.cancelConfirmation_button_Click);
            // 
            // bookTicket_button
            // 
            this.bookTicket_button.BackColor = System.Drawing.Color.Lime;
            this.bookTicket_button.Location = new System.Drawing.Point(226, 258);
            this.bookTicket_button.Name = "bookTicket_button";
            this.bookTicket_button.Size = new System.Drawing.Size(113, 37);
            this.bookTicket_button.TabIndex = 51;
            this.bookTicket_button.Text = "Book Ticket";
            this.bookTicket_button.UseVisualStyleBackColor = false;
            this.bookTicket_button.Click += new System.EventHandler(this.bookTicket_button_Click);
            // 
            // ConfirmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 373);
            this.Controls.Add(this.bookTicket_button);
            this.Controls.Add(this.cancelConfirmation_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ticketType_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventName_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventID_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketUserID_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConfirmTicket";
            this.Text = "ConfirmTicket";
            this.Load += new System.EventHandler(this.ConfirmTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ticketUserID_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventID_box;
        private System.Windows.Forms.TextBox eventName_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ticketType_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelConfirmation_button;
        private System.Windows.Forms.Button bookTicket_button;
    }
}