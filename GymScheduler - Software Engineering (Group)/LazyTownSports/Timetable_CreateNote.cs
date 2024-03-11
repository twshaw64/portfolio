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
    public partial class Timetable_CreateNote : Form
    {
        private Booking mBooking;
        public Timetable_CreateNote()
        {
            InitializeComponent();
        }
        public Timetable_CreateNote(RoomBooking pBooking):this()
        {
            txtBoxNote.Text = pBooking.BookingNotes;
            mBooking = pBooking;
        }
        public Timetable_CreateNote(PTBooking pBooking) : this()
        {
            txtBoxNote.Text = pBooking.BookingNotes;
            mBooking = pBooking;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            mBooking.BookingNotes = txtBoxNote.Text;
            mBooking.Save();
            this.Close();
        }
    }
}
