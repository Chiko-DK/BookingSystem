using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BookingSystem.Business
{
    public class Room
    {
        //This class represents each room in the hotel
        #region Data Members
        private string _Room_number;
        private decimal _price;
        private bool isAvailable;
        private string description;
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

        #region Property Methods
        public string RoomNumber { get { return _Room_number; } set { _Room_number = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public bool IsAvailable { get { return isAvailable; } set { isAvailable = value; } }
        public string Description { get { return description; } set { description = value; } }
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
        // Setting the RoomType and Description based on the string input.
        public void setRoomType(string roomType)
        {
            switch(roomType)
            {
                case "Single":
                    this.roomType = RoomType.Single;
                    description = "Description: A cozy room with a comfortable single bed, suitable for solo travelers or those seeking simplicity and affordability.\r\n"
                                 + "\nFeatures: Single bed, private bathroom, work desk, TV, and basic amenities.";
                    break;
                case "Double":
                    this.roomType = RoomType.Double;
                    description = "Description: A spacious room with a double bed, perfect for couples or travelers who prefer more space and comfort.\r\n" +
                                "\nFeatures: Double bed, private bathroom, seating area, TV, and standard amenities.";
                    break;
                case "Twin":
                    this.roomType = RoomType.Twin;
                    description = "Description: A room with two single beds, ideal for friends, colleagues, or family members traveling together.\r\n" +
                                "\nFeatures: Two single beds, private bathroom, work desk, TV, and standard amenities.";
                    break;
                case "Suite":
                    this.roomType = RoomType.Suite;
                    description = "Description: A luxurious suite offering a separate living area and bedroom, providing extra space and comfort.\r\n" +
                                "\nFeatures: King-size bed, separate living room, private bathroom, mini kitchenette, work desk, TV, and premium amenities.";
                    break;
                case "Presidential":
                    this.roomType = RoomType.Presidential;
                    description = "Description: The epitome of luxury and elegance, the presidential suite offers a grand living space, a master bedroom, and exclusive amenities.\r\n" +
                                "\nFeatures: King-size bed, spacious living room, dining area, private bathroom with Jacuzzi, fully-equipped kitchen, work desk, multiple TVs, and top-tier amenities.";
                    break;
                default:
                    this.roomType = RoomType.Null;
                    description = "";
                    break;
            }
        }

        //Room Occupancy: The number of day each room was occupied for a certain period
        public int RoomOccupancy(Collection<Reservation> reservations, DateTime startDate, DateTime endDate)
        {
            int count = 0;

            foreach (Reservation reservation in reservations)
            {
                if (reservation.BRoom.RoomNumber == RoomNumber)
                {
                    DateTime start = startDate;

                    while(start <= endDate)
                    {
                        if(start >= reservation.CheckIn && start <= reservation.CheckOut) { count++; }
                        start = start.AddDays(1);
                    }
                }
            }
            return count;
        }
        #endregion

    }
}
