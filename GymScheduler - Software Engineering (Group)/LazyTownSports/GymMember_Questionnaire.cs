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
    public partial class GymMember_Questionnaire : Form
    {
        private UserDetails CurrentUser;
        public List<UserDetails> PTs = new List<UserDetails>();
        public List<UserDetails> PTcustomer = new List<UserDetails>();
        public GymMember_Questionnaire(UserDetails pCurrentUser)
        {
            InitializeComponent();
            CurrentUser = pCurrentUser;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitValues_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to submit these values? You won't be able to change your personal trainer afterwards!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            int Motivation = trackBarMotivated.Value;
            int Fitness = trackBarFitness.Value;
            int FinalScore = Motivation + Fitness;//adds total of track bar scores
            int counter = 0;
            PTs = UserDetails.LoadUsers(UserLevel.PersonalTrainer);
            PTcustomer = UserDetails.LoadUsers(UserLevel.GymMember);
            for (int i = 0; i<20;i++)
            {
                foreach (UserDetails PT in PTs)
                {
                   
                    foreach (UserDetails user in PTcustomer)
                    {
                        if (user.PTAssigned == PT.FirstName + " " + PT.Surname)
                        {
                            counter++;
                        }
                    }                 
                    if (counter < 40 && PT.PTScore == FinalScore - i || PT.PTScore == FinalScore + i)
                    {
                        CurrentUser.PTAssigned = PT.Username;
                        break;
                    }


                }
                
            }//checks each pt for how many people they have if the pt has the score they got and less than 25 people they are assigned otherwise the score bounds are changed to find the closest match
            CurrentUser.Save();
        }
    }
}
