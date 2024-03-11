using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace LTSXML
{
    public class PTBooking : Booking
    {
        #region Fields
        /// <summary>
        /// First name of the personal trainer
        /// </summary>
        public string PTFirstName { get; set; }
        /// <summary>
        /// Surname of the personal trainer
        /// </summary>
        public string PTSurname { get; set; }
        /// <summary>
        /// The username of the personal trainer
        /// </summary>
        public string PTUsername { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Object for storing details of a personal trainer booking
        /// </summary>
        /// <param name="pUserFirstname">The first name of the user making the booking</param>
        /// <param name="pUserSurname">The surname of the person making the booking</param>
        /// <param name="pMemberUsername">The username of the user making the booking</param>
        /// <param name="pPTUsername">The username of the personal trainer</param>
        /// <param name="pPTFirstname">The first name of the personal trainer</param>
        /// <param name="pPTSurname">The surname of the personal trainer</param>
        public PTBooking(DateTime pBookingDate, string pUserFirstname, string pUserSurname, string pMemberUsername, string pPTUsername, string pPTFirstname, string pPTSurname, string pBookingNotes) : this(NextID, pBookingDate,pUserFirstname, pUserSurname, pMemberUsername, pPTUsername, pPTFirstname, pPTSurname, pBookingNotes)
        {
        }

        private PTBooking(int pBookingID, DateTime pBookingDate, string pUserFirstname, string pUserSurname, string pMemberUsername, string pPTUsername, string pPTFirstname, string pPTSurname, string pBookingNotes) : base(pBookingID, pBookingDate, pUserFirstname, pUserSurname, pMemberUsername, pBookingNotes)
        {
            BookingType = BookingType.PTBooking;
            PTUsername = pPTUsername;
            PTFirstName = pPTFirstname;
            PTSurname = pPTSurname;
        }
        #endregion

        #region XML
        #region Save
        /// <summary>
        /// Save this element to the XML file, overwriting if it already exists
        /// </summary>
        public override void Save()
        {
            string filename = StorageLocation.Bookings;
            XDocument eventsFile = XDocument.Load(filename);
            if (Exists())
            {
                List<XElement> ptBookings = eventsFile.Root.Element("PTBookings").Elements("booking").ToList();
                foreach(XElement element in ptBookings)
                {
                    if (element.Element("bookingID").Value == BookingID.ToString())
                    {
                        element.Remove();
                        eventsFile.Root.Element("PTBookings").Add(Compose());
                        eventsFile.Save(filename);
                        return;
                    }
                }
            }
            else
            {
                eventsFile.Root.Element("PTBookings").Add(Compose());
                eventsFile.Save(filename);
            }
        }

        /// <summary>
        /// Check if a record already exists and needs ovewriting
        /// </summary>
        private bool Exists()
        {
            string filename = StorageLocation.Bookings;
            XDocument eventsfile = XDocument.Load(filename);
            List<XElement> ptBookings = eventsfile.Root.Element("PTBookings").Elements("booking").ToList();
            for(int i = 0; i < ptBookings.Count; i++)
            {
                if (ptBookings[i].Element("bookingID").Value == BookingID.ToString()) return true;
            }
            return false;
        }

        /// <summary>
        /// Compose the current instance of the PTBooking object into an XML element for writing to file
        /// </summary>
        private XElement Compose()
        {
            return new XElement("booking",
                new XElement("bookingID", BookingID),
                new XElement("date", BookingDate),
                new XElement("userFirstName", UserFirstName),
                new XElement("userSurname", UserSurname),
                new XElement("memberUsername", MemberUsername),
                new XElement("PTUsername", PTUsername),
                new XElement("PTFirstName", PTFirstName),
                new XElement("PTSurname", PTSurname),
                new XElement("bookingNotes", BookingNotes),
                new XElement("bookingType", BookingType));
        }
        #endregion

        #region Load
        /// <summary>
        /// Return a list populated with PTBookings matching the specified criteria
        /// </summary>
        /// <param name="pUsername">Username to search for</param>
        /// <param name="pDate">Date to search for</param>
        /// <exception cref="BookingNotFoundException">Thrown if no records are found with the matching criteria</exception>
        /// <exception cref="BookingTypeException"></exception>
        public static List<PTBooking> Load(string pUsername, DateTime pDate)
        {
            string filename = StorageLocation.Bookings;
            List<PTBooking> output = new List<PTBooking>();
            XDocument bookingsFile = XDocument.Load(filename);
            XElement ptBookings = bookingsFile.Root.Element("PTBookings");
            foreach(XElement element in ptBookings.Elements("booking"))
            {
                if(element.Element("memberUsername").Value == pUsername && DateTime.Parse(element.Element("date").Value).Date == pDate)
                {
                    output.Add(Compose(element));
                }
            }
            
              return output;
            
        }

        /// <summary>
        /// Return a list of all the PT Bookings in the file system
        /// </summary>
        /// <exception cref="BookingTypeException"></exception>
        public static List<PTBooking> Load()
        {
            List<PTBooking> output = new List<PTBooking>();
            string filename = StorageLocation.Bookings;
            XDocument bookingsFile = XDocument.Load(filename);
            XElement ptBookings = bookingsFile.Root.Element("PTBookings");
            foreach(XElement element in ptBookings.Elements("booking"))
            {
                output.Add(Compose(element));
            }
            return output;
        }

        /// <summary>
        /// Return a list of all the bookings occuring on a certain date
        /// </summary>
        /// <param name="pBookingDate">The date to check</param>
        /// <exception cref="BookingTypeException"></exception>
        public static List<PTBooking> Load(DateTime pBookingDate)
        {
            string filename = StorageLocation.Bookings;
            List<PTBooking> output = new List<PTBooking>();
            XDocument eventsFile = XDocument.Load(filename);
            List<XElement> ptBookings = eventsFile.Root.Element("PTBookings").Elements("booking").ToList();
            foreach(XElement element in ptBookings)
            {
                if (DateTime.Parse(element.Element("date").Value).Date == pBookingDate)
                {
                    output.Add(Compose(element));
                }
            }
            return output;
        }

        /// <summary>
        /// Returns a populated PTBooking object from the program filesystem using the supplied ID number
        /// </summary>
        /// <param name="pBookingID">The ID of the booking to load</param>
        /// <exception cref="BookingNotFoundException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="BookingTypeException"></exception>
        public static PTBooking Load(int pBookingID)
        {
            string filename = StorageLocation.Bookings;
            if (!File.Exists(filename)) throw new FileNotFoundException("Bookings file not found");
            XDocument eventsFile = XDocument.Load(filename);
            List<XElement> eventsList = eventsFile.Root.Element("PTBookings").Elements("booking").ToList();
            foreach(XElement element in eventsList)
            {
                if (element.Element("bookingID").Value == pBookingID.ToString()) return Compose(element);
            }
            throw new BookingNotFoundException();
        }

        /// <summary>
        /// Return a new PTBooking object populated from the supplied XML element
        /// </summary>
        /// <param name="pElement">The element to compose the PTBooking from</param>
        /// <exception cref="BookingTypeException"></exception>
        private static PTBooking Compose(XElement pElement)
        {
            int bookingID = int.Parse(pElement.Element("bookingID").Value);
            DateTime bookingDate = DateTime.Parse(pElement.Element("date").Value);
            string userFirstName = pElement.Element("userFirstName").Value;
            string userSurname = pElement.Element("userSurname").Value;
            string memberUsername = pElement.Element("memberUsername").Value;
            string ptUsername = pElement.Element("PTUsername").Value;
            string ptFirstName = pElement.Element("PTFirstName").Value;
            string ptSurname = pElement.Element("PTSurname").Value;
            string bookingNotes = pElement.Element("bookingNotes").Value;
            return new PTBooking(bookingID, bookingDate, userFirstName, userSurname, memberUsername, ptUsername, ptFirstName, ptSurname, bookingNotes);
        }
        #endregion
        #endregion

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(base.ToString());
            builder.Append("PT Booking: ");
            builder.Append(PTFirstName);
            builder.Append(" ");
            builder.Append(PTSurname);
            return builder.ToString();
        }
    }
}
