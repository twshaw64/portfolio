using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTSLogic;
using LTSXML;
using LazyTownSports;

namespace LazyTownSports
{
    public partial class Society : Form
    {
        public List<RoomBooking> RoomBookings = new List<RoomBooking>();
        private UserDetails CurrentUser;

        public void Updateform()
        {
            lvBookingtimes.Clear();
            listBoxDisplayBookedTimes.Items.Clear();
            List<RoomBooking> BookCheck = new List<RoomBooking>();
            List<RoomBooking> Bookings = new List<RoomBooking>();
            List<RoomBooking> Timetable = new List<RoomBooking>();
            TimeSpan hour = new TimeSpan(1, 0, 0);
            TimeSpan StartTime = new TimeSpan(0, 0, 0);
            TimeSpan endtime = new TimeSpan(0, 0, 0);
            int counter = 1;
            #region add rows and columns
            lvBookingtimes.Columns.Add("Rooms", 200);
            ListViewItem SmallRoom = new ListViewItem("Small Room");
            ListViewItem MediumRoom = new ListViewItem("Medium Room");
            ListViewItem LargeRoom = new ListViewItem("Large Room");
            ListViewItem MUGA = new ListViewItem("Multiple-Use Games Room");
            #endregion
            #region changes colour inheritance
            SmallRoom.UseItemStyleForSubItems = false;
            MediumRoom.UseItemStyleForSubItems = false;
            LargeRoom.UseItemStyleForSubItems = false;
            MUGA.UseItemStyleForSubItems = false;
            BookCheck = RoomBooking.Load(dtPickerBooking.Value.Date);
            dtPickerBooking.MinDate = DateTime.Today;
            #endregion
            #region add columns to list view
            if (dtPickerBooking.Value.DayOfWeek == DayOfWeek.Saturday || dtPickerBooking.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                StartTime = new TimeSpan(9, 0, 0);
                endtime = new TimeSpan(19, 0, 0);
                try
                {
                     dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                     dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime ;
                }
                catch
                {
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
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
                }
                catch
                {
                    dtstarttime.MinDate = dtPickerBooking.Value.Date + StartTime;
                    dtstarttime.MaxDate = dtPickerBooking.Value.Date + endtime - hour;
                }
            }
            for (TimeSpan i = StartTime; i < endtime; i += hour)
            {
                lvBookingtimes.Columns.Add(i.ToString(@"hh\:mm"));
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

            #region Adding Bookings to the timetable
            RoomBookings = RoomBooking.Load(dtPickerTimetable.Value.Date);
            foreach (RoomBooking roomBooking in RoomBookings)
            {
                if (roomBooking.MemberUsername == CurrentUser.Username && roomBooking.BookingDate.Date == dtPickerTimetable.Value.Date)
                {
                    Timetable.Add(roomBooking);
                    
                }
            }
            Timetable.Sort();
            foreach(RoomBooking roombooking in Timetable)
            {
                listBoxDisplayBookedTimes.Items.Add(roombooking);
            }
            #endregion
        }

        public Society(UserDetails pCurrentUser)
        {
            InitializeComponent();
            CurrentUser = pCurrentUser;
        }

        private void btnBook_MouseHover(object sender, EventArgs e)
        {
            stripLabelSociety.Text = "Book the selected times and room.";
        }

        private void btnBook_MouseLeave(object sender, EventArgs e)
        {
            stripLabelSociety.Text = "";
        }


        private void Society_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Society_Load(object sender, EventArgs e)
        {
            stripLabelSociety.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}!";
            Updateform();
        }



        private void listBoxDisplayUnbookedTimes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelBookingDate_Click(object sender, EventArgs e)
        {

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
                        stripLabelSociety.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}!";
                        //if the user is updated so is the strip label as they might have changed their name 
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomBooking booking = null;
            DateTime BookingTime = dtPickerBooking.Value.Date + dtstarttime.Value.TimeOfDay;
            List<RoomBooking> BookCheck = new List<RoomBooking>();
            string BookingErrors = BookingMethods.CheckBooking(CurrentUser.Username, BookingTime,cmbRoom.Text, CurrentUser.ActiveUser);//checks to see if you can book
           if( BookingErrors != "")
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

        private void dtPickerTimetable_ValueChanged(object sender, EventArgs e)
        {
            Updateform();
        }

        private void btnUnbook_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)listBoxDisplayBookedTimes.SelectedItem;
            if (booking != null)
            {
                int ID = booking.BookingID;
                Booking.Delete(ID);//cancels booking
                MessageBox.Show("The booking has been cancelled", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please select a booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Updateform();
        }

        private void labelReportProblem_Click(object sender, EventArgs e)
        {

        }
    }
}
