namespace Event_Verse_Application.Organizer_Files
{
    partial class ResourceAndVendorManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vendorsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backToDashboard_button = new System.Windows.Forms.Button();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vendorID_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.category_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newCategory_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addVendor_button = new System.Windows.Forms.Button();
            this.deleteVendor_button = new System.Windows.Forms.Button();
            this.updateVendor_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Verse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 37);
            this.label6.TabIndex = 43;
            this.label6.Text = "Vendors List";
            // 
            // vendorsGridView
            // 
            this.vendorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsGridView.Location = new System.Drawing.Point(19, 98);
            this.vendorsGridView.Name = "vendorsGridView";
            this.vendorsGridView.Size = new System.Drawing.Size(463, 297);
            this.vendorsGridView.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(488, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 45;
            this.label1.Text = "Choose Vendor";
            // 
            // backToDashboard_button
            // 
            this.backToDashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToDashboard_button.Location = new System.Drawing.Point(12, 9);
            this.backToDashboard_button.Name = "backToDashboard_button";
            this.backToDashboard_button.Size = new System.Drawing.Size(103, 39);
            this.backToDashboard_button.TabIndex = 77;
            this.backToDashboard_button.Text = "<-- Go Back";
            this.backToDashboard_button.UseVisualStyleBackColor = false;
            this.backToDashboard_button.Click += new System.EventHandler(this.backToDashboard_button_Click);
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(518, 159);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(253, 20);
            this.id_box.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 82;
            this.label3.Text = "Enter Event ID :";
            // 
            // vendorID_box
            // 
            this.vendorID_box.Location = new System.Drawing.Point(518, 206);
            this.vendorID_box.Name = "vendorID_box";
            this.vendorID_box.Size = new System.Drawing.Size(253, 20);
            this.vendorID_box.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 84;
            this.label4.Text = "Enter Vendor ID :";
            // 
            // category_box
            // 
            this.category_box.Location = new System.Drawing.Point(518, 253);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(253, 20);
            this.category_box.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(491, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 21);
            this.label5.TabIndex = 86;
            this.label5.Text = "Enter Vendor Category :";
            // 
            // newCategory_box
            // 
            this.newCategory_box.Location = new System.Drawing.Point(515, 317);
            this.newCategory_box.Name = "newCategory_box";
            this.newCategory_box.Size = new System.Drawing.Size(253, 20);
            this.newCategory_box.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 88;
            this.label7.Text = "New Category :";
            // 
            // addVendor_button
            // 
            this.addVendor_button.Location = new System.Drawing.Point(495, 371);
            this.addVendor_button.Name = "addVendor_button";
            this.addVendor_button.Size = new System.Drawing.Size(75, 23);
            this.addVendor_button.TabIndex = 90;
            this.addVendor_button.Text = "Add Vendor";
            this.addVendor_button.UseVisualStyleBackColor = true;
            this.addVendor_button.Click += new System.EventHandler(this.addVendor_button_Click);
            // 
            // deleteVendor_button
            // 
            this.deleteVendor_button.Location = new System.Drawing.Point(576, 372);
            this.deleteVendor_button.Name = "deleteVendor_button";
            this.deleteVendor_button.Size = new System.Drawing.Size(100, 23);
            this.deleteVendor_button.TabIndex = 91;
            this.deleteVendor_button.Text = "Delete Vendor";
            this.deleteVendor_button.UseVisualStyleBackColor = true;
            this.deleteVendor_button.Click += new System.EventHandler(this.deleteVendor_button_Click);
            // 
            // updateVendor_button
            // 
            this.updateVendor_button.Location = new System.Drawing.Point(682, 372);
            this.updateVendor_button.Name = "updateVendor_button";
            this.updateVendor_button.Size = new System.Drawing.Size(100, 23);
            this.updateVendor_button.TabIndex = 92;
            this.updateVendor_button.Text = "Update Vendor";
            this.updateVendor_button.UseVisualStyleBackColor = true;
            this.updateVendor_button.Click += new System.EventHandler(this.updateVendor_button_Click);
            // 
            // ResourceAndVendorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateVendor_button);
            this.Controls.Add(this.deleteVendor_button);
            this.Controls.Add(this.addVendor_button);
            this.Controls.Add(this.newCategory_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vendorID_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backToDashboard_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendorsGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "ResourceAndVendorManagement";
            this.Text = "ResourceAndVendorManagement";
            this.Load += new System.EventHandler(this.ResourceAndVendorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView vendorsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToDashboard_button;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vendorID_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox category_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newCategory_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addVendor_button;
        private System.Windows.Forms.Button deleteVendor_button;
        private System.Windows.Forms.Button updateVendor_button;
    }
}