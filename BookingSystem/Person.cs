using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    internal class Person
    {
        #region Data Members
        private string id;
        private string name;
        private string email;
        private string phone;
        #endregion

        #region Properties
        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        #endregion

        #region Constructors
        public Person()
        {
            id = "";
            name = "";
            email = "";
            phone = "";
        }

        public Person(string id, string name, string email, string phone)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
        #endregion


    }
}
