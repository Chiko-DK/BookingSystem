using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Room
    {
        #region Data Members
        
        private string _Room_number;
        private decimal _price;
        private bool isAvailable;
        public enum RoomType
        {
            Single,
            Double,
            Twin,
            Suite,
            Presidential
        }
        private RoomType roomType;
        #endregion

        #region Properties
        
        public string Room_number { get { return _Room_number; } set { _Room_number = value; } }

        public decimal Price { get { return _price; } set { _price = value; } }
        public bool IsAvailable { get { return isAvailable; } set { isAvailable = value; } }
        public RoomType getRoomType
        { 
            get { return roomType; } 
            set { roomType = value; } 
        }
        #endregion

        #region constructor 
        public Room()
        {
            Room_number = "";
            Price = 0;
            isAvailable = false;
        }

        public Room(string Room_number, decimal Price, bool isAvailable)
        {
            this.Room_number = Room_number;
            this.Price = Price;
            this.isAvailable = isAvailable;
        }
        #endregion 












    }
}
