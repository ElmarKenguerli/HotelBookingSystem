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
using Phumla_Kamnandi_Hotel.DatabaseLayer;
using Phumla_Kamnandi_Hotel.Guests;

namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    public partial class GuestListingForm : Form
    {
        public bool listFormClosed;
        private Collection<Guest> guests;
        private Guest guest;
        private GuestController guestController;
        private FormStates state;

        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        public GuestListingForm(GuestController gController)
        {
            InitializeComponent();
            guestController = gController;
            this.Load += GuestListingForm_Load;
            this.Activated += GuestListingForm_Activated;
            state = FormStates.View;
        }

        private void GuestListingForm_Load(object sender, EventArgs e)
        {
            guestListView.View = View.Details;
        }

        private void GuestListingForm_Activated(object sender, EventArgs e)
        {
            guestListView.View = View.Details;
            setUpGuestListView();
            ShowAll(false);
        }
        private void ShowAll(bool value)
        {
            GuestIDLabel.Visible = value;
            NameLabel.Visible = value;
            AddressLabel.Visible = value;
            PhoneLabel.Visible = value;
            DepositLabel.Visible = value;
            //TextBoxes
            NameTextBox.Visible = value;
            GuestIDTextBox.Visible = value;
            AddressTextBox.Visible = value;
            PhoneTextBox.Visible = value;
            DepositTextBox.Visible = value;
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
            RemoveGuestButton.Visible = value;
            EditGuestButton.Visible = value;
        }
        private void ClearAll()
        {
            NameTextBox.Text = "";
            GuestIDTextBox.Text = "";
            AddressTextBox.Text = "";
            PhoneTextBox.Text = "";
            DepositTextBox.Text = "";
        }
        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                GuestIDTextBox.Enabled = !value;
            }
            else
            {
                GuestIDTextBox.Enabled = value;
            }
            NameTextBox.Enabled = value;
            AddressTextBox.Enabled = value;
            PhoneTextBox.Enabled = value;
            DepositTextBox.Enabled = value;
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
        private void PopulateTextBoxes(Guest guest)
        {
            GuestIDTextBox.Text = guest.GuestID;
            NameTextBox.Text = guest.Name;
            AddressTextBox.Text = guest.Address;
            PhoneTextBox.Text = guest.Phone;
            DepositTextBox.Text = Convert.ToString(guest.Deposit);
        }
        private void PopulateObject()
        {
            guest = new Guest();
            guest.GuestID = GuestIDTextBox.Text;
            guest.Name = NameTextBox.Text;
            guest.Address = AddressTextBox.Text;
            guest.Phone = PhoneTextBox.Text;
            guest.Deposit = double.Parse(DepositTextBox.Text);
        }
        public void setUpGuestListView()
        {
            ListViewItem guestDetails;
            guests = null;
            guests = guestController.AllGuests;
            guestListView.Clear();

            label1.Text = "List of all Guests";
            guestListView.Columns.Insert(0, "GuestID", 120, HorizontalAlignment.Left);
            guestListView.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            guestListView.Columns.Insert(2, "Address", 120, HorizontalAlignment.Left);
            guestListView.Columns.Insert(3, "Phone", 120, HorizontalAlignment.Left);
            guestListView.Columns.Insert(4, "Deposit", 120, HorizontalAlignment.Left);

            foreach (Guest guest in guests)
            {
                guestDetails = new ListViewItem();
                guestDetails.Text = guest.GuestID.ToString();
                guestDetails.SubItems.Add(guest.Name.ToString());
                guestDetails.SubItems.Add(guest.Address.ToString());
                guestDetails.SubItems.Add(guest.Phone.ToString());
                guestDetails.SubItems.Add(guest.Deposit.ToString());

                guestListView.Items.Add(guestDetails);
            }
            guestListView.Refresh();
            guestListView.GridLines = true;
        }

        private void guestListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (guestListView.SelectedItems.Count > 0)
            {
                guest = guestController.Find(guestListView.SelectedItems[0].Text);

                PopulateTextBoxes(guest);
            }
        }

        private void EditGuestButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            EnableEntries(true);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            if (state == FormStates.Edit)
            {
                guestController.DataMaintenance(guest, DatabaseLayer.DB.DBOperation.Edit);
            }
            else
            {
                guestController.DataMaintenance(guest, DatabaseLayer.DB.DBOperation.Delete);
            }
            guestController.FinalizeChanges(guest);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpGuestListView();
        }

        private void RemoveGuestButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Delete;
            RemoveGuestButton.Visible = false;
            EnableEntries(false);
            MessageBox.Show("This Guest is going to be Removed");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpGuestListView();
        }

        private void GuestListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
