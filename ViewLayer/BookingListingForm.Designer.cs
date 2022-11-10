
namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    partial class BookingListingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookingListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.BookingIDLabel = new System.Windows.Forms.Label();
            this.SignInDateLabel = new System.Windows.Forms.Label();
            this.SignOutDateLabel = new System.Windows.Forms.Label();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.GuestIDLabel = new System.Windows.Forms.Label();
            this.BookingIDTextBox = new System.Windows.Forms.TextBox();
            this.GuestIDTextBox = new System.Windows.Forms.TextBox();
            this.PaymentTextBox = new System.Windows.Forms.TextBox();
            this.CancelBookingButton = new System.Windows.Forms.Button();
            this.EditBookingButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.editlbl = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.signOutdtp = new System.Windows.Forms.DateTimePicker();
            this.signIndtp = new System.Windows.Forms.DateTimePicker();
            this.roomNtxt = new System.Windows.Forms.TextBox();
            this.roomNlbl = new System.Windows.Forms.Label();
            this.deletelbl = new System.Windows.Forms.Label();
            this.selectlbl = new System.Windows.Forms.Label();
            this.depositLbl = new System.Windows.Forms.Label();
            this.depositTxt = new System.Windows.Forms.TextBox();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingListView
            // 
            this.bookingListView.HideSelection = false;
            this.bookingListView.Location = new System.Drawing.Point(11, 30);
            this.bookingListView.Margin = new System.Windows.Forms.Padding(2);
            this.bookingListView.Name = "bookingListView";
            this.bookingListView.Size = new System.Drawing.Size(757, 280);
            this.bookingListView.TabIndex = 0;
            this.bookingListView.UseCompatibleStateImageBehavior = false;
            this.bookingListView.SelectedIndexChanged += new System.EventHandler(this.bookingListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // BookingIDLabel
            // 
            this.BookingIDLabel.AutoSize = true;
            this.BookingIDLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingIDLabel.Location = new System.Drawing.Point(16, 21);
            this.BookingIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingIDLabel.Name = "BookingIDLabel";
            this.BookingIDLabel.Size = new System.Drawing.Size(82, 18);
            this.BookingIDLabel.TabIndex = 2;
            this.BookingIDLabel.Text = "Booking ID";
            // 
            // SignInDateLabel
            // 
            this.SignInDateLabel.AutoSize = true;
            this.SignInDateLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInDateLabel.Location = new System.Drawing.Point(16, 87);
            this.SignInDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignInDateLabel.Name = "SignInDateLabel";
            this.SignInDateLabel.Size = new System.Drawing.Size(89, 18);
            this.SignInDateLabel.TabIndex = 3;
            this.SignInDateLabel.Text = "Sign In Date";
            // 
            // SignOutDateLabel
            // 
            this.SignOutDateLabel.AutoSize = true;
            this.SignOutDateLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutDateLabel.Location = new System.Drawing.Point(16, 146);
            this.SignOutDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignOutDateLabel.Name = "SignOutDateLabel";
            this.SignOutDateLabel.Size = new System.Drawing.Size(101, 18);
            this.SignOutDateLabel.TabIndex = 4;
            this.SignOutDateLabel.Text = "Sign Out Date";
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLabel.Location = new System.Drawing.Point(375, 87);
            this.PaymentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(68, 18);
            this.PaymentLabel.TabIndex = 5;
            this.PaymentLabel.Text = "Payment";
            // 
            // GuestIDLabel
            // 
            this.GuestIDLabel.AutoSize = true;
            this.GuestIDLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestIDLabel.Location = new System.Drawing.Point(375, 21);
            this.GuestIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GuestIDLabel.Name = "GuestIDLabel";
            this.GuestIDLabel.Size = new System.Drawing.Size(64, 18);
            this.GuestIDLabel.TabIndex = 6;
            this.GuestIDLabel.Text = "Guest ID";
            // 
            // BookingIDTextBox
            // 
            this.BookingIDTextBox.Location = new System.Drawing.Point(150, 19);
            this.BookingIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookingIDTextBox.Name = "BookingIDTextBox";
            this.BookingIDTextBox.Size = new System.Drawing.Size(188, 20);
            this.BookingIDTextBox.TabIndex = 7;
            // 
            // GuestIDTextBox
            // 
            this.GuestIDTextBox.Location = new System.Drawing.Point(469, 21);
            this.GuestIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GuestIDTextBox.Name = "GuestIDTextBox";
            this.GuestIDTextBox.Size = new System.Drawing.Size(193, 20);
            this.GuestIDTextBox.TabIndex = 9;
            // 
            // PaymentTextBox
            // 
            this.PaymentTextBox.Location = new System.Drawing.Point(469, 84);
            this.PaymentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PaymentTextBox.Name = "PaymentTextBox";
            this.PaymentTextBox.Size = new System.Drawing.Size(193, 20);
            this.PaymentTextBox.TabIndex = 10;
            // 
            // CancelBookingButton
            // 
            this.CancelBookingButton.BackgroundImage = global::Phumla_Kamnandi_Hotel.Properties.Resources.deleteIcon;
            this.CancelBookingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBookingButton.Location = new System.Drawing.Point(509, 352);
            this.CancelBookingButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBookingButton.Name = "CancelBookingButton";
            this.CancelBookingButton.Size = new System.Drawing.Size(76, 48);
            this.CancelBookingButton.TabIndex = 12;
            this.CancelBookingButton.UseVisualStyleBackColor = true;
            this.CancelBookingButton.Click += new System.EventHandler(this.CancelBookingButton_Click);
            // 
            // EditBookingButton
            // 
            this.EditBookingButton.BackgroundImage = global::Phumla_Kamnandi_Hotel.Properties.Resources.editIcon;
            this.EditBookingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditBookingButton.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBookingButton.Location = new System.Drawing.Point(174, 352);
            this.EditBookingButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditBookingButton.Name = "EditBookingButton";
            this.EditBookingButton.Size = new System.Drawing.Size(77, 48);
            this.EditBookingButton.TabIndex = 13;
            this.EditBookingButton.UseVisualStyleBackColor = true;
            this.EditBookingButton.Click += new System.EventHandler(this.EditBookingButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(427, 657);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(122, 53);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Apply Changes";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(562, 657);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(121, 53);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(697, 676);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(70, 34);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // editlbl
            // 
            this.editlbl.AutoSize = true;
            this.editlbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editlbl.Location = new System.Drawing.Point(115, 330);
            this.editlbl.Name = "editlbl";
            this.editlbl.Size = new System.Drawing.Size(200, 22);
            this.editlbl.TabIndex = 17;
            this.editlbl.Text = "Edit Selected Booking:";
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputPanel.Controls.Add(this.depositTxt);
            this.inputPanel.Controls.Add(this.depositLbl);
            this.inputPanel.Controls.Add(this.signOutdtp);
            this.inputPanel.Controls.Add(this.signIndtp);
            this.inputPanel.Controls.Add(this.roomNtxt);
            this.inputPanel.Controls.Add(this.roomNlbl);
            this.inputPanel.Controls.Add(this.BookingIDLabel);
            this.inputPanel.Controls.Add(this.SignInDateLabel);
            this.inputPanel.Controls.Add(this.SignOutDateLabel);
            this.inputPanel.Controls.Add(this.PaymentTextBox);
            this.inputPanel.Controls.Add(this.GuestIDTextBox);
            this.inputPanel.Controls.Add(this.GuestIDLabel);
            this.inputPanel.Controls.Add(this.PaymentLabel);
            this.inputPanel.Controls.Add(this.BookingIDTextBox);
            this.inputPanel.Location = new System.Drawing.Point(36, 405);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(708, 239);
            this.inputPanel.TabIndex = 19;
            // 
            // signOutdtp
            // 
            this.signOutdtp.Location = new System.Drawing.Point(150, 143);
            this.signOutdtp.Name = "signOutdtp";
            this.signOutdtp.Size = new System.Drawing.Size(188, 20);
            this.signOutdtp.TabIndex = 15;
            this.signOutdtp.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // signIndtp
            // 
            this.signIndtp.Location = new System.Drawing.Point(150, 84);
            this.signIndtp.Name = "signIndtp";
            this.signIndtp.Size = new System.Drawing.Size(188, 20);
            this.signIndtp.TabIndex = 14;
            this.signIndtp.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // roomNtxt
            // 
            this.roomNtxt.Location = new System.Drawing.Point(469, 143);
            this.roomNtxt.Margin = new System.Windows.Forms.Padding(2);
            this.roomNtxt.Name = "roomNtxt";
            this.roomNtxt.Size = new System.Drawing.Size(193, 20);
            this.roomNtxt.TabIndex = 13;
            // 
            // roomNlbl
            // 
            this.roomNlbl.AutoSize = true;
            this.roomNlbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNlbl.Location = new System.Drawing.Point(375, 146);
            this.roomNlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomNlbl.Name = "roomNlbl";
            this.roomNlbl.Size = new System.Drawing.Size(72, 18);
            this.roomNlbl.TabIndex = 12;
            this.roomNlbl.Text = "Room No.";
            // 
            // deletelbl
            // 
            this.deletelbl.AutoSize = true;
            this.deletelbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletelbl.Location = new System.Drawing.Point(435, 330);
            this.deletelbl.Name = "deletelbl";
            this.deletelbl.Size = new System.Drawing.Size(223, 22);
            this.deletelbl.TabIndex = 20;
            this.deletelbl.Text = "Cancel Selected Booking:";
            // 
            // selectlbl
            // 
            this.selectlbl.AutoSize = true;
            this.selectlbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectlbl.Location = new System.Drawing.Point(12, 324);
            this.selectlbl.Name = "selectlbl";
            this.selectlbl.Size = new System.Drawing.Size(0, 26);
            this.selectlbl.TabIndex = 21;
            // 
            // depositLbl
            // 
            this.depositLbl.AutoSize = true;
            this.depositLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLbl.Location = new System.Drawing.Point(16, 204);
            this.depositLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depositLbl.Name = "depositLbl";
            this.depositLbl.Size = new System.Drawing.Size(111, 18);
            this.depositLbl.TabIndex = 16;
            this.depositLbl.Text = "Deposit (yes/no)";
            // 
            // depositTxt
            // 
            this.depositTxt.Location = new System.Drawing.Point(150, 202);
            this.depositTxt.Margin = new System.Windows.Forms.Padding(2);
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.Size = new System.Drawing.Size(188, 20);
            this.depositTxt.TabIndex = 17;
            // 
            // BookingListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(778, 721);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.selectlbl);
            this.Controls.Add(this.deletelbl);
            this.Controls.Add(this.editlbl);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EditBookingButton);
            this.Controls.Add(this.CancelBookingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingListView);
            this.Controls.Add(this.inputPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingListingForm";
            this.Text = "BookingListingForm";
            this.Activated += new System.EventHandler(this.BookingListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookingListingForm_FormClosed);
            this.Load += new System.EventHandler(this.BookingListingForm_Load);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookingListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BookingIDLabel;
        private System.Windows.Forms.Label SignInDateLabel;
        private System.Windows.Forms.Label SignOutDateLabel;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.Label GuestIDLabel;
        private System.Windows.Forms.TextBox BookingIDTextBox;
        private System.Windows.Forms.TextBox GuestIDTextBox;
        private System.Windows.Forms.TextBox PaymentTextBox;
        private System.Windows.Forms.Button CancelBookingButton;
        private System.Windows.Forms.Button EditBookingButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label editlbl;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label deletelbl;
        private System.Windows.Forms.Label selectlbl;
        private System.Windows.Forms.TextBox roomNtxt;
        private System.Windows.Forms.Label roomNlbl;
        private System.Windows.Forms.DateTimePicker signOutdtp;
        private System.Windows.Forms.DateTimePicker signIndtp;
        private System.Windows.Forms.TextBox depositTxt;
        private System.Windows.Forms.Label depositLbl;
    }
}