using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Phumla_Kamnandi_Hotel.DatabaseLayer;

namespace Phumla_Kamnandi_Hotel.Guests
{
    public class GuestController
    {
        GuestDB guestDB;
        Collection<Guest> guests;

        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }
        public GuestController()
        {
            guestDB = new GuestDB();
            guests = guestDB.AllGuests;
        }
        public void DataMaintenance(Guest guest, DB.DBOperation operation)
        {
            int index = 0;
            guestDB.ChangeDataSet(guest, operation);
            switch (operation)
            {
                case DB.DBOperation.Add:
                    guests.Add(guest);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(guest);
                    guests[index] = guest;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(guest);
                    guests.RemoveAt(index);
                    break;
            }
        }
        public bool FinalizeChanges(Guest guest)
        {
            return guestDB.UpdateDataSource();
        }
        public Guest Find(string GuestID)
        {
            int index = 0;
            bool found = (guests[index].GuestID == GuestID);
            int count = guests.Count;
            while (!(found) && (index < guests.Count - 1))
            {
                index = index + 1;
                found = (guests[index].GuestID == GuestID);
            }
            return guests[index];
        }
        public int FindIndex(Guest guest)
        {
            int counter = 0;
            bool found = false;
            found = (guest.GuestID == guests[counter].GuestID);
            while (!(found) & counter < guests.Count - 1)
            {
                counter += 1;
                found = (guest.GuestID == guests[counter].GuestID);
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