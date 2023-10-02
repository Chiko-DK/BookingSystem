using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Data
{
    public class BookingDB:DB
    {
        #region  Data members        
        private string table1 = "Guests";
        private string sqlLocal1 = "SELECT * FROM Guests";
        private string table2 = "Reservation";
        private string sqlLocal2 = "SELECT * FROM Reservation";
        private string table3 = "Room";
        private string sqlLocal3 = "SELECT * FROM Room";

        private Collection<Guest> guests;
        private Collection<Reservation> reservations;
        private Collection<Room> rooms;
        #endregion

        #region Property Methods
        public Collection<Guest> AllGuests { get { return guests; } }
        public Collection<Reservation> AllReservations { get {  return reservations; } }
        public Collection<Room> AllRooms { get { return rooms; } }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            guests = new Collection<Guest>();
            reservations = new Collection<Reservation>();
            rooms = new Collection<Room>();
        }
        #endregion

        #region Utility methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void AddToCollection(string table)
        {
            DataRow myRow = null;
            Guest guest;
            Room room;
            Reservation res;

            //Iterate through each row in the specified table
            foreach (DataRow aRow in dsMain.Tables[table].Rows)
            {
                myRow = aRow;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //switch for each collection
                }
            }
        }
        #endregion
    }
}
