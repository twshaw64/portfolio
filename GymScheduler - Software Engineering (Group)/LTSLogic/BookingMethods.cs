using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTSXML;

namespace LTSLogic
{
    public class BookingMethods
    {
        
        public static string CheckBooking(string pUsername,DateTime pBookingTime,string pRoom,bool Active)
        {
            List<RoomBooking> RoomBookings = new List<RoomBooking>();
            string CantBook = "";
            int counter = 0;
            RoomBookings = RoomBooking.Load();
            if (Active == true)
            {
                foreach (RoomBooking roomBooking in RoomBookings)
                {
                    DateTime date1 = roomBooking.BookingDate.AddDays(-(int)roomBooking.BookingDate.DayOfWeek);
                    DateTime date2 = pBookingTime.AddDays(-(int)pBookingTime.DayOfWeek);
                    //checks to see if you have booked 3 things that week 
                    if (roomBooking.MemberUsername == pUsername && date1.Date == date2.Date)
                    {
                        counter++;
                    }
                    //Checks to see if someone has booked the timeslot you are trying to book 
                    if (roomBooking.BookingDate == pBookingTime && roomBooking.Room == pRoom)
                    {
                        CantBook = "Someone has already booked this timeslot";
                        break;
                    }
                }
            }
            else {
                CantBook = "You are not a paying member";
            }
            if(counter >= 3)
            {
                CantBook = "You have exceeded your weekly booking limit";
            }
            
           
            
            return CantBook;
        }
        public static void FindTypeofBooking(Booking booking)
        {
            int ID = 0;
            ID = booking.BookingID;
        }
        public static string CheckPTBooking(string pUsername,DateTime pBookingTime,string pPTUsername,bool Active)
        {
            List<PTBooking> PTBookings = new List<PTBooking>();
            string CantBook = "";
            int counter = 0;
            PTBookings = PTBooking.Load();
            if (Active == true) { 
                foreach (PTBooking ptBooking in PTBookings)
                {
                    DateTime date1 = ptBooking.BookingDate.AddDays(-(int)ptBooking.BookingDate.DayOfWeek);
                    DateTime date2 = pBookingTime.AddDays(-(int)pBookingTime.DayOfWeek);
                    //checks to see if you have booked 3 things that week 
                    if (ptBooking.MemberUsername == pUsername && date1.Date == date2.Date)
                    {
                        counter++;
                    }
                    //Checks to see if someone has booked the timeslot you are trying to book 
                    if (ptBooking.BookingDate == pBookingTime && ptBooking.PTUsername == pPTUsername)
                    {
                        CantBook = "Someone has already booked this timeslot";
                        break;
                    }
                }
            }
            else{
                CantBook = "You are not a paying member";
            }
            if (counter >= 3)
            {
                CantBook = "You have exceeded your weekly booking limit";
            }

            return CantBook;
        }

            
     }

        
}



    

