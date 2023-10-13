namespace BookingSystem.View
{
    partial class BookingListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookingLV = new System.Windows.Forms.ListView();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.roomNumTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.refTB = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.checkinLabel = new System.Windows.Forms.Label();
            this.roomNumLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.refLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.roomTypeCB = new System.Windows.Forms.ComboBox();
            this.checkinDTP = new System.Windows.Forms.DateTimePicker();
            this.checkoutDTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Of Reservations";
            // 
            // bookingLV
            // 
            this.bookingLV.HideSelection = false;
            this.bookingLV.Location = new System.Drawing.Point(43, 134);
            this.bookingLV.Name = "bookingLV";
            this.bookingLV.Size = new System.Drawing.Size(905, 264);
            this.bookingLV.TabIndex = 1;
            this.bookingLV.UseCompatibleStateImageBehavior = false;
            this.bookingLV.SelectedIndexChanged += new System.EventHandler(this.bookingLV_SelectedIndexChanged);
            // 
            // statusTB
            // 
            this.statusTB.Location = new System.Drawing.Point(181, 728);
            this.statusTB.Name = "statusTB";
            this.statusTB.Size = new System.Drawing.Size(150, 22);
            this.statusTB.TabIndex = 36;
            // 
            // roomNumTB
            // 
            this.roomNumTB.Location = new System.Drawing.Point(181, 580);
            this.roomNumTB.Name = "roomNumTB";
            this.roomNumTB.Size = new System.Drawing.Size(66, 22);
            this.roomNumTB.TabIndex = 32;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(181, 458);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(177, 22);
            this.idTB.TabIndex = 30;
            // 
            // refTB
            // 
            this.refTB.Location = new System.Drawing.Point(181, 421);
            this.refTB.Name = "refTB";
            this.refTB.Size = new System.Drawing.Size(224, 22);
            this.refTB.TabIndex = 29;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(40, 734);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 16);
            this.statusLabel.TabIndex = 28;
            this.statusLabel.Text = "Status";
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Location = new System.Drawing.Point(40, 696);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(100, 16);
            this.checkoutLabel.TabIndex = 27;
            this.checkoutLabel.Text = "Check Out Date";
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Location = new System.Drawing.Point(40, 658);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(90, 16);
            this.checkinLabel.TabIndex = 26;
            this.checkinLabel.Text = "Check In Date";
            // 
            // roomNumLabel
            // 
            this.roomNumLabel.AutoSize = true;
            this.roomNumLabel.Location = new System.Drawing.Point(40, 586);
            this.roomNumLabel.Name = "roomNumLabel";
            this.roomNumLabel.Size = new System.Drawing.Size(95, 16);
            this.roomNumLabel.TabIndex = 24;
            this.roomNumLabel.Text = "Room Number";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(40, 464);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(58, 16);
            this.idLabel.TabIndex = 22;
            this.idLabel.Text = "Guest ID";
            // 
            // refLabel
            // 
            this.refLabel.AutoSize = true;
            this.refLabel.Location = new System.Drawing.Point(40, 427);
            this.refLabel.Name = "refLabel";
            this.refLabel.Size = new System.Drawing.Size(121, 16);
            this.refLabel.TabIndex = 21;
            this.refLabel.Text = "Reference Number";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Location = new System.Drawing.Point(40, 622);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(79, 16);
            this.roomTypeLabel.TabIndex = 25;
            this.roomTypeLabel.Text = "Room Type";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 503);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 16);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "Guest Name";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(181, 497);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(319, 22);
            this.nameTB.TabIndex = 31;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(43, 545);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(97, 16);
            this.phoneLabel.TabIndex = 37;
            this.phoneLabel.Text = "Phone Number";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(181, 539);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(177, 22);
            this.phoneTB.TabIndex = 38;
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(634, 85);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(177, 22);
            this.searchTB.TabIndex = 39;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(829, 83);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(96, 27);
            this.searchBtn.TabIndex = 40;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Reference Number";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(660, 497);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(85, 40);
            this.editBtn.TabIndex = 42;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(660, 559);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(85, 43);
            this.deleteBtn.TabIndex = 43;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(560, 748);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(103, 36);
            this.confirmBtn.TabIndex = 44;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(695, 748);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(103, 36);
            this.cancelBtn.TabIndex = 45;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // roomTypeCB
            // 
            this.roomTypeCB.FormattingEnabled = true;
            this.roomTypeCB.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin",
            "Suite",
            "Presidential"});
            this.roomTypeCB.Location = new System.Drawing.Point(181, 614);
            this.roomTypeCB.Name = "roomTypeCB";
            this.roomTypeCB.Size = new System.Drawing.Size(150, 24);
            this.roomTypeCB.TabIndex = 46;
            // 
            // checkinDTP
            // 
            this.checkinDTP.Location = new System.Drawing.Point(181, 652);
            this.checkinDTP.Name = "checkinDTP";
            this.checkinDTP.Size = new System.Drawing.Size(255, 22);
            this.checkinDTP.TabIndex = 47;
            // 
            // checkoutDTP
            // 
            this.checkoutDTP.Location = new System.Drawing.Point(181, 690);
            this.checkoutDTP.Name = "checkoutDTP";
            this.checkoutDTP.Size = new System.Drawing.Size(255, 22);
            this.checkoutDTP.TabIndex = 48;
            // 
            // BookingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 810);
            this.Controls.Add(this.checkoutDTP);
            this.Controls.Add(this.checkinDTP);
            this.Controls.Add(this.roomTypeCB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.statusTB);
            this.Controls.Add(this.roomNumTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.refTB);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.checkoutLabel);
            this.Controls.Add(this.checkinLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.roomNumLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.refLabel);
            this.Controls.Add(this.bookingLV);
            this.Controls.Add(this.label1);
            this.Name = "BookingListForm";
            this.Text = "Booking List Form";
            this.Activated += new System.EventHandler(this.BookingListForm_Activated);
            this.Load += new System.EventHandler(this.BookingListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView bookingLV;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.TextBox roomNumTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox refTB;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.Label checkinLabel;
        private System.Windows.Forms.Label roomNumLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label refLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox roomTypeCB;
        private System.Windows.Forms.DateTimePicker checkinDTP;
        private System.Windows.Forms.DateTimePicker checkoutDTP;
    }
}