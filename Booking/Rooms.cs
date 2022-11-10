using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Bookings
{
    public class Rooms
    {
        private string roomID;
        private string[] daysOfMonth = new string[31];   //"0" value for available ; "1" for unavailable

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public Rooms(string roomID)
        {
            this.roomID = roomID;
            for (int i = 0; i < 31; i++)
            {
                daysOfMonth[i] = "0";
            }
        }

        /*
         * Checks if the room is available for the range of dates given for a booking
         */
        public bool isAvailable (DateTime start, DateTime end)
        {
            int startday = (int)start.Day;
            int endday = (int)end.Day;

            for (int i = startday-1; i < endday; i++)         //-1 for endday as they are signed out on that day and not booked anymore
            {
                if(daysOfMonth[i] == "1")
                {
                    return false;
                }
                    
            }
            return true;
        }

        public void setToBooked(DateTime start, DateTime end)
        {
            int startday = (int)start.Day;
            int endday = (int)end.Day;

            for (int i = startday - 1; i < endday; i++)
            {
                daysOfMonth[i] = "1"; 
            }
            
        }
    }
}
