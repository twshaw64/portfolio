using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTSXML;
using LTSLogic;

namespace LazyTownSports
{
    public partial class PersonalTrainer : Form
    {
        private UserDetails CurrentUser;
        public List<UserDetails> Users = new List<UserDetails>();
        public List<Report> Reports = new List<Report>();
        public List<RoomBooking> RoomBookings = new List<RoomBooking>();
        public List<EventBooking> EventBookings = new List<EventBooking>();
        public List<Booking> Timetable = new List<Booking>();
        public List<PTBooking> ptBookings = new List<PTBooking>();

        private void Updateform()
        {
            #region clear listboxes
            listBoxDisplayBookedTimes.Items.Clear();
            lvBookingtimes.Clear();
            listBoxDisplayEvents.Items.Clear();
            listBoxMyEvents.Items.Clear();
            listBoxUsers.Items.Clear();
            Timetable.Clear();
            #endregion 

            List<RoomBooking> BookCheck = new List<RoomBooking>();
            TimeSpan hour = new TimeSpan(1, 0, 0);
            TimeSpan StartTime = new TimeSpan(0, 0, 0);
            TimeSpan endtime = new TimeSpan(0, 0, 0);
            DateTime SelectedDate = dtPickerBooking.Value;
            int counter = 1;
            //set timespans to help populate list view

            lvBookingtimes.Columns.Add("Rooms", 200);
            ListViewItem SmallRoom = new ListViewItem("Small Room");
            ListViewItem MediumRoom = new ListViewItem("Medium Room");
            ListViewItem LargeRoom = new ListViewItem("Large Room");
            ListViewItem MUGA = new ListViewItem("Multiple-Use Games Room");
            //Make the rows for the list view 

            SmallRoom.UseItemStyleForSubItems = false;
            MediumRoom.UseItemStyleForSubItems = false;
            LargeRoom.UseItemStyleForSubItems = false;
            MUGA.UseItemStyleForSubItems = false;
            //allows for each box to be a diffrent colour

            BookCheck = RoomBooking.Load(SelectedDate.Date);
            
            dtPickerBooking.MinDate = DateTime.Today;
            #region add columns to list view
            if (dtPickerBooking.Value.DayOfWeek == DayOfWeek.Saturday || dtPickerBooking.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                StartTime = new TimeSpan(9, 0, 0);
                endtime = new TimeSpan(19, 0, 0);
                try
                {
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                }
                catch
                {
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                }//Stop maxdate from being lower than min date and vice versa


            }
            else
            {
                StartTime = new TimeSpan(7, 0, 0);
                endtime = new TimeSpan(22, 0, 0);
                try
                {
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    
                }
                catch
                {
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                  
                }//Stop maxdate from being lower than min date and vice versa

            }
            for (TimeSpan i = StartTime; i < endtime; i += hour)
            {
                lvBookingtimes.Columns.Add(i.ToString());
                SmallRoom.SubItems.Add("");
                MediumRoom.SubItems.Add("");
                LargeRoom.SubItems.Add("");
                MUGA.SubItems.Add("");

            }
            #endregion


            #region Apply Colour to the listview
            for (int i = 0; i < lvBookingtimes.Columns.Count - 1; i++)
            {
                SmallRoom.SubItems[counter].BackColor = Color.LightGreen;
                MediumRoom.SubItems[counter].BackColor = Color.LightGreen;
                LargeRoom.SubItems[counter].BackColor = Color.LightGreen;
                MUGA.SubItems[counter].BackColor = Color.LightGreen;

                foreach (RoomBooking Check in BookCheck)
                {
                    if (Check.BookingDate.TimeOfDay == StartTime)
                    {

                        switch (Check.Room)
                        {
                            case ("Small Room"):
                                {
                                    SmallRoom.SubItems[counter].BackColor = Color.Red;
                                    break;
                                }
                            case ("Medium Room"):
                                {
                                    MediumRoom.SubItems[counter].BackColor = Color.Red;
                                    break;
                                }
                            case ("Large Room"):
                                {
                                    LargeRoom.SubItems[counter].BackColor = Color.Red;
                                    break;
                                }
                            case ("Multiple-Use Games Room"):
                                {
                                    MUGA.SubItems[counter].BackColor = Color.Red;
                                    break;
                                }

                        }

                    }
                    if (Check.BookingDate.TimeOfDay == StartTime && Check.MemberUsername == CurrentUser.Username)
                    {
                        switch (Check.Room)
                        {
                            case ("Small Room"):
                                {
                                    SmallRoom.SubItems[counter].BackColor = Color.Yellow;
                                    break;
                                }
                            case ("Medium Room"):
                                {
                                    MediumRoom.SubItems[counter].BackColor = Color.Yellow;
                                    break;
                                }
                            case ("Large Room"):
                                {
                                    LargeRoom.SubItems[counter].BackColor = Color.Yellow;
                                    break;
                                }
                            case ("Multiple-Use Games Room"):
                                {
                                    MUGA.SubItems[counter].BackColor = Color.Yellow;
                                    break;
                                }

                        }
                    }
                }
                StartTime += hour;
                counter++;
            }
            lvBookingtimes.Items.Add(SmallRoom);
            lvBookingtimes.Items.Add(MediumRoom);
            lvBookingtimes.Items.Add(LargeRoom);
            lvBookingtimes.Items.Add(MUGA);
            #endregion

            #region populate users assigned to pt
            EventBookings = EventBooking.Load();
            ;
            listBoxUsers.Items.Clear();
            RoomBookings = RoomBooking.Load(dtPickerTimetable.Value.Date);
            Users = UserDetails.LoadUsers(UserLevel.GymMember);
            Users.Sort();
            foreach (UserDetails user in this.Users)
            {
                
                if (user.PTAssigned == CurrentUser.Username)
                {
                    listBoxUsers.Items.Add(user);
                }
            }
            #endregion

            #region Populate Timetable listbox
            ptBookings = PTBooking.Load(dtPickerTimetable.Value.Date);
            foreach (EventBooking Event in EventBookings)
            {
                if (Event.BookingDate.Date == dtPickerEvents.Value.Date)
                {
                    listBoxDisplayEvents.Items.Add(Event);
                    listBoxMyEvents.Items.Add(Event);
                    foreach (string attendee in Event.Attendees)
                    {
                        if (CurrentUser.Username == attendee && Event.BookingDate.Date == dtPickerTimetable.Value.Date)
                        {
                            Timetable.Add(Event);
                        }
                    }
                }

            }
            foreach (RoomBooking roomBooking in RoomBookings)
            {
                if (roomBooking.MemberUsername == CurrentUser.Username && roomBooking.BookingDate.Date == dtPickerTimetable.Value.Date)
                {
                    Timetable.Add(roomBooking);
                }
            }
            foreach(PTBooking booking in ptBookings)
            {
                if(booking.PTUsername == CurrentUser.Username)
                {
                    Timetable.Add(booking);
                }
            }
            Timetable.Sort();
            foreach (Booking booking in Timetable)
            {
                listBoxDisplayBookedTimes.Items.Add(booking);
            }
            #endregion


        }
        public PersonalTrainer(UserDetails pCurrentUser)
        {
            InitializeComponent();
            CurrentUser = pCurrentUser;
        }

