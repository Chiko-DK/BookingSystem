using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Reservation
    {
        #region data members
        private string refNumber; // ref number
        private Guest guest;    //type Guest
        private Room room;   // type Room
        private DateTime checkIn_date;   // type Date
        private DateTime checkOut_date;  //type Date
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

        /*public Reservation()
        {
            ID = "";
            guest = "";
            room = "";
            checkIn_date = "";
            checkOut_date = "";
            ReservationRef_number = "";
            Status = "";


        }*/
        #endregion 





    }

}
