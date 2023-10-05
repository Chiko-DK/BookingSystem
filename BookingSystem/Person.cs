using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    public class Person
    {
        #region Data Members
        private string id;
        private string fName;
        private string lName;
        private string email;
        private string phone;
        #endregion

        #region Properties
        public string ID { get { return id; } set { id = value; } }
        public string FirstName { get { return fName; } set { fName = value; } }
        public string LastName { get { return lName; } set { lName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        #endregion

        #region Constructors
        public Person()
        {
            id = "";
            fName = "";
            lName = "";
            email = "";
            phone = "";
        }

        public Person(string id, string fname, string lname, string email, string phone)
        {
            this.id = id;
            this.fName = fname;
            this.lName = lname;
            this.email = email;
            this.phone = phone;
        }
        #endregion


    }
}
