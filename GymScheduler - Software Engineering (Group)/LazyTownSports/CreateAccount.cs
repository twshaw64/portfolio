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
    public partial class CreateAccount : Form
    {
        #region Shadow text in text box
        public CreateAccount()
        {
            InitializeComponent();

            // watermarked text in text boxes
            txtPassword.ForeColor = Color.LightGray;
            txtPhoneNumber.ForeColor = Color.LightGray;
            txtAddress1.ForeColor = Color.LightGray;
            txtCity.ForeColor = Color.LightGray;
            txtCounty.ForeColor = Color.LightGray;
            txtPostcode.ForeColor = Color.LightGray;
            txtPostcode.ForeColor = Color.LightGray;

            txtPassword.Text = "Password must be longer than 8 characters";
            txtPhoneNumber.Text = "Phone number must be exactly 11 numbers";
            txtAddress1.Text = "House number and street name";
            txtCity.Text = "City";
            txtCounty.Text = "County";
            txtPostcode.Text = "Postcode";

            btnCreateAccount.Enabled = false;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password must be longer than 8 characters")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password must be longer than 8 characters";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtStreetAddress1_Enter(object sender, EventArgs e)
        {
            if (txtAddress1.Text == "House number and street name")
            {
                txtAddress1.Text = "";
                txtAddress1.ForeColor = Color.White;
            }
        }

        private void txtStreetAddress1_Leave(object sender, EventArgs e)
        {
            if (txtAddress1.Text.Length == 0)
            {
                txtAddress1.Text = "House number and street name";
                txtAddress1.ForeColor = Color.LightGray;
            }
        }

        private void txtStreetAddress2_Enter(object sender, EventArgs e)
        {
            if (txtCity.Text == "City")
            {
                txtCity.Text = "";
                txtCity.ForeColor = Color.White;
            }
        }

        private void txtStreetAddress2_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text.Length == 0)
            {
                txtCity.Text = "City";
                txtCity.ForeColor = Color.LightGray;
            }
        }

        private void txtStreetAddress3_Enter(object sender, EventArgs e)
        {
            if (txtCounty.Text == "County")
            {
                txtCounty.Text = "";
                txtCounty.ForeColor = Color.White;
            }
        }

        private void txtStreetAddress3_Leave(object sender, EventArgs e)
        {
            if (txtCounty.Text.Length == 0)
            {
                txtCounty.Text = "County";
                txtCounty.ForeColor = Color.LightGray;
            }
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "Phone number must be exactly 11 numbers")
            {
                txtPhoneNumber.Text = "";
                txtPhoneNumber.ForeColor = Color.White;
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Length == 0)
            {
                txtPhoneNumber.Text = "Phone number must be exactly 11 numbers";
                txtPhoneNumber.ForeColor = Color.LightGray;
            }
        }

        private void txtStreetAddress5_Enter(object sender, EventArgs e)
        {
            if (txtPostcode.Text == "Postcode")
            {
                txtPostcode.Text = "";
                txtPostcode.ForeColor = Color.White;
            }
        }

        private void txtStreetAddress5_Leave(object sender, EventArgs e)
        {
            if (txtPostcode.Text.Length == 0)
            {
                txtPostcode.Text = "Postcode";
                txtPostcode.ForeColor = Color.LightGray;
            }
        }

        #endregion

        #region Back to login button
        private void btnLoginScreen_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Region = this.Region;
            form.Show();
            this.Hide();
        }
        #endregion

        #region Create account button and associated methods
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            UserDetails user = null;
            try
            {
                if (Exists(txtUsername.Text)) throw new UserDetailException("Username already in use");
                user = new UserDetails(txtUsername.Text, txtPassword.Text, false, txtPhoneNumber.Text, txtAddress1.Text, txtCity.Text, txtCounty.Text, txtPostcode.Text, txtEmailAddress.Text, txtForename.Text, txtSurname.Text, UserLevel.GymMember, false);
                user.Save();
            }
            catch (UserDetailException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            MessageBox.Show($"Account {user.Username} created successfully. You may now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login form = new Login();
            form.Region = this.Region;
            form.Show();
            this.Hide();
        }

        private bool Exists(string pUsername)
        {
            try
            {
                UserDetails.Load(pUsername);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }
        #endregion

        private void CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login form = new Login();
            form.Region = this.Region;
            form.Show();
        }

        // Required field validation checks
        private void CreateAccount_MouseMove(object sender, MouseEventArgs e)
        {
            if ((txtUsername.Text.Length > 0) && (txtPassword.Text.Length > 0) && (txtPhoneNumber.Text.Length > 0) && (txtAddress1.Text.Length > 0) && (txtCity.Text.Length > 0) && (txtCounty.Text.Length > 0) && (txtPostcode.Text.Length > 0) && (txtForename.Text.Length > 0) && (txtSurname.Text.Length > 0) && (txtEmailAddress.Text.Length > 0))
            {
                btnCreateAccount.Enabled = true;
            }
            else
            {
                btnCreateAccount.Enabled = false;
            }
        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
