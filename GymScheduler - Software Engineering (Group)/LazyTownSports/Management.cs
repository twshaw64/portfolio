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
using System.IO;
using LazyTownSports;

namespace LazyTownSports
{
    public partial class Management : Form
    {
        private UserDetails CurrentUser;
        public List<UserDetails> Users = new List<UserDetails>();
        public List<Report> Reports = new List<Report>();
        public List<RoomBooking> RoomBookings = new List<RoomBooking>();
        public List<EventBooking> EventBookings = new List<EventBooking>();
        public List<Booking> Timetable = new List<Booking>();
        
        public Management(UserDetails pCurrentUser)
        {
            InitializeComponent();
            CurrentUser = pCurrentUser;
        }

        private void Updateform()
        {
            #region clear form
            listBoxDisplayBookedTimes.Items.Clear();
            lvBookingtimes.Clear();
            lvBookingtimes.Items.Clear();
            listBoxDisplayEvents.Items.Clear();
            listBoxEvents.Items.Clear();
            listBoxUsers.Items.Clear();
            lstReports.Items.Clear();
            Timetable.Clear();
            #endregion
            List<RoomBooking> BookCheck = new List<RoomBooking>();
            TimeSpan hour = new TimeSpan(1, 0, 0);
            TimeSpan StartTime = new TimeSpan (0, 0, 0);
            TimeSpan endtime = new TimeSpan(0, 0, 0);
            DateTime SelectedDate = dtPickerBooking.Value;
            int counter = 1;
            #region set columns and rows of listview

            lvBookingtimes.Columns.Add("Rooms", 200);
            ListViewItem SmallRoom = new ListViewItem("Small Room");
            ListViewItem MediumRoom = new ListViewItem("Medium Room");
            ListViewItem LargeRoom = new ListViewItem("Large Room");
            ListViewItem MUGA = new ListViewItem("Multiple-Use Games Room");
            #endregion
            
            #region set colour traits to not inherit listview
            SmallRoom.UseItemStyleForSubItems = false;
            MediumRoom.UseItemStyleForSubItems = false;
            LargeRoom.UseItemStyleForSubItems = false;
            MUGA.UseItemStyleForSubItems = false;
            #endregion
            BookCheck = RoomBooking.Load(SelectedDate.Date);
            dtPickerBooking.MinDate = DateTime.Today;
            
            #region add columns to list view
            if (dtPickerBooking.Value.DayOfWeek == DayOfWeek.Saturday || dtPickerBooking.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                StartTime = new TimeSpan(9, 0, 1);
                endtime = new TimeSpan(19, 0, 1);
                dtstarttime.Value = dtstarttime.Value.Date + StartTime;
                dtendtime.Value = dtstarttime.Value.AddHours(1);
                try
                {
                    dtendtime.MaxDate = dtPickerBooking.Value.Date + endtime;
                    dtendtime.MinDate = dtPickerBooking.Value.Date + StartTime + hour;
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;

                }
                catch
                {
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                    dtendtime.MinDate = dtPickerBooking.Value.Date + StartTime + hour;
                    dtendtime.MaxDate = dtPickerBooking.Value.Date + endtime;
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
                    dtendtime.MaxDate = dtPickerBooking.Value.Date + endtime;
                    dtendtime.MinDate = dtPickerBooking.Value.Date + StartTime + hour;
                }
                catch
                {
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                    dtendtime.MinDate = dtPickerBooking.Value.Date + StartTime + hour;
                    dtendtime.MaxDate = dtPickerBooking.Value.Date + endtime;
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
            for (int i = 0; i<lvBookingtimes.Columns.Count- 1;i++)
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



            #region populate user list
            Users = UserDetails.LoadUsers();
            EventBookings = EventBooking.Load();
            Users.Sort();
            listBoxUsers.Items.Clear();
            RoomBookings = RoomBooking.Load(dtPickerTimetable.Value.Date);
            foreach (UserDetails user in Users)
            {
                listBoxUsers.Items.Add(user);
            }
            #endregion
            Reports = Report.LoadReports();
            
            #region Populate report listbox
            foreach (Report report in Reports)
            {
                if (report.Resolved == false)
                {
                    lstReports.Items.Add(report);
                }
            }
            #endregion

            #region Populate Timetable listbox
            foreach (EventBooking Event in EventBookings)
            {
                if (Event.BookingDate.Date == dtPickerEvents.Value.Date)
                {
                    listBoxDisplayEvents.Items.Add(Event);
                    listBoxEvents.Items.Add(Event);
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
            Timetable.Sort();
            listBoxDisplayBookedTimes.Items.Clear();
            foreach (Booking booking in Timetable)
            {
                listBoxDisplayBookedTimes.Items.Add(booking);
            }
            #endregion


        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            UserDetails User = (UserDetails)listBoxUsers.SelectedItem;
            if (User != null)
            {
                Management_EditUser form = new Management_EditUser(User, true);
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

        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you sure you want to log out?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (closeResult == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            Timetable_CreateNote form = new Timetable_CreateNote();
            form.ShowDialog();
        }


        private void btnBook_MouseHover(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "Book the selected slot in the calendar.";
        }

        private void btnBook_MouseLeave(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "";
        }

        private void btnCreateNote_MouseHover(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "Create a note for the selected date.";
        }

        private void btnCreateNote_MouseLeave(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "";
        }

        private void btnEditUser_MouseHover(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "Edit the selected user";
        }

        private void btnEditUser_MouseLeave(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "";
        }

        private void btnSignUpForEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to sign up for this event?", "PLACEHOLDER BUTTON PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnSignUpForEvent_MouseHover(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "Sign up for the selected event.";
        }

        private void btnSignUpForEvent_MouseLeave(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "";
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            EventBooking Event = (EventBooking)listBoxEvents.SelectedItem;
            if (Event != null)
            {
                Management_EditEvent EventForm = new Management_EditEvent(Event,CurrentUser);
                EventForm.ShowDialog();
                if (EventForm.DialogResult == DialogResult.OK)//brings up edit event form to change information 
                {
                    listBoxEvents.Items.Clear();
                    listBoxDisplayEvents.Items.Clear();
                    
                    Updateform();
                }
            }
            else
            {
                MessageBox.Show("Please select a event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        

        private void Management_Load(object sender, EventArgs e)
        {
            stripLabelManagement.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}!";
            Updateform();

        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDisplayBookedTimes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxManageUsersSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            foreach (UserDetails user in this.Users)
            {
                if ((user.FirstName.ToLower()).Contains(txtBoxManageUsersSearch.Text) || (user.Surname.ToLower()).Contains(txtBoxManageUsersSearch.Text))
                {
                    listBoxUsers.Items.Add(user);//searches users
                }
            }
        }

        private void labelBookingDate_Click(object sender, EventArgs e)
        {

        }

     
        private void btnCreateNote_Click_1(object sender, EventArgs e)
        {

        }



        private void TabManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checks if the tab changes to the manage account tab and pulls up the edit user form
            if (TabManagement.SelectedTab.Name == "tabManageAccount")
            {
                TabManagement.SelectedIndex = 0;
                UserDetails User = CurrentUser;
              
                Management_EditUser form = new Management_EditUser(User, false);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    listBoxUsers.Items.Clear();
                    form.GetUser().Save();
                    Updateform();
                    stripLabelManagement.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}!";
                    //if the user is updated so is the strip label as they might have changed their name and the user list box is updated to show the new current user list
                }

            }
        }


        private void ResolveReport()
        {
            ((Report)lstReports.SelectedItem).Resolved = true;
        }

   

        private void dtPickerBooking_ValueChanged(object sender, EventArgs e)
        {
            Updateform();
        }

        

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            RoomBooking booking = null;
            TimeSpan Bookingstart = new TimeSpan(dtstarttime.Value.Hour,0,0);
            TimeSpan Bookingend = new TimeSpan(dtendtime.Value.Hour, 0, 0);
            TimeSpan hour = new TimeSpan(1, 0, 0);
            List<RoomBooking> BookCheck = new List<RoomBooking>();
            bool cancelled = false;
            for (TimeSpan i = Bookingstart;i<Bookingend;i+= hour)
            {
                DateTime bookingdate = dtPickerBooking.Value.Date.Add(i);
                BookCheck = RoomBooking.Load(bookingdate.Date);
                foreach (RoomBooking Check in BookCheck)
                {
                    if (Check.BookingDate.TimeOfDay == i && Check.Room == cmbRoom.Text)//books from the start and end time cancelling all bookings at that point 
                    {
                        cancelled = true;
                        Booking.Delete(Check.BookingID);//deletes from file
                    }
  
                }
                
                booking = new RoomBooking(bookingdate, CurrentUser.FirstName, CurrentUser.Surname, CurrentUser.Username,cmbRoom.Text,"");
                booking.Save();
                RoomBooking.Load();
               
                Updateform();
            }
            if (cancelled == true)
            {
                MessageBox.Show("Notified users who had a booking in that timeslot ");
            }
            
        }

        private void dtstarttime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan hour = new TimeSpan(1, 0, 0);
            if(dtstarttime.Value.Hour >= dtendtime.Value.Hour)//sets start time to be an hour below end time
            {
                try
                {
                    dtendtime.Value = dtstarttime.Value + hour;
                }
                catch
                {

                }
                
            }
        }

        private void dtendtime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan hour = new TimeSpan(1, 0, 0);
            if (dtstarttime.Value.Hour <= dtendtime.Value.Hour)//sets end time to be hour after start time if it goes below
            {
                try
                {
                    dtstarttime.Value = dtendtime.Value - hour;
                }
                catch
                {

                }
                
            }
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            Management_EditUser form = new Management_EditUser(true);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                form.GetUser().Save();
                listBoxUsers.Items.Clear();
                Updateform();//opens create account form to create new user
            }
        }

        private void btnaddevent_Click(object sender, EventArgs e)
        {
            Management_EditEvent EventForm = new Management_EditEvent(CurrentUser);
            EventForm.ShowDialog();
            if(EventForm.DialogResult == DialogResult.OK)
            {
                listBoxEvents.Items.Clear();
                listBoxDisplayEvents.Items.Clear();
   

                EventForm.GetEvent().Save();

                Updateform();//add new event
            }
        }

        private void dtPickerEvents_ValueChanged(object sender, EventArgs e)
        {
            listBoxDisplayEvents.Items.Clear();
            foreach (EventBooking Event in EventBookings)
            {
                if (Event.BookingDate == dtPickerEvents.Value.Date)
                {
                    listBoxDisplayEvents.Items.Add(Event);
                }
            }

            }//displays items on day specified


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();//adds bookings on specified day
            foreach (EventBooking Event in EventBookings)
            {
                if (Event.BookingDate == dtManageEvent.Value.Date)
                {
                    listBoxEvents.Items.Add(Event);
                }
            }
        }

