using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Address
    {
        public virtual string City { get; set; }
        public virtual string Town { get; set; }
        public virtual string Street { get; set; }
        public virtual int PostalCode { get; set; }

        public Address()
        {
        }
        public Address(string city, string town, string street, int postalCode)
        {
            City = city;
            Town = town;
            Street = street;
            PostalCode = postalCode;
        }

        public string GetPlaceOfResidence()
        {
            return Town + ", " + Street;
        }

        public string GetCityAndZipCode()
        {
            return City + ", " + PostalCode;
        }

        public override string ToString()
        {
            return GetPlaceOfResidence() + "; " + GetCityAndZipCode();
        }
    }
}