        private void PersonalTrainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you sure you want to log out?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (closeResult == DialogResult.No)
            {
                e.Cancel = true;
            }
			
			this.Hide();
			Login form = new Login();
			form.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to book this slot?", "PLACEHOLDER BUTTON PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnBook_MouseMove(object sender, MouseEventArgs e)
        {
            stripLabelPersonalTrainer.Text = "Book the selected slot in the calendar.";
        }

        private void btnBook_MouseLeave(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "";
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            Timetable_CreateNote form = new Timetable_CreateNote();
            form.ShowDialog();
        }

        private void btnCreateNote_MouseHover(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "Create a note for the selected date.";
        }

        private void btnCreateNote_MouseLeave(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "";
        }

        private void btnCancelSelected_Click(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "The selected appointments have been cancelled.";
        }

        private void btnCancelSelected_MouseHover(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "Cancel the selected appointments on the calendar.";
        }

        private void btnCancelSelected_MouseLeave(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "";
        }

        private void btnSignUpForEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to sign up for this event?", "PLACEHOLDER BUTTON PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnSignUpForEvent_MouseHover(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "Sign up for the selected event.";
        }

        private void btnSignUpForEvent_MouseLeave(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "";
        }

        

        private void panelTimetableCalendar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelMyEvents_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_MouseHover(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "Book the selected time at the gym.";
        }

        private void btnBook_MouseLeave_1(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = "";
        }

        private void PersonalTrainer_Load(object sender, EventArgs e)
        {
            stripLabelPersonalTrainer.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}";
            Updateform();
        }

