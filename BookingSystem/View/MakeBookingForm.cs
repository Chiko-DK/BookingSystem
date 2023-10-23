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
    public partial class MakeBookingForm : Form
    {
        #region Data Members
        RoomListingForm roomListingForm;
        private BookingController bookCtrl;
        public bool makeBookingFormClosed = false;
        #endregion

        #region Property Methods
        //public Reservation getReservation { get { return res; } set { res = value; } }
        //public Room getRoom { get { return room; } set { room = value; } }
        #endregion

        #region Constructor
        public MakeBookingForm()
        {
            InitializeComponent();
            checkinDTP.MinDate = DateTime.Today;
            checkoutDTP.MinDate = DateTime.Today;
            bookCtrl = new BookingController();
        }

        public MakeBookingForm(BookingController bookCtrl) //try this
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            checkinDTP.MinDate = DateTime.Today;
            checkoutDTP.MinDate = DateTime.Today.AddDays(1);
            this.bookCtrl = bookCtrl;
        }
        #endregion

        #region Utility Methods
        private void PopulateObject()
        {
            //bookCtrl.getReservation = new Reservation();
            bookCtrl.getReservation.CheckIn = checkinDTP.Value;
            bookCtrl.getReservation.CheckOut = checkoutDTP.Value;

            //bookCtrl.getRoom = new Room();
            bookCtrl.getRoom.setRoomType(roomtypeCB.Text);
        }

        private void CreateRoomListingForm()
        {
            PopulateObject();
            roomListingForm = new RoomListingForm(bookCtrl);
            roomListingForm.StartPosition = FormStartPosition.Manual;
            roomListingForm.Location = new Point(600, 100);
            roomListingForm.Show();

        }
        #endregion

        #region Form Events

        private void exitBtn_Click(object sender, EventArgs e)
        {
            makeBookingFormClosed = true;
            this.Close();            
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (roomListingForm == null)
            {
                CreateRoomListingForm();
            }
            if (roomListingForm.roomListFormClosed)
            {
                CreateRoomListingForm();
            }
        }

        private void checkinDTP_ValueChanged(object sender, EventArgs e)
        {
            if(checkinDTP.Value >= checkoutDTP.Value)
            {
                checkoutDTP.Value = checkinDTP.Value.AddDays(1);
            }
        }

        private void checkoutDTP_ValueChanged(object sender, EventArgs e)
        {
            if (checkoutDTP.Value <= checkinDTP.Value)
            {
                checkoutDTP.Value = checkinDTP.Value.AddDays(1);
            }
        }
        private void MakeBookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            makeBookingFormClosed = true;
            if (roomListingForm != null && !(roomListingForm.roomListFormClosed))
            {
                roomListingForm.Close();
            }
        }
        #endregion

    }
}
