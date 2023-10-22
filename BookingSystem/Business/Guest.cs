using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Guest : Person
    {
        //This class represents each guest of the hotel
        private string guestID;

        public string GuestID { get { return guestID; } set { guestID = value; } }

        public Guest():base()
        {
            guestID = ID;
        }
    }
}
