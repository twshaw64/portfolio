using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LTSXML
{
    public class EventBooking : Booking
    {
        #region Private Member Variables 
        private string m_EventName;
        private List<string> mAttendees;
        #endregion

        #region Fields
        /// <summary>
        /// Event name and description
        /// </summary>
        public string EventName
        {
            get { return m_EventName; }
            set { m_EventName = value; }
        }
        /// <summary>
        /// Read only list of Attendees. Use AddAttendee to add a user
        /// </summary>
        public List<string> Attendees
        {
            get
            {
                return mAttendees;
            }
        }
        /// <summary>
        /// Add a username to the list of attendees
        /// </summary>
        /// <param name="pUsername">The username to add</param>
        /// <exception cref="KeyNotFoundException">Thrown if the username is not valid</exception>
        public void AddAttendee(string pUsername)
        {
            try
            {
                UserDetails.Load(pUsername);
            }catch(KeyNotFoundException ex)
            {
                throw new KeyNotFoundException("Username not found. Cannot add to attendee list");
            }
            mAttendees.Add(pUsername);
        }
        #endregion

        #region Constructor 
        public EventBooking(int pBookingID, DateTime pBookingDate, string pUserFirstname, string pUserSurname, string pUsername, string pEventName, List<string> pAttendees) : base(pBookingID, pBookingDate, pUserFirstname, pUserSurname, pUsername)
        {
            m_EventName = pEventName;
            mAttendees = pAttendees;
        }
        #endregion

        #region XML
        #region Save
        /// <summary>
        /// Save the current instance of this object to the file system
        /// </summary>
        public void Save()
        {
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            XElement eventBookings = bookingsFile.Root.Element("eventBookings");
            if (Exists())
            {
                foreach(XElement element in eventBookings.Elements("booking"))
                {
                    if (element.Element("bookingID").Value == BookingID.ToString())
                    {
                        element.Remove();
                        eventBookings.Add(Compose());
                        bookingsFile.Save(filename);
                        return;
                    }
                }
            }
            else
            {
                eventBookings.Add(Compose());
                bookingsFile.Save(filename);
            }
        }

        /// <summary>
        /// Check if a record already exists.
        /// Returns true if the element exists
        /// </summary>
        private bool Exists()
        {
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            XElement eventBookings = bookingsFile.Root.Element("eventBookings");
            foreach (XElement element in eventBookings.Elements("booking"))
            {
                if (element.Element("bookingID").Value == BookingID.ToString()) return true;
            }
            return false;
        }

        /// <summary>
        /// Compose an XML element from the current object
        /// </summary>
        private XElement Compose()
        {
            return new XElement("booking",
                        new XElement("bookingID", BookingID),
                        new XElement("date", BookingDate.ToShortDateString()),
                        new XElement("userFirstName", UserFirstName),
                        new XElement("userSurname", UserSurname),
                        new XElement("username", MemberUsername),
                        new XElement("eventName", EventName),
                        new XElement(ComposeAttendees()));
        }

        private XElement ComposeAttendees()
        {
            XElement output = new XElement("attendees");
            foreach(string attendee in Attendees)
            {
                output.Add(new XElement("attendee", attendee));
            }
            return output;
        }
        #endregion

        #region Load
        /// <summary>
        /// Returns a list populated with EventBooking objects matching the username and date provided
        /// </summary>
        /// <param name="pUsername">The username to search for</param>
        /// <param name="pDate">The date to search for</param>
        /// <exception cref="BookingNotFoundException">Thrown if there are no bookings found matching the given criteria</exception>
        public static List<EventBooking> Load(string pUsername, DateTime pDate)
        {
            List<EventBooking> output = new List<EventBooking>();
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            XElement eventBookings = bookingsFile.Root.Element("eventBookings");
            foreach(XElement element in eventBookings.Elements("booking"))
            {
                if(DateTime.Parse(element.Element("date").Value) == pDate&&element.Element("username").Value == pUsername)
                {
                    output.Add(Compose(element));
                }
            }
            if(output.Count != 0)
            {
                return output;
            }
            else
            {
                throw new BookingNotFoundException("No bookings found matching the specified criteria");
            }
        }

        /// <summary>
        /// Return a list populated with all the event bookings on file
        /// </summary>
        /// <exception cref="BookingNotFoundException">Thrown if no bookings are on file</exception>
        public static List<EventBooking> Load()
        {
            List<EventBooking> output = new List<EventBooking>();
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            XElement eventBookings = bookingsFile.Root.Element("eventBookings");
            foreach(XElement element in eventBookings.Elements("booking"))
            {
                output.Add(Compose(element));
            }
            if (output.Count == 0) throw new BookingNotFoundException("No bookings found");
            return output;
        }

        /// <summary>
        /// Return a list populated with all the events happening on a set date
        /// </summary>
        /// <param name="pEventDate">The date to search for</param>
        /// <exception cref="BookingNotFoundException">Thrown if no bookings are found on the specified date</exception>
        public static List<EventBooking> Load(DateTime pEventDate)
        {
            List<EventBooking> output = new List<EventBooking>();
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            XElement eventBookings = bookingsFile.Root.Element("eventBookings");
            foreach (XElement element in eventBookings.Elements("booking"))
            {
                if(DateTime.Parse(element.Element("date").Value) == pEventDate)
                {
                    output.Add(Compose(element));
                }
            }
            if (output.Count == 0) throw new BookingNotFoundException("No bookings found on that date");
            return output;
        }

        /// <summary>
        /// Returns an EventBooking object from the file system with with the supplied booking ID
        /// </summary>
        /// <param name="pBookingID">The ID number of the booking to load</param>
        /// <exception cref="BookingNotFoundException"/>
        public static EventBooking Load(int pBookingID)
        {
            string filename = StorageLocation.Bookings;
            XDocument eventsFile = XDocument.Load(filename);
            XElement eventBookings = eventsFile.Root.Element("eventBookings");
            foreach(XElement element in eventBookings.Elements("booking"))
            {
                if (element.Element("bookingID").Value == pBookingID.ToString()) return Compose(element);
            }
            throw new BookingNotFoundException();
        }

        /// <summary>
        /// Returns a populated EventBooking object from the supplied XML element
        /// </summary>
        /// <param name="pElement">Element to generate the object from</param>
        private static EventBooking Compose(XElement pElement)
        {
            int bookingID = int.Parse(pElement.Element("bookingID").Value);
            DateTime bookingDate = DateTime.Parse(pElement.Element("date").Value);
            string userFirstName = pElement.Element("userFirstName").Value;
            string userSurname = pElement.Element("userSurname").Value;
            string username = pElement.Element("username").Value;
            string eventName = pElement.Element("eventName").Value;
            List<string> attendees = ComposeAttendees(pElement.Element("attendees"));
            return new EventBooking(bookingID, bookingDate, userFirstName, userSurname, username, eventName, attendees);
        }

        /// <summary>
        /// Compose a list of attendees from the supplied XML element
        /// </summary>
        /// <param name="pElement">Element containing the attendees</param>
        private static List<string> ComposeAttendees(XElement pElement)
        {
            List<string> output = new List<string>();
            foreach(XElement element in pElement.Elements("attendee"))
            {
                output.Add(element.Value);
            }
            return output;
        }
        #endregion

        #endregion

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(base.ToString());
            builder.Append(EventName);
            return builder.ToString();
        }
    }
}
