using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Phumla_Kamnandi_Hotel.Bookings;
using Phumla_Kamnandi_Hotel.Guests;

namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    public partial class BookingListingForm : Form
    {
        public bool listFormClosed;
        private Collection<Booking> bookings;
        private Booking booking;
        private BookingController bookingController;
        private GuestController guestController;
        private FormStates state;
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }

        public BookingListingForm()
        {
            InitializeComponent();
            this.Load += BookingListingForm_Load;
            this.Activated += BookingListingForm_Activated;
            state = FormStates.View;

        }

        public BookingListingForm(BookingController bController, GuestController gController)
        {
            InitializeComponent();
            bookingController = bController;
            guestController = gController;
            this.Load += BookingListingForm_Load;
            this.Activated += BookingListingForm_Activated;
            state = FormStates.View;

        }

        private void bookingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (bookingListView.SelectedItems.Count > 0)
            {
                booking = bookingController.Find(bookingListView.SelectedItems[0].Text);

                PopulateTextBoxes(booking);
            }
        }

        private void BookingListingForm_Load(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
        }

        private void BookingListingForm_Activated(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
            setUpBookingListView();
            selectlbl.Text = "Select Booking by BookingID";
            ShowAll(false);
        }
        private void ShowAll(bool value)
        {
            if (value)
            {
                selectlbl.Visible = false;
            }
            else
            {
                selectlbl.Visible = true;
            }
            editlbl.Visible = value;
            deletelbl.Visible = value;
            inputPanel.Visible = value;
            BookingIDLabel.Visible = value;
            GuestIDLabel.Visible = value;
            SignInDateLabel.Visible = value;
            SignOutDateLabel.Visible = value;
            PaymentLabel.Visible = value;
            depositLbl.Visible = value;
            //TextBoxes
            BookingIDTextBox.Visible = value;
            GuestIDTextBox.Visible = value;
            signIndtp.Visible = value;
            signOutdtp.Visible = value;
            PaymentTextBox.Visible = value;
            depositTxt.Visible = value;
            if (state == FormStates.Delete)
            {
                CancelButton.Visible = !value;
                SubmitButton.Visible = !value;
            }
            else
            {
                CancelButton.Visible = value;
                SubmitButton.Visible = value;
            }
            CancelBookingButton.Visible = value;
            EditBookingButton.Visible = value;
        }

        private void ClearAll()
        {
            BookingIDTextBox.Text = "";
            GuestIDTextBox.Text = "";
            signIndtp.ResetText();
            signOutdtp.ResetText();
            PaymentTextBox.Text = "";
            depositTxt.Text = "";
        }
        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                GuestIDTextBox.Enabled = !value;
                BookingIDTextBox.Enabled = !value;
            }
            else
            {
                BookingIDTextBox.Enabled = value;
                GuestIDTextBox.Enabled = value;
            }
            signIndtp.Enabled = value;
            signOutdtp.Enabled = value;
            PaymentTextBox.Enabled = value;
            roomNtxt.Enabled = value;
            depositTxt.Enabled = value;
            if (state == FormStates.Delete)
            {
                CancelButton.Visible = !value;
                SubmitButton.Visible = !value;
            }
            else
            {
                CancelButton.Visible = value;
                SubmitButton.Visible = value;
            }
        }
        private void PopulateTextBoxes(Booking booking)
        {
            BookingIDTextBox.Text = booking.BookingID;
            GuestIDTextBox.Text = booking.GuestID;
            signIndtp.Value = booking.SignInDate;
            signOutdtp.Value = booking.SignOutDate;
            PaymentTextBox.Text = Convert.ToString(booking.Rate);
            roomNtxt.Text = Convert.ToString(booking.RoomID);
            depositTxt.Text = booking.DepositPaid;
        }
        private void PopulateObject()
        {
            booking = new Booking();
            booking.GuestID = GuestIDTextBox.Text;
            booking.BookingID = BookingIDTextBox.Text;
            booking.SignInDate = signIndtp.Value;
            booking.SignOutDate = signOutdtp.Value;
            booking.Rate = double.Parse(PaymentTextBox.Text);
            booking.RoomID = roomNtxt.Text;
            booking.DepositPaid = depositTxt.Text;
        }
        public void setUpBookingListView()
        {
            ListViewItem bookingDetails;
            //bookings = null;
            bookingListView.Clear();

            label1.Text = "List of all Bookings";
            bookingListView.Columns.Insert(0, "BookingID", 70, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(1, "GuestID", 70, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(2, "SignInDate", 170, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(3, "SignOutDate", 170, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(4, "Total Price (R)", 100, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(5, "RoomNumber", 90, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(6, "Deposit Paid", 90, HorizontalAlignment.Left);
            bookings = bookingController.AllBookings;

            foreach (Booking booking in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = booking.BookingID.ToString();
                bookingDetails.SubItems.Add(booking.GuestID.ToString());
                bookingDetails.SubItems.Add(booking.SignInDate.Date.ToString("D"));
                bookingDetails.SubItems.Add(booking.SignOutDate.Date.ToString("D"));
                bookingDetails.SubItems.Add(booking.Rate.ToString());
                bookingDetails.SubItems.Add(booking.RoomID.ToString());
                bookingDetails.SubItems.Add(booking.DepositPaid);
                bookingListView.Items.Add(bookingDetails);
            }
            bookingListView.Refresh();
            bookingListView.GridLines = true;
        }

        private void EditBookingButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            EnableEntries(true);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (roomNtxt.Text == "" || depositTxt.Text == "" || PaymentTextBox.Text == "" )
            {
                MessageBox.Show("Please make sure all booking information is complete!");
            }
            else
            {
                PopulateObject();
                if (state == FormStates.Edit)
                {
                    bookingController.DataMaintenance(booking, DatabaseLayer.DB.DBOperation.Edit);
                }
                else
                {
                    bookingController.DataMaintenance(booking, DatabaseLayer.DB.DBOperation.Delete);
                }
                bookingController.FinalizeChanges(booking);
                ClearAll();
                state = FormStates.View;
                ShowAll(false);
                setUpBookingListView();
            }
        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Delete;
            EditBookingButton.Visible = false;
            EnableEntries(false);
            MessageBox.Show("This booking is going to be Cancelled");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpBookingListView();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookingListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
    }
}
