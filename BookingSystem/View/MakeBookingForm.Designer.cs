namespace BookingSystem.View
{
    partial class MakeBookingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomtypeCB = new System.Windows.Forms.ComboBox();
            this.checkoutDTP = new System.Windows.Forms.DateTimePicker();
            this.checkinDTP = new System.Windows.Forms.DateTimePicker();
            this.enterBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter booking details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Type";
            // 
            // roomtypeCB
            // 
            this.roomtypeCB.DisplayMember = "Room Type";
            this.roomtypeCB.FormattingEnabled = true;
            this.roomtypeCB.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin",
            "Suite",
            "Presidential"});
            this.roomtypeCB.Location = new System.Drawing.Point(197, 205);
            this.roomtypeCB.Name = "roomtypeCB";
            this.roomtypeCB.Size = new System.Drawing.Size(170, 24);
            this.roomtypeCB.TabIndex = 4;
            this.roomtypeCB.ValueMember = "Room Type";
            // 
            // checkoutDTP
            // 
            this.checkoutDTP.Location = new System.Drawing.Point(197, 144);
            this.checkoutDTP.Name = "checkoutDTP";
            this.checkoutDTP.Size = new System.Drawing.Size(250, 22);
            this.checkoutDTP.TabIndex = 5;
            this.checkoutDTP.ValueChanged += new System.EventHandler(this.checkoutDTP_ValueChanged);
            // 
            // checkinDTP
            // 
            this.checkinDTP.Location = new System.Drawing.Point(197, 101);
            this.checkinDTP.Name = "checkinDTP";
            this.checkinDTP.Size = new System.Drawing.Size(250, 22);
            this.checkinDTP.TabIndex = 6;
            this.checkinDTP.Value = new System.DateTime(2023, 10, 6, 0, 0, 0, 0);
            this.checkinDTP.ValueChanged += new System.EventHandler(this.checkinDTP_ValueChanged);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(452, 289);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(107, 32);
            this.enterBtn.TabIndex = 7;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(617, 289);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(87, 32);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MakeBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.checkinDTP);
            this.Controls.Add(this.checkoutDTP);
            this.Controls.Add(this.roomtypeCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MakeBookingForm";
            this.Text = "Make A Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roomtypeCB;
        private System.Windows.Forms.DateTimePicker checkoutDTP;
        private System.Windows.Forms.DateTimePicker checkinDTP;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}