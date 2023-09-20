using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    internal class Reservation
    {
        #region data members
        private string _ID;
        private string _GuestID;
        private string _Room;
        private string _CheckIn_date;
        private string _CheckOut_date;
        private string _ReservationRef_number;
        private string _Status;
        #endregion
        #region properties
        public string ID { get { return _ID; } set { _ID = value; } }
        public string GuestID { get { return _GuestID; } set { _GuestID = value; } }
        public string Room { get { return _Room; } set { _Room = value; } }
        public string CheckIn_date { get { return _CheckIn_date; } set { _CheckIn_date = value; } }
        public string CheckOut_date { get { return _CheckOut_date; } set { _CheckOut_date = value; } }
        public string ReservationRef_number { get { return _ReservationRef_number; } set { _ReservationRef_number = value; } }
        public string Status { get { return _Status; } set { _Status = value; } }
        #endregion
        #region constructor
        public Reservation()
        {
            ID = "";
            GuestID = "";
            Room = "";
            CheckIn_date = "";
            CheckOut_date = "";
            ReservationRef_number = "";
            Status = "";


        }
        #endregion 





    }

}
