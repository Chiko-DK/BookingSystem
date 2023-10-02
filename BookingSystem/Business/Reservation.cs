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
        private string _ID; // ref number
        private Guest guest;    //type Guest
        private Room room;   // type Room
        private DateTime checkIn_date;   // type Date
        private DateTime checkOut_date;  //type Date
        private string _ReservationRef_number;
        private string _Status;
        #endregion

        #region properties
        public string ID { get { return _ID; } set { _ID = value; } }
        public Guest BGuest { get { return guest; } set { guest = value; } }
        public Room BRoom { get { return room; } set { room = value; } }
        public DateTime CheckIn_date { get { return checkIn_date; } set { checkIn_date = value; } }
        public DateTime CheckOut_date { get { return checkOut_date; } set { checkOut_date = value; } }
        public string ReservationRef_number { get { return _ReservationRef_number; } set { _ReservationRef_number = value; } }
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
