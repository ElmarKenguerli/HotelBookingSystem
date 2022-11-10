
namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    partial class HotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEditRemoveBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEditRemoveGuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookingToolStripMenuItem,
            this.listEditRemoveBookingsToolStripMenuItem,
            this.availableRoomsToolStripMenuItem,
            this.listEditRemoveGuestsToolStripMenuItem,
            this.newGuestToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 15, 0, 15);
            this.menuStrip1.Size = new System.Drawing.Size(1042, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newBookingToolStripMenuItem
            // 
            this.newBookingToolStripMenuItem.Name = "newBookingToolStripMenuItem";
            this.newBookingToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.newBookingToolStripMenuItem.Text = "New Booking";
            this.newBookingToolStripMenuItem.ToolTipText = "Create a new booking";
            this.newBookingToolStripMenuItem.Click += new System.EventHandler(this.newBookingToolStripMenuItem_Click);
            // 
            // listEditRemoveBookingsToolStripMenuItem
            // 
            this.listEditRemoveBookingsToolStripMenuItem.Name = "listEditRemoveBookingsToolStripMenuItem";
            this.listEditRemoveBookingsToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.listEditRemoveBookingsToolStripMenuItem.Text = "Show / Edit / Remove Bookings";
            this.listEditRemoveBookingsToolStripMenuItem.ToolTipText = "List of Existing Bookings";
            this.listEditRemoveBookingsToolStripMenuItem.Click += new System.EventHandler(this.listEditRemoveBookingsToolStripMenuItem_Click);
            // 
            // availableRoomsToolStripMenuItem
            // 
            this.availableRoomsToolStripMenuItem.Name = "availableRoomsToolStripMenuItem";
            this.availableRoomsToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.availableRoomsToolStripMenuItem.Text = "Report";
            this.availableRoomsToolStripMenuItem.ToolTipText = "Generate Occupancy Report";
            this.availableRoomsToolStripMenuItem.Click += new System.EventHandler(this.availableRoomsToolStripMenuItem_Click);
            // 
            // listEditRemoveGuestsToolStripMenuItem
            // 
            this.listEditRemoveGuestsToolStripMenuItem.Enabled = false;
            this.listEditRemoveGuestsToolStripMenuItem.Name = "listEditRemoveGuestsToolStripMenuItem";
            this.listEditRemoveGuestsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.listEditRemoveGuestsToolStripMenuItem.Text = "List / Edit / Remove Guests";
            this.listEditRemoveGuestsToolStripMenuItem.Click += new System.EventHandler(this.listEditRemoveGuestsToolStripMenuItem_Click);
            // 
            // newGuestToolStripMenuItem
            // 
            this.newGuestToolStripMenuItem.Enabled = false;
            this.newGuestToolStripMenuItem.Name = "newGuestToolStripMenuItem";
            this.newGuestToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.newGuestToolStripMenuItem.Text = "New Guest";
            this.newGuestToolStripMenuItem.Click += new System.EventHandler(this.newGuestToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.ToolTipText = "Exit the program";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Phumla_Kamnandi_Hotel.Properties.Resources.HotelHomeScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 502);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HotelForm";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HotelForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEditRemoveBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEditRemoveGuestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableRoomsToolStripMenuItem;
    }
}