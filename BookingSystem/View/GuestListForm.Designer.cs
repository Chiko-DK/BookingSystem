namespace BookingSystem.View
{
    partial class GuestListForm
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
            this.addGuestBtn = new System.Windows.Forms.Button();
            this.resbtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.guestLV = new System.Windows.Forms.ListView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addGuestBtn
            // 
            this.addGuestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGuestBtn.Location = new System.Drawing.Point(567, 56);
            this.addGuestBtn.Name = "addGuestBtn";
            this.addGuestBtn.Size = new System.Drawing.Size(129, 38);
            this.addGuestBtn.TabIndex = 1;
            this.addGuestBtn.Text = "Add New Guest";
            this.addGuestBtn.UseVisualStyleBackColor = true;
            this.addGuestBtn.Click += new System.EventHandler(this.addGuestBtn_Click);
            // 
            // resbtn
            // 
            this.resbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resbtn.Location = new System.Drawing.Point(407, 372);
            this.resbtn.Name = "resbtn";
            this.resbtn.Size = new System.Drawing.Size(162, 33);
            this.resbtn.TabIndex = 2;
            this.resbtn.Text = "Create Reservation";
            this.resbtn.UseVisualStyleBackColor = true;
            this.resbtn.Click += new System.EventHandler(this.resbtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(72, 72);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(155, 22);
            this.searchTB.TabIndex = 3;
            // 
            // guestLV
            // 
            this.guestLV.HideSelection = false;
            this.guestLV.Location = new System.Drawing.Point(44, 110);
            this.guestLV.Name = "guestLV";
            this.guestLV.Size = new System.Drawing.Size(700, 243);
            this.guestLV.TabIndex = 4;
            this.guestLV.UseCompatibleStateImageBehavior = false;
            this.guestLV.SelectedIndexChanged += new System.EventHandler(this.guestLV_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(69, 46);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(106, 16);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Enter Guest ID";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(246, 71);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(68, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(614, 372);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(82, 32);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // GuestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.guestLV);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.resbtn);
            this.Controls.Add(this.addGuestBtn);
            this.Name = "GuestListForm";
            this.Text = "Guest List";
            this.Activated += new System.EventHandler(this.GuestListForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuestListForm_FormClosed);
            this.Load += new System.EventHandler(this.GuestListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addGuestBtn;
        private System.Windows.Forms.Button resbtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.ListView guestLV;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}