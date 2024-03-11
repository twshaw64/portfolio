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
    public partial class Management_EditUser : Form
    {
        #region Members and Fields
        private UserDetails mUser;
        private bool Management;

        public UserDetails GetUser()
        {
            return mUser;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor for the Management_EditUser form to be used when creating a new user
        /// </summary>
        /// <param name="pManagement">True if the user is a manager</param>
        public Management_EditUser(bool pManagement)
        {
            InitializeComponent();
            Management = pManagement;

            comboUserType.Text = "Gym Member";
            if (!Management)
            {
                comboUserType.Enabled = false;
                checkBoxActiveUser.Enabled = false;
            }
            btnDeleteUser.Enabled = false;
        }

        /// <summary>
        /// Constructor for the Management_EditUser form
        /// </summary>
        /// <param name="pUser">The user to edit</param>
        /// <param name="pManagement">True if the user is a manager</param>
        public Management_EditUser(UserDetails pUser,bool pManagement): this(pManagement)
        {
            txtEditUsername.ReadOnly = true;
            txtEditUsername.Text = pUser.Username;
            txtEditPassword.Text = pUser.HashedPassword;
            txtEditPhoneNumber.Text = pUser.PhoneNumber;
            txtEditAddressLine1.Text = pUser.AddressLine1;
            txtEditCity.Text = pUser.City;
            txtEditCounty.Text = pUser.County;
            txtEditPostCode.Text = pUser.PostCode;
            txtFirstName.Text = pUser.FirstName;
            txtSurname.Text = pUser.Surname;
            txtEditEmailAddress.Text = pUser.Email;
            comboUserType.Text = pUser.UserLevel.ToString();
            checkBoxActiveUser.Checked = pUser.ActiveUser;
            if(pUser.UserLevel == UserLevel.PersonalTrainer)
            {
                txtptscore.Text = pUser.PTScore.ToString();
            }
            else
            {
                txtptscore.Text = "N/A";
                txtptscore.ReadOnly = true;
            }
            mUser = pUser;
            btnDeleteUser.Enabled = Management;
        }
        #endregion

        #region Event Handlers
        #region Cancel Button
        private void btnCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (mUser != null)
            {
                txtEditUsername.Text = mUser.Username;
                txtEditPassword.Text = mUser.HashedPassword;
                txtEditPhoneNumber.Text = mUser.PhoneNumber;
                txtEditAddressLine1.Text = mUser.AddressLine1;
                txtEditCity.Text = mUser.City;
                txtEditCounty.Text = mUser.County;
                txtEditPostCode.Text = mUser.PostCode;
                txtFirstName.Text = mUser.FirstName;
                txtSurname.Text = mUser.Surname;
                txtEditEmailAddress.Text = mUser.Email;
                comboUserType.Text = mUser.UserLevel.ToString();
                checkBoxActiveUser.Checked = mUser.ActiveUser;
            }
            else
            {
                txtEditUsername.Clear();
                txtEditPassword.Clear();
                txtEditPhoneNumber.Clear();
                txtEditAddressLine1.Clear();
                txtEditCity.Clear();
                txtEditCounty.Clear();
                txtEditPostCode.Clear();
                txtFirstName.Clear();
                txtSurname.Clear();
                txtEditEmailAddress.Clear();
                checkBoxActiveUser.Checked = false;
            }

        }
        #endregion

        #region Apply Changes
        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            if (mUser == null)
            {
                try
                {
                    if (userExists(txtEditUsername.Text)) throw new UserDetailException("Username already in use");

                    int score = 0;
                    if(comboUserType.Text == "Personal Trainer")
                    {
                        if (score == 0)
                        {
                            score = -1;
                        }
                        mUser = new UserDetails(txtEditUsername.Text, txtEditPassword.Text, false, txtEditPhoneNumber.Text, txtEditAddressLine1.Text, txtEditCity.Text, txtEditCounty.Text, txtEditPostCode.Text, txtEditEmailAddress.Text, txtFirstName.Text, txtSurname.Text, StringToUserLevel.StringToEnum(comboUserType.Text), checkBoxActiveUser.Checked,score);
                    }
                    else
                    {
                        mUser = new UserDetails(txtEditUsername.Text, txtEditPassword.Text, false, txtEditPhoneNumber.Text, txtEditAddressLine1.Text, txtEditCity.Text, txtEditCounty.Text, txtEditPostCode.Text, txtEditEmailAddress.Text, txtFirstName.Text, txtSurname.Text, StringToUserLevel.StringToEnum(comboUserType.Text), checkBoxActiveUser.Checked);
                    }
                    
                    mUser.Save();
                }
                catch (UserDetailException ex)
                {
                    string exceptionMessage = ex.Message;
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    DialogResult = DialogResult.None;
                    return;
                }
            }
            else
            {
                try
                {
                    if(mUser.HashedPassword != txtEditPassword.Text)
                    {
                        mUser.PlainTextPassword = txtEditPassword.Text;
                    }
                    mUser.PhoneNumber = txtEditPhoneNumber.Text;
                    mUser.AddressLine1 = txtEditAddressLine1.Text;
                    mUser.City = txtEditCity.Text;
                    mUser.County = txtEditCounty.Text;
                    mUser.PostCode = txtEditPostCode.Text;
                    mUser.FirstName = txtFirstName.Text;
                    mUser.Surname = txtSurname.Text;
                    mUser.Email = txtEditEmailAddress.Text;
                    mUser.UserLevel = StringToUserLevel.StringToEnum(comboUserType.Text);
                    mUser.ActiveUser = checkBoxActiveUser.Checked;
                    if (txtptscore.Text == "N/A")
                    {
                        mUser.PTScore = -1;
                    }
                    else
                    {
                        mUser.PTScore = int.Parse(txtptscore.Text);
                    }
                    mUser.Save();
                    this.Close();
                }
                catch (UserDetailException ex)
                {
                    string exceptionMessage = ex.Message;
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            this.Close();

        }

        //check if a username already exists 
        private bool userExists(string pUsername)
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

        #region Delete User
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            UserDetails.DeleteRecord(mUser.Username);
            DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #endregion

        
    }
}
