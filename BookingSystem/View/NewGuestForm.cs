﻿using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookingSystem.View
{
    public partial class NewGuestForm : Form
    {
        #region Data Members
        private Guest guest;
        private BookingController bookCtrl;

        #endregion

        #region Constructor
        public NewGuestForm()
        {
            InitializeComponent();
            bookCtrl = new BookingController();
        }

        public NewGuestForm(BookingController bookingController)
        {
            InitializeComponent();
            this.bookCtrl = bookingController;
        }
        #endregion

        #region Utility Methods
        private void ClearAll()
        {
            idTB.Text = string.Empty;
            fnameTB.Text = string.Empty;
            lnameTB.Text = string.Empty;
            phoneTB.Text = string.Empty;
            emailTB.Text = string.Empty;
        }

        private void PopulateObject()
        {
            guest = new Guest();
            guest.ID = idTB.Text;
            guest.FirstName = fnameTB.Text;
            guest.LastName = lnameTB.Text;
            guest.Email = emailTB.Text;
            guest.Phone = phoneTB.Text;
        }
        #endregion

        #region Form Events

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

 

        private void addBtn_Click(object sender, EventArgs e)
        {
            PopulateObject();
            bookCtrl.DataMaintenance(guest);
            bookCtrl.FinalizeChanges(guest);
            ClearAll();
            MessageBox.Show("New guest has been added to the Database!");
            //this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}