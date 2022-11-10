
namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    partial class GuestListingForm
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
            this.guestListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.GuestIDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.DepositLabel = new System.Windows.Forms.Label();
            this.DepositTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.GuestIDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditGuestButton = new System.Windows.Forms.Button();
            this.RemoveGuestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guestListView
            // 
            this.guestListView.HideSelection = false;
            this.guestListView.Location = new System.Drawing.Point(12, 37);
            this.guestListView.Name = "guestListView";
            this.guestListView.Size = new System.Drawing.Size(988, 342);
            this.guestListView.TabIndex = 0;
            this.guestListView.UseCompatibleStateImageBehavior = false;
            this.guestListView.SelectedIndexChanged += new System.EventHandler(this.guestListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // GuestIDLabel
            // 
            this.GuestIDLabel.AutoSize = true;
            this.GuestIDLabel.Location = new System.Drawing.Point(27, 455);
            this.GuestIDLabel.Name = "GuestIDLabel";
            this.GuestIDLabel.Size = new System.Drawing.Size(63, 17);
            this.GuestIDLabel.TabIndex = 2;
            this.GuestIDLabel.Text = "Guest ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(27, 538);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(36, 627);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(49, 17);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "Phone";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(463, 460);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 17);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address";
            // 
            // DepositLabel
            // 
            this.DepositLabel.AutoSize = true;
            this.DepositLabel.Location = new System.Drawing.Point(463, 543);
            this.DepositLabel.Name = "DepositLabel";
            this.DepositLabel.Size = new System.Drawing.Size(56, 17);
            this.DepositLabel.TabIndex = 6;
            this.DepositLabel.Text = "Deposit";
            // 
            // DepositTextBox
            // 
            this.DepositTextBox.Location = new System.Drawing.Point(552, 538);
            this.DepositTextBox.Name = "DepositTextBox";
            this.DepositTextBox.Size = new System.Drawing.Size(304, 22);
            this.DepositTextBox.TabIndex = 7;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(552, 455);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(448, 22);
            this.AddressTextBox.TabIndex = 8;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(143, 627);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(282, 22);
            this.PhoneTextBox.TabIndex = 9;
            // 
            // GuestIDTextBox
            // 
            this.GuestIDTextBox.Location = new System.Drawing.Point(143, 452);
            this.GuestIDTextBox.Name = "GuestIDTextBox";
            this.GuestIDTextBox.Size = new System.Drawing.Size(282, 22);
            this.GuestIDTextBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(143, 538);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(282, 22);
            this.NameTextBox.TabIndex = 11;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(727, 698);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(81, 33);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(920, 698);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 33);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(527, 698);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(85, 33);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditGuestButton
            // 
            this.EditGuestButton.Location = new System.Drawing.Point(527, 627);
            this.EditGuestButton.Name = "EditGuestButton";
            this.EditGuestButton.Size = new System.Drawing.Size(234, 42);
            this.EditGuestButton.TabIndex = 15;
            this.EditGuestButton.Text = "Edit Guest";
            this.EditGuestButton.UseVisualStyleBackColor = true;
            this.EditGuestButton.Click += new System.EventHandler(this.EditGuestButton_Click);
            // 
            // RemoveGuestButton
            // 
            this.RemoveGuestButton.Location = new System.Drawing.Point(795, 627);
            this.RemoveGuestButton.Name = "RemoveGuestButton";
            this.RemoveGuestButton.Size = new System.Drawing.Size(205, 42);
            this.RemoveGuestButton.TabIndex = 16;
            this.RemoveGuestButton.Text = "Remove Guest";
            this.RemoveGuestButton.UseVisualStyleBackColor = true;
            this.RemoveGuestButton.Click += new System.EventHandler(this.RemoveGuestButton_Click);
            // 
            // GuestListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 743);
            this.Controls.Add(this.RemoveGuestButton);
            this.Controls.Add(this.EditGuestButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.GuestIDTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.DepositTextBox);
            this.Controls.Add(this.DepositLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.GuestIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestListView);
            this.Name = "GuestListingForm";
            this.Text = "Guest Listing Form";
            this.Activated += new System.EventHandler(this.GuestListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuestListingForm_FormClosed);
            this.Load += new System.EventHandler(this.GuestListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView guestListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GuestIDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label DepositLabel;
        private System.Windows.Forms.TextBox DepositTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox GuestIDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditGuestButton;
        private System.Windows.Forms.Button RemoveGuestButton;
    }
}