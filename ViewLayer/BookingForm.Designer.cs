
namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    partial class BookingForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SignInDateLabel = new System.Windows.Forms.Label();
            this.SignOutDateLabel = new System.Windows.Forms.Label();
            this.GuestIDLabel = new System.Windows.Forms.Label();
            this.GuestIDTextBox = new System.Windows.Forms.TextBox();
            this.inputpnl = new System.Windows.Forms.Panel();
            this.checkBtn = new System.Windows.Forms.Button();
            this.availableLbl = new System.Windows.Forms.Label();
            this.signOutdtp = new System.Windows.Forms.DateTimePicker();
            this.signIndtp = new System.Windows.Forms.DateTimePicker();
            this.roomNlbl = new System.Windows.Forms.Label();
            this.headerlbl = new System.Windows.Forms.Label();
            this.inputpnl2 = new System.Windows.Forms.Panel();
            this.roomCB = new System.Windows.Forms.CheckedListBox();
            this.bookingLbl = new System.Windows.Forms.Label();
            this.BookingIDTextBox = new System.Windows.Forms.TextBox();
            this.BookingIDLabel = new System.Windows.Forms.Label();
            this.RoomAvailabilityLbl = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.inputpnl.SuspendLayout();
            this.inputpnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(565, 559);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(84, 39);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(463, 133);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(115, 47);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SignInDateLabel
            // 
            this.SignInDateLabel.AutoSize = true;
            this.SignInDateLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInDateLabel.Location = new System.Drawing.Point(81, 59);
            this.SignInDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignInDateLabel.Name = "SignInDateLabel";
            this.SignInDateLabel.Size = new System.Drawing.Size(109, 22);
            this.SignInDateLabel.TabIndex = 3;
            this.SignInDateLabel.Text = "Sign In Date";
            // 
            // SignOutDateLabel
            // 
            this.SignOutDateLabel.AutoSize = true;
            this.SignOutDateLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutDateLabel.Location = new System.Drawing.Point(82, 112);
            this.SignOutDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignOutDateLabel.Name = "SignOutDateLabel";
            this.SignOutDateLabel.Size = new System.Drawing.Size(124, 22);
            this.SignOutDateLabel.TabIndex = 4;
            this.SignOutDateLabel.Text = "Sign Out Date";
            // 
            // GuestIDLabel
            // 
            this.GuestIDLabel.AutoSize = true;
            this.GuestIDLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestIDLabel.Location = new System.Drawing.Point(341, 59);
            this.GuestIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GuestIDLabel.Name = "GuestIDLabel";
            this.GuestIDLabel.Size = new System.Drawing.Size(80, 22);
            this.GuestIDLabel.TabIndex = 5;
            this.GuestIDLabel.Text = "Guest ID";
            // 
            // GuestIDTextBox
            // 
            this.GuestIDTextBox.Location = new System.Drawing.Point(446, 59);
            this.GuestIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GuestIDTextBox.Name = "GuestIDTextBox";
            this.GuestIDTextBox.Size = new System.Drawing.Size(132, 20);
            this.GuestIDTextBox.TabIndex = 10;
            // 
            // inputpnl
            // 
            this.inputpnl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputpnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputpnl.Controls.Add(this.checkBtn);
            this.inputpnl.Controls.Add(this.availableLbl);
            this.inputpnl.Controls.Add(this.signOutdtp);
            this.inputpnl.Controls.Add(this.signIndtp);
            this.inputpnl.Controls.Add(this.SignInDateLabel);
            this.inputpnl.Controls.Add(this.SignOutDateLabel);
            this.inputpnl.Location = new System.Drawing.Point(27, 84);
            this.inputpnl.Name = "inputpnl";
            this.inputpnl.Size = new System.Drawing.Size(597, 161);
            this.inputpnl.TabIndex = 12;
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Location = new System.Drawing.Point(463, 100);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(115, 47);
            this.checkBtn.TabIndex = 17;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // availableLbl
            // 
            this.availableLbl.AutoSize = true;
            this.availableLbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLbl.Location = new System.Drawing.Point(15, 12);
            this.availableLbl.Name = "availableLbl";
            this.availableLbl.Size = new System.Drawing.Size(191, 26);
            this.availableLbl.TabIndex = 15;
            this.availableLbl.Text = "Check Availability";
            // 
            // signOutdtp
            // 
            this.signOutdtp.Location = new System.Drawing.Point(243, 114);
            this.signOutdtp.MaxDate = new System.DateTime(2022, 4, 30, 0, 0, 0, 0);
            this.signOutdtp.MinDate = new System.DateTime(2021, 10, 25, 0, 0, 0, 0);
            this.signOutdtp.Name = "signOutdtp";
            this.signOutdtp.Size = new System.Drawing.Size(178, 20);
            this.signOutdtp.TabIndex = 15;
            this.signOutdtp.Value = new System.DateTime(2021, 10, 25, 0, 0, 0, 0);
            // 
            // signIndtp
            // 
            this.signIndtp.Location = new System.Drawing.Point(243, 59);
            this.signIndtp.MaxDate = new System.DateTime(2022, 4, 30, 0, 0, 0, 0);
            this.signIndtp.MinDate = new System.DateTime(2021, 10, 25, 0, 0, 0, 0);
            this.signIndtp.Name = "signIndtp";
            this.signIndtp.Size = new System.Drawing.Size(178, 20);
            this.signIndtp.TabIndex = 14;
            this.signIndtp.Value = new System.DateTime(2021, 10, 25, 0, 0, 0, 0);
            // 
            // roomNlbl
            // 
            this.roomNlbl.AutoSize = true;
            this.roomNlbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNlbl.Location = new System.Drawing.Point(18, 101);
            this.roomNlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomNlbl.Name = "roomNlbl";
            this.roomNlbl.Size = new System.Drawing.Size(120, 22);
            this.roomNlbl.TabIndex = 12;
            this.roomNlbl.Text = "Select 1 room:";
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.Location = new System.Drawing.Point(149, 23);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(343, 37);
            this.headerlbl.TabIndex = 13;
            this.headerlbl.Text = "Create Booking below:";
            // 
            // inputpnl2
            // 
            this.inputpnl2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputpnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputpnl2.Controls.Add(this.roomCB);
            this.inputpnl2.Controls.Add(this.bookingLbl);
            this.inputpnl2.Controls.Add(this.BookingIDTextBox);
            this.inputpnl2.Controls.Add(this.SubmitButton);
            this.inputpnl2.Controls.Add(this.BookingIDLabel);
            this.inputpnl2.Controls.Add(this.GuestIDLabel);
            this.inputpnl2.Controls.Add(this.GuestIDTextBox);
            this.inputpnl2.Controls.Add(this.roomNlbl);
            this.inputpnl2.Location = new System.Drawing.Point(27, 352);
            this.inputpnl2.Name = "inputpnl2";
            this.inputpnl2.Size = new System.Drawing.Size(597, 189);
            this.inputpnl2.TabIndex = 14;
            // 
            // roomCB
            // 
            this.roomCB.FormattingEnabled = true;
            this.roomCB.Location = new System.Drawing.Point(165, 101);
            this.roomCB.Name = "roomCB";
            this.roomCB.Size = new System.Drawing.Size(41, 79);
            this.roomCB.TabIndex = 17;
            // 
            // bookingLbl
            // 
            this.bookingLbl.AutoSize = true;
            this.bookingLbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingLbl.Location = new System.Drawing.Point(16, 18);
            this.bookingLbl.Name = "bookingLbl";
            this.bookingLbl.Size = new System.Drawing.Size(156, 26);
            this.bookingLbl.TabIndex = 16;
            this.bookingLbl.Text = "Make Booking";
            // 
            // BookingIDTextBox
            // 
            this.BookingIDTextBox.Location = new System.Drawing.Point(165, 61);
            this.BookingIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookingIDTextBox.Name = "BookingIDTextBox";
            this.BookingIDTextBox.Size = new System.Drawing.Size(132, 20);
            this.BookingIDTextBox.TabIndex = 10;
            // 
            // BookingIDLabel
            // 
            this.BookingIDLabel.AutoSize = true;
            this.BookingIDLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingIDLabel.Location = new System.Drawing.Point(18, 59);
            this.BookingIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingIDLabel.Name = "BookingIDLabel";
            this.BookingIDLabel.Size = new System.Drawing.Size(100, 22);
            this.BookingIDLabel.TabIndex = 2;
            this.BookingIDLabel.Text = "Booking ID";
            // 
            // RoomAvailabilityLbl
            // 
            this.RoomAvailabilityLbl.AutoSize = true;
            this.RoomAvailabilityLbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomAvailabilityLbl.Location = new System.Drawing.Point(27, 288);
            this.RoomAvailabilityLbl.Name = "RoomAvailabilityLbl";
            this.RoomAvailabilityLbl.Size = new System.Drawing.Size(0, 26);
            this.RoomAvailabilityLbl.TabIndex = 15;
            // 
            // depositBtn
            // 
            this.depositBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.Location = new System.Drawing.Point(442, 559);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(118, 39);
            this.depositBtn.TabIndex = 16;
            this.depositBtn.Text = "Pay Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(660, 609);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.RoomAvailabilityLbl);
            this.Controls.Add(this.headerlbl);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.inputpnl);
            this.Controls.Add(this.inputpnl2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            this.Activated += new System.EventHandler(this.BookingForm_Activated);
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.inputpnl.ResumeLayout(false);
            this.inputpnl.PerformLayout();
            this.inputpnl2.ResumeLayout(false);
            this.inputpnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label SignInDateLabel;
        private System.Windows.Forms.Label SignOutDateLabel;
        private System.Windows.Forms.Label GuestIDLabel;
        private System.Windows.Forms.TextBox GuestIDTextBox;
        private System.Windows.Forms.Panel inputpnl;
        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.Label roomNlbl;
        private System.Windows.Forms.DateTimePicker signOutdtp;
        private System.Windows.Forms.DateTimePicker signIndtp;
        private System.Windows.Forms.Panel inputpnl2;
        private System.Windows.Forms.TextBox BookingIDTextBox;
        private System.Windows.Forms.Label BookingIDLabel;
        private System.Windows.Forms.Label availableLbl;
        private System.Windows.Forms.Label bookingLbl;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.CheckedListBox roomCB;
        private System.Windows.Forms.Label RoomAvailabilityLbl;
        private System.Windows.Forms.Button depositBtn;
    }
}