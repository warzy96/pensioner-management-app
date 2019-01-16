using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Address
    {
        private string City { get; set; }
        private string Town { get; set; }
        private string Street { get; set; }
        private string PostalCode { get; set; }

        internal Address(string city = null, string town = null, string street = null, string postalCode = null)
        {
            City = city ?? throw new ArgumentNullException(nameof(city));
            Town = town ?? throw new ArgumentNullException(nameof(town));
            Street = street ?? throw new ArgumentNullException(nameof(street));
            PostalCode = postalCode ?? throw new ArgumentNullException(nameof(postalCode));
        }
    }
}
