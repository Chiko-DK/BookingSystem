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
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Available Rooms";
            // 
            // roomLV
            // 
            this.roomLV.HideSelection = false;
            this.roomLV.Location = new System.Drawing.Point(70, 73);
            this.roomLV.Name = "roomLV";
            this.roomLV.Size = new System.Drawing.Size(629, 229);
            this.roomLV.TabIndex = 1;
            this.roomLV.UseCompatibleStateImageBehavior = false;
            this.roomLV.SelectedIndexChanged += new System.EventHandler(this.roomLV_SelectedIndexChanged);
            // 
            // roomDetailsLabel
            // 
            this.roomDetailsLabel.AutoSize = true;
            this.roomDetailsLabel.Location = new System.Drawing.Point(70, 333);
            this.roomDetailsLabel.Name = "roomDetailsLabel";
            this.roomDetailsLabel.Size = new System.Drawing.Size(87, 16);
            this.roomDetailsLabel.TabIndex = 2;
            this.roomDetailsLabel.Text = "Room details";
            // 
            // roomDetailsTB
            // 
            this.roomDetailsTB.Location = new System.Drawing.Point(73, 368);
            this.roomDetailsTB.Multiline = true;
            this.roomDetailsTB.Name = "roomDetailsTB";
            this.roomDetailsTB.ReadOnly = true;
            this.roomDetailsTB.Size = new System.Drawing.Size(405, 135);
            this.roomDetailsTB.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(586, 368);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(586, 420);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 28);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // RoomListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 515);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.roomDetailsTB);
            this.Controls.Add(this.roomDetailsLabel);
            this.Controls.Add(this.roomLV);
            this.Controls.Add(this.label1);
            this.Name = "RoomListingForm";
            this.Text = "RoomListingForm";
            this.Activated += new System.EventHandler(this.RoomListingForm_Activated);
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