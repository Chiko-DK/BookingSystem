namespace BookingSystem.View
{
    partial class RoomListingForm
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
            this.roomLV = new System.Windows.Forms.ListView();
            this.roomDetailsLabel = new System.Windows.Forms.Label();
            this.roomDetailsTB = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Available Rooms";
            // 
            // roomLV
            // 
            this.roomLV.HideSelection = false;
            this.roomLV.Location = new System.Drawing.Point(70, 86);
            this.roomLV.Name = "roomLV";
            this.roomLV.Size = new System.Drawing.Size(629, 229);
            this.roomLV.TabIndex = 1;
            this.roomLV.UseCompatibleStateImageBehavior = false;
            this.roomLV.SelectedIndexChanged += new System.EventHandler(this.roomLV_SelectedIndexChanged);
            // 
            // roomDetailsLabel
            // 
            this.roomDetailsLabel.AutoSize = true;
            this.roomDetailsLabel.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDetailsLabel.Location = new System.Drawing.Point(70, 333);
            this.roomDetailsLabel.Name = "roomDetailsLabel";
            this.roomDetailsLabel.Size = new System.Drawing.Size(184, 22);
            this.roomDetailsLabel.TabIndex = 2;
            this.roomDetailsLabel.Text = "Room Description";
            // 
            // roomDetailsTB
            // 
            this.roomDetailsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDetailsTB.Location = new System.Drawing.Point(73, 368);
            this.roomDetailsTB.Multiline = true;
            this.roomDetailsTB.Name = "roomDetailsTB";
            this.roomDetailsTB.ReadOnly = true;
            this.roomDetailsTB.Size = new System.Drawing.Size(405, 163);
            this.roomDetailsTB.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(586, 378);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(96, 41);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(586, 437);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(96, 41);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // RoomListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 543);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.roomDetailsTB);
            this.Controls.Add(this.roomDetailsLabel);
            this.Controls.Add(this.roomLV);
            this.Controls.Add(this.label1);
            this.Name = "RoomListingForm";
            this.Text = "RoomListingForm";
            this.Activated += new System.EventHandler(this.RoomListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomListingForm_FormClosed);
            this.Load += new System.EventHandler(this.RoomListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView roomLV;
        private System.Windows.Forms.Label roomDetailsLabel;
        private System.Windows.Forms.TextBox roomDetailsTB;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
    }
}