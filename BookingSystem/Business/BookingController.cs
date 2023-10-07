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

        private Guest guest;
        private Room room;
        private Reservation res;
        #endregion

        #region property Methods
        public Reservation getReservation { get { return res; } set { res = value; } }
        public Room getRoom { get { return room; } set { room = value; } }
        public Guest getGuest { get { return guest; } set { guest = value; } }
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
            room = new Room();
            res = new Reservation();
            guest = new Guest();
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
                bool found = (guests[index].GuestID == id);
                while (!(found) && (index < guests.Count))
                {
                    index++;
                    found = (guests[index].GuestID == id);
                }
                return found ? guests[index] : null;
            }
            else if (obj is Reservation)
            {
                bool found = false;
                while (!(found) && (index < reservations.Count))
                {
                    found = (reservations[index].ReferenceNumber == id);
                    index++;
                }
                return found ? reservations[index] : null;
            }
            else if (obj is Room)
            {
                bool found = (rooms[index].RoomNumber == id);
                while (!(found) && (index < rooms.Count))
                {
                    index++;
                    found = (rooms[index].RoomNumber == id);
                }
                return found ? rooms[index] : null;
            }
            else { return null; }

        }
        #endregion
    }
}