        private void TabManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checks if the tab changes to the manage account tab and pulls up the edit user form
            if (TabManagement.SelectedTab.Name == "tabManageAccount")
            {
                TabManagement.SelectedIndex = 0;
                UserDetails User = CurrentUser;
                if (User != null)
                {
                    Management_EditUser form = new Management_EditUser(User, false);
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.OK)
                    {
                        stripLabelPersonalTrainer.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}!";
                        //if the user is updated so is the strip label as they might have changed their name 
                    }
                }

            }
        }

        private void dtPickerBooking_ValueChanged(object sender, EventArgs e)
        {
            Updateform();
        }

        private void dtPickerTimetable_ValueChanged(object sender, EventArgs e)
        {
            Updateform();
        }

        private void dtPickerEvents_ValueChanged(object sender, EventArgs e)
        {
            Updateform();
        }

        private void dtManageEvent_ValueChanged(object sender, EventArgs e)
        {
            Updateform();
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            RoomBooking booking = null;
            DateTime BookingTime = dtPickerBooking.Value.Date + dtstarttime.Value.TimeOfDay;
            List<RoomBooking> BookCheck = new List<RoomBooking>();
            string BookingErrors = BookingMethods.CheckBooking(CurrentUser.Username, BookingTime, cmbRoom.Text, CurrentUser.ActiveUser);//checks booking constraint to see if they can book returns why they cant book
            if (BookingErrors != "")
            {
                MessageBox.Show(BookingErrors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                booking = new RoomBooking(BookingTime, CurrentUser.FirstName, CurrentUser.Surname, CurrentUser.Username, cmbRoom.Text,"");
                booking.Save();
            }
            Updateform();
        }

        private void btnUnbook_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)listBoxDisplayBookedTimes.SelectedItem;
            if (booking != null)
            {
                int ID = booking.BookingID;
                Booking.Delete(ID);//deletes booking
                MessageBox.Show("The booking has been cancelled", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please select a booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Updateform();
        }

        private void btnSignUpForEvent_Click_1(object sender, EventArgs e)
        {
            EventBooking Event = (EventBooking)listBoxDisplayEvents.SelectedItem;
            bool Attendeefound = false;
            if (Event != null)
            {
                foreach (string attendee in Event.Attendees)
                {
                    if (attendee == CurrentUser.Username)
                    {
                        MessageBox.Show("You have already registered for this event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Attendeefound = true;
                        break;//already registers so doesnt sign them up
                    }
                }
                if (Attendeefound == false)
                {
                    Event.AddAttendee(CurrentUser.Username);
                    MessageBox.Show("You have been added to the event");
                    Event.Save();//adds them to event if there not on it
                    Updateform();
                }

            }
            else
            {
                MessageBox.Show("Please select an event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnaddevent_Click(object sender, EventArgs e)
        {
            Management_EditEvent EventForm = new Management_EditEvent(CurrentUser);
            EventForm.ShowDialog();
            if (EventForm.DialogResult == DialogResult.OK)
            {
                listBoxMyEvents.Items.Clear();
                listBoxDisplayEvents.Items.Clear();


                EventForm.GetEvent().Save();

                Updateform();//add new event by bringing up empty create event
            }
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            EventBooking Event = (EventBooking)listBoxMyEvents.SelectedItem;
            if (Event != null)
            {
                Management_EditEvent EventForm = new Management_EditEvent(Event, CurrentUser);
                EventForm.ShowDialog();
                if (EventForm.DialogResult == DialogResult.OK)
                {
                    listBoxMyEvents.Items.Clear();
                    listBoxDisplayEvents.Items.Clear();

                    Updateform();//brings up event details to edit
                }
            }
            else
            {
                MessageBox.Show("Please select a event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        
        private void btnSubmitReport_Click(object sender, EventArgs e) //create and save a new report
        {
            string reportText = txtBoxReportProblem.Text;
            if(reportText.Trim() == "")
            {
                MessageBox.Show("Please enter text for report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//error no text
                return;
            }
            Report newReport = new Report(DateTime.Now, CurrentUser.Username, reportText, false);
            newReport.Save();
            MessageBox.Show("Report submitted, thank you", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBoxReportProblem.Text = "";
        }

        private void btnPersonalTrainerCreateNote_Click(object sender, EventArgs e)
        {
            if(listBoxDisplayBookedTimes.SelectedItem == null) //throw error message if the user has not selected an event
            {
                MessageBox.Show("Please select an event to add a note to", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Timetable_CreateNote createNote;
            switch (((Booking)listBoxDisplayBookedTimes.SelectedItem).BookingType) //pass to selected booking to the notes form
            {
                case BookingType.RoomBooking:
                    createNote = new Timetable_CreateNote((RoomBooking)listBoxDisplayBookedTimes.SelectedItem);
                    createNote.Show();
                    break;
                case BookingType.PTBooking:
                    createNote = new Timetable_CreateNote((PTBooking)listBoxDisplayBookedTimes.SelectedItem);
                    createNote.Show();
                    break;
            }
            Updateform();
        }

        private void txtBoxManageClientsSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            foreach (UserDetails user in this.Users)
            {
                if ((user.FirstName.ToLower()).Contains(txtBoxManageClientsSearch.Text) || (user.Surname.ToLower()).Contains(txtBoxManageClientsSearch.Text) && user.PTAssigned == CurrentUser.Username)
                {
                    listBoxUsers.Items.Add(user);
                }
            }
        }

        private void btnviewUser_Click(object sender, EventArgs e)
        {
            UserDetails User = (UserDetails)listBoxUsers.SelectedItem;
            if (User != null)
            {
                Management_EditUser form = new Management_EditUser(User, false);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)//brings up account form to change user info
                {
                    Updateform();
                }
            }
            else
            {
                MessageBox.Show("Please select a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}


