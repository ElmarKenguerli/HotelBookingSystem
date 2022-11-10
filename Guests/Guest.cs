using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Guests
{
    public class Guest
    {
        private string id;
        private string name;
        private string address;
        private string phone;
        private double deposit;
        private int daysBooked;

        public int DaysBooked
        {
            get { return daysBooked; }
            set { daysBooked = value; }
        }
        public double Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        public string GuestID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Guest()
        {

        }
    }
}
