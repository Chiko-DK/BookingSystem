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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addGuestBtn
            // 
            this.addGuestBtn.Location = new System.Drawing.Point(567, 65);
            this.addGuestBtn.Name = "addGuestBtn";
            this.addGuestBtn.Size = new System.Drawing.Size(129, 38);
            this.addGuestBtn.TabIndex = 1;
            this.addGuestBtn.Text = "Add New Guest";
            this.addGuestBtn.UseVisualStyleBackColor = true;
            this.addGuestBtn.Click += new System.EventHandler(this.addGuestBtn_Click);
            // 
            // resbtn
            // 
            this.resbtn.Location = new System.Drawing.Point(506, 362);
            this.resbtn.Name = "resbtn";
            this.resbtn.Size = new System.Drawing.Size(162, 33);
            this.resbtn.TabIndex = 2;
            this.resbtn.Text = "Create Reservation";
            this.resbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 206);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(69, 46);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(92, 16);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Enter Guest ID";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(246, 80);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(68, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // GuestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resbtn);
            this.Controls.Add(this.addGuestBtn);
            this.Name = "GuestListForm";
            this.Text = "Guest List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addGuestBtn;
        private System.Windows.Forms.Button resbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchBtn;
    }
}