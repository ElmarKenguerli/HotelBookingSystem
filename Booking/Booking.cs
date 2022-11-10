using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_Hotel.Guests;

namespace Phumla_Kamnandi_Hotel.Bookings
{
    public class Booking
    {
        //private int numberOfRooms;
        private string bookingID;
        private string roomID;
        private DateTime signInDate;
        private DateTime signOutDate;
        private double rate;
        private string guestID;
        private string depositPaid;

        //public Booking()
        //{
            
        //}
        public Booking()
        {
            
        }

        
        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public string DepositPaid
        {
            get { return depositPaid; }
            set { depositPaid = value; }
        }

        public string BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }


        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public DateTime SignInDate
        {
            get { return signInDate; }
            set { signInDate = value; }
        }

        public DateTime SignOutDate
        {
            get { return signOutDate; }
            set { signOutDate = value; }
        }
    }
}
