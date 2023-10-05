using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class BookingController
    {
        #region Data Members
        BookingDB bookingDB;
        private Collection<Guest> guests;
        private Collection<Reservation> reservations;
        private Collection<Room> rooms;
        #endregion

        #region Property Methods
        public Collection<Guest> AllGuests { get { return guests; } }
        public Collection<Reservation> AllReservations { get { return reservations; } }
        public Collection<Room> AllRooms { get { return rooms; } }
        #endregion

        #region Constructor
        public BookingController()
        {
            bookingDB = new BookingDB();
            guests = bookingDB.AllGuests;
            reservations = bookingDB.AllReservations;
            rooms = bookingDB.AllRooms;
        }
        #endregion

        #region Database Communication
        public void DataMaintenance(Object obj)
        {
            //perform a given database operation to the dataset in memory; 
            bookingDB.DataSetChange(obj);

            if (obj is Guest)
            {
                guests.Add((Guest)obj);
            }
            else if (obj is Reservation)
            {
                reservations.Add((Reservation)obj);
            }
            else if (obj is Room)
            {
                rooms.Add((Room)obj);
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Object obj)
        {
            return bookingDB.UpdateDataSource(obj);
        }
        #endregion

        #region Search Methods
        public Collection<Room> FindByTypeAvailability (Collection<Room> r, Room.RoomType rType)
        {
            Collection<Room> result = new Collection<Room>();
            foreach (Room room in r)
            {
                if(room.getRoomType == rType && room.IsAvailable)
                {
                    result.Add(room);
                }
            }
            return result;
        }

        public Collection<Room> FindByAvailability(Collection<Room> r)
        {
            Collection<Room> result = new Collection<Room>();
            foreach (Room room in r)
            {
                if (room.IsAvailable)
                {
                    result.Add(room);
                }
            }
            return result;
        }

        public Object Find(Object obj, string id)
        {
            int index = 0;

            if(obj is Guest)
            {
                bool found = (guests[index].ID == id);
                while (!(found) && (index < guests.Count - 1))
                {
                    index++;
                    found = (guests[index].ID == id);
                }
                return guests[index];
            }
            else if (obj is Reservation)
            {
                bool found = (reservations[index].ReferenceNumber == id);
                while (!(found) && (index < reservations.Count - 1))
                {
                    index++;
                    found = (reservations[index].ReferenceNumber == id);
                }
                return reservations[index];
            }
            else if (obj is Room)
            {
                bool found = (rooms[index].RoomNumber == id);
                while (!(found) && (index < rooms.Count - 1))
                {
                    index++;
                    found = (rooms[index].RoomNumber == id);
                }
                return rooms[index];
            }
            else { return null; }
        }
        #endregion
    }
}
