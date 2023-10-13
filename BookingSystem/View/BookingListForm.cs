﻿using BookingSystem.Business;
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
        private BookingController bookCtrl;
        private Collection<Reservation> reservations;
        private Reservation res;

        #region Constructors
        public BookingListForm()
        {
            InitializeComponent();
            bookCtrl = new BookingController();
        }

        public BookingListForm(BookingController bookCtrl)
        {
            InitializeComponent();
            this.bookCtrl = bookCtrl;
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
                if (bookCtrl.getGuest == null)
                {
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
        #endregion

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
            EnableEntries(true);
            confirmBtn.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //didn't finish :(
        }
    }
}