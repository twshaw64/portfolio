namespace LazyTownSports
{
    partial class PersonalTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalTrainer));
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
            this.btnPersonalTrainerCreateNote = new System.Windows.Forms.Button();
            this.tabManageClients = new System.Windows.Forms.TabPage();
            this.labelManageClientsSearch = new System.Windows.Forms.Label();
            this.txtBoxManageClientsSearch = new System.Windows.Forms.TextBox();
            this.labelListOfClients = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.tabCurrentEvents = new System.Windows.Forms.TabPage();
            this.labelCurrentEventsEvents = new System.Windows.Forms.Label();
            this.labelEventsDate = new System.Windows.Forms.Label();
            this.listBoxDisplayEvents = new System.Windows.Forms.ListBox();
            this.dtPickerEvents = new System.Windows.Forms.DateTimePicker();
            this.btnSignUpForEvent = new System.Windows.Forms.Button();
            this.tabMyEvents = new System.Windows.Forms.TabPage();
            this.dtManageEvent = new System.Windows.Forms.DateTimePicker();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnaddevent = new System.Windows.Forms.Button();
            this.labelMyEventsSearch = new System.Windows.Forms.Label();
            this.labelMyEvents = new System.Windows.Forms.Label();
            this.listBoxMyEvents = new System.Windows.Forms.ListBox();
            this.tabManageAccount = new System.Windows.Forms.TabPage();
            this.tabReportProblem = new System.Windows.Forms.TabPage();
            this.labelReportProblemFooter = new System.Windows.Forms.Label();
            this.btnSubmitReport = new System.Windows.Forms.Button();
            this.txtBoxReportProblem = new System.Windows.Forms.TextBox();
            this.labelReportProblemSubtitle = new System.Windows.Forms.Label();
            this.labelReportProblem = new System.Windows.Forms.Label();
            this.statusStripPersonalTrainer = new System.Windows.Forms.StatusStrip();
            this.personalTrainer_StripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripLabelPersonalTrainer = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnviewUser = new System.Windows.Forms.Button();
            this.TabManagement.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.tabTimetable.SuspendLayout();
            this.tabManageClients.SuspendLayout();
            this.tabCurrentEvents.SuspendLayout();
            this.tabMyEvents.SuspendLayout();
            this.tabReportProblem.SuspendLayout();
            this.statusStripPersonalTrainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabManagement
            // 
            this.TabManagement.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabManagement.Controls.Add(this.tabBooking);
            this.TabManagement.Controls.Add(this.tabTimetable);
            this.TabManagement.Controls.Add(this.tabManageClients);
            this.TabManagement.Controls.Add(this.tabCurrentEvents);
            this.TabManagement.Controls.Add(this.tabMyEvents);
            this.TabManagement.Controls.Add(this.tabManageAccount);
            this.TabManagement.Controls.Add(this.tabReportProblem);
            this.TabManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TabManagement.Location = new System.Drawing.Point(4, 4);
            this.TabManagement.Multiline = true;
            this.TabManagement.Name = "TabManagement";
            this.TabManagement.SelectedIndex = 0;
            this.TabManagement.Size = new System.Drawing.Size(802, 536);
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
            this.tabBooking.Size = new System.Drawing.Size(794, 500);
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
            this.cmbRoom.Location = new System.Drawing.Point(106, 439);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(309, 28);
            this.cmbRoom.TabIndex = 39;
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
            this.btnBook.Location = new System.Drawing.Point(421, 416);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(207, 67);
            this.btnBook.TabIndex = 37;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click_1);
            // 
            // dtstarttime
            // 
            this.dtstarttime.CustomFormat = "hh:00:tt";
            this.dtstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtstarttime.Location = new System.Drawing.Point(215, 30);
            this.dtstarttime.Name = "dtstarttime";
            this.dtstarttime.ShowUpDown = true;
            this.dtstarttime.Size = new System.Drawing.Size(200, 26);
            this.dtstarttime.TabIndex = 36;
            this.dtstarttime.Value = new System.DateTime(2018, 12, 8, 1, 0, 0, 0);
            // 
            // lvBookingtimes
            // 
            this.lvBookingtimes.GridLines = true;
            this.lvBookingtimes.Location = new System.Drawing.Point(9, 62);
            this.lvBookingtimes.MultiSelect = false;
            this.lvBookingtimes.Name = "lvBookingtimes";
            this.lvBookingtimes.Size = new System.Drawing.Size(748, 348);
            this.lvBookingtimes.TabIndex = 34;
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
            this.labelBookingDate.TabIndex = 19;
            this.labelBookingDate.Text = "Date:";
            // 
            // dtPickerBooking
            // 
            this.dtPickerBooking.Location = new System.Drawing.Point(9, 30);
            this.dtPickerBooking.Name = "dtPickerBooking";
            this.dtPickerBooking.Size = new System.Drawing.Size(200, 26);
            this.dtPickerBooking.TabIndex = 14;
            this.dtPickerBooking.ValueChanged += new System.EventHandler(this.dtPickerBooking_ValueChanged);
            // 
            // tabTimetable
            // 
            this.tabTimetable.Controls.Add(this.btnUnbook);
            this.tabTimetable.Controls.Add(this.labelTimetableDate);
            this.tabTimetable.Controls.Add(this.listBoxDisplayBookedTimes);
            this.tabTimetable.Controls.Add(this.dtPickerTimetable);
            this.tabTimetable.Controls.Add(this.btnPersonalTrainerCreateNote);
            this.tabTimetable.Location = new System.Drawing.Point(4, 32);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimetable.Size = new System.Drawing.Size(794, 500);
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
            this.btnUnbook.Location = new System.Drawing.Point(363, 152);
            this.btnUnbook.Name = "btnUnbook";
            this.btnUnbook.Size = new System.Drawing.Size(207, 67);
            this.btnUnbook.TabIndex = 39;
            this.btnUnbook.Text = "Unbook";
            this.btnUnbook.UseVisualStyleBackColor = false;
            this.btnUnbook.Click += new System.EventHandler(this.btnUnbook_Click);
            // 
            // labelTimetableDate
            // 
            this.labelTimetableDate.AutoSize = true;
            this.labelTimetableDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimetableDate.Location = new System.Drawing.Point(6, 15);
            this.labelTimetableDate.Name = "labelTimetableDate";
            this.labelTimetableDate.Size = new System.Drawing.Size(36, 15);
            this.labelTimetableDate.TabIndex = 18;
            this.labelTimetableDate.Text = "Date:";
            // 
            // listBoxDisplayBookedTimes
            // 
            this.listBoxDisplayBookedTimes.FormattingEnabled = true;
            this.listBoxDisplayBookedTimes.ItemHeight = 20;
            this.listBoxDisplayBookedTimes.Location = new System.Drawing.Point(9, 60);
            this.listBoxDisplayBookedTimes.Name = "listBoxDisplayBookedTimes";
            this.listBoxDisplayBookedTimes.Size = new System.Drawing.Size(294, 384);
            this.listBoxDisplayBookedTimes.TabIndex = 15;
            // 
            // dtPickerTimetable
            // 
            this.dtPickerTimetable.Location = new System.Drawing.Point(9, 33);
            this.dtPickerTimetable.Name = "dtPickerTimetable";
            this.dtPickerTimetable.Size = new System.Drawing.Size(200, 26);
            this.dtPickerTimetable.TabIndex = 14;
            this.dtPickerTimetable.ValueChanged += new System.EventHandler(this.dtPickerTimetable_ValueChanged);
            // 
            // btnPersonalTrainerCreateNote
            // 
            this.btnPersonalTrainerCreateNote.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPersonalTrainerCreateNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPersonalTrainerCreateNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPersonalTrainerCreateNote.Location = new System.Drawing.Point(363, 225);
            this.btnPersonalTrainerCreateNote.Name = "btnPersonalTrainerCreateNote";
            this.btnPersonalTrainerCreateNote.Size = new System.Drawing.Size(207, 67);
            this.btnPersonalTrainerCreateNote.TabIndex = 12;
            this.btnPersonalTrainerCreateNote.Text = "Notes";
            this.btnPersonalTrainerCreateNote.UseVisualStyleBackColor = false;
            this.btnPersonalTrainerCreateNote.Click += new System.EventHandler(this.btnPersonalTrainerCreateNote_Click);
            // 
            // tabManageClients
            // 
            this.tabManageClients.Controls.Add(this.btnviewUser);
            this.tabManageClients.Controls.Add(this.labelManageClientsSearch);
            this.tabManageClients.Controls.Add(this.txtBoxManageClientsSearch);
            this.tabManageClients.Controls.Add(this.labelListOfClients);
            this.tabManageClients.Controls.Add(this.listBoxUsers);
            this.tabManageClients.Location = new System.Drawing.Point(4, 32);
            this.tabManageClients.Name = "tabManageClients";
            this.tabManageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageClients.Size = new System.Drawing.Size(794, 500);
            this.tabManageClients.TabIndex = 2;
            this.tabManageClients.Text = "Manage Clients";
            this.tabManageClients.UseVisualStyleBackColor = true;
            // 
            // labelManageClientsSearch
            // 
            this.labelManageClientsSearch.AutoSize = true;
            this.labelManageClientsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageClientsSearch.Location = new System.Drawing.Point(123, 53);
            this.labelManageClientsSearch.Name = "labelManageClientsSearch";
            this.labelManageClientsSearch.Size = new System.Drawing.Size(49, 15);
            this.labelManageClientsSearch.TabIndex = 9;
            this.labelManageClientsSearch.Text = "Search:";
            // 
            // txtBoxManageClientsSearch
            // 
            this.txtBoxManageClientsSearch.Location = new System.Drawing.Point(178, 47);
            this.txtBoxManageClientsSearch.Name = "txtBoxManageClientsSearch";
            this.txtBoxManageClientsSearch.Size = new System.Drawing.Size(443, 26);
            this.txtBoxManageClientsSearch.TabIndex = 8;
            this.txtBoxManageClientsSearch.TextChanged += new System.EventHandler(this.txtBoxManageClientsSearch_TextChanged);
            // 
            // labelListOfClients
            // 
            this.labelListOfClients.AutoSize = true;
            this.labelListOfClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelListOfClients.Location = new System.Drawing.Point(332, 19);
            this.labelListOfClients.Name = "labelListOfClients";
            this.labelListOfClients.Size = new System.Drawing.Size(94, 15);
            this.labelListOfClients.TabIndex = 4;
            this.labelListOfClients.Text = "List of Clients";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 20;
            this.listBoxUsers.Location = new System.Drawing.Point(132, 79);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(489, 364);
            this.listBoxUsers.TabIndex = 3;
            // 
            // tabCurrentEvents
            // 
            this.tabCurrentEvents.Controls.Add(this.labelCurrentEventsEvents);
            this.tabCurrentEvents.Controls.Add(this.labelEventsDate);
            this.tabCurrentEvents.Controls.Add(this.listBoxDisplayEvents);
            this.tabCurrentEvents.Controls.Add(this.dtPickerEvents);
            this.tabCurrentEvents.Controls.Add(this.btnSignUpForEvent);
            this.tabCurrentEvents.Location = new System.Drawing.Point(4, 32);
            this.tabCurrentEvents.Name = "tabCurrentEvents";
            this.tabCurrentEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrentEvents.Size = new System.Drawing.Size(794, 500);
            this.tabCurrentEvents.TabIndex = 3;
            this.tabCurrentEvents.Text = "Current Events";
            this.tabCurrentEvents.UseVisualStyleBackColor = true;
            // 
            // labelCurrentEventsEvents
            // 
            this.labelCurrentEventsEvents.AutoSize = true;
            this.labelCurrentEventsEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentEventsEvents.Location = new System.Drawing.Point(165, 78);
            this.labelCurrentEventsEvents.Name = "labelCurrentEventsEvents";
            this.labelCurrentEventsEvents.Size = new System.Drawing.Size(46, 15);
            this.labelCurrentEventsEvents.TabIndex = 25;
            this.labelCurrentEventsEvents.Text = "Events:";
            // 
            // labelEventsDate
            // 
            this.labelEventsDate.AutoSize = true;
            this.labelEventsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsDate.Location = new System.Drawing.Point(165, 32);
            this.labelEventsDate.Name = "labelEventsDate";
            this.labelEventsDate.Size = new System.Drawing.Size(36, 15);
            this.labelEventsDate.TabIndex = 24;
            this.labelEventsDate.Text = "Date:";
            // 
            // listBoxDisplayEvents
            // 
            this.listBoxDisplayEvents.FormattingEnabled = true;
            this.listBoxDisplayEvents.ItemHeight = 20;
            this.listBoxDisplayEvents.Location = new System.Drawing.Point(168, 96);
            this.listBoxDisplayEvents.Name = "listBoxDisplayEvents";
            this.listBoxDisplayEvents.Size = new System.Drawing.Size(451, 264);
            this.listBoxDisplayEvents.TabIndex = 23;
            // 
            // dtPickerEvents
            // 
            this.dtPickerEvents.Location = new System.Drawing.Point(168, 50);
            this.dtPickerEvents.Name = "dtPickerEvents";
            this.dtPickerEvents.Size = new System.Drawing.Size(451, 26);
            this.dtPickerEvents.TabIndex = 22;
            this.dtPickerEvents.ValueChanged += new System.EventHandler(this.dtPickerEvents_ValueChanged);
            // 
            // btnSignUpForEvent
            // 
            this.btnSignUpForEvent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignUpForEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSignUpForEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUpForEvent.Location = new System.Drawing.Point(299, 413);
            this.btnSignUpForEvent.Name = "btnSignUpForEvent";
            this.btnSignUpForEvent.Size = new System.Drawing.Size(207, 67);
            this.btnSignUpForEvent.TabIndex = 21;
            this.btnSignUpForEvent.Text = "Sign up for event";
            this.btnSignUpForEvent.UseVisualStyleBackColor = false;
            this.btnSignUpForEvent.Click += new System.EventHandler(this.btnSignUpForEvent_Click_1);
            // 
            // tabMyEvents
            // 
            this.tabMyEvents.Controls.Add(this.dtManageEvent);
            this.tabMyEvents.Controls.Add(this.btnEditEvent);
            this.tabMyEvents.Controls.Add(this.btnaddevent);
            this.tabMyEvents.Controls.Add(this.labelMyEventsSearch);
            this.tabMyEvents.Controls.Add(this.labelMyEvents);
            this.tabMyEvents.Controls.Add(this.listBoxMyEvents);
            this.tabMyEvents.Location = new System.Drawing.Point(4, 32);
            this.tabMyEvents.Name = "tabMyEvents";
            this.tabMyEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyEvents.Size = new System.Drawing.Size(794, 500);
            this.tabMyEvents.TabIndex = 4;
            this.tabMyEvents.Text = "My Events";
            this.tabMyEvents.UseVisualStyleBackColor = true;
            // 
            // dtManageEvent
            // 
            this.dtManageEvent.Location = new System.Drawing.Point(184, 54);
            this.dtManageEvent.Name = "dtManageEvent";
            this.dtManageEvent.Size = new System.Drawing.Size(323, 26);
            this.dtManageEvent.TabIndex = 15;
            this.dtManageEvent.ValueChanged += new System.EventHandler(this.dtManageEvent_ValueChanged);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnEditEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnEditEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditEvent.Location = new System.Drawing.Point(355, 429);
            this.btnEditEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(205, 44);
            this.btnEditEvent.TabIndex = 14;
            this.btnEditEvent.Text = "Edit Event";
            this.btnEditEvent.UseVisualStyleBackColor = false;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // btnaddevent
            // 
            this.btnaddevent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddevent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnaddevent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnaddevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddevent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnaddevent.Location = new System.Drawing.Point(132, 429);
            this.btnaddevent.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddevent.Name = "btnaddevent";
            this.btnaddevent.Size = new System.Drawing.Size(215, 44);
            this.btnaddevent.TabIndex = 13;
            this.btnaddevent.Text = "Add Event";
            this.btnaddevent.UseVisualStyleBackColor = false;
            this.btnaddevent.Click += new System.EventHandler(this.btnaddevent_Click);
            // 
            // labelMyEventsSearch
            // 
            this.labelMyEventsSearch.AutoSize = true;
            this.labelMyEventsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyEventsSearch.Location = new System.Drawing.Point(129, 51);
            this.labelMyEventsSearch.Name = "labelMyEventsSearch";
            this.labelMyEventsSearch.Size = new System.Drawing.Size(49, 15);
            this.labelMyEventsSearch.TabIndex = 12;
            this.labelMyEventsSearch.Text = "Search:";
            // 
            // labelMyEvents
            // 
            this.labelMyEvents.AutoSize = true;
            this.labelMyEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelMyEvents.Location = new System.Drawing.Point(276, 20);
            this.labelMyEvents.Name = "labelMyEvents";
            this.labelMyEvents.Size = new System.Drawing.Size(71, 15);
            this.labelMyEvents.TabIndex = 6;
            this.labelMyEvents.Text = "My Events";
            this.labelMyEvents.Click += new System.EventHandler(this.labelMyEvents_Click);
            // 
            // listBoxMyEvents
            // 
            this.listBoxMyEvents.FormattingEnabled = true;
            this.listBoxMyEvents.ItemHeight = 20;
            this.listBoxMyEvents.Location = new System.Drawing.Point(132, 86);
            this.listBoxMyEvents.Name = "listBoxMyEvents";
            this.listBoxMyEvents.Size = new System.Drawing.Size(428, 304);
            this.listBoxMyEvents.TabIndex = 5;
            // 
            // tabManageAccount
            // 
            this.tabManageAccount.Location = new System.Drawing.Point(4, 32);
            this.tabManageAccount.Name = "tabManageAccount";
            this.tabManageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageAccount.Size = new System.Drawing.Size(794, 500);
            this.tabManageAccount.TabIndex = 5;
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
            this.tabReportProblem.Size = new System.Drawing.Size(794, 500);
            this.tabReportProblem.TabIndex = 6;
            this.tabReportProblem.Text = "Report Problem";
            this.tabReportProblem.UseVisualStyleBackColor = true;
            // 
            // labelReportProblemFooter
            // 
            this.labelReportProblemFooter.AutoSize = true;
            this.labelReportProblemFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportProblemFooter.Location = new System.Drawing.Point(168, 379);
            this.labelReportProblemFooter.Name = "labelReportProblemFooter";
            this.labelReportProblemFooter.Size = new System.Drawing.Size(453, 15);
            this.labelReportProblemFooter.TabIndex = 4;
            this.labelReportProblemFooter.Text = "Please remember to be as descriptive as possible about the situation!";
            // 
            // btnSubmitReport
            // 
            this.btnSubmitReport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmitReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSubmitReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmitReport.Location = new System.Drawing.Point(289, 413);
            this.btnSubmitReport.Name = "btnSubmitReport";
            this.btnSubmitReport.Size = new System.Drawing.Size(207, 67);
            this.btnSubmitReport.TabIndex = 3;
            this.btnSubmitReport.Text = "Submit Report";
            this.btnSubmitReport.UseVisualStyleBackColor = false;
            this.btnSubmitReport.Click += new System.EventHandler(this.btnSubmitReport_Click);
            // 
            // txtBoxReportProblem
            // 
            this.txtBoxReportProblem.Location = new System.Drawing.Point(30, 91);
            this.txtBoxReportProblem.Multiline = true;
            this.txtBoxReportProblem.Name = "txtBoxReportProblem";
            this.txtBoxReportProblem.Size = new System.Drawing.Size(746, 285);
            this.txtBoxReportProblem.TabIndex = 2;
            // 
            // labelReportProblemSubtitle
            // 
            this.labelReportProblemSubtitle.Location = new System.Drawing.Point(26, 47);
            this.labelReportProblemSubtitle.Name = "labelReportProblemSubtitle";
            this.labelReportProblemSubtitle.Size = new System.Drawing.Size(750, 41);
            this.labelReportProblemSubtitle.TabIndex = 1;
            this.labelReportProblemSubtitle.Text = resources.GetString("labelReportProblemSubtitle.Text");
            // 
            // labelReportProblem
            // 
            this.labelReportProblem.AutoSize = true;
            this.labelReportProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportProblem.Location = new System.Drawing.Point(21, 14);
            this.labelReportProblem.Name = "labelReportProblem";
            this.labelReportProblem.Size = new System.Drawing.Size(200, 25);
            this.labelReportProblem.TabIndex = 0;
            this.labelReportProblem.Text = "Report a problem:";
            // 
            // statusStripPersonalTrainer
            // 
            this.statusStripPersonalTrainer.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStripPersonalTrainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalTrainer_StripLabel,
            this.stripLabelPersonalTrainer});
            this.statusStripPersonalTrainer.Location = new System.Drawing.Point(0, 540);
            this.statusStripPersonalTrainer.Name = "statusStripPersonalTrainer";
            this.statusStripPersonalTrainer.Size = new System.Drawing.Size(810, 22);
            this.statusStripPersonalTrainer.TabIndex = 3;
            this.statusStripPersonalTrainer.Text = "statusStrip1";
            // 
            // personalTrainer_StripLabel
            // 
            this.personalTrainer_StripLabel.Name = "personalTrainer_StripLabel";
            this.personalTrainer_StripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // stripLabelPersonalTrainer
            // 
            this.stripLabelPersonalTrainer.Name = "stripLabelPersonalTrainer";
            this.stripLabelPersonalTrainer.Size = new System.Drawing.Size(118, 17);
            this.stripLabelPersonalTrainer.Text = "toolStripStatusLabel1";
            // 
            // btnviewUser
            // 
            this.btnviewUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnviewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnviewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnviewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnviewUser.Location = new System.Drawing.Point(126, 449);
            this.btnviewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnviewUser.Name = "btnviewUser";
            this.btnviewUser.Size = new System.Drawing.Size(495, 44);
            this.btnviewUser.TabIndex = 10;
            this.btnviewUser.Text = "View User";
            this.btnviewUser.UseVisualStyleBackColor = false;
            this.btnviewUser.Click += new System.EventHandler(this.btnviewUser_Click);
            // 
            // PersonalTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 562);
            this.Controls.Add(this.statusStripPersonalTrainer);
            this.Controls.Add(this.TabManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonalTrainer";
            this.Text = "LTS | Personal Trainer Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalTrainer_FormClosing);
            this.Load += new System.EventHandler(this.PersonalTrainer_Load);
            this.TabManagement.ResumeLayout(false);
            this.tabBooking.ResumeLayout(false);
            this.tabBooking.PerformLayout();
            this.tabTimetable.ResumeLayout(false);
            this.tabTimetable.PerformLayout();
            this.tabManageClients.ResumeLayout(false);
            this.tabManageClients.PerformLayout();
            this.tabCurrentEvents.ResumeLayout(false);
            this.tabCurrentEvents.PerformLayout();
            this.tabMyEvents.ResumeLayout(false);
            this.tabMyEvents.PerformLayout();
            this.tabReportProblem.ResumeLayout(false);
            this.tabReportProblem.PerformLayout();
            this.statusStripPersonalTrainer.ResumeLayout(false);
            this.statusStripPersonalTrainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabManagement;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.TabPage tabManageClients;
        private System.Windows.Forms.TabPage tabCurrentEvents;
        private System.Windows.Forms.TabPage tabMyEvents;
        private System.Windows.Forms.TabPage tabManageAccount;
        private System.Windows.Forms.Label labelListOfClients;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label labelMyEvents;
        private System.Windows.Forms.ListBox listBoxMyEvents;
        private System.Windows.Forms.StatusStrip statusStripPersonalTrainer;
        private System.Windows.Forms.ToolStripStatusLabel personalTrainer_StripLabel;
        private System.Windows.Forms.ToolStripStatusLabel stripLabelPersonalTrainer;
        private System.Windows.Forms.Label labelManageClientsSearch;
        private System.Windows.Forms.TextBox txtBoxManageClientsSearch;
        private System.Windows.Forms.Label labelTimetableDate;
        private System.Windows.Forms.ListBox listBoxDisplayBookedTimes;
        private System.Windows.Forms.DateTimePicker dtPickerTimetable;
        private System.Windows.Forms.Button btnPersonalTrainerCreateNote;
        private System.Windows.Forms.Label labelMyEventsSearch;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.Label labelCurrentEventsEvents;
        private System.Windows.Forms.Label labelEventsDate;
        private System.Windows.Forms.ListBox listBoxDisplayEvents;
        private System.Windows.Forms.DateTimePicker dtPickerEvents;
        private System.Windows.Forms.Button btnSignUpForEvent;
        private System.Windows.Forms.TabPage tabReportProblem;
        private System.Windows.Forms.Label labelReportProblemFooter;
        private System.Windows.Forms.Button btnSubmitReport;
        private System.Windows.Forms.TextBox txtBoxReportProblem;
        private System.Windows.Forms.Label labelReportProblemSubtitle;
        private System.Windows.Forms.Label labelReportProblem;
        private System.Windows.Forms.ListView lvBookingtimes;
        private System.Windows.Forms.DateTimePicker dtPickerBooking;
        private System.Windows.Forms.DateTimePicker dtstarttime;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnUnbook;
        private System.Windows.Forms.Button btnaddevent;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.DateTimePicker dtManageEvent;
        private System.Windows.Forms.Button btnviewUser;
    }
}