        private void btnSignUpForEvent_Click_1(object sender, EventArgs e)
        {
            EventBooking Event = (EventBooking)listBoxDisplayEvents.SelectedItem;
            bool Attendeefound = false;
            if (Event != null)
            {
                foreach(string attendee in Event.Attendees)
                {
                    if(attendee == CurrentUser.Username)
                    {
                        MessageBox.Show("You have already registered for an event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Attendeefound = true;//if you have signed up you get an error
                        break;
                    }
                }
                if(Attendeefound == false)
                {
                    Event.AddAttendee(CurrentUser.Username);
                    MessageBox.Show("You have been added to the event");
                    Event.Save();//if not on list you get added to it
                   
                }
                
            }
            else
            {
                MessageBox.Show("Please select an event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
            Updateform();
        }

        private void dtPickerTimetable_ValueChanged(object sender, EventArgs e)
        {
            foreach (RoomBooking roomBooking in RoomBookings)
            {
                if (roomBooking.MemberUsername == CurrentUser.Username && roomBooking.BookingDate.Date == dtPickerTimetable.Value.Date)
                {
                    Timetable.Add(roomBooking);
                }
            }
        }

        private void btnUnbook_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)listBoxDisplayBookedTimes.SelectedItem;
            if(booking != null)
            {
                int ID = booking.BookingID;
                Booking.Delete(ID);
                MessageBox.Show("The booking has been cancelled", "Success", MessageBoxButtons.OK);//unbook booking
            }
            else
            {
                MessageBox.Show("Please select a booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Updateform();
        }
    }
}

