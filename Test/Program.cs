using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    class Program
    {

        public class Booking
        {
            public int Id;
            public DateTime BookingStart;
            public DateTime BookingEnd;
        }
        public class MeetingRoom
        {
            public bool IsAvailable(DateTime start, DateTime end)
            {
                List<Booking> list =  new List<Booking>() {
                new Booking{Id = 1,BookingStart=DateTime.Parse("2014/01/15 10:00"),BookingEnd=DateTime.Parse("2014/01/15 11:00")},
                new Booking{Id = 2,BookingStart=DateTime.Parse("2014/01/15 13:00"),BookingEnd=DateTime.Parse("2014/01/15 14:30")},
                new Booking{Id = 3,BookingStart=DateTime.Parse("2014/01/15 16:00"),BookingEnd=DateTime.Parse("2014/01/15 17:00")},
                };
                var y = list.Where(x => x.BookingStart<=start && x.BookingEnd >= end).ToList();

                if (y.Count > 0)
                {
                    return true;
                }
                return false;
                }
        }
        static void Main(string[] args)
        {
            MeetingRoom meetingRoom = new MeetingRoom();
            DateTime startDateTime = DateTime.Parse("2014/01/15 10:30");
            DateTime endDateTime = DateTime.Parse("2014/01/15 10:50");

           bool bookingStatus = meetingRoom.IsAvailable(startDateTime, endDateTime);
            string msg = " not available";
            if (bookingStatus)
            {
                msg = " available";
            }
            Console.WriteLine("Booking is" + msg);
        }
    }
}
