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
        private Reservation res;
        private Room room;
        private BookingController bookCtrl;
        #endregion

        #region Property Methods
        public Reservation getReservation { get { return res; } set { res = value; } }
        public Room getRoom { get { return room; } set { room = value; } }
        #endregion

        #region Constructor
        public MakeBookingForm()
        {
            InitializeComponent();
            checkinDTP.MinDate = DateTime.Today;
            checkoutDTP.MinDate = DateTime.Today;
            bookCtrl = new BookingController();
        }

        public MakeBookingForm(BookingController bookCtrl)
        {
            InitializeComponent();
            this.bookCtrl = bookCtrl;
        }
        #endregion

        #region Utility Methods
        private void PopulateObject()
        {
            res = new Reservation();
            res.CheckIn = checkinDTP.Value;
            res.CheckOut = checkoutDTP.Value;

            room = new Room();
            room.setRoomType(roomtypeCB.Text);


        }

        private void CreateRoomListingForm()
        {
            PopulateObject();
            roomListingForm = new RoomListingForm();
            roomListingForm.getReservation = this.getReservation;
            roomListingForm.getRoom = this.getRoom;
            roomListingForm.Show();
            roomListingForm.StartPosition = FormStartPosition.Manual;
        }
        #endregion

        #region Form Events

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            CreateRoomListingForm();
            //this.Hide();
        }

        private void checkinDTP_ValueChanged(object sender, EventArgs e)
        {
            if(checkinDTP.Value > checkoutDTP.Value)
            {
                checkoutDTP.Value = checkinDTP.Value.AddDays(1);
            }
        }

        private void checkoutDTP_ValueChanged(object sender, EventArgs e)
        {
            if (checkoutDTP.Value < checkinDTP.Value)
            {
                checkoutDTP.Value = checkinDTP.Value.AddDays(1);
            }
        }
        #endregion
    }
}
