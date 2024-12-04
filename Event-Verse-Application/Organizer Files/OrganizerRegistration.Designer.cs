namespace Event_Verse_Application.Organizer_Files
{
    partial class OrganizerRegistration
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
            this.registerButton = new System.Windows.Forms.Button();
            this.organizationName_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backToRegistration_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.registerButton.TabIndex = 36;
            this.registerButton.Text = "REGISTER ";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // organizationName_box
            // 
            this.organizationName_box.Location = new System.Drawing.Point(18, 108);
            this.organizationName_box.Name = "organizationName_box";
            this.organizationName_box.Size = new System.Drawing.Size(177, 20);
            this.organizationName_box.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Enter Organization Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Organizer Registration Has been Selected!";
            // 
            // backToRegistration_button
            // 
            this.backToRegistration_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToRegistration_button.Location = new System.Drawing.Point(12, 12);
            this.backToRegistration_button.Name = "backToRegistration_button";
            this.backToRegistration_button.Size = new System.Drawing.Size(105, 25);
            this.backToRegistration_button.TabIndex = 32;
            this.backToRegistration_button.Text = "<-- Go Back";
            this.backToRegistration_button.UseVisualStyleBackColor = false;
            this.backToRegistration_button.Click += new System.EventHandler(this.backToRegistration_button_Click);
            // 
            // OrganizerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 202);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.organizationName_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToRegistration_button);
            this.Name = "OrganizerRegistration";
            this.Text = "OrganizerRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox organizationName_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToRegistration_button;
    }
}