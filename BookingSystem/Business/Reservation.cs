using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Reservation
    {
        //This class represents each booking transaction
        #region data members
        private string refNumber; // Reference number
        private Guest guest;    //Guest that booked
        private Room room;   // Room booked
        private DateTime checkIn_date;
        private DateTime checkOut_date;
        private decimal totalPrice;
        private string _Status;
        #endregion

        #region properties
        public string ReferenceNumber { get { return refNumber; } set { refNumber = value; } }
        public Guest BGuest { get { return guest; } set { guest = value; } }
        public Room BRoom { get { return room; } set { room = value; } }
        public DateTime CheckIn { get { return checkIn_date; } set { checkIn_date = value; } }
        public DateTime CheckOut { get { return checkOut_date; } set { checkOut_date = value; } }
        public decimal TotalPrice { get { return totalPrice; } set { totalPrice = value; } }
        public string Status { get { return _Status; } set { _Status = value; } }
        #endregion

        #region constructor

        public Reservation()
        {
            guest = new Guest();
            room = new Room();

        }

        public Reservation(Guest guest, Room room)
        {
            this.guest = guest;
            this.room = room;
        }
        #endregion
    }

}
