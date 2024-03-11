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
    public partial class GymMember : Form
    {
        private UserDetails CurrentUser;
        private UserDetails PT;
        public List<RoomBooking> RoomBookings = new List<RoomBooking>();
        public List<EventBooking> EventBookings = new List<EventBooking>();
        public List<PTBooking> PTBookings = new List<PTBooking>();
        public List<Booking> Timetable = new List<Booking>();

        public void Updateform()
        {
            bool assignedPT = false;
            dtPickerBooking.MinDate = DateTime.Today;
            lvBookingtimes.Items.Clear();
            lvBookingtimes.Clear();
            listBoxDisplayBookedTimes.Items.Clear();
            lvBookingPT.Items.Clear();
            lvBookingPT.Clear();
            #region PT form
            if (CurrentUser.PTAssigned == "")
            {
                labelPersonalTrainerName.Text = "No personal trainer!";
                btnBookpersonaltrainer.Enabled = false;
                assignedPT = false;
                
            }
            else
            {
                PT = UserDetails.Load(CurrentUser.PTAssigned);
                PTBookings = PTBooking.Load(CurrentUser.Username,dtPTDate.Value.Date);
                labelPersonalTrainerName.Text = PT.FirstName + " " + PT.Surname;
                btnQuestionnaire.Enabled = true;
                assignedPT = true;
                
            }
            #endregion
            List<RoomBooking> BookCheck = new List<RoomBooking>();
            List<RoomBooking> Bookings = new List<RoomBooking>();
            TimeSpan hour = new TimeSpan(1, 0, 0);
            TimeSpan StartTime = new TimeSpan(0, 0, 0);
            TimeSpan endtime = new TimeSpan(0, 0, 0);
            int counter = 1;
            lvBookingtimes.Columns.Add("Rooms", 200);
            lvBookingPT.Columns.Add("Times", 200);
            #region set list view rows
            ListViewItem SmallRoom = new ListViewItem("Small Room");
            ListViewItem MediumRoom = new ListViewItem("Medium Room");
            ListViewItem LargeRoom = new ListViewItem("Large Room");
            ListViewItem MUGA = new ListViewItem("Multiple-Use Games Room");//make new rows in the list views
            ListViewItem PTbooking = new ListViewItem("");
            if(assignedPT == true)
            {
                PTbooking = new ListViewItem(PT.FirstName + " " + PT.Surname);
            }
            else
            {
                PTbooking = new ListViewItem("");
            }
                
               
           // add new list view if a pt exists
            
            #endregion

            #region Set list view properties
            SmallRoom.UseItemStyleForSubItems = false;
            MediumRoom.UseItemStyleForSubItems = false;
            LargeRoom.UseItemStyleForSubItems = false;
            MUGA.UseItemStyleForSubItems = false;
            PTbooking.UseItemStyleForSubItems = false;
            
            //set each row property to have diffrent styles so each field can be a diffrent colour
            #endregion

            BookCheck = RoomBooking.Load(dtPickerBooking.Value.Date);

            #region add columns to list view
            if (dtPickerBooking.Value.DayOfWeek == DayOfWeek.Saturday || dtPickerBooking.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                StartTime = new TimeSpan(9, 0, 0);
                endtime = new TimeSpan(19, 0, 0);
                try
                {
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtPTBooking.MaxDate = dtPTBooking.Value.Date + endtime - hour;
                    dtPTBooking.MinDate = dtPTBooking.Value.Date + StartTime;
                }
                catch
                {
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                    dtPTBooking.MinDate = dtPTBooking.Value.Date + StartTime;
                    dtPTBooking.MaxDate = dtPTBooking.Value.Date + endtime - hour;
                }

            }
            else
            {
                StartTime = new TimeSpan(7, 0, 0);
                endtime = new TimeSpan(22, 0, 0);
                try
                {
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtPTBooking.MaxDate = dtPTBooking.Value.Date + endtime - hour;
                    dtPTBooking.MinDate = dtPTBooking.Value.Date + StartTime;
                }
                catch
                {
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                    dtPTBooking.MinDate = dtPTBooking.Value.Date + StartTime;
                    dtPTBooking.MaxDate = dtPTBooking.Value.Date + endtime - hour;
                }
            }
            for (TimeSpan i = StartTime; i < endtime; i += hour)
            {
                lvBookingtimes.Columns.Add(i.ToString(@"hh\:mm"));
                SmallRoom.SubItems.Add("");
                MediumRoom.SubItems.Add("");
                LargeRoom.SubItems.Add("");
                MUGA.SubItems.Add("");

                
                lvBookingPT.Columns.Add(i.ToString(@"hh\:mm"));
                PTbooking.SubItems.Add("");

            }
            #endregion   
            lvBookingPT.Hide();
           
            #region Apply Colour to the listview
            for (int i = 0; i < lvBookingtimes.Columns.Count - 1; i++)
            {
                SmallRoom.SubItems[counter].BackColor = Color.LightGreen;
                MediumRoom.SubItems[counter].BackColor = Color.LightGreen;
                LargeRoom.SubItems[counter].BackColor = Color.LightGreen;
                MUGA.SubItems[counter].BackColor = Color.LightGreen;

                PTbooking.SubItems[counter].BackColor = Color.LightGreen;

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
                foreach (PTBooking PTbookings in PTBookings)
                {
                    if (PTbookings.PTUsername == CurrentUser.PTAssigned)
                    {
                        if (PTbookings.BookingDate.TimeOfDay == StartTime)
                        {
                            PTbooking.SubItems[counter].BackColor = Color.Red;
                        }
                        if (PTbookings.BookingDate.TimeOfDay == StartTime && PTbookings.MemberUsername == CurrentUser.Username)
                        {
                            PTbooking.SubItems[counter].BackColor = Color.Yellow;
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

            lvBookingPT.Items.Add(PTbooking);
            #endregion

            #region Populate Timetable listbox
            EventBookings = EventBooking.Load();
            RoomBookings = RoomBooking.Load(dtPickerTimetable.Value.Date);

           
            listBoxDisplayEvents.Items.Clear();
            foreach (EventBooking Event in EventBookings)
            {
                if (Event.BookingDate.Date == dtPickerEvents.Value.Date)
                {
                    listBoxDisplayEvents.Items.Add(Event);
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
            foreach(PTBooking ptbooking in PTBookings)
            {
                
                Timetable.Add(ptbooking);
            }
            Timetable.Sort();
            foreach (Booking booking in Timetable)
            {
                listBoxDisplayBookedTimes.Items.Add(booking);
            }
            #endregion


           

        }

        public GymMember(UserDetails pCurrentUser)
        {
            InitializeComponent();
            CurrentUser = pCurrentUser;
            Updateform();
        }
       
        private void GymMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you sure you want to log out?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (closeResult == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            
            Login login = new Login();
            login.Show();
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            if (listBoxDisplayBookedTimes.SelectedItem == null) //throw error message if the user has not selected an event
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

        private void btnBook_MouseLeave(object sender, EventArgs e)
        {
            stripLabelGymMember.Text = "";
        }

        private void btnBook_MouseHover(object sender, EventArgs e)
        {
            stripLabelGymMember.Text = "Book the selected slot in the calendar.";
        }

        private void btnCreateNote_MouseHover_1(object sender, EventArgs e)
        {
            stripLabelGymMember.Text = "Create a note for the selected date.";
        }

        private void btnCreateNote_MouseLeave(object sender, EventArgs e)
        {
            stripLabelGymMember.Text = "";
        }

        private void btnSignUpForEvent_Click(object sender, EventArgs e)
        {
            EventBooking Event = (EventBooking)listBoxDisplayEvents.SelectedItem;
            bool Attendeefound = false;
            if (Event != null)
            {
                foreach (string attendee in Event.Attendees)
                {
                    if (attendee == CurrentUser.Username)//checks if the user is already added to the event
                    {
                        MessageBox.Show("You have already registered for this event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Attendeefound = true;
                        break;
                    }
                }
                if (Attendeefound == false)//if not the user is added to the event
                {
                    Event.AddAttendee(CurrentUser.Username);
                    MessageBox.Show("You have been added to the event");
                    Event.Save();
                }

            }
            else//if nothing selected then error message
            {
                MessageBox.Show("Please select an event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            Updateform();
        }

        private void btnSignUpForEvent_MouseHover(object sender, EventArgs e)
        {
            stripLabelGymMember.Text = "Sign up for the selected event.";
        }

        private void btnSignUpForEvent_MouseLeave(object sender, EventArgs e)
        {
            stripLabelGymMember.Text = "";
        }

        private void GymMember_Load(object sender, EventArgs e)
        {
            stripLabelGymMember.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}!";
            

            if (labelPersonalTrainerName.Text == "No personal trainer!")
            {
                btnBookpersonaltrainer.Enabled = false;
            }
        }

        private void btnQuestionnaire_Click(object sender, EventArgs e)
        {
            GymMember_Questionnaire qstnForm = new GymMember_Questionnaire(CurrentUser);
            qstnForm.ShowDialog();
            if (qstnForm.DialogResult == DialogResult.OK)//opens up questionare form so user can input details
            {
                Updateform();
            }
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string reportingUsername = CurrentUser.Username;
            string description = txtBoxReportProblem.Text;
            Report report = new Report(date, reportingUsername, description, false);
            report.Save();
            txtBoxReportProblem.Text = "";
            //submit new report and save the xml;
        }

        private void dtPickerTimetable_ValueChanged(object sender, EventArgs e)
        {
            Updateform();
        }

        private void dtPickerBooking_ValueChanged(object sender, EventArgs e)
        {
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
                        stripLabelGymMember.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}!";
                        //if the user is updated so is the strip label as they might have changed their name 
                    }
                }
            }
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            RoomBooking booking = null;
            DateTime BookingTime = dtPickerBooking.Value.Date + dtstarttime.Value.TimeOfDay;//time of booking
            List<RoomBooking> BookCheck = new List<RoomBooking>();
            string BookingErrors = BookingMethods.CheckBooking(CurrentUser.Username, BookingTime, cmbRoom.Text,CurrentUser.ActiveUser);//checks to see if they have booked the slot or havent booked too many times
            if (BookingErrors != "")
            {
                MessageBox.Show(BookingErrors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                booking = new RoomBooking(BookingTime, CurrentUser.FirstName, CurrentUser.Surname, CurrentUser.Username, cmbRoom.Text, "");
                booking.Save();//new roombooking
            }

            Updateform();
        }

        private void btnUnbook_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)listBoxDisplayBookedTimes.SelectedItem;
            if (booking != null)
            {
                int ID = booking.BookingID;
                Booking.Delete(ID);
                MessageBox.Show("The booking has been cancelled", "Success", MessageBoxButtons.OK);//cancel booking from list box
            }
            else
            {
                MessageBox.Show("Please select a booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//nothing selected
            }

            Updateform();
        }

        private void dtPickerEvents_ValueChanged(object sender, EventArgs e)
        {
            Updateform();
        }

        private void btnContactPersonalTrainer_Click(object sender, EventArgs e)
        {
            PTBooking booking = null;
            DateTime BookingTime = dtPTDate.Value.Date + dtPTBooking.Value.TimeOfDay;//gets booking time form date time picker
            List<PTBooking> BookCheck = new List<PTBooking>();
            string BookingErrors = BookingMethods.CheckPTBooking(CurrentUser.Username, BookingTime, CurrentUser.PTAssigned, CurrentUser.ActiveUser);//checks to see if the user can book the timeslot
            if (BookingErrors != "")
            {
                MessageBox.Show(BookingErrors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                booking = new PTBooking(BookingTime, CurrentUser.FirstName, CurrentUser.Surname, CurrentUser.Username, PT.Username, PT.FirstName, PT.Surname, "");
                booking.Save();//creates new booking and saves it if errors = null
            }

            Updateform();
        }

        private void dtPTDate_ValueChanged(object sender, EventArgs e)
        {
            Updateform();
        }
    }
}
