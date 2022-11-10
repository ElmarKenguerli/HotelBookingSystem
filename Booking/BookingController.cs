using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Phumla_Kamnandi_Hotel.DatabaseLayer;

namespace Phumla_Kamnandi_Hotel.Bookings
{
    public class BookingController
    {
        BookingDB bookingDB;
        Collection<Booking> bookings;
        Collection<Rooms> rooms = new Collection<Rooms>();

        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }

        public Collection<Rooms> AllRooms
        {
            get { return rooms; }
        }
        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;

            //adding rooms to room collection
            rooms.Add(new Rooms("1"));
            rooms.Add(new Rooms("2"));
            rooms.Add(new Rooms("3"));
            rooms.Add(new Rooms("4"));
            rooms.Add(new Rooms("5"));

            foreach (Booking booking in bookings)
            {
                switch(booking.RoomID)
                {
                    case "1":
                        rooms[0].setToBooked(booking.SignInDate, booking.SignOutDate);
                        break;
                    case "2":
                        rooms[1].setToBooked(booking.SignInDate, booking.SignOutDate);
                        break;
                    case "3":
                        rooms[2].setToBooked(booking.SignInDate, booking.SignOutDate);
                        break;
                    case "4":
                        rooms[3].setToBooked(booking.SignInDate, booking.SignOutDate);
                        break;
                    case "5":
                        rooms[4].setToBooked(booking.SignInDate, booking.SignOutDate);
                        break;

                }
            }
        }
        public void DataMaintenance(Booking booking, DB.DBOperation operation)
        {
            int index = 0;
            bookingDB.ChangeDataSet(booking, operation);
            switch (operation)
            {
                case DB.DBOperation.Add:
                    bookings.Add(booking);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(booking);
                    bookings[index] = booking;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(booking);
                    bookings.RemoveAt(index);
                    break;
            }
        }
        
        public bool FinalizeChanges(Booking booking)
        {
            return bookingDB.UpdateDataSource();
        }
        public Booking Find(string BookingID)
        {
            int index = 0;
            bool found = (bookings[index].BookingID == BookingID);
            int count = bookings.Count;
            while (!(found) && (index < bookings.Count - 1))
            {
                index = index + 1;
                found = (bookings[index].BookingID == BookingID);
            }
            return bookings[index];
        }
        public int FindIndex(Booking booking)
        {
            int counter = 0;
            bool found = false;
            found = (booking.BookingID == bookings[counter].BookingID);
            while (!(found) & counter < bookings.Count - 1)
            {
                counter += 1;
                found = (booking.BookingID == bookings[counter].BookingID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

    }
}
