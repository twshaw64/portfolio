using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.IO;

namespace LTSXML
{
    /// <summary>
    /// Enum for storing the user level of a user
    /// </summary>
    public enum UserLevel
    {
        GymMember, PersonalTrainer, Society, Manager, None
    }

    /// <summary>
    /// Object for storing all the details of a user
    /// </summary>
    public class UserDetails:IComparable
    {
        #region Constructor
        /// <summary>
        /// Object for storing the details of a user
        /// </summary>
        /// <param name="pPassword">Password in either plain text or hashed, indicate which using the bool pHashedPassword</param>
        /// <param name="pHashedPassword">TRUE if the password being provided is hashed, FALSE if its plain text</param>
        /// <param name="pPTAssigned">Only needed if the user level is Gym Member</param>
        /// <param name="pPTScore">Only needed if the user level is Personal Trainer</param>
        private UserDetails(string pUsername, string pPassword, bool pHashedPassword, string pPhoneNumber,
           string pAddress1, string pCity, string pCounty, string pPostCode,
            string pEmail, string pFirstName, string pSurname, UserLevel pUserLevel, bool pActiveUser, string pPTAssigned, int pPTScore)
        {
            Username = pUsername;
            if (pHashedPassword)
            {
                HashedPassword = pPassword;
            }
            else
            {
                PlainTextPassword = pPassword;
            }
            PhoneNumber = pPhoneNumber;
            AddressLine1 = pAddress1;
            City = pCity;
            County = pCounty;
            PostCode = pPostCode;
            Email = pEmail;
            FirstName = pFirstName;
            Surname = pSurname;
            UserLevel = pUserLevel;
            ActiveUser = pActiveUser;
            PTScore = pPTScore;
            PTAssigned = pPTAssigned;
        }
       
        /// <summary>
        /// Object for storing the details of a user
        /// </summary>
        /// <param name="pPassword">Password in either plain text or hashed, indicate which using the bool pHashedPassword</param>
        /// <param name="pHashedPassword">TRUE if the password being provided is hashed, FALSE if its plain text</param>
        public UserDetails(string pUsername, string pPassword, bool pHashedPassword, string pPhoneNumber,
           string pAddress1, string pCity, string pCounty, string pPostCode,
            string pEmail, string pFirstName, string pSurname, UserLevel pUserLevel, bool pActiveUser) : this( pUsername,  pPassword,  pHashedPassword,  pPhoneNumber, pAddress1,  pCity,  pCounty,  pPostCode,  pEmail,  pFirstName,  pSurname, pUserLevel, pActiveUser, null, -1)
        {
        }

        /// <summary>
        /// Object for storing the details of a user, Constructor for setting the PTAssigned. ONLY FOR USE WITH GYM MEMBER
        /// </summary>
        /// <param name="pPassword">Password in either plain text or hashed, indicate which using the bool pHashedPassword</param>
        /// <param name="pHashedPassword">TRUE if the password being provided is hashed, FALSE if its plain text</param>
        /// <param name="pPTAssigned">Only needed if the user level is Gym Member</param>
        public UserDetails(string pUsername, string pPassword, bool pHashedPassword, string pPhoneNumber,
           string pAddress1, string pCity, string pCounty, string pPostCode,
            string pEmail, string pFirstName, string pSurname, UserLevel pUserLevel, bool pActiveUser, string pPTAssigned) : this(pUsername, pPassword, pHashedPassword, pPhoneNumber, pAddress1, pCity, pCounty, pPostCode, pEmail, pFirstName, pSurname, pUserLevel, pActiveUser, pPTAssigned, -1)
        {
        }

