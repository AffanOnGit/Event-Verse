namespace Event_Verse_Application
{
    partial class UserLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.Pass_Box = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Register_Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(97, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Verse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password :";
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(162, 139);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(154, 22);
            this.ID_box.TabIndex = 4;
            // 
            // Pass_Box
            // 
            this.Pass_Box.Location = new System.Drawing.Point(162, 190);
            this.Pass_Box.Name = "Pass_Box";
            this.Pass_Box.Size = new System.Drawing.Size(154, 22);
            this.Pass_Box.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.AllowDrop = true;
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Teal;
            this.loginButton.Location = new System.Drawing.Point(134, 262);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(116, 35);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Don\'t have Account? ";
            // 
            // Register_Link
            // 
            this.Register_Link.AutoSize = true;
            this.Register_Link.Location = new System.Drawing.Point(264, 228);
            this.Register_Link.Name = "Register_Link";
            this.Register_Link.Size = new System.Drawing.Size(52, 13);
            this.Register_Link.TabIndex = 8;
            this.Register_Link.TabStop = true;
            this.Register_Link.Text = "SIGN UP!";
            this.Register_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_Link_LinkClicked);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 410);
            this.Controls.Add(this.Register_Link);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.Pass_Box);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.TextBox Pass_Box;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel Register_Link;
    }
}

