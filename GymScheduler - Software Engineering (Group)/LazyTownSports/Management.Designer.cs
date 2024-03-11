namespace LazyTownSports
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.TabManagement = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.dtstarttime = new System.Windows.Forms.DateTimePicker();
            this.dtendtime = new System.Windows.Forms.DateTimePicker();
            this.lvBookingtimes = new System.Windows.Forms.ListView();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.dtPickerBooking = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.btnUnbook = new System.Windows.Forms.Button();
            this.labelTimetableDate = new System.Windows.Forms.Label();
            this.listBoxDisplayBookedTimes = new System.Windows.Forms.ListBox();
            this.dtPickerTimetable = new System.Windows.Forms.DateTimePicker();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.tabCurrentEvents = new System.Windows.Forms.TabPage();
            this.labelCurrentEventsEvents = new System.Windows.Forms.Label();
            this.labelEventsDate = new System.Windows.Forms.Label();
            this.listBoxDisplayEvents = new System.Windows.Forms.ListBox();
            this.dtPickerEvents = new System.Windows.Forms.DateTimePicker();
            this.btnSignUpForEvent = new System.Windows.Forms.Button();
            this.tabManageEvents = new System.Windows.Forms.TabPage();
            this.dtManageEvent = new System.Windows.Forms.DateTimePicker();
            this.btnaddevent = new System.Windows.Forms.Button();
            this.labelManageEventsSearch = new System.Windows.Forms.Label();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.labelListOfEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.tabManageAccount = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.tabManageUsers = new System.Windows.Forms.TabPage();
            this.btnadduser = new System.Windows.Forms.Button();
            this.labelManageUsersSearch = new System.Windows.Forms.Label();
            this.txtBoxManageUsersSearch = new System.Windows.Forms.TextBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.labelListOfUsers = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.statusStripManagement = new System.Windows.Forms.StatusStrip();
            this.stripLabelManagement = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnResolveReport = new System.Windows.Forms.Button();
            this.TabManagement.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabTimetable.SuspendLayout();
            this.tabCurrentEvents.SuspendLayout();
            this.tabManageEvents.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabManageUsers.SuspendLayout();
            this.statusStripManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabManagement
            // 
            this.TabManagement.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabManagement.Controls.Add(this.tabPage1);
            this.TabManagement.Controls.Add(this.tabTimetable);
            this.TabManagement.Controls.Add(this.tabCurrentEvents);
            this.TabManagement.Controls.Add(this.tabManageEvents);
            this.TabManagement.Controls.Add(this.tabManageAccount);
            this.TabManagement.Controls.Add(this.tabReports);
            this.TabManagement.Controls.Add(this.tabManageUsers);
            this.TabManagement.HotTrack = true;
            this.TabManagement.Location = new System.Drawing.Point(1, 1);
            this.TabManagement.Margin = new System.Windows.Forms.Padding(4);
            this.TabManagement.Multiline = true;
            this.TabManagement.Name = "TabManagement";
            this.TabManagement.SelectedIndex = 0;
            this.TabManagement.Size = new System.Drawing.Size(777, 629);
            this.TabManagement.TabIndex = 0;
            this.TabManagement.SelectedIndexChanged += new System.EventHandler(this.TabManagement_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.cmbRoom);
            this.tabPage1.Controls.Add(this.dtstarttime);
            this.tabPage1.Controls.Add(this.dtendtime);
            this.tabPage1.Controls.Add(this.lvBookingtimes);
            this.tabPage1.Controls.Add(this.labelBookingDate);
            this.tabPage1.Controls.Add(this.dtPickerBooking);
            this.tabPage1.Controls.Add(this.btnBook);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 593);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Booking";
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Items.AddRange(new object[] {
            "Small Room",
            "Medium Room",
            "Large Room",
            "Multiple-Use Games Room"});
            this.cmbRoom.Location = new System.Drawing.Point(16, 266);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(309, 28);
            this.cmbRoom.TabIndex = 35;
            this.cmbRoom.Text = "Small Room";
            // 
            // dtstarttime
            // 
            this.dtstarttime.CustomFormat = "hh:00:tt";
            this.dtstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtstarttime.Location = new System.Drawing.Point(357, 38);
            this.dtstarttime.Name = "dtstarttime";
            this.dtstarttime.ShowUpDown = true;
            this.dtstarttime.Size = new System.Drawing.Size(200, 26);
            this.dtstarttime.TabIndex = 34;
            this.dtstarttime.Value = new System.DateTime(2018, 12, 8, 1, 0, 0, 0);
            this.dtstarttime.ValueChanged += new System.EventHandler(this.dtstarttime_ValueChanged);
            // 
            // dtendtime
            // 
            this.dtendtime.CustomFormat = "hh:00:tt";
            this.dtendtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtendtime.Location = new System.Drawing.Point(563, 38);
            this.dtendtime.MaxDate = new System.DateTime(9998, 12, 24, 0, 0, 0, 0);
            this.dtendtime.Name = "dtendtime";
            this.dtendtime.ShowUpDown = true;
            this.dtendtime.Size = new System.Drawing.Size(200, 26);
            this.dtendtime.TabIndex = 33;
            this.dtendtime.ValueChanged += new System.EventHandler(this.dtendtime_ValueChanged);
            // 
            // lvBookingtimes
            // 
            this.lvBookingtimes.GridLines = true;
            this.lvBookingtimes.Location = new System.Drawing.Point(15, 70);
            this.lvBookingtimes.MultiSelect = false;
            this.lvBookingtimes.Name = "lvBookingtimes";
            this.lvBookingtimes.Size = new System.Drawing.Size(748, 190);
            this.lvBookingtimes.TabIndex = 32;
            this.lvBookingtimes.UseCompatibleStateImageBehavior = false;
            this.lvBookingtimes.View = System.Windows.Forms.View.Details;
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingDate.Location = new System.Drawing.Point(12, 15);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(48, 20);
            this.labelBookingDate.TabIndex = 27;
            this.labelBookingDate.Text = "Date:";
            this.labelBookingDate.Click += new System.EventHandler(this.labelBookingDate_Click);
            // 
            // dtPickerBooking
            // 
            this.dtPickerBooking.Location = new System.Drawing.Point(16, 38);
            this.dtPickerBooking.Name = "dtPickerBooking";
            this.dtPickerBooking.Size = new System.Drawing.Size(335, 26);
            this.dtPickerBooking.TabIndex = 25;
            this.dtPickerBooking.ValueChanged += new System.EventHandler(this.dtPickerBooking_ValueChanged);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBook.Location = new System.Drawing.Point(331, 266);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(207, 67);
            this.btnBook.TabIndex = 20;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click_1);
            // 
            // tabTimetable
            // 
            this.tabTimetable.BackColor = System.Drawing.SystemColors.Window;
            this.tabTimetable.Controls.Add(this.btnUnbook);
            this.tabTimetable.Controls.Add(this.labelTimetableDate);
            this.tabTimetable.Controls.Add(this.listBoxDisplayBookedTimes);
            this.tabTimetable.Controls.Add(this.dtPickerTimetable);
            this.tabTimetable.Controls.Add(this.btnCreateNote);
            this.tabTimetable.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabTimetable.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabTimetable.Location = new System.Drawing.Point(4, 32);
            this.tabTimetable.Margin = new System.Windows.Forms.Padding(4);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Padding = new System.Windows.Forms.Padding(4);
            this.tabTimetable.Size = new System.Drawing.Size(769, 593);
            this.tabTimetable.TabIndex = 1;
            this.tabTimetable.Text = "Timetable";
            // 
            // btnUnbook
            // 
            this.btnUnbook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUnbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnUnbook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnUnbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnbook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUnbook.Location = new System.Drawing.Point(487, 435);
            this.btnUnbook.Name = "btnUnbook";
            this.btnUnbook.Size = new System.Drawing.Size(213, 67);
            this.btnUnbook.TabIndex = 32;
            this.btnUnbook.Text = "Unbook";
            this.btnUnbook.UseVisualStyleBackColor = false;
            this.btnUnbook.Click += new System.EventHandler(this.btnUnbook_Click);
            // 
            // labelTimetableDate
            // 
            this.labelTimetableDate.AutoSize = true;
            this.labelTimetableDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimetableDate.Location = new System.Drawing.Point(12, 14);
            this.labelTimetableDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimetableDate.Name = "labelTimetableDate";
            this.labelTimetableDate.Size = new System.Drawing.Size(36, 15);
            this.labelTimetableDate.TabIndex = 19;
            this.labelTimetableDate.Text = "Date:";
            // 
            // listBoxDisplayBookedTimes
            // 
            this.listBoxDisplayBookedTimes.FormattingEnabled = true;
            this.listBoxDisplayBookedTimes.ItemHeight = 20;
            this.listBoxDisplayBookedTimes.Location = new System.Drawing.Point(17, 75);
            this.listBoxDisplayBookedTimes.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDisplayBookedTimes.Name = "listBoxDisplayBookedTimes";
            this.listBoxDisplayBookedTimes.Size = new System.Drawing.Size(402, 504);
            this.listBoxDisplayBookedTimes.TabIndex = 13;
            this.listBoxDisplayBookedTimes.SelectedIndexChanged += new System.EventHandler(this.listBoxDisplayBookedTimes_SelectedIndexChanged);
            // 
            // dtPickerTimetable
            // 
            this.dtPickerTimetable.Location = new System.Drawing.Point(17, 40);
            this.dtPickerTimetable.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickerTimetable.Name = "dtPickerTimetable";
            this.dtPickerTimetable.Size = new System.Drawing.Size(402, 26);
            this.dtPickerTimetable.TabIndex = 12;
            this.dtPickerTimetable.ValueChanged += new System.EventHandler(this.dtPickerTimetable_ValueChanged);
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateNote.Location = new System.Drawing.Point(487, 509);
            this.btnCreateNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(213, 70);
            this.btnCreateNote.TabIndex = 10;
            this.btnCreateNote.Text = "Create Note";
            this.btnCreateNote.UseVisualStyleBackColor = false;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click_1);
            // 
            // tabCurrentEvents
            // 
            this.tabCurrentEvents.BackColor = System.Drawing.SystemColors.Window;
            this.tabCurrentEvents.Controls.Add(this.labelCurrentEventsEvents);
            this.tabCurrentEvents.Controls.Add(this.labelEventsDate);
            this.tabCurrentEvents.Controls.Add(this.listBoxDisplayEvents);
            this.tabCurrentEvents.Controls.Add(this.dtPickerEvents);
            this.tabCurrentEvents.Controls.Add(this.btnSignUpForEvent);
            this.tabCurrentEvents.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabCurrentEvents.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabCurrentEvents.Location = new System.Drawing.Point(4, 32);
            this.tabCurrentEvents.Margin = new System.Windows.Forms.Padding(4);
            this.tabCurrentEvents.Name = "tabCurrentEvents";
            this.tabCurrentEvents.Padding = new System.Windows.Forms.Padding(4);
            this.tabCurrentEvents.Size = new System.Drawing.Size(769, 593);
            this.tabCurrentEvents.TabIndex = 3;
            this.tabCurrentEvents.Text = "Current Events";
            // 
            // labelCurrentEventsEvents
            // 
            this.labelCurrentEventsEvents.AutoSize = true;
            this.labelCurrentEventsEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentEventsEvents.Location = new System.Drawing.Point(148, 162);
            this.labelCurrentEventsEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentEventsEvents.Name = "labelCurrentEventsEvents";
            this.labelCurrentEventsEvents.Size = new System.Drawing.Size(46, 15);
            this.labelCurrentEventsEvents.TabIndex = 30;
            this.labelCurrentEventsEvents.Text = "Events:";
            // 
            // labelEventsDate
            // 
            this.labelEventsDate.AutoSize = true;
            this.labelEventsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsDate.Location = new System.Drawing.Point(148, 95);
            this.labelEventsDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventsDate.Name = "labelEventsDate";
            this.labelEventsDate.Size = new System.Drawing.Size(36, 15);
            this.labelEventsDate.TabIndex = 29;
            this.labelEventsDate.Text = "Date:";
            // 
            // listBoxDisplayEvents
            // 
            this.listBoxDisplayEvents.FormattingEnabled = true;
            this.listBoxDisplayEvents.ItemHeight = 20;
            this.listBoxDisplayEvents.Location = new System.Drawing.Point(153, 189);
            this.listBoxDisplayEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDisplayEvents.Name = "listBoxDisplayEvents";
            this.listBoxDisplayEvents.Size = new System.Drawing.Size(298, 224);
            this.listBoxDisplayEvents.TabIndex = 28;
            // 
            // dtPickerEvents
            // 
            this.dtPickerEvents.Location = new System.Drawing.Point(153, 121);
            this.dtPickerEvents.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickerEvents.Name = "dtPickerEvents";
            this.dtPickerEvents.Size = new System.Drawing.Size(298, 26);
            this.dtPickerEvents.TabIndex = 27;
            this.dtPickerEvents.ValueChanged += new System.EventHandler(this.dtPickerEvents_ValueChanged);
            // 
            // btnSignUpForEvent
            // 
            this.btnSignUpForEvent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignUpForEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnSignUpForEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnSignUpForEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpForEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpForEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUpForEvent.Location = new System.Drawing.Point(196, 442);
            this.btnSignUpForEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUpForEvent.Name = "btnSignUpForEvent";
            this.btnSignUpForEvent.Size = new System.Drawing.Size(212, 50);
            this.btnSignUpForEvent.TabIndex = 26;
            this.btnSignUpForEvent.Text = "Sign up for event";
            this.btnSignUpForEvent.UseVisualStyleBackColor = false;
            this.btnSignUpForEvent.Click += new System.EventHandler(this.btnSignUpForEvent_Click_1);
            // 
            // tabManageEvents
            // 
            this.tabManageEvents.BackColor = System.Drawing.SystemColors.Window;
            this.tabManageEvents.Controls.Add(this.dtManageEvent);
            this.tabManageEvents.Controls.Add(this.btnaddevent);
            this.tabManageEvents.Controls.Add(this.labelManageEventsSearch);
            this.tabManageEvents.Controls.Add(this.btnEditEvent);
            this.tabManageEvents.Controls.Add(this.labelListOfEvents);
            this.tabManageEvents.Controls.Add(this.listBoxEvents);
            this.tabManageEvents.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabManageEvents.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabManageEvents.Location = new System.Drawing.Point(4, 32);
            this.tabManageEvents.Margin = new System.Windows.Forms.Padding(4);
            this.tabManageEvents.Name = "tabManageEvents";
            this.tabManageEvents.Padding = new System.Windows.Forms.Padding(4);
            this.tabManageEvents.Size = new System.Drawing.Size(769, 593);
            this.tabManageEvents.TabIndex = 4;
            this.tabManageEvents.Text = "Manage Events";
            // 
            // dtManageEvent
            // 
            this.dtManageEvent.Location = new System.Drawing.Point(174, 69);
            this.dtManageEvent.Name = "dtManageEvent";
            this.dtManageEvent.Size = new System.Drawing.Size(323, 26);
            this.dtManageEvent.TabIndex = 9;
            this.dtManageEvent.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnaddevent
            // 
            this.btnaddevent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddevent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnaddevent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnaddevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddevent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnaddevent.Location = new System.Drawing.Point(73, 496);
            this.btnaddevent.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddevent.Name = "btnaddevent";
            this.btnaddevent.Size = new System.Drawing.Size(215, 44);
            this.btnaddevent.TabIndex = 8;
            this.btnaddevent.Text = "Add Event";
            this.btnaddevent.UseVisualStyleBackColor = false;
            this.btnaddevent.Click += new System.EventHandler(this.btnaddevent_Click);
            // 
            // labelManageEventsSearch
            // 
            this.labelManageEventsSearch.AutoSize = true;
            this.labelManageEventsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageEventsSearch.Location = new System.Drawing.Point(70, 69);
            this.labelManageEventsSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManageEventsSearch.Name = "labelManageEventsSearch";
            this.labelManageEventsSearch.Size = new System.Drawing.Size(49, 15);
            this.labelManageEventsSearch.TabIndex = 7;
            this.labelManageEventsSearch.Text = "Search:";
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnEditEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnEditEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditEvent.Location = new System.Drawing.Point(292, 496);
            this.btnEditEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(205, 44);
            this.btnEditEvent.TabIndex = 5;
            this.btnEditEvent.Text = "Edit Event";
            this.btnEditEvent.UseVisualStyleBackColor = false;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // labelListOfEvents
            // 
            this.labelListOfEvents.AutoSize = true;
            this.labelListOfEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelListOfEvents.Location = new System.Drawing.Point(224, 30);
            this.labelListOfEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListOfEvents.Name = "labelListOfEvents";
            this.labelListOfEvents.Size = new System.Drawing.Size(92, 15);
            this.labelListOfEvents.TabIndex = 4;
            this.labelListOfEvents.Text = "List of Events";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(69, 104);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(428, 384);
            this.listBoxEvents.TabIndex = 3;
            // 
            // tabManageAccount
            // 
            this.tabManageAccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabManageAccount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabManageAccount.Location = new System.Drawing.Point(4, 32);
            this.tabManageAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tabManageAccount.Name = "tabManageAccount";
            this.tabManageAccount.Padding = new System.Windows.Forms.Padding(4);
            this.tabManageAccount.Size = new System.Drawing.Size(769, 593);
            this.tabManageAccount.TabIndex = 5;
            this.tabManageAccount.Text = "Manage Account";
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.SystemColors.Window;
            this.tabReports.Controls.Add(this.btnResolveReport);
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.Controls.Add(this.lstReports);
            this.tabReports.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabReports.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabReports.Location = new System.Drawing.Point(4, 32);
            this.tabReports.Margin = new System.Windows.Forms.Padding(4);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(4);
            this.tabReports.Size = new System.Drawing.Size(769, 593);
            this.tabReports.TabIndex = 6;
            this.tabReports.Text = "Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Received Reports:";
            // 
            // lstReports
            // 
            this.lstReports.FormattingEnabled = true;
            this.lstReports.ItemHeight = 20;
            this.lstReports.Location = new System.Drawing.Point(95, 89);
            this.lstReports.Margin = new System.Windows.Forms.Padding(4);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(567, 424);
            this.lstReports.TabIndex = 0;
            // 
            // tabManageUsers
            // 
            this.tabManageUsers.BackColor = System.Drawing.SystemColors.Window;
            this.tabManageUsers.Controls.Add(this.btnadduser);
            this.tabManageUsers.Controls.Add(this.labelManageUsersSearch);
            this.tabManageUsers.Controls.Add(this.txtBoxManageUsersSearch);
            this.tabManageUsers.Controls.Add(this.btnEditUser);
            this.tabManageUsers.Controls.Add(this.labelListOfUsers);
            this.tabManageUsers.Controls.Add(this.listBoxUsers);
            this.tabManageUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabManageUsers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabManageUsers.Location = new System.Drawing.Point(4, 32);
            this.tabManageUsers.Margin = new System.Windows.Forms.Padding(4);
            this.tabManageUsers.Name = "tabManageUsers";
            this.tabManageUsers.Padding = new System.Windows.Forms.Padding(4);
            this.tabManageUsers.Size = new System.Drawing.Size(769, 593);
            this.tabManageUsers.TabIndex = 2;
            this.tabManageUsers.Text = "Manage Users";
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnadduser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnadduser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnadduser.Location = new System.Drawing.Point(70, 502);
            this.btnadduser.Margin = new System.Windows.Forms.Padding(4);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(215, 44);
            this.btnadduser.TabIndex = 5;
            this.btnadduser.Text = "Add User";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // labelManageUsersSearch
            // 
            this.labelManageUsersSearch.AutoSize = true;
            this.labelManageUsersSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageUsersSearch.Location = new System.Drawing.Point(77, 69);
            this.labelManageUsersSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManageUsersSearch.Name = "labelManageUsersSearch";
            this.labelManageUsersSearch.Size = new System.Drawing.Size(49, 15);
            this.labelManageUsersSearch.TabIndex = 4;
            this.labelManageUsersSearch.Text = "Search:";
            // 
            // txtBoxManageUsersSearch
            // 
            this.txtBoxManageUsersSearch.Location = new System.Drawing.Point(154, 64);
            this.txtBoxManageUsersSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxManageUsersSearch.Name = "txtBoxManageUsersSearch";
            this.txtBoxManageUsersSearch.Size = new System.Drawing.Size(344, 26);
            this.txtBoxManageUsersSearch.TabIndex = 3;
            this.txtBoxManageUsersSearch.TextChanged += new System.EventHandler(this.txtBoxManageUsersSearch_TextChanged);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditUser.Location = new System.Drawing.Point(293, 502);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(205, 44);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            this.btnEditUser.MouseLeave += new System.EventHandler(this.btnEditUser_MouseLeave);
            this.btnEditUser.MouseHover += new System.EventHandler(this.btnEditUser_MouseHover);
            // 
            // labelListOfUsers
            // 
            this.labelListOfUsers.AutoSize = true;
            this.labelListOfUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelListOfUsers.Location = new System.Drawing.Point(216, 25);
            this.labelListOfUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListOfUsers.Name = "labelListOfUsers";
            this.labelListOfUsers.Size = new System.Drawing.Size(87, 15);
            this.labelListOfUsers.TabIndex = 1;
            this.labelListOfUsers.Text = "List of Users";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 20;
            this.listBoxUsers.Location = new System.Drawing.Point(70, 110);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(428, 384);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // statusStripManagement
            // 
            this.statusStripManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabelManagement});
            this.statusStripManagement.Location = new System.Drawing.Point(0, 630);
            this.statusStripManagement.Name = "statusStripManagement";
            this.statusStripManagement.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStripManagement.Size = new System.Drawing.Size(780, 25);
            this.statusStripManagement.TabIndex = 1;
            this.statusStripManagement.Text = "statusStrip1";
            // 
            // stripLabelManagement
            // 
            this.stripLabelManagement.BackColor = System.Drawing.Color.Transparent;
            this.stripLabelManagement.Name = "stripLabelManagement";
            this.stripLabelManagement.Size = new System.Drawing.Size(163, 20);
            this.stripLabelManagement.Text = "toolStripStatusLabel1";
            // 
            // btnResolveReport
            // 
            this.btnResolveReport.Location = new System.Drawing.Point(285, 533);
            this.btnResolveReport.Name = "btnResolveReport";
            this.btnResolveReport.Size = new System.Drawing.Size(133, 29);
            this.btnResolveReport.TabIndex = 6;
            this.btnResolveReport.Text = "Resolve Report";
            this.btnResolveReport.UseVisualStyleBackColor = true;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(780, 655);
            this.Controls.Add(this.statusStripManagement);
            this.Controls.Add(this.TabManagement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Management";
            this.Text = "LTS | Facilities Management Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Management_FormClosing);
            this.Load += new System.EventHandler(this.Management_Load);
            this.TabManagement.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabTimetable.ResumeLayout(false);
            this.tabTimetable.PerformLayout();
            this.tabCurrentEvents.ResumeLayout(false);
            this.tabCurrentEvents.PerformLayout();
            this.tabManageEvents.ResumeLayout(false);
            this.tabManageEvents.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            this.tabManageUsers.ResumeLayout(false);
            this.tabManageUsers.PerformLayout();
            this.statusStripManagement.ResumeLayout(false);
            this.statusStripManagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabManagement;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.TabPage tabManageUsers;
        private System.Windows.Forms.TabPage tabCurrentEvents;
        private System.Windows.Forms.TabPage tabManageEvents;
        private System.Windows.Forms.TabPage tabManageAccount;
        private System.Windows.Forms.Label labelListOfUsers;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Label labelListOfEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.StatusStrip statusStripManagement;
        private System.Windows.Forms.ToolStripStatusLabel stripLabelManagement;
        private System.Windows.Forms.ListBox listBoxDisplayBookedTimes;
        private System.Windows.Forms.DateTimePicker dtPickerTimetable;
        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.Label labelManageUsersSearch;
        private System.Windows.Forms.TextBox txtBoxManageUsersSearch;
        private System.Windows.Forms.Label labelManageEventsSearch;
        private System.Windows.Forms.Label labelTimetableDate;
        private System.Windows.Forms.Label labelCurrentEventsEvents;
        private System.Windows.Forms.Label labelEventsDate;
        private System.Windows.Forms.ListBox listBoxDisplayEvents;
        private System.Windows.Forms.DateTimePicker dtPickerEvents;
        private System.Windows.Forms.Button btnSignUpForEvent;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.DateTimePicker dtPickerBooking;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ListView lvBookingtimes;
        private System.Windows.Forms.DateTimePicker dtendtime;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DateTimePicker dtstarttime;
        private System.Windows.Forms.Button btnaddevent;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.DateTimePicker dtManageEvent;
        private System.Windows.Forms.Button btnUnbook;
        private System.Windows.Forms.Button btnResolveReport;
    }
}