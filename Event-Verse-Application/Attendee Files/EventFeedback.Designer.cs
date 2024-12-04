namespace Event_Verse_Application
{
    partial class EventFeedback
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
            this.label4 = new System.Windows.Forms.Label();
            this.eventID_box = new System.Windows.Forms.TextBox();
            this.eventName_box = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attendeeID_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.feedback_box = new System.Windows.Forms.TextBox();
            this.provideFeedback_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Verse";
            // 
            // backToDashboard_button
            // 
            this.backToDashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToDashboard_button.Location = new System.Drawing.Point(12, 9);
            this.backToDashboard_button.Name = "backToDashboard_button";
            this.backToDashboard_button.Size = new System.Drawing.Size(103, 39);
            this.backToDashboard_button.TabIndex = 22;
            this.backToDashboard_button.Text = "<-- Go Back";
            this.backToDashboard_button.UseVisualStyleBackColor = false;
            this.backToDashboard_button.Click += new System.EventHandler(this.backToDashboard_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(33, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 37);
            this.label6.TabIndex = 23;
            this.label6.Text = "Provide Event Feedback";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Event ID :";
            // 
            // eventID_box
            // 
            this.eventID_box.Location = new System.Drawing.Point(134, 146);
            this.eventID_box.Name = "eventID_box";
            this.eventID_box.Size = new System.Drawing.Size(142, 20);
            this.eventID_box.TabIndex = 52;
            // 
            // eventName_box
            // 
            this.eventName_box.AutoSize = true;
            this.eventName_box.Location = new System.Drawing.Point(51, 183);
            this.eventName_box.Name = "eventName_box";
            this.eventName_box.Size = new System.Drawing.Size(72, 13);
            this.eventName_box.TabIndex = 51;
            this.eventName_box.Text = "Event Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Attendee ID :";
            // 
            // attendeeID_box
            // 
            this.attendeeID_box.Location = new System.Drawing.Point(134, 111);
            this.attendeeID_box.Name = "attendeeID_box";
            this.attendeeID_box.Size = new System.Drawing.Size(142, 20);
            this.attendeeID_box.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Feedback :";
            // 
            // feedback_box
            // 
            this.feedback_box.Location = new System.Drawing.Point(134, 227);
            this.feedback_box.Name = "feedback_box";
            this.feedback_box.Size = new System.Drawing.Size(142, 20);
            this.feedback_box.TabIndex = 55;
            // 
            // provideFeedback_button
            // 
            this.provideFeedback_button.BackColor = System.Drawing.Color.Chartreuse;
            this.provideFeedback_button.Location = new System.Drawing.Point(116, 295);
            this.provideFeedback_button.Name = "provideFeedback_button";
            this.provideFeedback_button.Size = new System.Drawing.Size(123, 42);
            this.provideFeedback_button.TabIndex = 56;
            this.provideFeedback_button.Text = "Provide Feedback";
            this.provideFeedback_button.UseVisualStyleBackColor = false;
            this.provideFeedback_button.Click += new System.EventHandler(this.provideFeedback_button_Click);
            // 
            // EventFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 374);
            this.Controls.Add(this.provideFeedback_button);
            this.Controls.Add(this.feedback_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventID_box);
            this.Controls.Add(this.eventName_box);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendeeID_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backToDashboard_button);
            this.Controls.Add(this.label1);
            this.Name = "EventFeedback";
            this.Text = "EventFeedback";
            this.Load += new System.EventHandler(this.EventFeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToDashboard_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eventID_box;
        private System.Windows.Forms.Label eventName_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox attendeeID_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox feedback_box;
        private System.Windows.Forms.Button provideFeedback_button;
    }
}