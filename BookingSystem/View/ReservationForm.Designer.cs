namespace BookingSystem.View
{
    partial class ReservationForm
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
            this.proceedBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.cardLabel = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.cardTB = new System.Windows.Forms.TextBox();
            this.refLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.roomNumLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.checkinLabel = new System.Windows.Forms.Label();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.refTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.roomNumTB = new System.Windows.Forms.TextBox();
            this.roomTypeTB = new System.Windows.Forms.TextBox();
            this.checkinTB = new System.Windows.Forms.TextBox();
            this.checkoutTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.depositLabel = new System.Windows.Forms.Label();
            this.depositTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // proceedBtn
            // 
            this.proceedBtn.Location = new System.Drawing.Point(494, 487);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(81, 33);
            this.proceedBtn.TabIndex = 0;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.UseVisualStyleBackColor = true;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(623, 487);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 33);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(42, 452);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(87, 16);
            this.cardLabel.TabIndex = 2;
            this.cardLabel.Text = "Card Number";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(45, 29);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(125, 16);
            this.resLabel.TabIndex = 3;
            this.resLabel.Text = "Reservation Details";
            // 
            // cardTB
            // 
            this.cardTB.Location = new System.Drawing.Point(183, 446);
            this.cardTB.Name = "cardTB";
            this.cardTB.Size = new System.Drawing.Size(288, 22);
            this.cardTB.TabIndex = 4;
            // 
            // refLabel
            // 
            this.refLabel.AutoSize = true;
            this.refLabel.Location = new System.Drawing.Point(42, 80);
            this.refLabel.Name = "refLabel";
            this.refLabel.Size = new System.Drawing.Size(121, 16);
            this.refLabel.TabIndex = 5;
            this.refLabel.Text = "Reference Number";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(42, 117);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(58, 16);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "Guest ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(42, 156);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 16);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Guest Name";
            // 
            // roomNumLabel
            // 
            this.roomNumLabel.AutoSize = true;
            this.roomNumLabel.Location = new System.Drawing.Point(42, 194);
            this.roomNumLabel.Name = "roomNumLabel";
            this.roomNumLabel.Size = new System.Drawing.Size(95, 16);
            this.roomNumLabel.TabIndex = 8;
            this.roomNumLabel.Text = "Room Number";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Location = new System.Drawing.Point(42, 230);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(79, 16);
            this.roomTypeLabel.TabIndex = 9;
            this.roomTypeLabel.Text = "Room Type";
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Location = new System.Drawing.Point(42, 266);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(90, 16);
            this.checkinLabel.TabIndex = 10;
            this.checkinLabel.Text = "Check In Date";
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Location = new System.Drawing.Point(42, 304);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(100, 16);
            this.checkoutLabel.TabIndex = 11;
            this.checkoutLabel.Text = "Check Out Date";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(42, 342);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(72, 16);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Total Price";
            // 
            // refTB
            // 
            this.refTB.Location = new System.Drawing.Point(183, 74);
            this.refTB.Name = "refTB";
            this.refTB.Size = new System.Drawing.Size(224, 22);
            this.refTB.TabIndex = 13;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(183, 111);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(177, 22);
            this.idTB.TabIndex = 14;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(183, 150);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(319, 22);
            this.nameTB.TabIndex = 15;
            // 
            // roomNumTB
            // 
            this.roomNumTB.Location = new System.Drawing.Point(183, 188);
            this.roomNumTB.Name = "roomNumTB";
            this.roomNumTB.Size = new System.Drawing.Size(66, 22);
            this.roomNumTB.TabIndex = 16;
            // 
            // roomTypeTB
            // 
            this.roomTypeTB.Location = new System.Drawing.Point(183, 224);
            this.roomTypeTB.Name = "roomTypeTB";
            this.roomTypeTB.Size = new System.Drawing.Size(150, 22);
            this.roomTypeTB.TabIndex = 17;
            // 
            // checkinTB
            // 
            this.checkinTB.Location = new System.Drawing.Point(183, 260);
            this.checkinTB.Name = "checkinTB";
            this.checkinTB.Size = new System.Drawing.Size(194, 22);
            this.checkinTB.TabIndex = 18;
            // 
            // checkoutTB
            // 
            this.checkoutTB.Location = new System.Drawing.Point(183, 298);
            this.checkoutTB.Name = "checkoutTB";
            this.checkoutTB.Size = new System.Drawing.Size(194, 22);
            this.checkoutTB.TabIndex = 19;
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(183, 336);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(150, 22);
            this.priceTB.TabIndex = 20;
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Location = new System.Drawing.Point(183, 404);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(94, 36);
            this.checkoutBtn.TabIndex = 21;
            this.checkoutBtn.Text = "CheckOut";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(42, 378);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(91, 16);
            this.depositLabel.TabIndex = 22;
            this.depositLabel.Text = "Deposit (10%)";
            // 
            // depositTB
            // 
            this.depositTB.Location = new System.Drawing.Point(183, 372);
            this.depositTB.Name = "depositTB";
            this.depositTB.Size = new System.Drawing.Size(150, 22);
            this.depositTB.TabIndex = 23;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 541);
            this.Controls.Add(this.depositTB);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.checkoutTB);
            this.Controls.Add(this.checkinTB);
            this.Controls.Add(this.roomTypeTB);
            this.Controls.Add(this.roomNumTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.refTB);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.checkoutLabel);
            this.Controls.Add(this.checkinLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.roomNumLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.refLabel);
            this.Controls.Add(this.cardTB);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.proceedBtn);
            this.Name = "ReservationForm";
            this.Text = "Reservation Form";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button proceedBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.TextBox cardTB;
        private System.Windows.Forms.Label refLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label roomNumLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label checkinLabel;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox refTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox roomNumTB;
        private System.Windows.Forms.TextBox roomTypeTB;
        private System.Windows.Forms.TextBox checkinTB;
        private System.Windows.Forms.TextBox checkoutTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.TextBox depositTB;
    }
}