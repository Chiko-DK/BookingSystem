using BookingSystem.Business;
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
        public bool newGuestFormClosed = false;
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
            guest.GuestID = idTB.Text;
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
            //bookCtrl = new BookingController();
            PopulateObject();
            if (guest.GuestID == string.Empty)
            {
                MessageBox.Show("Please enter a guest ID");
            }
            else
            {
                MessageBox.Show("New guest has been added to the Database!");
                bookCtrl.DataMaintenance(guest);
                bookCtrl.FinalizeChanges(guest);
                ClearAll();
                this.Close();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            newGuestFormClosed = true;
            this.Close();
        }
        #endregion

        private void NewGuestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            newGuestFormClosed = true;
        }
    }
}
