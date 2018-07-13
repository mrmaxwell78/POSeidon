using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    class Customer
    {
        private string FirstName, LastName, Address, Phone, Email;
        private bool loyal;

        public Customer()
        {
            FirstName = LastName = Address = Phone = Email = " ";
            loyal = false;
        }

        public Customer(string fn, string ln, string adr, string ph, string em, bool loy)
        {
            FirstName = fn;
            LastName = ln;
            Address = adr;
            Phone = ph;
            Email = em;
            loyal = loy;
        }

        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string Email1 { get => Email; set => Email = value; }
        public bool Loyal { get => loyal; set => loyal = value; }
    }
}
