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
        public List<RoomBooking> RoomBooking = new List<RoomBooking>();

        public Management(UserDetails pCurrentUser)
        {
            InitializeComponent();
            CurrentUser = pCurrentUser;
        }

        private void updateBookingTimes()
        {
        
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            UserDetails User = (UserDetails)listBoxUsers.SelectedItem;
            if (User != null)
            {
                Management_EditUser form = new Management_EditUser(User, true);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    listBoxUsers.Items.Clear();
                    Users.Sort();
                    foreach (UserDetails user in Users)
                    {
                        listBoxUsers.Items.Add(user);
                    }
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to book this slot?", "PLACEHOLDER BUTTON PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btnCancelSelected_Click(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "The selected appointments have been cancelled.";
        }

        private void btnCancelSelected_MouseHover(object sender, EventArgs e)
        {
            stripLabelManagement.Text = "Cancel the selected appointments on the calendar.";
        }

        private void btnCancelSelected_MouseLeave(object sender, EventArgs e)
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
            Management_EditEvent form = new Management_EditEvent();
            form.ShowDialog();
        }

        

        private void Management_Load(object sender, EventArgs e)
        {
            stripLabelManagement.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}!";
            Users = UserDetails.LoadUsers();
            Users.Sort();
            listBoxUsers.Items.Clear();
            foreach (UserDetails user in Users)
            {
                listBoxUsers.Items.Add(user);
            }
            Reports = Report.LoadReports();
            foreach(Report report in Reports)
            {
                if (report.Resolved == false)
                {
                    lstReports.Items.Add(report);
                }
            }

            for (int i = 9; i < 19; i++)
            {
                listView1.Columns.Add(i + ":00", 100);
            }

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
                    listBoxUsers.Items.Add(user);
                }
            }
        }

        private void labelBookingDate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelSelected_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCreateNote_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Management_EditUser form = new Management_EditUser();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Users.Add(form.GetUser());
                listBoxUsers.Items.Clear();
                Users.Sort();
                foreach (UserDetails user in Users)
                {
                    listBoxUsers.Items.Add(user);
                }
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Management_EditEvent form = new Management_EditEvent();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {

            }
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
                    Users.Sort();
                    foreach (UserDetails user in Users)
                    {
                            listBoxUsers.Items.Add(user);
                    }
                    stripLabelManagement.Text = $"Welcome {CurrentUser.FirstName} {CurrentUser.Surname}!";
                    //if the user is updated so is the strip label as they might have changed their name and the user list box is updated to show the new current user list
                }

            }
        }


        private void ResolveReport()
        {
            ((Report)lstReports.SelectedItem).Resolved = true;
        }
    }
}

