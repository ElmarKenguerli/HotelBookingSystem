
namespace Phumla_Kamnandi_Hotel.ViewLayer
{
    partial class ReportForm
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
            this.SearchDateLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDateP = new System.Windows.Forms.DateTimePicker();
            this.toDateP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportTxt = new System.Windows.Forms.RichTextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.revenueBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchDateLabel
            // 
            this.SearchDateLabel.AutoSize = true;
            this.SearchDateLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDateLabel.Location = new System.Drawing.Point(206, 79);
            this.SearchDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchDateLabel.Name = "SearchDateLabel";
            this.SearchDateLabel.Size = new System.Drawing.Size(138, 29);
            this.SearchDateLabel.TabIndex = 1;
            this.SearchDateLabel.Text = "Enter Dates";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(142, 109);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(200, 40);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Retrieve";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Occupancy Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "To:";
            // 
            // fromDateP
            // 
            this.fromDateP.Location = new System.Drawing.Point(142, 25);
            this.fromDateP.Name = "fromDateP";
            this.fromDateP.Size = new System.Drawing.Size(200, 20);
            this.fromDateP.TabIndex = 8;
            // 
            // toDateP
            // 
            this.toDateP.Location = new System.Drawing.Point(142, 66);
            this.toDateP.Name = "toDateP";
            this.toDateP.Size = new System.Drawing.Size(200, 20);
            this.toDateP.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Occupancy Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.toDateP);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fromDateP);
            this.panel1.Location = new System.Drawing.Point(35, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 155);
            this.panel1.TabIndex = 11;
            // 
            // reportTxt
            // 
            this.reportTxt.Location = new System.Drawing.Point(35, 340);
            this.reportTxt.Name = "reportTxt";
            this.reportTxt.Size = new System.Drawing.Size(494, 183);
            this.reportTxt.TabIndex = 12;
            this.reportTxt.Text = "";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(467, 647);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(98, 40);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // revenueBtn
            // 
            this.revenueBtn.Enabled = false;
            this.revenueBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueBtn.Location = new System.Drawing.Point(35, 617);
            this.revenueBtn.Margin = new System.Windows.Forms.Padding(2);
            this.revenueBtn.Name = "revenueBtn";
            this.revenueBtn.Size = new System.Drawing.Size(239, 70);
            this.revenueBtn.TabIndex = 13;
            this.revenueBtn.Text = "Retrieve";
            this.revenueBtn.UseVisualStyleBackColor = true;
            this.revenueBtn.Click += new System.EventHandler(this.revenueBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Retrieve Revenue Report";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(576, 696);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.revenueBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.reportTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchDateLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportForm";
            this.Text = "Occupancy Report";
            this.Activated += new System.EventHandler(this.RoomsForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomsForm_FormClosed);
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SearchDateLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fromDateP;
        private System.Windows.Forms.DateTimePicker toDateP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox reportTxt;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button revenueBtn;
        private System.Windows.Forms.Label label5;
    }
}