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
    public partial class ReservationForm : Form
    {
        #region Data Members
        private BookingController bookCtrl;
        private Reservation reservation;
        //private Room room;
        //private Guest guest;
        #endregion

        #region Property Methods
        public Reservation getReservation { get { return reservation; } set { reservation = value; } }
        //public Room getRoom { get { return room; } set { room = value; } }
        //public Guest getGuest { get { return guest; } set { guest = value; } }
        #endregion

        #region Constructors
        public ReservationForm()
        {
            InitializeComponent();
            bookCtrl = new BookingController();
        }

        public ReservationForm(BookingController bookCtrl)
        {
            InitializeComponent();
            this.bookCtrl = bookCtrl;
        }
        #endregion

        #region Utility methods
        private void ShowAll(bool value)
        {
            cardLabel.Visible = value;
            cardTB.Visible = value;
            proceedBtn.Visible = value;
            checkoutBtn.Visible = !value;
        }

        private void EnableEntries(bool value)
        {
            refTB.Enabled = value;
            idTB.Enabled = value;
            nameTB.Enabled = value;
            roomNumTB.Enabled = value;
            roomTypeTB.Enabled = value;
            checkinTB.Enabled = value;
            checkoutTB.Enabled = value;
            priceTB.Enabled = value;
            depositTB.Enabled = value;
        }

        private void CreateReservationObject()
        {
            reservation = new Reservation();
            Random rand = new Random();
            string refNum = rand.Next(100000, 1000000).ToString();
            Reservation res = (Reservation)bookCtrl.Find(bookCtrl.getReservation, refNum);
            while (res != null)
            {
                refNum = rand.Next(100000, 1000000).ToString();
                res = (Reservation)bookCtrl.Find(reservation, refNum);
            }
            reservation.ReferenceNumber = refNum;
            reservation.BGuest = bookCtrl.getGuest;
            reservation.BRoom = bookCtrl.getRoom;
            reservation.CheckIn = bookCtrl.getReservation.CheckIn;
            reservation.CheckOut = bookCtrl.getReservation.CheckOut;
            TimeSpan difference = reservation.CheckOut - reservation.CheckIn;
            int numOfDays = difference.Days;
            reservation.TotalPrice = reservation.BRoom.Price * numOfDays;
            reservation.Status = "Pending";
        }

        private void PopulateTextBoxes()
        {
            refTB.Text = reservation.ReferenceNumber;
            idTB.Text = reservation.BGuest.GuestID;
            nameTB.Text = reservation.BGuest.FirstName + " " + reservation.BGuest.LastName;
            roomNumTB.Text = reservation.BRoom.RoomNumber;
            roomTypeTB.Text = reservation.BRoom.getRoomType.ToString();
            checkinTB.Text = reservation.CheckIn.ToString();
            checkoutTB.Text = reservation.CheckOut.ToString();
            priceTB.Text = reservation.TotalPrice.ToString();
            depositTB.Text = ((decimal)0.1 * reservation.TotalPrice).ToString();
        }
        #endregion

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A new booing is about to be created\nPress 'Yes' to confirm");
            bookCtrl.DataMaintenance(reservation);
            bookCtrl.FinalizeChanges(reservation);
            MessageBox.Show("Added!");
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            ShowAll(false);
            EnableEntries(false);
            CreateReservationObject();
            PopulateTextBoxes();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            ShowAll(true);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
