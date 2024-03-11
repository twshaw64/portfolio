using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using LTSLogic;
using LTSXML;
using System.IO;

namespace TestingProject
{
    [TestClass]
    public class UnitTest
    {
        #region UserDetails Global Test Values
        static string testUsername = "testing";
        static string plainTextTestPassword = "password";
        static string testFirstName = "michael";
        static string testSurname = "watson";
        static string testAddressLine1 = "20 cranbrook avenue";
        static string testCity = "hull";
        static string testCounty = "east yorkshire";
        static string testPostCode = "hu65sn";
        static string testPhoneNumber = "07888888888";
        static string testEmail = "w@w.com";
        static UserLevel testUserLevel = UserLevel.GymMember;
        static bool testActiveMember = true;
        static UserDetails testDetails = new UserDetails(testUsername, plainTextTestPassword, false, testPhoneNumber, testAddressLine1, testCity, testCounty, testPostCode, testEmail, testFirstName, testSurname, testUserLevel, testActiveMember);
        #endregion

        #region UserDetails
        #region Username
        [TestMethod]
        public void UserDetailsUsername()
        {
            //test data
            string[] shouldFailTestData = new string[] { "", " ", "h e", "k l k"};
            string[] shouldPassTestData = new string[] { "test", "hello2", "TEST", "tEST","Test" };

            //run test

            foreach (string test in shouldFailTestData)
            {
                try
                {
                    testDetails.Username = test;
                    throw new AssertFailedException($"Failed at: {test}");
                }
                catch (UserDetailException)
                {

                }
            }
            foreach (string test in shouldPassTestData)
            {
                testDetails.Username = test;
            }
            Assert.IsTrue(true);
        }
        #endregion
        #region First Name
        [TestMethod]
        public void UserDetailsFirstName()
        {
            //test data
            string[] shouldFail = new string[] { "", " ", "1", "h3", "h h", "@", "te,st", ",$£%","yeet@" };
            string[] shouldPass = new string[] { "test", "Test", "tEST", "TEST" };

            //run test
            foreach (string test in shouldFail)
            {
                try
                {
                    testDetails.FirstName = test;
                    throw new AssertFailedException($"Failed at: {test}");
                }
                catch (UserDetailException) { }
            }
            foreach(string test in shouldPass)
            {
                testDetails.FirstName = test;
            }
            Assert.IsTrue(true);
        }
        #endregion
        #region Surname
        [TestMethod]
        public void UserDetailsSurname()
        {
            //test data
            string[] shouldFail = new string[] { "", " ", "1", "h3", "h h", "@", "te,st", ",$£%", "yeet@" };
            string[] shouldPass = new string[] { "test", "TEST", "Test", "tEST" };

            //run test
            foreach(string test in shouldFail)
            {
                try
                {
                    testDetails.Surname = test;
                    throw new AssertFailedException($"Failed at: {test}");
                }
                catch (UserDetailException) { }
            }
            foreach(string test in shouldPass)
            {
                testDetails.Surname = test;
            }
            Assert.IsTrue(true);
        }
        #endregion
        #region PostCode
        [TestMethod]
        public void UserDetailsPostCode()
        {
            //test data
            string[] shouldFail = new string[] { "", " ", "gg", "H4", "55t", "hhhhhhhhhhhh" };
            string[] shouldPass = new string[] { "hhhhhh", "HHHHHHH", "hHhHhHhH", "666666", "6666hhh" };

            //run test
            foreach(string test in shouldFail)
            {
                try
                {
                    testDetails.PostCode = test;
                    throw new AssertFailedException($"Failed at: {test}");
                }
                catch (UserDetailException) { }
            }
            foreach(string test in shouldPass)
            {
                testDetails.PostCode = test;
            }
            Assert.IsTrue(true);
        }
        #endregion
        #region Email Address
        [TestMethod]
        public void UserDetailsEmailAddress()
        {
            //test data
            string[] shouldFail = new string[] { "", " ", "test", "test@test", "test.com", "test@", "@test", ".test", "test.", "test@.", "myemail", "my email", "123", "123@", "@123", "123@.", "@@@", "...","@@..", "test@....", "test@@@....","test@@@." };
            string[] shouldPass = new string[] { "test@testserver.com", "test@me.co.uk", "test.test@me.com", "test.test@test.co.uk", "123@123.com", "123@123.co.uk", "hello23@gmail.com" };

            //run test
            foreach(string test in shouldFail)
            {
                try
                {
                    testDetails.Email = test;
                    throw new AssertFailedException($"Failed at: {test}");
                }
                catch (UserDetailException) { }
            }
            foreach(string test in shouldPass)
            {
                testDetails.Email = test;
            }
            Assert.IsTrue(true);
        }
        #endregion
        #region Phone Number
        [TestMethod]
        public void UserDetailsPhoneNumber()
        {
            //test data
            string[] shouldFail = new string[] { "", " ", "h", "0", "000000000000", "hhhhhhhhhhh","99999999999", "£$%^", "///", "yeet","phonenumber" };
            string[] shouldPass = new string[] { "07888888888", "07123456789", "01248636256" }; 

            //run test
            foreach(string test in shouldFail)
            {
                try
                {
                    testDetails.PhoneNumber = test;
                    throw new AssertFailedException($"Failed at: {test}");
                }
                catch (UserDetailException) { }
            }
            foreach(string test in shouldPass)
            {
                testDetails.PhoneNumber = test;
            }
            Assert.IsTrue(true);
        }
        #endregion
        #region PTScore
        [TestMethod]
        public void UserDetailsPTScore()
        {
            //for this test to pass the userdetails object should not let the PT score be assigned to unless
            //the user is a PT

            //test the outcome if the user is a PT
            testDetails.UserLevel = UserLevel.PersonalTrainer;
            testDetails.PTScore = 2;

            //test the outcome if the user is any other level than PT
            UserLevel[] possibleUserLevels = new UserLevel[] { UserLevel.GymMember, UserLevel.Manager, UserLevel.Society };
            
            foreach(UserLevel level in possibleUserLevels)
            {
                testDetails.UserLevel = level;
                try
                {
                    testDetails.PTScore = 2;
                    throw new AssertFailedException($"Failed at: {level.ToString()}");
                }
                catch (UserDetailException)
                {
                    continue;
                }
            }
            Assert.IsTrue(true);
        }
        #endregion
        #region PTAssigned
        [TestMethod]
        public void UserDetailsPTAssigned()
        {
            //this test should fail unless it only allows you to assign to PTAssigned if the user
            //is a gym member
            
            //test data
            UserLevel[] shouldFailLevels = new UserLevel[] {UserLevel.Manager, UserLevel.PersonalTrainer, UserLevel.Society };

            //ensure a valid personal trainer is stored in the file system
            testDetails.Username = "personaltrainer";
            testDetails.UserLevel = UserLevel.PersonalTrainer;
            testDetails.Save();

            //run test
            foreach(UserLevel level in shouldFailLevels)
            {
                testDetails.UserLevel = level;
                try
                {
                    testDetails.PTAssigned = "personaltrainer";
                    throw new AssertFailedException($"Failed at: {level}");
                }
                catch(UserDetailException)
                {
                    continue;
                }
            }

            testDetails.UserLevel = UserLevel.GymMember;
            try
            {
                testDetails.PTAssigned = "personaltrainer";
            }
            catch (UserDetailException ex)
            {
                throw new AssertFailedException($"Failed at: Gym Member, {ex.Message}",ex);
            }
        }
        #endregion
        #endregion
    }
}
