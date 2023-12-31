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
    public partial class RoomListingForm : Form
    {
        #region Data Members
        GuestListForm guestListForm;
        private Collection<Room> rooms;
        private BookingController bookCtrl;
        public bool roomListFormClosed = false;
        #endregion

        #region Property Methods
        //public Reservation getReservation { get { return res; } set { res = value; } }
        //public Room getRoom { get { return room; } set { room = value; } }
        #endregion

        #region Constructors
        public RoomListingForm()
        {
            InitializeComponent();
            bookCtrl = new BookingController();
        }

        public RoomListingForm(BookingController bookCtrl)
        {
            InitializeComponent();
            this.bookCtrl = bookCtrl;
        }
        #endregion

        #region ListView set up
        public void setUpRoomListView()
        {
            ListViewItem roomDetails;
            rooms = null;
            roomLV.Clear();

            if(bookCtrl.getRoom.getRoomType == Room.RoomType.Null)
            {
                rooms = bookCtrl.FindByAvailability(bookCtrl.AllRooms);
            }
            else
            {
                rooms = bookCtrl.FindByTypeAvailability(bookCtrl.AllRooms, bookCtrl.getRoom.getRoomType);
            }

            roomLV.Columns.Insert(0, "Room Number", 120, HorizontalAlignment.Left);
            roomLV.Columns.Insert(1, "Room Type", 120, HorizontalAlignment.Left);
            roomLV.Columns.Insert(2, "Price", 100, HorizontalAlignment.Center);
            roomLV.Columns.Insert(3, "isAvailable", 100, HorizontalAlignment.Center);

            foreach (Room r in rooms)
            {
                roomDetails = new ListViewItem();
                roomDetails.Text = r.RoomNumber.ToString();
                roomDetails.SubItems.Add(r.getRoomType.ToString());
                roomDetails.SubItems.Add(r.Price.ToString());
                roomDetails.SubItems.Add(r.IsAvailable.ToString());

                roomLV.Items.Add(roomDetails);
            }
            roomLV.Refresh();
            roomLV.GridLines = true;
        }
        #endregion

        #region Utility methods
        private void ShowAll(bool value)
        {
            roomDetailsLabel.Visible = value;
            roomDetailsTB.Visible = value;
            confirmBtn.Visible = value;
        }

        private void PopulateTextBox(Room room)
        {
            roomDetailsTB.Text = room.Description;
        }

        private void CreateGuestListForm ()
        {
            guestListForm = new GuestListForm(bookCtrl);
            guestListForm.StartPosition = FormStartPosition.Manual;
            guestListForm.Location = new Point(600, 100);
            guestListForm.Show();
        }
        #endregion

        #region Form Events
        private void RoomListingForm_Load(object sender, EventArgs e)
        {
            roomLV.View = System.Windows.Forms.View.Details;
        }

        private void RoomListingForm_Activated(object sender, EventArgs e)
        {
            roomLV.View = System.Windows.Forms.View.Details;
            setUpRoomListView();
            ShowAll(false);
        }

        private void roomLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            if (roomLV.SelectedItems.Count > 0)
            {
                bookCtrl.getRoom = (Room)bookCtrl.Find(bookCtrl.getRoom, roomLV.SelectedItems[0].Text);
                PopulateTextBox(bookCtrl.getRoom);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            roomListFormClosed = true;
            this.Close();
            //makeBookingForm.Show();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (guestListForm == null)
            {
                CreateGuestListForm();
            }
            if (guestListForm.guestFormClosed)
            {
                CreateGuestListForm();
            }
        }
        #endregion

        private void RoomListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            roomListFormClosed = true;
            if(guestListForm!= null && !(guestListForm.guestFormClosed))
            {
                guestListForm.Close();
            }
        }
    }
}
