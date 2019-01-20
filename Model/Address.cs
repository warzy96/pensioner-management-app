using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Address
    {
        public string City { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }

        public Address(string city, string town, string street, int postalCode)
        {
            City = city;
            Town = town;
            Street = street;
            PostalCode = postalCode;
        }
    }
}
