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
            Null = 0,
            Single = 1,
            Double = 2,
            Twin = 3,
            Suite = 4,
            Presidential = 5
        }
        private RoomType roomType;
        #endregion

        #region Properties
        public string RoomNumber { get { return _Room_number; } set { _Room_number = value; } }
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
            RoomNumber = "";
            Price = 0;
            isAvailable = false;
        }

        public Room(string Room_number, decimal Price, bool isAvailable)
        {
            this.RoomNumber = Room_number;
            this.Price = Price;
            this.isAvailable = isAvailable;
        }
        #endregion

        #region Utility meethod
        public void setRoomType(string roomType)
        {
            switch(roomType)
            {
                case "Single":
                    this.roomType = RoomType.Single;
                    break;
                case "Double":
                    this.roomType = RoomType.Double;
                    break;
                case "Twin":
                    this.roomType = RoomType.Twin;
                    break;
                case "Suite":
                    this.roomType = RoomType.Suite;
                    break;
                case "Presidential":
                    this.roomType = RoomType.Presidential;
                    break;
                default:
                    this.roomType = RoomType.Null;
                    break;
            }
        }
        #endregion

    }
}
