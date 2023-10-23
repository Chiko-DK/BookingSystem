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
    public partial class BookingListForm : Form
    {
        #region Data Members
        private BookingController bookCtrl;
        private Collection<Reservation> reservations;
        private Reservation res;
        public bool bookingListFormClosed = false;
        private FormState formState;
        public enum FormState
        {
            View,
            Edit,
            Delete
        }
        #endregion

        #region Constructors
        public BookingListForm()
        {
            InitializeComponent();
            bookCtrl = new BookingController();
            formState = FormState.View;
        }

        public BookingListForm(BookingController bookCtrl)
        {
            InitializeComponent();
            this.bookCtrl = bookCtrl;
            checkinDTP.MinDate = DateTime.Today;
            checkoutDTP.MinDate = DateTime.Today.AddDays(1);
            formState = FormState.View;
        }
        #endregion

        #region Setup View List
        private void SetupBookingListView(String id)
        {
            ListViewItem resDetails;
            reservations = null;
            bookingLV.Clear();

            if (id != string.Empty)
            {
                bookCtrl.getReservation = (Reservation)bookCtrl.Find(bookCtrl.getReservation, id);
                if (bookCtrl.getReservation == null)
                {
                    MessageBox.Show("No Reservation Found!");
                    reservations = bookCtrl.AllReservations;
                }
                else
                {
                    reservations = new Collection<Reservation> { bookCtrl.getReservation };
                }
            }
            else
            {
                reservations = bookCtrl.AllReservations;
            }

            bookingLV.Columns.Insert(0, "Reference Number", 120, HorizontalAlignment.Left);
            bookingLV.Columns.Insert(1, "Guest ID", 120, HorizontalAlignment.Left);
            bookingLV.Columns.Insert(2, "Room Number", 120, HorizontalAlignment.Left);
            bookingLV.Columns.Insert(3, "Check In", 120, HorizontalAlignment.Center);
            bookingLV.Columns.Insert(4, "Check Out", 120, HorizontalAlignment.Center);
            bookingLV.Columns.Insert(5, "Total Price", 100, HorizontalAlignment.Center);
            bookingLV.Columns.Insert(6, "Status", 100, HorizontalAlignment.Center);

            foreach (Reservation r in reservations)
            {
                resDetails = new ListViewItem();
                resDetails.Text = r.ReferenceNumber.ToString();
                resDetails.SubItems.Add(r.BGuest.GuestID.ToString());
                resDetails.SubItems.Add(r.BRoom.RoomNumber.ToString());
                resDetails.SubItems.Add(r.CheckIn.Date.ToString());
                resDetails.SubItems.Add(r.CheckOut.Date.ToString());
                resDetails.SubItems.Add(r.TotalPrice.ToString());
                resDetails.SubItems.Add(r.Status.ToString());

                bookingLV.Items.Add(resDetails);
            }
            bookingLV.Refresh();
            bookingLV.GridLines = true;

        }
        #endregion

        #region utility Methods
        private void ShowAll(bool value)
        {
            refLabel.Visible = value;
            refTB.Visible = value;
            idLabel.Visible = value;
            idTB.Visible = value;
            nameLabel.Visible = value;
            nameTB.Visible = value;
            phoneLabel.Visible = value;
            phoneTB.Visible = value;
            roomNumLabel.Visible = value;
            roomNumTB.Visible = value;
            roomTypeLabel.Visible = value;
            roomTypeCB.Visible = value;
            checkinLabel.Visible = value;
            checkinDTP.Visible = value;
            checkoutLabel.Visible = value;
            checkoutDTP.Visible = value;
            statusLabel.Visible = value;
            statusTB.Visible = value;
            editBtn.Visible = value;
            deleteBtn.Visible = value;
            confirmBtn.Visible = false;
        }
        private void EnableEntries(bool value)
        {
            refTB.Enabled = false;
            idTB.Enabled = value;
            nameTB.Enabled = false;
            phoneTB.Enabled = false;
            roomNumTB.Enabled = false;
            roomTypeCB.Enabled = value;
            checkinDTP.Enabled = value;
            checkoutDTP.Enabled = value;
            statusTB.Enabled = false;
        }

        private void PopulateSearchObject()
        {
            bookCtrl.getReservation = new Reservation();
            bookCtrl.getReservation.ReferenceNumber = searchTB.Text;
            if (bookCtrl.getReservation.ReferenceNumber == string.Empty)
            {
                MessageBox.Show("Please enter a Booking Reference Number");
            }
        }

        private void PopulateTextBoxes(Reservation res)
        {
            
            refTB.Text = res.ReferenceNumber;

            idTB.Text = res.BGuest.GuestID;
            Guest g = new Guest();
            g = (Guest)bookCtrl.Find(g, idTB.Text);
            nameTB.Text = g.FirstName + " " + g.LastName;
            phoneTB.Text = g.Phone;

            roomNumTB.Text = res.BRoom.RoomNumber;
            Room r = new Room();
            r = (Room)bookCtrl.Find(r, roomNumTB.Text);
            roomTypeCB.Text = r.getRoomType.ToString();

            checkinDTP.Text = res.CheckIn.Date.ToString();
            checkoutDTP.Text = res.CheckOut.Date.ToString();
            statusTB.Text = res.Status.ToString();
        }

        private void PopulateEditObject()
        {
            res = new Reservation();
            res.ReferenceNumber = refTB.Text;
            res.Status = statusTB.Text;

            res.BGuest.GuestID = idTB.Text;
            res.BGuest = (Guest)bookCtrl.Find(bookCtrl.getGuest, res.BGuest.GuestID);
            if (res.BGuest == null )
            {
                MessageBox.Show("Guest ID was not found in the system");
            }

            res.BRoom.setRoomType(roomTypeCB.Text);
            bookCtrl.getReservation.CheckIn = checkinDTP.Value;
            bookCtrl.getReservation.CheckOut = checkoutDTP.Value;
            Collection<Room> rooms;
            rooms = bookCtrl.FindByTypeAvailability(bookCtrl.AllRooms, res.BRoom.getRoomType);
            if (rooms.Count != 0)
            {
                res.BRoom = rooms[0];
                res.CheckIn = checkinDTP.Value;
                res.CheckOut = checkoutDTP.Value;
                TimeSpan difference = res.CheckOut - res.CheckIn;
                int numOfDays = difference.Days;
                res.TotalPrice = res.BRoom.Price * numOfDays;
            }
            else
            {
                MessageBox.Show("There is no available rooms for that period");
                res.BRoom = null;
            }

            if (res.BGuest != null && res.BRoom != null)
            {
                PopulateTextBoxes(res);
            }
            else
            {
                ShowAll(false);
            }
        }

        #endregion

        #region Form Events
        private void BookingListForm_Load(object sender, EventArgs e)
        {
            bookingLV.View = System.Windows.Forms.View.Details;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            PopulateSearchObject();
            SetupBookingListView(bookCtrl.getReservation.ReferenceNumber);
            searchTB.Clear();
        }

        private void BookingListForm_Activated(object sender, EventArgs e)
        {
            bookingLV.View = System.Windows.Forms.View.Details;
            SetupBookingListView(string.Empty);
            ShowAll(false);
        }

        private void bookingLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            EnableEntries(false);
            if (bookingLV.SelectedItems.Count > 0)
            {
                res = (Reservation)bookCtrl.Find(bookCtrl.getReservation, bookingLV.SelectedItems[0].Text);
                PopulateTextBoxes(res);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            formState = FormState.Edit;
            EnableEntries(true);
            confirmBtn.Visible = true;
            checkinDTP.Value = DateTime.Today;
            checkoutDTP.Value = DateTime.Today.AddDays(1);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            bookingListFormClosed = true;
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(formState == FormState.Edit)
            {
                PopulateEditObject();

                string title = "Confirmation";
                string message = "Do you want to make changes the current booking\nPress 'Yes' to confirm.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if(result == DialogResult.Yes)
                {
                    bookCtrl.DataMaintenance(res, Data.DB.DBOperation.Edit);
                    bookCtrl.FinalizeChanges(res);
                    SetupBookingListView(string.Empty);
                    ShowAll(false);
                }
            }

        }

        private void BookingListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bookingListFormClosed = true;
        }
        #endregion

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            formState = FormState.Delete;
            string title = "Confirmation";
            string message = "The current reservation is about to be deleted\nPress 'OK' to confirm.";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.OK)
            {
                bookCtrl.DataMaintenance(res, Data.DB.DBOperation.Delete);
                bookCtrl.FinalizeChanges(res);
                SetupBookingListView(string.Empty);
                ShowAll(false);
            }
        }

        private void checkinDTP_ValueChanged(object sender, EventArgs e)
        {
            if (checkinDTP.Value >= checkoutDTP.Value)
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
    }
}
