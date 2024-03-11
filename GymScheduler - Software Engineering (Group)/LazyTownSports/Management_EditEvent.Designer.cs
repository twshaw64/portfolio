namespace LazyTownSports
{
    partial class Management_EditEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management_EditEvent));
            this.txtEditEvent = new System.Windows.Forms.TextBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.dtEventDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSportsVolunteers = new System.Windows.Forms.Label();
            this.clbSportsVolunteers = new System.Windows.Forms.CheckedListBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEditEvent
            // 
            this.txtEditEvent.Location = new System.Drawing.Point(12, 30);
            this.txtEditEvent.MaxLength = 100;
            this.txtEditEvent.Name = "txtEditEvent";
            this.txtEditEvent.Size = new System.Drawing.Size(219, 20);
            this.txtEditEvent.TabIndex = 6;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelEventName.Location = new System.Drawing.Point(9, 9);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(86, 15);
            this.labelEventName.TabIndex = 5;
            this.labelEventName.Text = "Event name:";
            // 
            // dtEventDate
            // 
            this.dtEventDate.CustomFormat = "dd/MM/yyyy hh:00:tt";
            this.dtEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventDate.Location = new System.Drawing.Point(12, 77);
            this.dtEventDate.Name = "dtEventDate";
            this.dtEventDate.Size = new System.Drawing.Size(219, 20);
            this.dtEventDate.TabIndex = 7;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelDate.Location = new System.Drawing.Point(9, 59);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 15);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date:";
            // 
            // labelSportsVolunteers
            // 
            this.labelSportsVolunteers.AutoSize = true;
            this.labelSportsVolunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelSportsVolunteers.Location = new System.Drawing.Point(9, 109);
            this.labelSportsVolunteers.Name = "labelSportsVolunteers";
            this.labelSportsVolunteers.Size = new System.Drawing.Size(124, 15);
            this.labelSportsVolunteers.TabIndex = 9;
            this.labelSportsVolunteers.Text = "Sports Volunteers:";
            // 
            // clbSportsVolunteers
            // 
            this.clbSportsVolunteers.FormattingEnabled = true;
            this.clbSportsVolunteers.Location = new System.Drawing.Point(12, 127);
            this.clbSportsVolunteers.Name = "clbSportsVolunteers";
            this.clbSportsVolunteers.Size = new System.Drawing.Size(219, 109);
            this.clbSportsVolunteers.TabIndex = 10;
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(12, 251);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(83, 23);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Management_EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 285);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.clbSportsVolunteers);
            this.Controls.Add(this.labelSportsVolunteers);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dtEventDate);
            this.Controls.Add(this.txtEditEvent);
            this.Controls.Add(this.labelEventName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Management_EditEvent";
            this.Text = "LTS | Management Portal - Edit Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditEvent;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.DateTimePicker dtEventDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSportsVolunteers;
        private System.Windows.Forms.CheckedListBox clbSportsVolunteers;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}