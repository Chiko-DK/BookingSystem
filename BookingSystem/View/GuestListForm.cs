using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.View
{
    public partial class GuestListForm : Form
    {
        #region Data members
        NewGuestForm newGuestForm;
        ReservationForm reservationForm;
        private BookingController bookCtrl;
        private Collection<Guest> guests;
        public bool guestFormClosed = false;
        #endregion

        #region Property Methods
        #endregion

        #region Constructors
        public GuestListForm()
        {
            InitializeComponent();
            bookCtrl = new BookingController();
        }

        public GuestListForm(BookingController bookCtrl)
        {
            InitializeComponent();
            this.bookCtrl = bookCtrl;
        }
        #endregion

        #region List View
        private void SetupGuestListView(String id)
        {
            ListViewItem guestDetails;
            guests = null;
            guestLV.Clear();

            if (id != string.Empty)
            {
                bookCtrl.getGuest = (Guest)bookCtrl.Find(bookCtrl.getGuest, id);
                if ( bookCtrl.getGuest == null)
                {
                    MessageBox.Show("No Guest Found!");
                    guests = bookCtrl.AllGuests;
                }
                else
                {  
                    guests = new Collection<Guest> { bookCtrl.getGuest };
                }
            }
            else
            {
                guests = bookCtrl.AllGuests;
            }

            guestLV.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            guestLV.Columns.Insert(1, "First Name", 120, HorizontalAlignment.Left);
            guestLV.Columns.Insert(2, "Last Name", 120, HorizontalAlignment.Left);
            guestLV.Columns.Insert(3, "Phone", 120, HorizontalAlignment.Left);
            guestLV.Columns.Insert(4, "Email", 170, HorizontalAlignment.Left);

            foreach(Guest g in guests)
            {
                guestDetails = new ListViewItem();
                guestDetails.Text = g.GuestID.ToString();
                guestDetails.SubItems.Add(g.FirstName.ToString());
                guestDetails.SubItems.Add(g.LastName.ToString());
                guestDetails.SubItems.Add(g.Phone.ToString());
                guestDetails.SubItems.Add(g.Email.ToString());

                guestLV.Items.Add(guestDetails);
            }
            guestLV.Refresh();
            guestLV.GridLines = true;


        }
        #endregion

        #region Utility Methods
        private void PopulateObject()
        {
            bookCtrl.getGuest = new Guest();
            bookCtrl.getGuest.GuestID = searchTB.Text;
            if (bookCtrl.getGuest.GuestID == string.Empty)
            {
                MessageBox.Show("Please enter a Guest ID");
            }
        }

        private void CreateReservationForm()
        {
            reservationForm = new ReservationForm(bookCtrl);
            reservationForm.Show();
        }
        private void CreateNewGuestForm()
        {
            newGuestForm = new NewGuestForm(bookCtrl);
            newGuestForm.Show();
        }
        #endregion

        #region Form Events
        private void addGuestBtn_Click(object sender, EventArgs e)
        {
            if(newGuestForm == null)
            {
                CreateNewGuestForm();
            }
            if (newGuestForm.newGuestFormClosed)
            {
                CreateNewGuestForm();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            PopulateObject();
            SetupGuestListView(bookCtrl.getGuest.GuestID);
            searchTB.Clear();
        }

        private void GuestListForm_Activated(object sender, EventArgs e)
        {
            guestLV.View = System.Windows.Forms.View.Details;
            resbtn.Visible = false;
            SetupGuestListView(string.Empty);

        }

        private void GuestListForm_Load(object sender, EventArgs e)
        {
            guestLV.View = System.Windows.Forms.View.Details;
            SetupGuestListView(string.Empty);
        }

        private void guestLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            resbtn.Visible = true;
            if (guestLV.SelectedItems.Count > 0)
            {
                bookCtrl.getGuest = (Guest)bookCtrl.Find(bookCtrl.getGuest, guestLV.SelectedItems[0].Text);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            guestFormClosed = true;
            this.Close();
        }

        private void resbtn_Click(object sender, EventArgs e)
        {
            if (reservationForm == null)
            {
                CreateReservationForm();
            }
            if (reservationForm.reservationFormClosed)
            {
                CreateReservationForm();
            }
        }
        #endregion

        private void GuestListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            guestFormClosed = true;
            if (reservationForm != null && !(reservationForm.reservationFormClosed))
            {
                reservationForm.Close();
            }
            if (newGuestForm != null && !(newGuestForm.newGuestFormClosed))
            {
                newGuestForm.Close();
            }
        }
    }
}