        /// <summary>
        /// Object for storing the details of a user, Constructor for setting the PTScore. ONLY FOR USE WITH PTs
        /// </summary>
        /// <param name="pPassword">Password in either plain text or hashed, indicate which using the bool pHashedPassword</param>
        /// <param name="pHashedPassword">TRUE if the password being provided is hashed, FALSE if its plain text</param>
        /// <param name="pPTScore">Only needed if the user level is Personal Trainer</param>
        public UserDetails(string pUsername, string pPassword, bool pHashedPassword, string pPhoneNumber,
           string pAddress1, string pCity, string pCounty, string pPostCode,
            string pEmail, string pFirstName, string pSurname, UserLevel pUserLevel, bool pActiveUser, int pPTScore) : this(pUsername, pPassword, pHashedPassword, pPhoneNumber, pAddress1, pCity, pCounty, pPostCode, pEmail, pFirstName, pSurname, pUserLevel, pActiveUser, null, pPTScore)
        {
        }
        #endregion

        #region Fields
        private int mPTScore;
        /// <summary>
        /// The score assignes to a personal trainer. Does not work if the user is not a personal trainer. Default value is -1.
        /// </summary>
        /// <exception cref="UserDetailException"></exception>"
        public int PTScore
        {
            get
            {
                if(UserLevel == UserLevel.PersonalTrainer)
                {
                    return mPTScore;
                }
                else
                {
                    throw new UserDetailException("User is not a personal trainer and so does not have a PT Score");
                }
            }
            set
            {
                if(value == -1)
                {
                    mPTScore = -1;
                    return;
                }
                if(UserLevel == UserLevel.PersonalTrainer)
                {
                    mPTScore = value;
                }
                else
                {
                    throw new UserDetailException("User is not a personal trainer and so does not have a PT Score");
                }
            }
        }

