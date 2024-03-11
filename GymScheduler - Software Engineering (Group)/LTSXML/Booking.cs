using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LTSXML
{
    public enum BookingType
    {
        RoomBooking, PTBooking, EventBooking
    }
    public abstract class Booking :IComparable<Booking>
    {
        #region Private Member Variables
        private int m_BookingID;
        private DateTime m_BookingDate;
        private string m_UserFirstName;
        private string m_UserSurname;
        private string m_MemberUsername;
        private string m_BookingNotes;
        private BookingType m_BookingType;
        #endregion

        #region Fields
        /// <summary>
        /// Returns notes on the booking, assigning appends the new value to the end of the existing notes
        /// </summary>
        public string BookingNotes
        {
            get
            {
                if (m_BookingNotes == null) m_BookingNotes = "";
                return m_BookingNotes;
            }
            set
            {
                m_BookingNotes = value;
            }
        }
        /// <summary>
        /// The ID number of the booking
        /// </summary>
        public int BookingID
        {
            get { return m_BookingID; }
            set { m_BookingID = value; }
        }
        /// <summary>
        /// The date the booking takes place
        /// </summary>
        public DateTime BookingDate
        {
            get { return m_BookingDate; }
            set { m_BookingDate = value; }
        }

        /// <summary>
        /// The first name of the person making the booking
        /// </summary>
        public string UserFirstName
        {
            get { return m_UserFirstName; }
            set { m_UserFirstName = value; }
        }

        /// <summary>
        /// The surname of the person making the booking
        /// </summary>
        public string UserSurname
        {
            get { return m_UserSurname; }
            set { m_UserSurname = value; }
        }

       /// <summary>
       /// The username of the person making the booking
       /// </summary>
        public string MemberUsername
        {
            get { return m_MemberUsername; }
            set { m_MemberUsername = value; }
        }
        /// <summary>
        /// The type of booking
        /// </summary>
        public BookingType BookingType
        {
            get { return m_BookingType; }
            set { m_BookingType = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for the base class
        /// </summary>
        /// <param name="pBookingID"></param>
        /// <param name="pBookingDate"></param>
        /// <param name="pFirstname">First name of the person making the booking</param>
        /// <param name="pSurname">Surname of the person making the booking</param>
        /// <param name="pUsername">Username of the person making the booking</param>
        protected Booking(int pBookingID,DateTime pBookingDate, string pFirstname, string pSurname, string pUsername, string pBookingNotes)
        {
            BookingID = pBookingID;
            BookingDate = pBookingDate;
            UserFirstName = pFirstname;
            UserSurname = pSurname;
            MemberUsername = pUsername;
            if (pBookingNotes == null)
            {
                BookingNotes = "";
            }
            else
            {
                BookingNotes = pBookingNotes;
            }
        }
        #endregion

        #region XML
        #region ID Number Management
        public static int NextID
        {
            get
            {
                string filename = StorageLocation.Bookings;
                XDocument bookingsFile = XDocument.Load(filename);
                int output = int.Parse(bookingsFile.Root.Element("nextID").Value);
                IncrementID(output);
                return output;
            }
        }

        private static void IncrementID(int pOriginal)
        {
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            int newID = pOriginal+ 1;
            bookingsFile.Root.Element("nextID").Value = newID.ToString();
            bookingsFile.Save(filename);
        }

        #endregion

        #region Delete Booking
        /// <summary>
        /// Delete the selected booking from the file system
        /// </summary>
        /// <param name="pBookingID">The Id number of the booking to delete</param>
        /// <exception cref="BookingNotFoundException">Thrown if no booking is found with the supplied booking ID</exception>
        public static void Delete(int pBookingID)
        {
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            foreach(XElement element in bookingsFile.Root.Elements())
            {
                foreach(XElement booking in element.Elements("booking"))
                {
                    if (booking.Element("bookingID").Value == pBookingID.ToString())
                    {
                        booking.Remove();
                        bookingsFile.Save(filename);
                        return;
                    }
                }
            }
            throw new BookingNotFoundException($"No bookings found with ID number: {pBookingID.ToString()}");
        }
        #endregion

        public abstract void Save();
        #endregion

        #region IComparable
        public int CompareTo(Booking other)
        {
            return BookingDate.CompareTo(other.BookingDate);
        }

        #endregion

        #region BookingType Handler
        /// <summary>
        /// Parse a string into BookingType
        /// </summary>
        /// <param name="pString">The string to parse</param>
        /// <exception cref="BookingTypeException">Thrown if the string provided is not a valid booking type</exception>
        public static BookingType ParseBookingType(string pString)
        {
            switch (pString)
            {
                case "RoomBooking": return BookingType.RoomBooking;
                case "PTBooking": return BookingType.PTBooking;
                case "EventBooking": return BookingType.EventBooking;
                default: throw new BookingTypeException($"{pString} is not a valid booking type");
            }
        }
        #endregion
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(BookingDate.ToShortDateString());
            builder.Append(": ");
            return builder.ToString();
        }

    }








}
