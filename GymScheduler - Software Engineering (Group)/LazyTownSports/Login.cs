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
using System.IO;


namespace LazyTownSports
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateAccount form = new CreateAccount();
            form.Region = this.Region;
            form.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            UserDetails ValidatedUser = null;
            
            try
            {
                ValidatedUser = new ValidateLogin(txtUsername.Text, txtPassword.Text).Validate();
                switch (ValidatedUser.UserLevel)
            {
                case UserLevel.Manager:
                    Management form = new Management(ValidatedUser);
                    form.Show();
                    this.Hide();
                    break;
                case UserLevel.GymMember:
                    GymMember gymForm = new GymMember(ValidatedUser);
                    gymForm.Show();
                    this.Hide();
                    break;
                case UserLevel.PersonalTrainer:
                    PersonalTrainer personalTrainerForm = new PersonalTrainer(ValidatedUser);
                    personalTrainerForm.Show();
                    this.Hide();
                    break;
                case UserLevel.Society:
                    Society societyForm = new Society(ValidatedUser);
                    societyForm.Show();
                    this.Hide();
                    break;              
            }
            }
            catch (UserNotValidatedException ex)
            {
                // put code here for if the user enters incorrect password
                string exceptionMessage = ex.Message;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (FileNotFoundException ex)
            {
                // insert code here for if the login file cannot be found
                string exceptionMessage = ex.Message;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch(KeyNotFoundException ex)
            {
                // insert code here for if the user enters a username not found in the logins file
                string exceptionMessage = ex.Message;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}