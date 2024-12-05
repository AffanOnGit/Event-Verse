namespace Event_Verse_Application.Organizer_Files
{
    partial class EventFeedbackView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.feedbackView = new System.Windows.Forms.DataGridView();
            this.searchFeedback_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackView)).BeginInit();
            this.SuspendLayout();
            // 
            // backToDashboard_button
            // 
            this.backToDashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backToDashboard_button.Location = new System.Drawing.Point(12, 12);
            this.backToDashboard_button.Name = "backToDashboard_button";
            this.backToDashboard_button.Size = new System.Drawing.Size(103, 39);
            this.backToDashboard_button.TabIndex = 79;
            this.backToDashboard_button.Text = "<-- Go Back";
            this.backToDashboard_button.UseVisualStyleBackColor = false;
            this.backToDashboard_button.Click += new System.EventHandler(this.backToDashboard_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(237, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 44);
            this.label2.TabIndex = 78;
            this.label2.Text = "Event Verse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(29, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 37);
            this.label6.TabIndex = 80;
            this.label6.Text = "Event Feedback View";
            // 
            // feedbackView
            // 
            this.feedbackView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackView.Location = new System.Drawing.Point(36, 145);
            this.feedbackView.Name = "feedbackView";
            this.feedbackView.Size = new System.Drawing.Size(542, 379);
            this.feedbackView.TabIndex = 81;
            // 
            // searchFeedback_button
            // 
            this.searchFeedback_button.Location = new System.Drawing.Point(447, 92);
            this.searchFeedback_button.Name = "searchFeedback_button";
            this.searchFeedback_button.Size = new System.Drawing.Size(131, 36);
            this.searchFeedback_button.TabIndex = 82;
            this.searchFeedback_button.Text = "Search Feedback";
            this.searchFeedback_button.UseVisualStyleBackColor = true;
            this.searchFeedback_button.Click += new System.EventHandler(this.searchFeedback_button_Click);
            // 
            // EventFeedbackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 557);
            this.Controls.Add(this.searchFeedback_button);
            this.Controls.Add(this.feedbackView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backToDashboard_button);
            this.Controls.Add(this.label2);
            this.Name = "EventFeedbackView";
            this.Text = "EventFeedbackView";
            this.Load += new System.EventHandler(this.EventFeedbackView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToDashboard_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView feedbackView;
        private System.Windows.Forms.Button searchFeedback_button;
    }
}