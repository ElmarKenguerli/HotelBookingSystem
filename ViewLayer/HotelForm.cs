using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_Hotel.Bookings;
using Phumla_Kamnandi_Hotel.Guests;

namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    public partial class HotelForm : Form
    {
        BookingForm bookingForm;
        GuestForm guestForm;
        BookingListingForm bookingListForm;
        GuestListingForm guestListForm;
        BookingController bookingController;
        GuestController guestController;
        ReportForm roomsForm;
        public HotelForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            bookingController = new BookingController();
            guestController = new GuestController();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            { 
                this.Close();
            }
            else
            {
                //do nothing
            }
                
        }

        private void listEditRemoveBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bookingListForm == null)
            {
                CreateNewBookingListForm();
            }
            if (bookingListForm.listFormClosed)
            {
                CreateNewBookingListForm();
            }
            bookingListForm.setUpBookingListView();
            bookingListForm.Show();
        }

        private void listEditRemoveGuestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guestListForm == null)
            {
                CreateNewGuestListForm();
            }
            if (guestListForm.listFormClosed)
            {
                CreateNewGuestListForm();
            }
            guestListForm.setUpGuestListView();
            guestListForm.Show();
        }
        private void CreateNewBookingForm()
        {
            bookingForm = new BookingForm(bookingController, guestController);
            bookingForm.MdiParent = this;
            bookingForm.StartPosition = FormStartPosition.CenterScreen;
            //bookingForm.WindowState = FormWindowState.Maximized;
        }
        private void CreateNewGuestForm()
        {
            guestForm = new GuestForm(guestController);
            guestForm.MdiParent = this;
            guestForm.StartPosition = FormStartPosition.CenterScreen;
            //guestForm.WindowState = FormWindowState.Maximized;
        }
        private void CreateNewBookingListForm()
        {
            bookingListForm = new BookingListingForm(bookingController, guestController);
            bookingListForm.MdiParent = this;
            bookingListForm.StartPosition = FormStartPosition.CenterScreen;
            //bookingListForm.WindowState = FormWindowState.;
        }
        private void CreateNewGuestListForm()
        {
            guestListForm = new GuestListingForm(guestController);
            guestListForm.MdiParent = this;
            guestListForm.StartPosition = FormStartPosition.CenterScreen;
            //guestListForm.WindowState = FormWindowState.Maximized;
        }

        private void newBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bookingForm == null)
            {
                CreateNewBookingForm();
            }
            if (bookingForm.bookingFormClosed)
            {
                CreateNewBookingForm();
            }
            bookingForm.Show();
        }

        private void newGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guestForm == null)
            {
                CreateNewGuestForm();
            }
            if (guestForm.guestFormClosed)
            {
                CreateNewGuestForm();
            }
            guestForm.Show();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewRoomsForm()
        {
            roomsForm = new ReportForm(bookingController);
            roomsForm.MdiParent = this;
            roomsForm.StartPosition = FormStartPosition.CenterScreen;
            //roomsForm.WindowState = FormWindowState.ce;
        }

        private void availableRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (roomsForm == null)
            {
                CreateNewRoomsForm();
            }
            if (roomsForm.roomsFormClosed)
            {
                CreateNewRoomsForm();
            }
            //roomsForm.searchDate("12/24/2021");
            roomsForm.Show();
            //roomsForm.writeToTextBox();
            //roomsForm.Populate();
        }
    }
}
