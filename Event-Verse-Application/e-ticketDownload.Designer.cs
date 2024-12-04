namespace Event_Verse_Application
{
    partial class e_ticketDownload
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
            this.backToBookTicket_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.attendeeID_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eventName_box = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eventID_box = new System.Windows.Forms.TextBox();
            this.ticketType = new System.Windows.Forms.Label();
            this.ticketType_box = new System.Windows.Forms.TextBox();
            this.generateQR_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.eventDate_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketID_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "Event Verse";
            // 
            // backToBookTicket_button
            // 
            this.backToBookTicket_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToBookTicket_button.Location = new System.Drawing.Point(12, 17);
            this.backToBookTicket_button.Name = "backToBookTicket_button";
            this.backToBookTicket_button.Size = new System.Drawing.Size(103, 39);
            this.backToBookTicket_button.TabIndex = 24;
            this.backToBookTicket_button.Text = "<-- Go Back";
            this.backToBookTicket_button.UseVisualStyleBackColor = false;
            this.backToBookTicket_button.Click += new System.EventHandler(this.backToDashboard_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(295, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 107);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 37);
            this.label6.TabIndex = 41;
            this.label6.Text = "E Ticket Info";
            // 
            // attendeeID_box
            // 
            this.attendeeID_box.Location = new System.Drawing.Point(99, 132);
            this.attendeeID_box.Name = "attendeeID_box";
            this.attendeeID_box.Size = new System.Drawing.Size(142, 20);
            this.attendeeID_box.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Attendee ID :";
            // 
            // eventName_box
            // 
            this.eventName_box.AutoSize = true;
            this.eventName_box.Location = new System.Drawing.Point(16, 204);
            this.eventName_box.Name = "eventName_box";
            this.eventName_box.Size = new System.Drawing.Size(72, 13);
            this.eventName_box.TabIndex = 45;
            this.eventName_box.Text = "Event Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Event ID :";
            // 
            // eventID_box
            // 
            this.eventID_box.Location = new System.Drawing.Point(99, 167);
            this.eventID_box.Name = "eventID_box";
            this.eventID_box.Size = new System.Drawing.Size(142, 20);
            this.eventID_box.TabIndex = 46;
            // 
            // ticketType
            // 
            this.ticketType.AutoSize = true;
            this.ticketType.Location = new System.Drawing.Point(18, 267);
            this.ticketType.Name = "ticketType";
            this.ticketType.Size = new System.Drawing.Size(70, 13);
            this.ticketType.TabIndex = 49;
            this.ticketType.Text = "Ticket Type :";
            // 
            // ticketType_box
            // 
            this.ticketType_box.Location = new System.Drawing.Point(101, 264);
            this.ticketType_box.Name = "ticketType_box";
            this.ticketType_box.Size = new System.Drawing.Size(142, 20);
            this.ticketType_box.TabIndex = 48;
            // 
            // generateQR_button
            // 
            this.generateQR_button.BackColor = System.Drawing.Color.Teal;
            this.generateQR_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateQR_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateQR_button.Location = new System.Drawing.Point(310, 312);
            this.generateQR_button.Name = "generateQR_button";
            this.generateQR_button.Size = new System.Drawing.Size(127, 37);
            this.generateQR_button.TabIndex = 50;
            this.generateQR_button.Text = "Generate QR ";
            this.generateQR_button.UseVisualStyleBackColor = false;
            this.generateQR_button.Click += new System.EventHandler(this.generateQR_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Event Date :";
            // 
            // eventDate_box
            // 
            this.eventDate_box.Location = new System.Drawing.Point(101, 234);
            this.eventDate_box.Name = "eventDate_box";
            this.eventDate_box.Size = new System.Drawing.Size(142, 20);
            this.eventDate_box.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Ticket ID :";
            // 
            // ticketID_box
            // 
            this.ticketID_box.Location = new System.Drawing.Point(101, 293);
            this.ticketID_box.Name = "ticketID_box";
            this.ticketID_box.Size = new System.Drawing.Size(142, 20);
            this.ticketID_box.TabIndex = 53;
            // 
            // e_ticketDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 410);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ticketID_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventDate_box);
            this.Controls.Add(this.generateQR_button);
            this.Controls.Add(this.ticketType);
            this.Controls.Add(this.ticketType_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventID_box);
            this.Controls.Add(this.eventName_box);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendeeID_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backToBookTicket_button);
            this.Controls.Add(this.label1);
            this.Name = "e_ticketDownload";
            this.Text = "e_ticketDownload";
            this.Load += new System.EventHandler(this.e_ticketDownload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToBookTicket_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox attendeeID_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label eventName_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eventID_box;
        private System.Windows.Forms.Label ticketType;
        private System.Windows.Forms.TextBox ticketType_box;
        private System.Windows.Forms.Button generateQR_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventDate_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ticketID_box;
    }
}