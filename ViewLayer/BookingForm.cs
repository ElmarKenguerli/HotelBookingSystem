using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_Hotel.DatabaseLayer;
using Phumla_Kamnandi_Hotel.Bookings;
using Phumla_Kamnandi_Hotel.Guests;

namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    public partial class BookingForm : Form
    {
        private Booking booking;
        private BookingController bookingController;
        private GuestController guestController;
        public bool bookingFormClosed = false;
        public BookingForm(BookingController aController, GuestController gController)
        {
            InitializeComponent();
            bookingController = aController;
            guestController = gController;
        }
        private void ShowAll(bool value)
        {
            headerlbl.Visible = value;
            inputpnl.Visible = value;
            inputpnl2.Visible = value;
            bookingLbl.Visible = value;
            availableLbl.Visible = value;
            roomNlbl.Visible = value;
            roomCB.Visible = value;
            BookingIDLabel.Visible = value;
            GuestIDLabel.Visible = value;
            SignInDateLabel.Visible = value;
            SignOutDateLabel.Visible = value;
            //TextBoxes
            BookingIDTextBox.Visible = value;
            GuestIDTextBox.Visible = value;
            signIndtp.Visible = value;
            signOutdtp.Visible = value;
            BookingIDTextBox.Enabled = false;
            roomCB.Enabled = false;
            GuestIDTextBox.Enabled = false;
            SubmitButton.Enabled = false;
            depositBtn.Visible = false;
        }

        private void ClearAll()
        {
            BookingIDTextBox.Text = "";
            GuestIDTextBox.Text = "";
            signIndtp.ResetText();
            signOutdtp.ResetText();
            roomCB.Items.Clear();

        }
        private void Populate()
        { 
            DateTime start = signIndtp.Value;
            DateTime end = signOutdtp.Value;
            int numDays = (int)(end - start).TotalDays;
            double totalPay = 0; 
            booking = new Booking();

            foreach (DateTime date in EachDay(start, end))
            {
                if(date.Day >= 1 && date.Day <= 7)
                {
                    totalPay += 550;
                }
                if (date.Day >= 8 && date.Day <= 15)
                {
                    totalPay += 750;
                }
                if (date.Day >= 16 && date.Day <= 31)
                {
                    totalPay += 995;
                }
            }
            booking.DepositPaid = "no";
            booking.GuestID = GuestIDTextBox.Text;
            booking.BookingID = BookingIDTextBox.Text;
            booking.SignInDate = signIndtp.Value;
            booking.SignOutDate = signOutdtp.Value;
            booking.Rate = totalPay;
            booking.RoomID = roomCB.SelectedItem.ToString();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            ShowAll(true);
            ClearAll();

        }
        public static bool isNumeric(string s)
        {
            return int.TryParse(s, out int n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookingFormClosed = true;
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(BookingIDTextBox.Text == "" || GuestIDTextBox.Text == "" || roomCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please make sure all booking information is complete!");
            }
            else
            {
                if(isNumeric(BookingIDTextBox.Text) && isNumeric(GuestIDTextBox.Text))
                {
                    //POPULATE BOOKING OBJECT   
                    Populate();

                    //UPDATE OCCUPANCY 
                    bookingController.AllRooms.ElementAt(Int16.Parse(booking.RoomID)-1).setToBooked(booking.SignInDate, booking.SignOutDate);

                    MessageBox.Show("Data to be submitted to the Database!");
                    bookingController.DataMaintenance(booking, DB.DBOperation.Add);
                    bookingController.FinalizeChanges(booking);
                    ClearAll();
                    ShowAll(true);
                    signIndtp.Enabled = true;
                    signOutdtp.Enabled = true;
                    depositBtn.Visible = true;
                }
                else
                {
                    MessageBox.Show("To proceed, please make sure Booking ID and Guest ID are numbers! ");
                }
                
            }
            
        }

        private void BookingForm_Activated(object sender, EventArgs e)
        {
            ShowAll(true);
        }

        public IEnumerable<DateTime> EachDay(DateTime start, DateTime end)
        {
            for (var day = start.Date; day.Date <= end.Date; day = day.AddDays(1))
                yield return day;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            DateTime start = signIndtp.Value;
            DateTime end = signOutdtp.Value;
            String[] availRooms = new String[5];
            int counter = 0;
            bool roomFound = false;

            foreach (Rooms room in bookingController.AllRooms)
            {

                if(room.isAvailable(start, end))
                {
                    availRooms[counter] = room.RoomID;
                    roomFound = true;
                }
                else
                {
                    availRooms[counter] = "no";
                }
                counter++;
            }

            if(roomFound)
            {
                RoomAvailabilityLbl.Text = "Room/s available! Make booking below.";
                BookingIDTextBox.Enabled = true;
                roomCB.Enabled = true;
                GuestIDTextBox.Enabled = true;
                SubmitButton.Enabled = true;
                for (int i = 0; i < 5; i++)
                {
                    if(availRooms[i]!="" && availRooms[i] != "no")
                    {
                        roomCB.Items.Add(availRooms[i]);
                    }
                }
                signIndtp.Enabled = false;
                signOutdtp.Enabled = false;
            }
            else
            {
                MessageBox.Show("Unavailable", "Unforunately no rooms unavailable on the selected dates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                ShowAll(true);
            }
        
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            string deposit = "The deposit amount is: " + booking.Rate * 0.1 + " \n Do you want to pay now?" ;
            DialogResult result = MessageBox.Show(deposit, "Deposit Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                booking.DepositPaid = "yes";
            }
            else
            {
                //do nothing
            }
        }
    }
}
