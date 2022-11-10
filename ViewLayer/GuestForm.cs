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
using Phumla_Kamnandi_Hotel.Guests;

namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    public partial class GuestForm : Form
    {
        private Guest guest;
        private GuestController guestController;
        public bool guestFormClosed = false;
        public GuestForm(GuestController aController)
        {
            InitializeComponent();
            guestController = aController;
        }
        private void ShowAll(bool value)
        {
            GuestIDLabel.Visible = value;
            NameLabel.Visible = value;
            AddressLabel.Visible = value;
            PhoneLabel.Visible = value;
            DepositLabel.Visible = value;
            //TextBoxes
            GuestIDTextBox.Visible = value;
            NameTextBox.Visible = value;
            AddressTextBox.Visible = value;
            PhoneTextBox.Visible = value;
            DepositTextBox.Visible = value;
        }

        private void ClearAll()
        {
            NameTextBox.Text = "";
            GuestIDTextBox.Text = "";
            AddressTextBox.Text = "";
            PhoneTextBox.Text = "";
            DepositTextBox.Text = "";
        }
        private void Populate()
        {
            guest = new Guest();
            guest.GuestID = GuestIDTextBox.Text;
            guest.Name = NameTextBox.Text;
            guest.Address = AddressTextBox.Text;
            guest.Phone = PhoneTextBox.Text;
            guest.Deposit = double.Parse(DepositTextBox.Text);
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            ShowAll(true);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            guestFormClosed = true;
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Populate();
            MessageBox.Show("Data to be submitted to the Database!");
            guestController.DataMaintenance(guest, DB.DBOperation.Add);
            guestController.FinalizeChanges(guest);
            ClearAll();
            ShowAll(true);
        }

        private void GuestForm_Activated(object sender, EventArgs e)
        {
            ShowAll(true);
        }
    }
}