        private string mPTAssigned;
        /// <summary>
        /// The username of the personal trainer assigned to the Gym Member. Does not work if user if not a gym member
        /// </summary>
        /// <exception cref="UserDetailException"></exception>
        public string PTAssigned
        {
            get
            {
                if(UserLevel == UserLevel.GymMember)
                {
                    return mPTAssigned;
                }
                else
                {
                    throw new UserDetailException("User is not a gym member and so does not have a personal trainer");
                }
            }
            set
            {
                if (value == null || value.Trim() == "") { mPTAssigned = ""; return; }
                if(UserLevel == UserLevel.GymMember)
                {
                    try
                    {
                       if(UserDetails.Load(value).UserLevel == UserLevel.PersonalTrainer)
                        {
                            mPTAssigned = value;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        throw new UserDetailException($"{value} is not a valid personal trainer");
                    }
                }
                else
                {
                    throw new UserDetailException("User is not a gym member and so does not have a personal trainer");
                }
            }
        }

        private string mUsername;
        /// <summary>
        /// Username in plain text
        /// </summary>
        public string Username
        {
            get { return mUsername.ToLower(); }
            set
            {
                if (value.Contains(' ')) throw new UserDetailException("Username cannot contain white space");
                if (value.Trim() == "") throw new UserDetailException("Username cannot be blank");
                mUsername = value.ToLower();
            }
        }

        /// <summary>
        /// Password in hashed form
        /// </summary>
        public string HashedPassword { get; set; } // this stops the program from ever storing a plain text password

        /// <summary>
        /// Password in plain text (this variable is write-only as the object never stores the plain text password).
        /// Setting this field as a string hashes the string then saves it in the HashedPassword field
        /// Exception is thrown if the password is invalid
        /// </summary>
        /// <exception cref="UserDetailException">Thrown if the password is not valid</exception>
        public string PlainTextPassword
        {
            set
            {
                if (value.Length < 8) throw new UserDetailException("Password must be longer than 8 characters");
                if (value.Trim() == "") throw new UserDetailException("Password cannot be blank");
                HashedPassword = new HashString().HashedString(value);
            }
        }

        private string mPhoneNumber; //private member

        /// <summary>
        /// Phone number as a string
        /// </summary>
        /// <remarks>This is a string because storing as an int removes the leading '0'</remarks>
        public string PhoneNumber
        {
            get { return mPhoneNumber; }
            set
            {
                if (value.Trim().Length != 11) throw new UserDetailException("Phone numbers must be 11 digits long");
                if (!(value[0] == '0')) throw new UserDetailException("Phone numbers must start with 0");
                try
                {
                    long.Parse(value);
                    mPhoneNumber = value;
                }
                catch
                {
                    throw new UserDetailException("Phone number must contain only numbers");
                }
            }
        }

        /// <summary>
        /// String containing the street address of the user
        /// </summary>
        public string AddressLine1;

        /// <summary>
        /// String containing the city of the user
        /// </summary>
        public string City;

        /// <summary>
        /// String containing the county of the user
        /// </summary>
        public string County;

        private string mPostCode;
        /// <summary>
        /// String containing the postcode of the user
        /// </summary>
        /// <exception cref="UserDetailException"></exception>
        public string PostCode
        {
            get { return mPostCode; }
            set
            {
                if (value.Length < 6 || value.Length > 9) throw new UserDetailException("Post code must be 6-9 letters long");
                mPostCode = value;
            }
        }

        private string mEmail; //private member
        /// <summary>
        /// Email address as a string. Must contain '@', must have at least one '.' after the '@' symbol.
        /// Must not be blank 
        /// </summary>
        /// <exception cref="UserDetailException">Thrown if the email is invalid</exception>
        public string Email
        {
            get { return mEmail; }
            set
            {
                try
                {
                    if (!value.Contains("@")) throw new Exception();
                    string[] emailSplit = value.Split('@');
                    if (!emailSplit[1].Contains('.')) throw new Exception();
                    if (emailSplit[1].Trim(new char[] { '.' }) == "") throw new Exception();
                    if (emailSplit[0].Trim() == "") throw new Exception();
                    mEmail = value;
                }
                catch
                {
                    throw new UserDetailException("Invalid email format");
                }
            }
        }

        private string mFirstName; //private member
        /// <summary>
        /// First name as a string. Must not be blank, must not contain numbers
        /// </summary>
        /// <exception cref="UserDetailException">Thrown if the supplied firstname is invalid</exception>
        public string FirstName
        {
            get { return mFirstName; }
            set
            {
                if (value.Trim() == "") throw new UserDetailException("First name cannot be blank");
                if (value.Contains(' ')) throw new UserDetailException("First name cannot contain spaces");
                if (value.Any(char.IsDigit)) throw new UserDetailException("First name cannot contain numbers");
                if (value.Any(char.IsSymbol)) throw new UserDetailException("First name cannot contain symbols");
                if (value.Any(char.IsPunctuation)) throw new UserDetailException("First name cannot contain punctuation");
                mFirstName = value;
            }
        }

        private string mSurname; //private member
        /// <summary>
        /// Surname as a string. Must not be blank, must not contain numbers
        /// </summary>
        /// <exception cref="UserDetailException">Thrown if the supplied surname is invalid</exception>
        public string Surname
        {
            get { return mSurname; }
            set
            {
                if (value.Trim() == "") throw new UserDetailException("Surname cannot be blank");
                if (value.Contains(' ')) throw new UserDetailException("Surname cannot contain spaces"); 
                if (value.Any(char.IsDigit)) throw new UserDetailException("Surname cannot contain numbers");
                if (value.Any(char.IsSymbol)) throw new UserDetailException("Surname cannot contain symbols");
                if (value.Any(char.IsPunctuation)) throw new UserDetailException("Surname cannot contain punctuation");
                mSurname = value;
            }
        }

        private UserLevel mUserLevel; //private member
        /// <summary>
        /// UserLevel as enum, must not be set as 'None'
        /// </summary>
        /// <exception cref="UserDetailException">Thrown if the UserLevel supplied is set to \"none\"</exception>
        public UserLevel UserLevel
        {
            get { return mUserLevel; }
            set
            {
                if (value == UserLevel.None) throw new UserDetailException("User level cannot be \"None\"");
                mUserLevel = value;
            }
        }
        /// <summary>
        /// Active user tag to be used by management
        /// </summary>
        public bool ActiveUser;
        #endregion

        #region XML
        #region Save
        /// <summary>
        /// Save the object to the user details file
        /// </summary>
        public void Save()
        {
            string filename = StorageLocation.Logins;
            XDocument loginsFile = XDocument.Load(filename);
            List<XElement> loginList = new List<XElement>();
            loginList = loginsFile.Root.Elements("login").ToList();
            if (UsernameExists(loginList))
            {
                foreach (XElement element in loginsFile.Root.Elements("login"))
                {
                    if (element.Element("username").Value == Username)
                    {
                        element.Remove();
                        loginsFile.Root.Add(Compose());
                        loginsFile.Save(filename);
                        return;
                    }
                }
            }
            else
            {
                loginsFile.Root.Add(Compose());
                loginsFile.Save(filename);
            }

        }
        /// <summary>
        /// Returns true if the details in this instance of the UserDetails object are already stored in the XML file and need to be ovewritten
        /// </summary>
        /// <param name="pLoginList">List of XML elements from the XML file</param>
        /// <returns></returns>
        private bool UsernameExists(List<XElement> pLoginList)
        {
            for (int i = 0; i < pLoginList.Count; i++)
            {
                if (pLoginList[i].Element("username").Value == Username)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Compose XML element from the current instance
        /// </summary>
        private XElement Compose()
        {
            XElement element = new XElement("login",
                new XElement("username", Username),
                new XElement("password", HashedPassword),
                new XElement("firstName", FirstName),
                new XElement("surname", Surname),
                new XElement("addressLine1", AddressLine1),
                new XElement("city", City),
                new XElement("county", County),
                new XElement("postCode", PostCode),
                new XElement("phoneNumber", PhoneNumber),
                new XElement("email", Email),
                new XElement("userLevel", UserLevel.ToString()),
                new XElement("activeMember", ActiveUser),
                new XElement("PTAssigned", mPTAssigned),
                new XElement("PTScore", mPTScore.ToString()));
            return element;
        }
        #endregion
        #region Load
        /// <summary>
        /// Load the details of the user with the supplied username
        /// </summary>
        /// <exception cref="FileNotFoundException">Thrown if the logins file cannot be found</exception>
        /// <exception cref="KeyNotFoundException">Thrown if the username cannot be found in the file</exception>"
        /// <exception cref="UserLevelException">Thrown if there is an issue parsing a string to a user level</exception>"
        /// <param name="pUsername"></param>
        /// <returns></returns>
        public static UserDetails Load(string pUsername)
        {
            pUsername = pUsername.ToLower();
            string filename = StorageLocation.Logins;
            if (!File.Exists(filename)) throw new FileNotFoundException("Logins file not found");
            return Compose(FindElement(pUsername));
        }

        /// <summary>
        /// Load all the users of a specified userlevel into a list of UserDetails objects
        /// </summary>
        /// <param name="pUserLevel">The userlevel to search for</param>
        public static List<UserDetails> LoadUsers(UserLevel pUserLevel)
        {
            string filename = StorageLocation.Logins;
            XDocument userFile = XDocument.Load(filename);
            List<UserDetails> output = new List<UserDetails>();
            List<XElement> userList = userFile.Root.Elements("login").ToList();
            foreach (XElement element in userList)
            {
                UserLevel elementUserLevel = StringToUserLevel(element.Element("userLevel").Value);
                if (elementUserLevel == pUserLevel)
                {

                    output.Add(Compose(element));
                }
            }
            return output;
        }

        /// <summary>
        /// Load all users on file into a list of UserDetails objects
        /// </summary>
        /// <exception cref="UserLevelException">Thrown if there is an issue parsing a string to a user level</exception>
        public static List<UserDetails> LoadUsers()
        {
            string filename = StorageLocation.Logins;
            XDocument userFile = XDocument.Load(filename);
            List<UserDetails> output = new List<UserDetails>();
            List<XElement> userList = userFile.Root.Elements("login").ToList();
            foreach(XElement element in userList)
            {
                output.Add(Compose(element));
            }
            return output;
        }

        /// <summary>
        ///find element in xml file with the username pUsername
        /// </summary>
        private static XElement FindElement(string pUsername) 
        {
            string filename = StorageLocation.Logins;
            XDocument userFile = XDocument.Load(filename);
            List<XElement> userList = userFile.Root.Elements("login").ToList();
            foreach(XElement element in userList)
            {
                if (element.Element("username").Value == pUsername) return element;
            }
            throw new KeyNotFoundException("Invalid username");
        }

        /// <summary>
        /// compose userdetails object from xml element
        /// </summary>
        private static UserDetails Compose(XElement pElement)
        {
            string username = pElement.Element("username").Value;
            string password = pElement.Element("password").Value;
            string firstName = pElement.Element("firstName").Value;
            string surname = pElement.Element("surname").Value;
            string addressLine1 = pElement.Element("addressLine1").Value;
            string city = pElement.Element("city").Value;
            string county = pElement.Element("county").Value;
            string postCode = pElement.Element("postCode").Value;
            string phoneNumber = pElement.Element("phoneNumber").Value;
            string email = pElement.Element("email").Value;
            UserLevel userlevel = StringToUserLevel(pElement.Element("userLevel").Value);
            bool activeMember = bool.Parse(pElement.Element("activeMember").Value);
            string PTAssigned = pElement.Element("PTAssigned").Value;
            int PTScore = int.Parse(pElement.Element("PTScore").Value);
            switch (userlevel)
            {
                case UserLevel.GymMember:
                    return new UserDetails(username, password, true, phoneNumber, addressLine1, city, county, postCode, email, firstName, surname, userlevel, activeMember, PTAssigned);
                case UserLevel.PersonalTrainer:
                    return new UserDetails(username, password, true, phoneNumber, addressLine1, city, county, postCode, email, firstName, surname, userlevel, activeMember, PTScore);
                default:
                    return new UserDetails(username, password, true, phoneNumber, addressLine1, city, county, postCode, email, firstName, surname, userlevel, activeMember);
            }
        }

        /// <summary>
        /// convert string userlevel to enum userlevel
        /// </summary>
        private static UserLevel StringToUserLevel(string pUserLevel)
        {
            switch (pUserLevel)
            {
                case "GymMember": return UserLevel.GymMember;
                case "Manager": return UserLevel.Manager;
                case "PersonalTrainer": return UserLevel.PersonalTrainer;
                case "Society": return UserLevel.Society;
                default: throw new UserLevelException();
            }
        }
        #endregion
        #region Delete Record
        /// <summary>
        /// Delete the selected record from the file system.
        /// UserDetailException is thrown if the username does not exist
        /// </summary>
        /// <param name="pUsername">The username of the record to delete</param>
        /// <exception cref="UserDetailException">Thrown if the username is not found in the file system and the deletion fails</exception>
        public static void DeleteRecord(string pUsername)
        {
            string filename = StorageLocation.Logins;
            XDocument loginsFile = XDocument.Load(filename);
            foreach (XElement element in loginsFile.Root.Elements("login"))
            {
                if (element.Element("username").Value == pUsername)
                {
                    element.Remove();
                    loginsFile.Save(filename);
                    return;
                }
            }
            throw new UserDetailException("Username not found. Deletion Failed");
        }
        #endregion
        #endregion
        public override string ToString()
        {
            return FirstName + " " + Surname;
        }
        public int CompareTo(object pObject)
        {
            UserDetails pOtherUser = (UserDetails)pObject;
            return this.FirstName.CompareTo(pOtherUser.FirstName);
        }
    }
}
