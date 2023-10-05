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

namespace BookingSystem.View
{
    public partial class GuestListForm : Form
    {
        #region Data members
        RoomListingForm roomListingForm;
        NewGuestForm newGuestForm;
        private BookingController bookCtrl;
        private Reservation res;
        private Room room;
        private Guest guest;
        #endregion

        #region Property Methods
        public Reservation getReservation { get { return res; } set { res = value; } }
        public Room getRoom { get { return room; } set { room = value; } }
        public Guest getGuest { get { return guest; } set { guest = value; } }
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

        private void addGuestBtn_Click(object sender, EventArgs e)
        {
            newGuestForm = new NewGuestForm();
        }
    }
}
