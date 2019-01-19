using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Address
    {
        private int PensionerId { get; }
        private string City { get; set; }
        private string Town { get; set; }
        private string Street { get; set; }
        private int PostalCode { get; set; }

        public Address(int pensionerId, string city, string town, string street, int postalCode)
        {
            PensionerId = pensionerId;
            City = city;
            Town = town;
            Street = street;
            PostalCode = postalCode;
        }
    }
}
