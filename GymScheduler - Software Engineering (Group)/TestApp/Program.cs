using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTSLogic;
using LTSXML;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainTextTestPassword = "password";
            string testFirstName = "michael";
            string testSurname = "watson";
            string testAddressLine1 = "20 cranbrook avenue";
            string testCity = "hull";
            string testCounty = "east yorkshire";
            string testPostCode = "hu65sn";
            string testPhoneNumber = "07888888888";
            string testEmail = "w@w.com";
            bool testActiveMember = true;
            UserLevel[] levels = new UserLevel[] { UserLevel.GymMember, UserLevel.Manager, UserLevel.PersonalTrainer, UserLevel.Society };
            foreach(UserLevel level in levels)
            {
                UserDetails testDetails = new UserDetails(level.ToString(), plainTextTestPassword, false, testPhoneNumber, testAddressLine1, testCity, testCounty, testPostCode, testEmail, testFirstName, testSurname, level, testActiveMember);
                testDetails.Save();
            }
            Console.WriteLine("done");
            Console.ReadKey(true);
        }

        private static bool tryagain()
        {
            Console.WriteLine("Try again?");
            return Console.ReadKey(true).KeyChar == 'y';
        }
    }
}
