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

namespace LazyTownSports
{
    public partial class Management_EditEvent : Form
    {
        private EventBooking mEvent;
        private UserDetails mUser;

        private List<string> Attendees = new List<string>();
        private List<UserDetails> Users = new List<UserDetails>();

        public EventBooking GetEvent()
        {
            return mEvent;
        }

        #region Construction of form
        public Management_EditEvent()
        {
            InitializeComponent();
            dtEventDate.Value = DateTime.Now;
        }
        public Management_EditEvent(EventBooking pEvent, UserDetails pUser) :this()
        {
            int i =0;
            txtEditEvent.Text = pEvent.EventName;
            dtEventDate.Value = pEvent.BookingDate;
            Attendees = pEvent.Attendees;
            foreach (string attendee in pEvent.Attendees) 
            {
                Users = UserDetails.LoadUsers();
                foreach (UserDetails user in Users)
                {
                    if (user.Username == attendee)
                    {
                        clbSportsVolunteers.Items.Add(user);
                        clbSportsVolunteers.SetItemChecked(i, true);
                    }
                }
              
                i++;
            }
            mEvent = pEvent;
            mUser = pUser;
        }
        public Management_EditEvent(UserDetails pUser) : this()
        {
            mUser = pUser;
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DateTime EventDate = dtEventDate.Value.Date.Add(new TimeSpan(dtEventDate.Value.Hour, 0, 0));
            Attendees.Clear();
            if (mEvent == null)//event doesnt exist so creates new one
            {
                
                mEvent = new EventBooking(EventDate, mUser.FirstName, mUser.Surname, mUser.Username, txtEditEvent.Text, Attendees,"");
                mEvent.Save();
            }
            else
            {
                mEvent.EventName = txtEditEvent.Text;
                mEvent.BookingDate = EventDate;
                foreach(UserDetails attendee in clbSportsVolunteers.CheckedItems)
                {
                    
                    Attendees.Add(attendee.Username);
                }
                mEvent.SetAttendees(Attendees);
                mEvent.Save();//append event that exists
            }
        }
    }
}
