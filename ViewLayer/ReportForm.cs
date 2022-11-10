using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Phumla_Kamnandi_Hotel.Bookings;
using Phumla_Kamnandi_Hotel.DatabaseLayer;
using System.Collections.ObjectModel;


namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    public partial class ReportForm : Form
    {
        Booking booking;
        public bool roomsFormClosed;
        private Collection<Booking> bookings;
        private BookingController bookingController;
        BookingDB database = new BookingDB();
        //DateTime date;
        public ReportForm(BookingController aController)
        {
            InitializeComponent();
            bookingController = aController;
            bookings = bookingController.AllBookings; 
        }


        private void RoomsForm_Load(object sender, EventArgs e)
        {
            
            reportTxt.Text = "";
        }

        private void RoomsForm_Activated(object sender, EventArgs e)
        {
            reportTxt.Text = "";
        }

        private void RoomsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            roomsFormClosed = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            revenueBtn.Enabled = true;
            string output;
            //counts per room
            int room1 = 0;
            int room2 = 0;
            int room3 = 0;
            int room4 = 0;
            int room5 = 0;
            //totalcount
            int totalOccupancy = 0;
            //dates for search
            DateTime startday ;
            DateTime endday;

            DateTime bookingStart, bookingEnd;

            if (fromDateP.Checked && toDateP.Checked)
            {
                //dates for search
                startday = fromDateP.Value.Date;
                endday = toDateP.Value.Date;


                foreach (Booking booking in bookings)
                {
                    bookingStart = booking.SignInDate.Date;
                    bookingEnd = booking.SignOutDate.Date;
                    foreach (DateTime day in EachDay(bookingStart, bookingStart))
                    {
                        if (day >= startday && day <= endday)
                        {
                            totalOccupancy++;
                            switch (booking.RoomID)
                            {
                                case "1":
                                    room1++;
                                    break;
                                case "2":
                                    room2++;
                                    break;
                                case "3":
                                    room3++;
                                    break;
                                case "4":
                                    room4++;
                                    break;
                                case "5":
                                    room5++;
                                    break;
                            }
                        }
                    }

                }

                //fill output string
                output = "Occupancy report for:   " + startday.ToString("D") + "   to   " + endday.ToString("D") + "\n" +
                        "____________________________________________________________________________" + "\n\n" +
                        "Occupancy level per room: " + "\n" +
                        "Room 1 : " + room1 + " bookings" + "\n" +
                        "Room 2 : " + room2 + " bookings" + "\n" +
                        "Room 3 : " + room3 + " bookings" + "\n" +
                        "Room 4 : " + room4 + " bookings" + "\n" +
                        "Room 5 : " + room5 + " bookings" + "\n\n" +
                        "Total Occupancy for the period: " + "\n" +
                        totalOccupancy + " bookings"
                        ;
                reportTxt.Text = "";
                reportTxt.Text = output;
                
            }
            else
            {
                MessageBox.Show("Please select dates for the occupancy report");
            }
            
            
        }

        public IEnumerable<DateTime> EachDay(DateTime start, DateTime end)
        {
            for (var days = start.Date; days.Date <= end.Date; days = days.AddDays(1))
                yield return days;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            roomsFormClosed = true;
            Close();
        }

        private void revenueBtn_Click(object sender, EventArgs e)
        {
            string output = "";
            //counts per room
            double room1 = 0;
            double room2 = 0;
            double room3 = 0;
            double room4 = 0;
            double room5 = 0;

            //totalcount
            double totalrevenue = 0;

            DateTime startday;
            DateTime endday;

            DateTime bookingStart, bookingEnd;
            bool bookingInPeriod = false;
            if (fromDateP.Checked && toDateP.Checked)
            {
                //dates for search
                startday = fromDateP.Value.Date;
                endday = toDateP.Value.Date;
                foreach (Booking booking in bookings)
                {
                    bookingStart = booking.SignInDate.Date;
                    bookingEnd = booking.SignOutDate.Date;
                    foreach (DateTime day in EachDay(bookingStart, bookingStart))
                    {
                        if (day >= startday && day <= endday)
                        {
                            bookingInPeriod = true;                         
                        }
                    }
                    if(bookingInPeriod)
                    {
                        totalrevenue += booking.Rate;
                        switch (booking.RoomID)
                        {

                            case "1":
                                room1+=booking.Rate;
                                break;
                            case "2":
                                room2 += booking.Rate;
                                break;
                            case "3":
                                room3 += booking.Rate;
                                break;
                            case "4":
                                room4 += booking.Rate;
                                break;
                            case "5":
                                room5 += booking.Rate;
                                break;
                        }
                    }

                }

                output = "Revenue report for:   " + startday.ToString("D") + "   to   " + endday.ToString("D") + "\n" +
                        "____________________________________________________________________________" + "\n\n" +
                        "Revenue level per room: " + "\n" +
                        "Room 1 : R " + room1 + "\n" +
                        "Room 2 : R " + room2 +  "\n" +
                        "Room 3 : R " + room3 + "\n" +
                        "Room 4 : R " + room4 + "\n" +
                        "Room 5 : R " + room5 + "\n\n" +
                        "Total Revenue for the period: " + "\n" +
                        "R" +totalrevenue;
                        
                reportTxt.Text = "";
                reportTxt.Text = output;
            }
            else
            {
                MessageBox.Show("Please select dates for the revenue report");
            }

        }
    }
}
