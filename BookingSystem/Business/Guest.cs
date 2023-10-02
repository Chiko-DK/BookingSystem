using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Guest : Person
    {
        private string guestID;

        public string GuestID { get { return guestID; } set { guestID = value; } }

        public Guest()
        {
            guestID = ID;
        }
    }
}
