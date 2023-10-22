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
            this.proceedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.Location = new System.Drawing.Point(541, 539);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(81, 33);
            this.proceedBtn.TabIndex = 0;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.UseVisualStyleBackColor = true;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(670, 539);
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
            this.cardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLabel.Location = new System.Drawing.Point(42, 476);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(98, 16);
            this.cardLabel.TabIndex = 2;
            this.cardLabel.Text = "Card Number";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLabel.Location = new System.Drawing.Point(27, 27);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(175, 20);
            this.resLabel.TabIndex = 3;
            this.resLabel.Text = "Reservation Details";
            // 
            // cardTB
            // 
            this.cardTB.Location = new System.Drawing.Point(216, 470);
            this.cardTB.Name = "cardTB";
            this.cardTB.Size = new System.Drawing.Size(288, 22);
            this.cardTB.TabIndex = 4;
            // 
            // refLabel
            // 
            this.refLabel.AutoSize = true;
            this.refLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refLabel.Location = new System.Drawing.Point(42, 89);
            this.refLabel.Name = "refLabel";
            this.refLabel.Size = new System.Drawing.Size(137, 16);
            this.refLabel.TabIndex = 5;
            this.refLabel.Text = "Reference Number";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(42, 126);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(66, 16);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "Guest ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(42, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(92, 16);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Guest Name";
            // 
            // roomNumLabel
            // 
            this.roomNumLabel.AutoSize = true;
            this.roomNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumLabel.Location = new System.Drawing.Point(42, 203);
            this.roomNumLabel.Name = "roomNumLabel";
            this.roomNumLabel.Size = new System.Drawing.Size(106, 16);
            this.roomNumLabel.TabIndex = 8;
            this.roomNumLabel.Text = "Room Number";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.Location = new System.Drawing.Point(42, 239);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(88, 16);
            this.roomTypeLabel.TabIndex = 9;
            this.roomTypeLabel.Text = "Room Type";
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinLabel.Location = new System.Drawing.Point(42, 275);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(103, 16);
            this.checkinLabel.TabIndex = 10;
            this.checkinLabel.Text = "Check In Date";
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLabel.Location = new System.Drawing.Point(42, 313);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(114, 16);
            this.checkoutLabel.TabIndex = 11;
            this.checkoutLabel.Text = "Check Out Date";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(42, 351);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(83, 16);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Total Price";
            // 
            // refTB
            // 
            this.refTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refTB.Location = new System.Drawing.Point(216, 83);
            this.refTB.Name = "refTB";
            this.refTB.ReadOnly = true;
            this.refTB.Size = new System.Drawing.Size(224, 22);
            this.refTB.TabIndex = 13;
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(216, 120);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(177, 22);
            this.idTB.TabIndex = 14;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(216, 159);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(319, 22);
            this.nameTB.TabIndex = 15;
            // 
            // roomNumTB
            // 
            this.roomNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumTB.Location = new System.Drawing.Point(216, 197);
            this.roomNumTB.Name = "roomNumTB";
            this.roomNumTB.ReadOnly = true;
            this.roomNumTB.Size = new System.Drawing.Size(66, 22);
            this.roomNumTB.TabIndex = 16;
            // 
            // roomTypeTB
            // 
            this.roomTypeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeTB.Location = new System.Drawing.Point(216, 233);
            this.roomTypeTB.Name = "roomTypeTB";
            this.roomTypeTB.ReadOnly = true;
            this.roomTypeTB.Size = new System.Drawing.Size(150, 22);
            this.roomTypeTB.TabIndex = 17;
            // 
            // checkinTB
            // 
            this.checkinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinTB.Location = new System.Drawing.Point(216, 269);
            this.checkinTB.Name = "checkinTB";
            this.checkinTB.ReadOnly = true;
            this.checkinTB.Size = new System.Drawing.Size(194, 22);
            this.checkinTB.TabIndex = 18;
            // 
            // checkoutTB
            // 
            this.checkoutTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutTB.Location = new System.Drawing.Point(216, 307);
            this.checkoutTB.Name = "checkoutTB";
            this.checkoutTB.ReadOnly = true;
            this.checkoutTB.Size = new System.Drawing.Size(194, 22);
            this.checkoutTB.TabIndex = 19;
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTB.Location = new System.Drawing.Point(216, 345);
            this.priceTB.Name = "priceTB";
            this.priceTB.ReadOnly = true;
            this.priceTB.Size = new System.Drawing.Size(150, 22);
            this.priceTB.TabIndex = 20;
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.Location = new System.Drawing.Point(216, 421);
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
            this.depositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(42, 387);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(104, 16);
            this.depositLabel.TabIndex = 22;
            this.depositLabel.Text = "Deposit (10%)";
            // 
            // depositTB
            // 
            this.depositTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositTB.Location = new System.Drawing.Point(216, 381);
            this.depositTB.Name = "depositTB";
            this.depositTB.ReadOnly = true;
            this.depositTB.Size = new System.Drawing.Size(150, 22);
            this.depositTB.TabIndex = 23;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 595);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationForm_FormClosed);
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