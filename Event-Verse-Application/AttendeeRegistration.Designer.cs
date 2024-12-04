namespace Event_Verse_Application
{
    partial class AttendeeRegistration
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
            this.backToRegistration_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventPreference_box = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToRegistration_button
            // 
            this.backToRegistration_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToRegistration_button.Location = new System.Drawing.Point(12, 12);
            this.backToRegistration_button.Name = "backToRegistration_button";
            this.backToRegistration_button.Size = new System.Drawing.Size(105, 25);
            this.backToRegistration_button.TabIndex = 27;
            this.backToRegistration_button.Text = "<-- Go Back";
            this.backToRegistration_button.UseVisualStyleBackColor = false;
            this.backToRegistration_button.Click += new System.EventHandler(this.backToRegistration_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Attendee Registration Has been Selected!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Choose Event Preference :";
            // 
            // eventPreference_box
            // 
            this.eventPreference_box.Location = new System.Drawing.Point(18, 108);
            this.eventPreference_box.Name = "eventPreference_box";
            this.eventPreference_box.Size = new System.Drawing.Size(177, 22);
            this.eventPreference_box.TabIndex = 30;
            // 
            // registerButton
            // 
            this.registerButton.AllowDrop = true;
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.Teal;
            this.registerButton.Location = new System.Drawing.Point(183, 155);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(108, 35);
            this.registerButton.TabIndex = 31;
            this.registerButton.Text = "REGISTER ";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // AttendeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 202);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.eventPreference_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToRegistration_button);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AttendeeRegistration";
            this.Text = "AttendeeRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToRegistration_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eventPreference_box;
        private System.Windows.Forms.Button registerButton;
    }
}