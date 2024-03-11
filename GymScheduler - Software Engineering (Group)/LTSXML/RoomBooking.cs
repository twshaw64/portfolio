using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LTSXML
{
    public class RoomBooking : Booking
    {
        #region Member Variables 
        private string m_Room;
        #endregion

        #region Fields
        public string Room
        {
            get
            {
                return m_Room;
            }
            set { m_Room = value; }
        }
        #endregion

        #region Constructor 
        public RoomBooking(DateTime pBookingDate, string pFirstname, string pSurname, string pUsername, string pRoom, string pBookingNotes) : this(NextID, pBookingDate, pFirstname, pSurname, pUsername, pRoom, pBookingNotes)
        {
        }

        private RoomBooking(int pBookingID, DateTime pBookingDate, string pFirstname, string pSurname, string pUsername, string pRoom, string pBookingNotes) : base(pBookingID, pBookingDate, pFirstname, pSurname, pUsername, pBookingNotes)
        {
            BookingType = BookingType.RoomBooking;
            m_Room = pRoom;
        }
        #endregion

        #region XML
        #region Save
        /// <summary>
        /// Save the current instance of the object to the file system
        /// </summary>
        public override void Save()
        {
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            XElement roomBookings = bookingsFile.Root.Element("roomBookings");
            foreach (XElement element in roomBookings.Elements("booking"))
            {
                if(element.Element("bookingID").Value == BookingID.ToString())
                {
                    element.Remove();
                    roomBookings.Add(Compose());
                    bookingsFile.Save(filename);
                    return;
                }
            }
            roomBookings.Add(Compose());
            bookingsFile.Save(filename);
        }

        /// <summary>
        /// Return an XML element from the current instance of the object
        /// </summary>
        private XElement Compose()
        {
            return new XElement("booking",
                new XElement("bookingID", BookingID),
                new XElement("date", BookingDate),
                new XElement("userFirstName", UserFirstName),
                new XElement("userSurname", UserSurname),
                new XElement("username", MemberUsername),
                new XElement("room", Room),
                new XElement("bookingNotes", BookingNotes),
                new XElement("bookingType", BookingType));
        }
        #endregion
        #region Load
        /// <summary>
        /// Returns a list populated with RoomBooking objects from the specified criteria
        /// </summary>
        /// <param name="pUsername">The username to search for</param>
        /// <param name="pDate">The date to search for</param>
        /// <exception cref="BookingNotFoundException">Thrown if no bookings are found matching the specified criteria</exception>
        /// <exception cref="BookingTypeException"></exception>
        public static List<RoomBooking> Load(string pUsername, DateTime pDate)
        {
            string filename = StorageLocation.Bookings;
            List<RoomBooking> output = new List<RoomBooking>();
            XDocument bookingsFile = XDocument.Load(filename);
            XElement roomBookings = bookingsFile.Root.Element("roomBookings");
            foreach(XElement element in roomBookings.Elements("booking"))
            {
                if(element.Element("username").Value == pUsername && DateTime.Parse(element.Element("date").Value) == pDate)
                {
                    output.Add(Compose(element));
                }
            }
            if(output.Count == 0)
            {
                throw new BookingNotFoundException("No bookings found matching the specified criteria");
            }
            else
            {
                return output;
            }
        }
        /// <summary>
        /// Return a list of all the room bookings on file
        /// </summary>
        /// <exception cref="BookingTypeException"></exception>
        public static List<RoomBooking> Load()
        {
            string filename = StorageLocation.Bookings;
            List<RoomBooking> output = new List<RoomBooking>();
            XDocument bookingsFile = XDocument.Load(filename);
            XElement roomBookings = bookingsFile.Root.Element("roomBookings");
            foreach (XElement element in roomBookings.Elements("booking"))
            {
                output.Add(Compose(element));
            }
            return output;
        }

        /// <summary>
        /// return a list of all the room bookings on the selected date
        /// </summary>
        /// <param name="pBookingDate">The date to search for</param>
        /// <exception cref="BookingNotFoundException">Thrown if there are no bookings found on the selected date</exception>
        /// <exception cref="BookingTypeException"></exception>
        public static List<RoomBooking> Load(DateTime pBookingDate)
        {
            string filename = StorageLocation.Bookings;
            List<RoomBooking> output = new List<RoomBooking>();
            XDocument bookingsFile = XDocument.Load(filename);
            XElement roomBookings = bookingsFile.Root.Element("roomBookings");
            foreach(XElement element in roomBookings.Elements("booking"))
            {
                if(DateTime.Parse(element.Element("date").Value).Date == pBookingDate)
                {
                    output.Add(Compose(element));
                }
            }
            
            return output;
        }

        /// <summary>
        /// Return a populated RoomBooking object with the booking ID supplied
        /// </summary>
        /// <param name="pBookingID">The booking ID to load</param>
        /// <exception cref="BookingNotFoundException">Thrown if the bookingID is not found in the file system</exception>
        /// <exception cref="BookingTypeException"></exception>
        public static RoomBooking Load(int pBookingID)
        {
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            XElement roomBookings = bookingsFile.Root.Element("roomBookings");
            foreach(XElement element in roomBookings.Elements("booking"))
            {
                if (element.Element("bookingID").Value == pBookingID.ToString())
                {
                    return Compose(element);
                }
            }
            throw new BookingNotFoundException();
        }

        /// <summary>
        /// Compose a RoomBooking object from the supplied XML element
        /// </summary>
        /// <param name="pElement">The XML element to generate RoomBooking from</param>
        /// <exception cref="BookingTypeException"></exception>
        private static RoomBooking Compose(XElement pElement)
        {
            int bookingID = int.Parse(pElement.Element("bookingID").Value);
            DateTime date = DateTime.Parse(pElement.Element("date").Value);
            string userFirstName = pElement.Element("userFirstName").Value;
            string userSurname = pElement.Element("userSurname").Value;
            string username = pElement.Element("username").Value;
            string room = pElement.Element("room").Value;
            string bookingNotes = pElement.Element("bookingNotes").Value;
            return new RoomBooking(bookingID, date, userFirstName, userSurname, username, room, bookingNotes);
        }
        #endregion
        #endregion
      
        public override string ToString()
        {
            TimeSpan hour = new TimeSpan(1, 0, 0);
            return base.BookingDate.TimeOfDay + "-" + (base.BookingDate.TimeOfDay+ hour) + " " + Room;
        }
    }
}
