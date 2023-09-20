using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    internal class Room
    {
        #region Data Members
        
        private string _Room_number;
        private string _Room_type;
        private decimal _price;
        private bool isAvailable;
        #endregion

        #region Properties
        
        public string Room_number { get { return _Room_number; } set { _Room_number = value; } }
        public string Room_type { get { return _Room_type; } set { _Room_type = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public bool IsAvailable { get { return isAvailable; } set { isAvailable = value; } }
        #endregion

        #region constructor 
        public Room()
        {
            Room_number = "";
            Room_type = "";
            Price = 0;
            isAvailable = false;

        }

        public Room(string Room_number, string Room_type, decimal Price, bool isAvailable)
        {
            this.Room_number = Room_number;
            this.Room_type = Room_type;
            this.Price = Price;
            this.isAvailable = isAvailable;
        }
        #endregion 












    }
}
