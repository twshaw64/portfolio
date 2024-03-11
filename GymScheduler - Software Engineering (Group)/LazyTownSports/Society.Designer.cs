namespace LazyTownSports
{
    partial class Society
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Society));
            this.TabManagement = new System.Windows.Forms.TabControl();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.dtstarttime = new System.Windows.Forms.DateTimePicker();
            this.lvBookingtimes = new System.Windows.Forms.ListView();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.dtPickerBooking = new System.Windows.Forms.DateTimePicker();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.btnUnbook = new System.Windows.Forms.Button();
            this.labelTimetableDate = new System.Windows.Forms.Label();
            this.listBoxDisplayBookedTimes = new System.Windows.Forms.ListBox();
            this.dtPickerTimetable = new System.Windows.Forms.DateTimePicker();
            this.btnCancelSelected = new System.Windows.Forms.Button();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.tabManageAccount = new System.Windows.Forms.TabPage();
            this.tabReportProblem = new System.Windows.Forms.TabPage();
            this.labelReportProblemFooter = new System.Windows.Forms.Label();
            this.btnSubmitReport = new System.Windows.Forms.Button();
            this.txtBoxReportProblem = new System.Windows.Forms.TextBox();
            this.labelReportProblemSubtitle = new System.Windows.Forms.Label();
            this.labelReportProblem = new System.Windows.Forms.Label();
            this.statusStripSociety = new System.Windows.Forms.StatusStrip();
            this.stripLabelSociety = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabManagement.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.tabTimetable.SuspendLayout();
            this.tabReportProblem.SuspendLayout();
            this.statusStripSociety.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabManagement
            // 
            this.TabManagement.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabManagement.Controls.Add(this.tabBooking);
            this.TabManagement.Controls.Add(this.tabTimetable);
            this.TabManagement.Controls.Add(this.tabManageAccount);
            this.TabManagement.Controls.Add(this.tabReportProblem);
            this.TabManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TabManagement.Location = new System.Drawing.Point(9, 5);
            this.TabManagement.Multiline = true;
            this.TabManagement.Name = "TabManagement";
            this.TabManagement.SelectedIndex = 0;
            this.TabManagement.Size = new System.Drawing.Size(778, 557);
            this.TabManagement.TabIndex = 2;
            this.TabManagement.SelectedIndexChanged += new System.EventHandler(this.TabManagement_SelectedIndexChanged);
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.cmbRoom);
            this.tabBooking.Controls.Add(this.btnBook);
            this.tabBooking.Controls.Add(this.dtstarttime);
            this.tabBooking.Controls.Add(this.lvBookingtimes);
            this.tabBooking.Controls.Add(this.labelBookingDate);
            this.tabBooking.Controls.Add(this.dtPickerBooking);
            this.tabBooking.Location = new System.Drawing.Point(4, 32);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabBooking.Size = new System.Drawing.Size(770, 521);
            this.tabBooking.TabIndex = 0;
            this.tabBooking.Text = "Booking";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Items.AddRange(new object[] {
            "Small Room",
            "Medium Room",
            "Large Room",
            "Multiple-Use Games Room"});
            this.cmbRoom.Location = new System.Drawing.Point(9, 252);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(309, 28);
            this.cmbRoom.TabIndex = 38;
            this.cmbRoom.Text = "Small Room";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBook.Location = new System.Drawing.Point(337, 252);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(207, 67);
            this.btnBook.TabIndex = 36;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtstarttime
            // 
            this.dtstarttime.CustomFormat = "hh:00:tt";
            this.dtstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtstarttime.Location = new System.Drawing.Point(215, 30);
            this.dtstarttime.Name = "dtstarttime";
            this.dtstarttime.ShowUpDown = true;
            this.dtstarttime.Size = new System.Drawing.Size(200, 26);
            this.dtstarttime.TabIndex = 35;
            this.dtstarttime.Value = new System.DateTime(2018, 12, 8, 1, 0, 0, 0);
            // 
            // lvBookingtimes
            // 
            this.lvBookingtimes.GridLines = true;
            this.lvBookingtimes.Location = new System.Drawing.Point(9, 56);
            this.lvBookingtimes.MultiSelect = false;
            this.lvBookingtimes.Name = "lvBookingtimes";
            this.lvBookingtimes.Size = new System.Drawing.Size(748, 190);
            this.lvBookingtimes.TabIndex = 33;
            this.lvBookingtimes.UseCompatibleStateImageBehavior = false;
            this.lvBookingtimes.View = System.Windows.Forms.View.Details;
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingDate.Location = new System.Drawing.Point(6, 12);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(36, 15);
            this.labelBookingDate.TabIndex = 20;
            this.labelBookingDate.Text = "Date:";
            this.labelBookingDate.Click += new System.EventHandler(this.labelBookingDate_Click);
            // 
            // dtPickerBooking
            // 
            this.dtPickerBooking.Location = new System.Drawing.Point(9, 30);
            this.dtPickerBooking.Name = "dtPickerBooking";
            this.dtPickerBooking.Size = new System.Drawing.Size(200, 26);
            this.dtPickerBooking.TabIndex = 7;
            this.dtPickerBooking.ValueChanged += new System.EventHandler(this.dtPickerBooking_ValueChanged);
            // 
            // tabTimetable
            // 
            this.tabTimetable.Controls.Add(this.btnUnbook);
            this.tabTimetable.Controls.Add(this.labelTimetableDate);
            this.tabTimetable.Controls.Add(this.listBoxDisplayBookedTimes);
            this.tabTimetable.Controls.Add(this.dtPickerTimetable);
            this.tabTimetable.Controls.Add(this.btnCancelSelected);
            this.tabTimetable.Controls.Add(this.btnCreateNote);
            this.tabTimetable.Location = new System.Drawing.Point(4, 32);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimetable.Size = new System.Drawing.Size(770, 521);
            this.tabTimetable.TabIndex = 1;
            this.tabTimetable.Text = "Timetable";
            this.tabTimetable.UseVisualStyleBackColor = true;
            // 
            // btnUnbook
            // 
            this.btnUnbook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUnbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnUnbook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnUnbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnbook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUnbook.Location = new System.Drawing.Point(348, 264);
            this.btnUnbook.Name = "btnUnbook";
            this.btnUnbook.Size = new System.Drawing.Size(207, 67);
            this.btnUnbook.TabIndex = 38;
            this.btnUnbook.Text = "Unbook";
            this.btnUnbook.UseVisualStyleBackColor = false;
            this.btnUnbook.Click += new System.EventHandler(this.btnUnbook_Click);
            // 
            // labelTimetableDate
            // 
            this.labelTimetableDate.AutoSize = true;
            this.labelTimetableDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimetableDate.Location = new System.Drawing.Point(16, 14);
            this.labelTimetableDate.Name = "labelTimetableDate";
            this.labelTimetableDate.Size = new System.Drawing.Size(36, 15);
            this.labelTimetableDate.TabIndex = 19;
            this.labelTimetableDate.Text = "Date:";
            // 
            // listBoxDisplayBookedTimes
            // 
            this.listBoxDisplayBookedTimes.FormattingEnabled = true;
            this.listBoxDisplayBookedTimes.ItemHeight = 20;
            this.listBoxDisplayBookedTimes.Location = new System.Drawing.Point(19, 58);
            this.listBoxDisplayBookedTimes.Name = "listBoxDisplayBookedTimes";
            this.listBoxDisplayBookedTimes.Size = new System.Drawing.Size(260, 444);
            this.listBoxDisplayBookedTimes.TabIndex = 9;
            // 
            // dtPickerTimetable
            // 
            this.dtPickerTimetable.Location = new System.Drawing.Point(19, 32);
            this.dtPickerTimetable.Name = "dtPickerTimetable";
            this.dtPickerTimetable.Size = new System.Drawing.Size(260, 26);
            this.dtPickerTimetable.TabIndex = 8;
            this.dtPickerTimetable.ValueChanged += new System.EventHandler(this.dtPickerTimetable_ValueChanged);
            // 
            // btnCancelSelected
            // 
            this.btnCancelSelected.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCancelSelected.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelSelected.Location = new System.Drawing.Point(348, 410);
            this.btnCancelSelected.Name = "btnCancelSelected";
            this.btnCancelSelected.Size = new System.Drawing.Size(207, 67);
            this.btnCancelSelected.TabIndex = 3;
            this.btnCancelSelected.Text = "Cancel Selected";
            this.btnCancelSelected.UseVisualStyleBackColor = false;
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCreateNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateNote.Location = new System.Drawing.Point(348, 337);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(207, 67);
            this.btnCreateNote.TabIndex = 2;
            this.btnCreateNote.Text = "Create Note";
            this.btnCreateNote.UseVisualStyleBackColor = false;
            // 
            // tabManageAccount
            // 
            this.tabManageAccount.Location = new System.Drawing.Point(4, 32);
            this.tabManageAccount.Name = "tabManageAccount";
            this.tabManageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageAccount.Size = new System.Drawing.Size(770, 521);
            this.tabManageAccount.TabIndex = 4;
            this.tabManageAccount.Text = "Manage Account";
            this.tabManageAccount.UseVisualStyleBackColor = true;
            // 
            // tabReportProblem
            // 
            this.tabReportProblem.Controls.Add(this.labelReportProblemFooter);
            this.tabReportProblem.Controls.Add(this.btnSubmitReport);
            this.tabReportProblem.Controls.Add(this.txtBoxReportProblem);
            this.tabReportProblem.Controls.Add(this.labelReportProblemSubtitle);
            this.tabReportProblem.Controls.Add(this.labelReportProblem);
            this.tabReportProblem.Location = new System.Drawing.Point(4, 32);
            this.tabReportProblem.Name = "tabReportProblem";
            this.tabReportProblem.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportProblem.Size = new System.Drawing.Size(770, 521);
            this.tabReportProblem.TabIndex = 5;
            this.tabReportProblem.Text = "Report Problem";
            this.tabReportProblem.UseVisualStyleBackColor = true;
            // 
            // labelReportProblemFooter
            // 
            this.labelReportProblemFooter.AutoSize = true;
            this.labelReportProblemFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportProblemFooter.Location = new System.Drawing.Point(161, 419);
            this.labelReportProblemFooter.Name = "labelReportProblemFooter";
            this.labelReportProblemFooter.Size = new System.Drawing.Size(453, 15);
            this.labelReportProblemFooter.TabIndex = 9;
            this.labelReportProblemFooter.Text = "Please remember to be as descriptive as possible about the situation!";
            // 
            // btnSubmitReport
            // 
            this.btnSubmitReport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmitReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSubmitReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmitReport.Location = new System.Drawing.Point(285, 437);
            this.btnSubmitReport.Name = "btnSubmitReport";
            this.btnSubmitReport.Size = new System.Drawing.Size(207, 67);
            this.btnSubmitReport.TabIndex = 8;
            this.btnSubmitReport.Text = "Submit Report";
            this.btnSubmitReport.UseVisualStyleBackColor = false;
            // 
            // txtBoxReportProblem
            // 
            this.txtBoxReportProblem.Location = new System.Drawing.Point(24, 95);
            this.txtBoxReportProblem.Multiline = true;
            this.txtBoxReportProblem.Name = "txtBoxReportProblem";
            this.txtBoxReportProblem.Size = new System.Drawing.Size(724, 321);
            this.txtBoxReportProblem.TabIndex = 7;
            // 
            // labelReportProblemSubtitle
            // 
            this.labelReportProblemSubtitle.Location = new System.Drawing.Point(20, 51);
            this.labelReportProblemSubtitle.Name = "labelReportProblemSubtitle";
            this.labelReportProblemSubtitle.Size = new System.Drawing.Size(709, 41);
            this.labelReportProblemSubtitle.TabIndex = 6;
            this.labelReportProblemSubtitle.Text = resources.GetString("labelReportProblemSubtitle.Text");
            // 
            // labelReportProblem
            // 
            this.labelReportProblem.AutoSize = true;
            this.labelReportProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportProblem.Location = new System.Drawing.Point(19, 16);
            this.labelReportProblem.Name = "labelReportProblem";
            this.labelReportProblem.Size = new System.Drawing.Size(200, 25);
            this.labelReportProblem.TabIndex = 5;
            this.labelReportProblem.Text = "Report a problem:";
            this.labelReportProblem.Click += new System.EventHandler(this.labelReportProblem_Click);
            // 
            // statusStripSociety
            // 
            this.statusStripSociety.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabelSociety});
            this.statusStripSociety.Location = new System.Drawing.Point(0, 564);
            this.statusStripSociety.Name = "statusStripSociety";
            this.statusStripSociety.Size = new System.Drawing.Size(787, 22);
            this.statusStripSociety.TabIndex = 3;
            this.statusStripSociety.Text = "statusStrip1";
            // 
            // stripLabelSociety
            // 
            this.stripLabelSociety.Name = "stripLabelSociety";
            this.stripLabelSociety.Size = new System.Drawing.Size(118, 17);
            this.stripLabelSociety.Text = "toolStripStatusLabel1";
            // 
            // Society
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 586);
            this.Controls.Add(this.statusStripSociety);
            this.Controls.Add(this.TabManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Society";
            this.Text = "LTS | Society Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Society_FormClosing);
            this.Load += new System.EventHandler(this.Society_Load);
            this.TabManagement.ResumeLayout(false);
            this.tabBooking.ResumeLayout(false);
            this.tabBooking.PerformLayout();
            this.tabTimetable.ResumeLayout(false);
            this.tabTimetable.PerformLayout();
            this.tabReportProblem.ResumeLayout(false);
            this.tabReportProblem.PerformLayout();
            this.statusStripSociety.ResumeLayout(false);
            this.statusStripSociety.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabManagement;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.DateTimePicker dtPickerBooking;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.Label labelTimetableDate;
        private System.Windows.Forms.ListBox listBoxDisplayBookedTimes;
        private System.Windows.Forms.DateTimePicker dtPickerTimetable;
        private System.Windows.Forms.Button btnCancelSelected;
        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.StatusStrip statusStripSociety;
        private System.Windows.Forms.ToolStripStatusLabel stripLabelSociety;
        private System.Windows.Forms.TabPage tabReportProblem;
        private System.Windows.Forms.Label labelReportProblemFooter;
        private System.Windows.Forms.Button btnSubmitReport;
        private System.Windows.Forms.TextBox txtBoxReportProblem;
        private System.Windows.Forms.Label labelReportProblemSubtitle;
        private System.Windows.Forms.Label labelReportProblem;
        private System.Windows.Forms.TabPage tabManageAccount;
        private System.Windows.Forms.ListView lvBookingtimes;
        private System.Windows.Forms.DateTimePicker dtstarttime;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnUnbook;
    }
}