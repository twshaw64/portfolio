namespace LazyTownSports
{
    partial class GymMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymMember));
            this.statusStripGymMember = new System.Windows.Forms.StatusStrip();
            this.stripLabelGymMember = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabReportProblem = new System.Windows.Forms.TabPage();
            this.labelReportProblemFooter = new System.Windows.Forms.Label();
            this.btnSubmitReport = new System.Windows.Forms.Button();
            this.txtBoxReportProblem = new System.Windows.Forms.TextBox();
            this.labelReportProblemSubtitle = new System.Windows.Forms.Label();
            this.labelReportProblem = new System.Windows.Forms.Label();
            this.tabManageAccount = new System.Windows.Forms.TabPage();
            this.tabCurrentEvents = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEventsDate = new System.Windows.Forms.Label();
            this.listBoxDisplayEvents = new System.Windows.Forms.ListBox();
            this.dtPickerEvents = new System.Windows.Forms.DateTimePicker();
            this.btnSignUpForEvent = new System.Windows.Forms.Button();
            this.tabManageUsers = new System.Windows.Forms.TabPage();
            this.dtPTBooking = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPTDate = new System.Windows.Forms.DateTimePicker();
            this.lvBookingPT = new System.Windows.Forms.ListView();
            this.labelPersonalTrainerName = new System.Windows.Forms.Label();
            this.labelPersonalTrainerDeclaration = new System.Windows.Forms.Label();
            this.btnQuestionnaire = new System.Windows.Forms.Button();
            this.btnBookpersonaltrainer = new System.Windows.Forms.Button();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.btnUnbook = new System.Windows.Forms.Button();
            this.labelTimetableDate = new System.Windows.Forms.Label();
            this.listBoxDisplayBookedTimes = new System.Windows.Forms.ListBox();
            this.dtPickerTimetable = new System.Windows.Forms.DateTimePicker();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.btnBook = new System.Windows.Forms.Button();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.dtstarttime = new System.Windows.Forms.DateTimePicker();
            this.lvBookingtimes = new System.Windows.Forms.ListView();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.dtPickerBooking = new System.Windows.Forms.DateTimePicker();
            this.TabManagement = new System.Windows.Forms.TabControl();
            this.statusStripGymMember.SuspendLayout();
            this.tabReportProblem.SuspendLayout();
            this.tabCurrentEvents.SuspendLayout();
            this.tabManageUsers.SuspendLayout();
            this.tabTimetable.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.TabManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripGymMember
            // 
            this.statusStripGymMember.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStripGymMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabelGymMember});
            this.statusStripGymMember.Location = new System.Drawing.Point(0, 583);
            this.statusStripGymMember.Name = "statusStripGymMember";
            this.statusStripGymMember.Size = new System.Drawing.Size(789, 22);
            this.statusStripGymMember.TabIndex = 2;
            this.statusStripGymMember.Text = "statusStrip1";
            // 
            // stripLabelGymMember
            // 
            this.stripLabelGymMember.Name = "stripLabelGymMember";
            this.stripLabelGymMember.Size = new System.Drawing.Size(118, 17);
            this.stripLabelGymMember.Text = "toolStripStatusLabel1";
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
            this.tabReportProblem.Size = new System.Drawing.Size(772, 539);
            this.tabReportProblem.TabIndex = 5;
            this.tabReportProblem.Text = "Report Problem";
            this.tabReportProblem.UseVisualStyleBackColor = true;
            // 
            // labelReportProblemFooter
            // 
            this.labelReportProblemFooter.AutoSize = true;
            this.labelReportProblemFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportProblemFooter.Location = new System.Drawing.Point(159, 425);
            this.labelReportProblemFooter.Name = "labelReportProblemFooter";
            this.labelReportProblemFooter.Size = new System.Drawing.Size(453, 15);
            this.labelReportProblemFooter.TabIndex = 9;
            this.labelReportProblemFooter.Text = "Please remember to be as descriptive as possible about the situation!";
            // 
            // btnSubmitReport
            // 
            this.btnSubmitReport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmitReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmitReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmitReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSubmitReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmitReport.Location = new System.Drawing.Point(269, 466);
            this.btnSubmitReport.Name = "btnSubmitReport";
            this.btnSubmitReport.Size = new System.Drawing.Size(207, 67);
            this.btnSubmitReport.TabIndex = 8;
            this.btnSubmitReport.Text = "Submit Report";
            this.btnSubmitReport.UseVisualStyleBackColor = false;
            this.btnSubmitReport.Click += new System.EventHandler(this.btnSubmitReport_Click);
            // 
            // txtBoxReportProblem
            // 
            this.txtBoxReportProblem.Location = new System.Drawing.Point(15, 112);
            this.txtBoxReportProblem.Multiline = true;
            this.txtBoxReportProblem.Name = "txtBoxReportProblem";
            this.txtBoxReportProblem.Size = new System.Drawing.Size(749, 297);
            this.txtBoxReportProblem.TabIndex = 7;
            // 
            // labelReportProblemSubtitle
            // 
            this.labelReportProblemSubtitle.Location = new System.Drawing.Point(11, 54);
            this.labelReportProblemSubtitle.Name = "labelReportProblemSubtitle";
            this.labelReportProblemSubtitle.Size = new System.Drawing.Size(753, 70);
            this.labelReportProblemSubtitle.TabIndex = 6;
            this.labelReportProblemSubtitle.Text = resources.GetString("labelReportProblemSubtitle.Text");
            // 
            // labelReportProblem
            // 
            this.labelReportProblem.AutoSize = true;
            this.labelReportProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportProblem.Location = new System.Drawing.Point(6, 21);
            this.labelReportProblem.Name = "labelReportProblem";
            this.labelReportProblem.Size = new System.Drawing.Size(200, 25);
            this.labelReportProblem.TabIndex = 5;
            this.labelReportProblem.Text = "Report a problem:";
            // 
            // tabManageAccount
            // 
            this.tabManageAccount.Location = new System.Drawing.Point(4, 32);
            this.tabManageAccount.Name = "tabManageAccount";
            this.tabManageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageAccount.Size = new System.Drawing.Size(772, 539);
            this.tabManageAccount.TabIndex = 4;
            this.tabManageAccount.Text = "Manage Account";
            this.tabManageAccount.UseVisualStyleBackColor = true;
            // 
            // tabCurrentEvents
            // 
            this.tabCurrentEvents.Controls.Add(this.label1);
            this.tabCurrentEvents.Controls.Add(this.labelEventsDate);
            this.tabCurrentEvents.Controls.Add(this.listBoxDisplayEvents);
            this.tabCurrentEvents.Controls.Add(this.dtPickerEvents);
            this.tabCurrentEvents.Controls.Add(this.btnSignUpForEvent);
            this.tabCurrentEvents.Location = new System.Drawing.Point(4, 32);
            this.tabCurrentEvents.Name = "tabCurrentEvents";
            this.tabCurrentEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrentEvents.Size = new System.Drawing.Size(772, 539);
            this.tabCurrentEvents.TabIndex = 3;
            this.tabCurrentEvents.Text = "Events";
            this.tabCurrentEvents.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Events:";
            // 
            // labelEventsDate
            // 
            this.labelEventsDate.AutoSize = true;
            this.labelEventsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsDate.Location = new System.Drawing.Point(159, 60);
            this.labelEventsDate.Name = "labelEventsDate";
            this.labelEventsDate.Size = new System.Drawing.Size(36, 15);
            this.labelEventsDate.TabIndex = 19;
            this.labelEventsDate.Text = "Date:";
            // 
            // listBoxDisplayEvents
            // 
            this.listBoxDisplayEvents.FormattingEnabled = true;
            this.listBoxDisplayEvents.ItemHeight = 20;
            this.listBoxDisplayEvents.Location = new System.Drawing.Point(162, 124);
            this.listBoxDisplayEvents.Name = "listBoxDisplayEvents";
            this.listBoxDisplayEvents.Size = new System.Drawing.Size(407, 264);
            this.listBoxDisplayEvents.TabIndex = 9;
            // 
            // dtPickerEvents
            // 
            this.dtPickerEvents.Location = new System.Drawing.Point(162, 78);
            this.dtPickerEvents.Name = "dtPickerEvents";
            this.dtPickerEvents.Size = new System.Drawing.Size(407, 26);
            this.dtPickerEvents.TabIndex = 8;
            this.dtPickerEvents.ValueChanged += new System.EventHandler(this.dtPickerEvents_ValueChanged);
            // 
            // btnSignUpForEvent
            // 
            this.btnSignUpForEvent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignUpForEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpForEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSignUpForEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUpForEvent.Location = new System.Drawing.Point(155, 425);
            this.btnSignUpForEvent.Name = "btnSignUpForEvent";
            this.btnSignUpForEvent.Size = new System.Drawing.Size(414, 67);
            this.btnSignUpForEvent.TabIndex = 0;
            this.btnSignUpForEvent.Text = "Sign up for event";
            this.btnSignUpForEvent.UseVisualStyleBackColor = false;
            this.btnSignUpForEvent.Click += new System.EventHandler(this.btnSignUpForEvent_Click);
            this.btnSignUpForEvent.MouseLeave += new System.EventHandler(this.btnSignUpForEvent_MouseLeave);
            this.btnSignUpForEvent.MouseHover += new System.EventHandler(this.btnSignUpForEvent_MouseHover);
            // 
            // tabManageUsers
            // 
            this.tabManageUsers.Controls.Add(this.dtPTBooking);
            this.tabManageUsers.Controls.Add(this.label2);
            this.tabManageUsers.Controls.Add(this.dtPTDate);
            this.tabManageUsers.Controls.Add(this.lvBookingPT);
            this.tabManageUsers.Controls.Add(this.labelPersonalTrainerName);
            this.tabManageUsers.Controls.Add(this.labelPersonalTrainerDeclaration);
            this.tabManageUsers.Controls.Add(this.btnQuestionnaire);
            this.tabManageUsers.Controls.Add(this.btnBookpersonaltrainer);
            this.tabManageUsers.Location = new System.Drawing.Point(4, 32);
            this.tabManageUsers.Name = "tabManageUsers";
            this.tabManageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageUsers.Size = new System.Drawing.Size(772, 539);
            this.tabManageUsers.TabIndex = 2;
            this.tabManageUsers.Text = "Personal Trainer";
            this.tabManageUsers.UseVisualStyleBackColor = true;
            // 
            // dtPTBooking
            // 
            this.dtPTBooking.CustomFormat = "hh:00:tt";
            this.dtPTBooking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPTBooking.Location = new System.Drawing.Point(212, 61);
            this.dtPTBooking.Name = "dtPTBooking";
            this.dtPTBooking.ShowUpDown = true;
            this.dtPTBooking.Size = new System.Drawing.Size(200, 26);
            this.dtPTBooking.TabIndex = 39;
            this.dtPTBooking.Value = new System.DateTime(2018, 12, 8, 1, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Date:";
            // 
            // dtPTDate
            // 
            this.dtPTDate.Location = new System.Drawing.Point(6, 61);
            this.dtPTDate.Name = "dtPTDate";
            this.dtPTDate.Size = new System.Drawing.Size(200, 26);
            this.dtPTDate.TabIndex = 37;
            this.dtPTDate.ValueChanged += new System.EventHandler(this.dtPTDate_ValueChanged);
            // 
            // lvBookingPT
            // 
            this.lvBookingPT.GridLines = true;
            this.lvBookingPT.Location = new System.Drawing.Point(7, 93);
            this.lvBookingPT.MultiSelect = false;
            this.lvBookingPT.Name = "lvBookingPT";
            this.lvBookingPT.Size = new System.Drawing.Size(744, 318);
            this.lvBookingPT.TabIndex = 35;
            this.lvBookingPT.UseCompatibleStateImageBehavior = false;
            this.lvBookingPT.View = System.Windows.Forms.View.Details;
            // 
            // labelPersonalTrainerName
            // 
            this.labelPersonalTrainerName.AutoSize = true;
            this.labelPersonalTrainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalTrainerName.Location = new System.Drawing.Point(246, 18);
            this.labelPersonalTrainerName.Name = "labelPersonalTrainerName";
            this.labelPersonalTrainerName.Size = new System.Drawing.Size(69, 16);
            this.labelPersonalTrainerName.TabIndex = 3;
            this.labelPersonalTrainerName.Text = "Sportacus";
            // 
            // labelPersonalTrainerDeclaration
            // 
            this.labelPersonalTrainerDeclaration.AutoSize = true;
            this.labelPersonalTrainerDeclaration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalTrainerDeclaration.Location = new System.Drawing.Point(7, 12);
            this.labelPersonalTrainerDeclaration.Name = "labelPersonalTrainerDeclaration";
            this.labelPersonalTrainerDeclaration.Size = new System.Drawing.Size(233, 24);
            this.labelPersonalTrainerDeclaration.TabIndex = 2;
            this.labelPersonalTrainerDeclaration.Text = "Your personal trainer is:";
            // 
            // btnQuestionnaire
            // 
            this.btnQuestionnaire.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQuestionnaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionnaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnQuestionnaire.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuestionnaire.Location = new System.Drawing.Point(443, 433);
            this.btnQuestionnaire.Name = "btnQuestionnaire";
            this.btnQuestionnaire.Size = new System.Drawing.Size(207, 67);
            this.btnQuestionnaire.TabIndex = 1;
            this.btnQuestionnaire.Text = "Questionnaire";
            this.btnQuestionnaire.UseVisualStyleBackColor = false;
            this.btnQuestionnaire.Click += new System.EventHandler(this.btnQuestionnaire_Click);
            // 
            // btnBookpersonaltrainer
            // 
            this.btnBookpersonaltrainer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBookpersonaltrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookpersonaltrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBookpersonaltrainer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBookpersonaltrainer.Location = new System.Drawing.Point(131, 433);
            this.btnBookpersonaltrainer.Name = "btnBookpersonaltrainer";
            this.btnBookpersonaltrainer.Size = new System.Drawing.Size(207, 68);
            this.btnBookpersonaltrainer.TabIndex = 0;
            this.btnBookpersonaltrainer.Text = "Book";
            this.btnBookpersonaltrainer.UseVisualStyleBackColor = false;
            this.btnBookpersonaltrainer.Click += new System.EventHandler(this.btnContactPersonalTrainer_Click);
            // 
            // tabTimetable
            // 
            this.tabTimetable.Controls.Add(this.btnUnbook);
            this.tabTimetable.Controls.Add(this.labelTimetableDate);
            this.tabTimetable.Controls.Add(this.listBoxDisplayBookedTimes);
            this.tabTimetable.Controls.Add(this.dtPickerTimetable);
            this.tabTimetable.Controls.Add(this.btnCreateNote);
            this.tabTimetable.Location = new System.Drawing.Point(4, 32);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimetable.Size = new System.Drawing.Size(772, 539);
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
            this.btnUnbook.Location = new System.Drawing.Point(526, 198);
            this.btnUnbook.Name = "btnUnbook";
            this.btnUnbook.Size = new System.Drawing.Size(207, 67);
            this.btnUnbook.TabIndex = 42;
            this.btnUnbook.Text = "Unbook";
            this.btnUnbook.UseVisualStyleBackColor = false;
            this.btnUnbook.Click += new System.EventHandler(this.btnUnbook_Click);
            // 
            // labelTimetableDate
            // 
            this.labelTimetableDate.AutoSize = true;
            this.labelTimetableDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimetableDate.Location = new System.Drawing.Point(96, 37);
            this.labelTimetableDate.Name = "labelTimetableDate";
            this.labelTimetableDate.Size = new System.Drawing.Size(36, 15);
            this.labelTimetableDate.TabIndex = 19;
            this.labelTimetableDate.Text = "Date:";
            // 
            // listBoxDisplayBookedTimes
            // 
            this.listBoxDisplayBookedTimes.FormattingEnabled = true;
            this.listBoxDisplayBookedTimes.ItemHeight = 20;
            this.listBoxDisplayBookedTimes.Location = new System.Drawing.Point(9, 80);
            this.listBoxDisplayBookedTimes.Name = "listBoxDisplayBookedTimes";
            this.listBoxDisplayBookedTimes.Size = new System.Drawing.Size(470, 424);
            this.listBoxDisplayBookedTimes.TabIndex = 9;
            // 
            // dtPickerTimetable
            // 
            this.dtPickerTimetable.Location = new System.Drawing.Point(150, 33);
            this.dtPickerTimetable.Name = "dtPickerTimetable";
            this.dtPickerTimetable.Size = new System.Drawing.Size(200, 26);
            this.dtPickerTimetable.TabIndex = 8;
            this.dtPickerTimetable.Value = new System.DateTime(2018, 12, 4, 0, 0, 0, 0);
            this.dtPickerTimetable.ValueChanged += new System.EventHandler(this.dtPickerTimetable_ValueChanged);
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCreateNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateNote.Location = new System.Drawing.Point(526, 280);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(207, 67);
            this.btnCreateNote.TabIndex = 2;
            this.btnCreateNote.Text = "Notes";
            this.btnCreateNote.UseVisualStyleBackColor = false;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            this.btnCreateNote.MouseLeave += new System.EventHandler(this.btnCreateNote_MouseLeave);
            this.btnCreateNote.MouseHover += new System.EventHandler(this.btnCreateNote_MouseHover_1);
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.btnBook);
            this.tabBooking.Controls.Add(this.cmbRoom);
            this.tabBooking.Controls.Add(this.dtstarttime);
            this.tabBooking.Controls.Add(this.lvBookingtimes);
            this.tabBooking.Controls.Add(this.labelBookingDate);
            this.tabBooking.Controls.Add(this.dtPickerBooking);
            this.tabBooking.Location = new System.Drawing.Point(4, 32);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(772, 539);
            this.tabBooking.TabIndex = 0;
            this.tabBooking.Text = "Booking";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBook.Location = new System.Drawing.Point(422, 413);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(207, 67);
            this.btnBook.TabIndex = 40;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click_1);
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Items.AddRange(new object[] {
            "Small Room",
            "Medium Room",
            "Large Room",
            "Multiple-Use Games Room"});
            this.cmbRoom.Location = new System.Drawing.Point(95, 413);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(309, 28);
            this.cmbRoom.TabIndex = 39;
            this.cmbRoom.Text = "Small Room";
            // 
            // dtstarttime
            // 
            this.dtstarttime.CustomFormat = "hh:00:tt";
            this.dtstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtstarttime.Location = new System.Drawing.Point(216, 40);
            this.dtstarttime.Name = "dtstarttime";
            this.dtstarttime.ShowUpDown = true;
            this.dtstarttime.Size = new System.Drawing.Size(200, 26);
            this.dtstarttime.TabIndex = 36;
            this.dtstarttime.Value = new System.DateTime(2018, 12, 8, 1, 0, 0, 0);
            // 
            // lvBookingtimes
            // 
            this.lvBookingtimes.GridLines = true;
            this.lvBookingtimes.Location = new System.Drawing.Point(10, 72);
            this.lvBookingtimes.MultiSelect = false;
            this.lvBookingtimes.Name = "lvBookingtimes";
            this.lvBookingtimes.Size = new System.Drawing.Size(744, 318);
            this.lvBookingtimes.TabIndex = 34;
            this.lvBookingtimes.UseCompatibleStateImageBehavior = false;
            this.lvBookingtimes.View = System.Windows.Forms.View.Details;
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingDate.Location = new System.Drawing.Point(7, 22);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(36, 15);
            this.labelBookingDate.TabIndex = 20;
            this.labelBookingDate.Text = "Date:";
            // 
            // dtPickerBooking
            // 
            this.dtPickerBooking.Location = new System.Drawing.Point(10, 40);
            this.dtPickerBooking.Name = "dtPickerBooking";
            this.dtPickerBooking.Size = new System.Drawing.Size(200, 26);
            this.dtPickerBooking.TabIndex = 7;
            this.dtPickerBooking.ValueChanged += new System.EventHandler(this.dtPickerBooking_ValueChanged);
            // 
            // TabManagement
            // 
            this.TabManagement.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabManagement.Controls.Add(this.tabBooking);
            this.TabManagement.Controls.Add(this.tabTimetable);
            this.TabManagement.Controls.Add(this.tabManageUsers);
            this.TabManagement.Controls.Add(this.tabCurrentEvents);
            this.TabManagement.Controls.Add(this.tabManageAccount);
            this.TabManagement.Controls.Add(this.tabReportProblem);
            this.TabManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TabManagement.Location = new System.Drawing.Point(1, 1);
            this.TabManagement.Multiline = true;
            this.TabManagement.Name = "TabManagement";
            this.TabManagement.SelectedIndex = 0;
            this.TabManagement.Size = new System.Drawing.Size(780, 575);
            this.TabManagement.TabIndex = 1;
            this.TabManagement.SelectedIndexChanged += new System.EventHandler(this.TabManagement_SelectedIndexChanged);
            // 
            // GymMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 605);
            this.Controls.Add(this.statusStripGymMember);
            this.Controls.Add(this.TabManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GymMember";
            this.Text = "LTS | Gym Member Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GymMember_FormClosing);
            this.Load += new System.EventHandler(this.GymMember_Load);
            this.statusStripGymMember.ResumeLayout(false);
            this.statusStripGymMember.PerformLayout();
            this.tabReportProblem.ResumeLayout(false);
            this.tabReportProblem.PerformLayout();
            this.tabCurrentEvents.ResumeLayout(false);
            this.tabCurrentEvents.PerformLayout();
            this.tabManageUsers.ResumeLayout(false);
            this.tabManageUsers.PerformLayout();
            this.tabTimetable.ResumeLayout(false);
            this.tabTimetable.PerformLayout();
            this.tabBooking.ResumeLayout(false);
            this.tabBooking.PerformLayout();
            this.TabManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStripGymMember;
        private System.Windows.Forms.ToolStripStatusLabel stripLabelGymMember;
        private System.Windows.Forms.TabPage tabReportProblem;
        private System.Windows.Forms.Label labelReportProblemFooter;
        private System.Windows.Forms.Button btnSubmitReport;
        private System.Windows.Forms.TextBox txtBoxReportProblem;
        private System.Windows.Forms.Label labelReportProblemSubtitle;
        private System.Windows.Forms.Label labelReportProblem;
        private System.Windows.Forms.TabPage tabManageAccount;
        private System.Windows.Forms.TabPage tabCurrentEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEventsDate;
        private System.Windows.Forms.ListBox listBoxDisplayEvents;
        private System.Windows.Forms.DateTimePicker dtPickerEvents;
        private System.Windows.Forms.Button btnSignUpForEvent;
        private System.Windows.Forms.TabPage tabManageUsers;
        private System.Windows.Forms.Label labelPersonalTrainerName;
        private System.Windows.Forms.Label labelPersonalTrainerDeclaration;
        private System.Windows.Forms.Button btnQuestionnaire;
        private System.Windows.Forms.Button btnBookpersonaltrainer;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.Label labelTimetableDate;
        private System.Windows.Forms.ListBox listBoxDisplayBookedTimes;
        private System.Windows.Forms.DateTimePicker dtPickerTimetable;
        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.ListView lvBookingtimes;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.DateTimePicker dtPickerBooking;
        private System.Windows.Forms.TabControl TabManagement;
        private System.Windows.Forms.DateTimePicker dtstarttime;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnUnbook;
        private System.Windows.Forms.DateTimePicker dtPTBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPTDate;
        private System.Windows.Forms.ListView lvBookingPT;
    }
}