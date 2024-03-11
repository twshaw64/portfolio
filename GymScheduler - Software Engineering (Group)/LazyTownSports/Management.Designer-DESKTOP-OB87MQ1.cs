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
            this.btnUnbook = new System.Windows.Forms.Button();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.listBoxDisplayUnbookedTimes = new System.Windows.Forms.ListBox();
            this.dtPickerBooking = new System.Windows.Forms.DateTimePicker();
            this.checkBoxMUGA = new System.Windows.Forms.CheckBox();
            this.checkBoxLargeRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxMediumRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxSmallRoom = new System.Windows.Forms.CheckBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.labelTimetableDate = new System.Windows.Forms.Label();
            this.listBoxDisplayBookedTimes = new System.Windows.Forms.ListBox();
            this.dtPickerTimetable = new System.Windows.Forms.DateTimePicker();
            this.btnCancelSelected = new System.Windows.Forms.Button();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.tabManageUsers = new System.Windows.Forms.TabPage();
            this.labelManageUsersSearch = new System.Windows.Forms.Label();
            this.txtBoxManageUsersSearch = new System.Windows.Forms.TextBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.labelListOfUsers = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.tabCurrentEvents = new System.Windows.Forms.TabPage();
            this.labelCurrentEventsEvents = new System.Windows.Forms.Label();
            this.labelEventsDate = new System.Windows.Forms.Label();
            this.listBoxDisplayEvents = new System.Windows.Forms.ListBox();
            this.dtPickerEvents = new System.Windows.Forms.DateTimePicker();
            this.btnSignUpForEvent = new System.Windows.Forms.Button();
            this.tabManageEvents = new System.Windows.Forms.TabPage();
            this.labelManageEventsSearch = new System.Windows.Forms.Label();
            this.txtBoxManageEventsSerch = new System.Windows.Forms.TextBox();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.labelListOfEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.tabManageAccount = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.statusStripManagement = new System.Windows.Forms.StatusStrip();
            this.stripLabelManagement = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TabManagement.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabTimetable.SuspendLayout();
            this.tabManageUsers.SuspendLayout();
            this.tabCurrentEvents.SuspendLayout();
            this.tabManageEvents.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.statusStripManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabManagement
            // 
            this.TabManagement.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabManagement.Controls.Add(this.tabPage1);
            this.TabManagement.Controls.Add(this.tabTimetable);
            this.TabManagement.Controls.Add(this.tabManageUsers);
            this.TabManagement.Controls.Add(this.tabCurrentEvents);
            this.TabManagement.Controls.Add(this.tabManageEvents);
            this.TabManagement.Controls.Add(this.tabManageAccount);
            this.TabManagement.Controls.Add(this.tabReports);
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
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.btnUnbook);
            this.tabPage1.Controls.Add(this.dtEndTime);
            this.tabPage1.Controls.Add(this.dtStartTime);
            this.tabPage1.Controls.Add(this.labelBookingDate);
            this.tabPage1.Controls.Add(this.listBoxDisplayUnbookedTimes);
            this.tabPage1.Controls.Add(this.dtPickerBooking);
            this.tabPage1.Controls.Add(this.checkBoxMUGA);
            this.tabPage1.Controls.Add(this.checkBoxLargeRoom);
            this.tabPage1.Controls.Add(this.checkBoxMediumRoom);
            this.tabPage1.Controls.Add(this.checkBoxSmallRoom);
            this.tabPage1.Controls.Add(this.btnBook);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 593);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Booking";
            // 
            // btnUnbook
            // 
            this.btnUnbook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUnbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnUnbook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnUnbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnbook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUnbook.Location = new System.Drawing.Point(430, 323);
            this.btnUnbook.Name = "btnUnbook";
            this.btnUnbook.Size = new System.Drawing.Size(207, 67);
            this.btnUnbook.TabIndex = 31;
            this.btnUnbook.Text = "Unbook";
            this.btnUnbook.UseVisualStyleBackColor = false;
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "hh:00:tt";
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(564, 38);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.ShowUpDown = true;
            this.dtEndTime.Size = new System.Drawing.Size(200, 26);
            this.dtEndTime.TabIndex = 30;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "hh:00:tt";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(358, 38);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.ShowUpDown = true;
            this.dtStartTime.Size = new System.Drawing.Size(200, 26);
            this.dtStartTime.TabIndex = 29;
            this.dtStartTime.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
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
            // listBoxDisplayUnbookedTimes
            // 
            this.listBoxDisplayUnbookedTimes.FormattingEnabled = true;
            this.listBoxDisplayUnbookedTimes.ItemHeight = 20;
            this.listBoxDisplayUnbookedTimes.Location = new System.Drawing.Point(16, 78);
            this.listBoxDisplayUnbookedTimes.Name = "listBoxDisplayUnbookedTimes";
            this.listBoxDisplayUnbookedTimes.Size = new System.Drawing.Size(335, 504);
            this.listBoxDisplayUnbookedTimes.TabIndex = 26;
            // 
            // dtPickerBooking
            // 
            this.dtPickerBooking.Location = new System.Drawing.Point(16, 38);
            this.dtPickerBooking.Name = "dtPickerBooking";
            this.dtPickerBooking.Size = new System.Drawing.Size(335, 26);
            this.dtPickerBooking.TabIndex = 25;
            // 
            // checkBoxMUGA
            // 
            this.checkBoxMUGA.AutoSize = true;
            this.checkBoxMUGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMUGA.Location = new System.Drawing.Point(373, 187);
            this.checkBoxMUGA.Name = "checkBoxMUGA";
            this.checkBoxMUGA.Size = new System.Drawing.Size(330, 29);
            this.checkBoxMUGA.TabIndex = 24;
            this.checkBoxMUGA.Text = "Multi-Use Games Area (MUGA)";
            this.checkBoxMUGA.UseVisualStyleBackColor = true;
            // 
            // checkBoxLargeRoom
            // 
            this.checkBoxLargeRoom.AutoSize = true;
            this.checkBoxLargeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLargeRoom.Location = new System.Drawing.Point(373, 153);
            this.checkBoxLargeRoom.Name = "checkBoxLargeRoom";
            this.checkBoxLargeRoom.Size = new System.Drawing.Size(148, 29);
            this.checkBoxLargeRoom.TabIndex = 23;
            this.checkBoxLargeRoom.Text = "Large Room";
            this.checkBoxLargeRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxMediumRoom
            // 
            this.checkBoxMediumRoom.AutoSize = true;
            this.checkBoxMediumRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMediumRoom.Location = new System.Drawing.Point(373, 118);
            this.checkBoxMediumRoom.Name = "checkBoxMediumRoom";
            this.checkBoxMediumRoom.Size = new System.Drawing.Size(169, 29);
            this.checkBoxMediumRoom.TabIndex = 22;
            this.checkBoxMediumRoom.Text = "Medium Room";
            this.checkBoxMediumRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmallRoom
            // 
            this.checkBoxSmallRoom.AutoSize = true;
            this.checkBoxSmallRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSmallRoom.Location = new System.Drawing.Point(373, 84);
            this.checkBoxSmallRoom.Name = "checkBoxSmallRoom";
            this.checkBoxSmallRoom.Size = new System.Drawing.Size(146, 29);
            this.checkBoxSmallRoom.TabIndex = 21;
            this.checkBoxSmallRoom.Text = "Small Room";
            this.checkBoxSmallRoom.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBook.Location = new System.Drawing.Point(430, 250);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(207, 67);
            this.btnBook.TabIndex = 20;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // tabTimetable
            // 
            this.tabTimetable.BackColor = System.Drawing.SystemColors.Window;
            this.tabTimetable.Controls.Add(this.labelTimetableDate);
            this.tabTimetable.Controls.Add(this.listBoxDisplayBookedTimes);
            this.tabTimetable.Controls.Add(this.dtPickerTimetable);
            this.tabTimetable.Controls.Add(this.btnCancelSelected);
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
            // 
            // btnCancelSelected
            // 
            this.btnCancelSelected.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSelected.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelSelected.Location = new System.Drawing.Point(487, 504);
            this.btnCancelSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelSelected.Name = "btnCancelSelected";
            this.btnCancelSelected.Size = new System.Drawing.Size(213, 70);
            this.btnCancelSelected.TabIndex = 11;
            this.btnCancelSelected.Text = "Cancel Selected";
            this.btnCancelSelected.UseVisualStyleBackColor = false;
            this.btnCancelSelected.Click += new System.EventHandler(this.btnCancelSelected_Click_1);
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateNote.Location = new System.Drawing.Point(487, 425);
            this.btnCreateNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(213, 70);
            this.btnCreateNote.TabIndex = 10;
            this.btnCreateNote.Text = "Create Note";
            this.btnCreateNote.UseVisualStyleBackColor = false;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click_1);
            // 
            // tabManageUsers
            // 
            this.tabManageUsers.BackColor = System.Drawing.SystemColors.Window;
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
            this.btnEditUser.Location = new System.Drawing.Point(70, 531);
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
            // 
            // btnSignUpForEvent
            // 
            this.btnSignUpForEvent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignUpForEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnSignUpForEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnSignUpForEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpForEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpForEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUpForEvent.Location = new System.Drawing.Point(190, 449);
            this.btnSignUpForEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUpForEvent.Name = "btnSignUpForEvent";
            this.btnSignUpForEvent.Size = new System.Drawing.Size(212, 50);
            this.btnSignUpForEvent.TabIndex = 26;
            this.btnSignUpForEvent.Text = "Sign up for event";
            this.btnSignUpForEvent.UseVisualStyleBackColor = false;
            // 
            // tabManageEvents
            // 
            this.tabManageEvents.BackColor = System.Drawing.SystemColors.Window;
            this.tabManageEvents.Controls.Add(this.labelManageEventsSearch);
            this.tabManageEvents.Controls.Add(this.txtBoxManageEventsSerch);
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
            // txtBoxManageEventsSerch
            // 
            this.txtBoxManageEventsSerch.Location = new System.Drawing.Point(153, 66);
            this.txtBoxManageEventsSerch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxManageEventsSerch.Name = "txtBoxManageEventsSerch";
            this.txtBoxManageEventsSerch.Size = new System.Drawing.Size(344, 26);
            this.txtBoxManageEventsSerch.TabIndex = 6;
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnEditEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnEditEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditEvent.Location = new System.Drawing.Point(69, 519);
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
            this.label1.Location = new System.Drawing.Point(225, 58);
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
            this.lstReports.Location = new System.Drawing.Point(39, 108);
            this.lstReports.Margin = new System.Windows.Forms.Padding(4);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(567, 424);
            this.lstReports.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(70, 531);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(205, 44);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(69, 517);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(205, 44);
            this.btnAddEvent.TabIndex = 8;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // statusStripManagement
            // 
            this.statusStripManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabelManagement});
            this.statusStripManagement.Location = new System.Drawing.Point(0, 634);
            this.statusStripManagement.Name = "statusStripManagement";
            this.statusStripManagement.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStripManagement.Size = new System.Drawing.Size(783, 25);
            this.statusStripManagement.TabIndex = 1;
            this.statusStripManagement.Text = "statusStrip1";
            // 
            // stripLabelManagement
            // 
            this.stripLabelManagement.Name = "stripLabelManagement";
            this.stripLabelManagement.Size = new System.Drawing.Size(163, 20);
            this.stripLabelManagement.Text = "toolStripStatusLabel1";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(142, 118);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 229);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(783, 659);
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
            this.tabManageUsers.ResumeLayout(false);
            this.tabManageUsers.PerformLayout();
            this.tabCurrentEvents.ResumeLayout(false);
            this.tabCurrentEvents.PerformLayout();
            this.tabManageEvents.ResumeLayout(false);
            this.tabManageEvents.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
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
        private System.Windows.Forms.Button btnCancelSelected;
        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.Label labelManageUsersSearch;
        private System.Windows.Forms.TextBox txtBoxManageUsersSearch;
        private System.Windows.Forms.Label labelManageEventsSearch;
        private System.Windows.Forms.TextBox txtBoxManageEventsSerch;
        private System.Windows.Forms.Label labelTimetableDate;
        private System.Windows.Forms.Label labelCurrentEventsEvents;
        private System.Windows.Forms.Label labelEventsDate;
        private System.Windows.Forms.ListBox listBoxDisplayEvents;
        private System.Windows.Forms.DateTimePicker dtPickerEvents;
        private System.Windows.Forms.Button btnSignUpForEvent;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.ListBox listBoxDisplayUnbookedTimes;
        private System.Windows.Forms.DateTimePicker dtPickerBooking;
        private System.Windows.Forms.CheckBox checkBoxMUGA;
        private System.Windows.Forms.CheckBox checkBoxLargeRoom;
        private System.Windows.Forms.CheckBox checkBoxMediumRoom;
        private System.Windows.Forms.CheckBox checkBoxSmallRoom;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnUnbook;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.ListView listView1;
    }
}