using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Pensioner
    {
        private string Oib { get; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private DateTime DateOfBirth { get; set; }
        private DateTime? DateOfDeath { get; set; }
        private Address CurrentAddress { get; set; }
        private string PlaceOfBirth { get; set; }
        private bool IsAlive => DateOfDeath == null;

        public Pensioner(string oib = null, string name = null, string surname = null,
            DateTime dateOfBirth = default(DateTime), DateTime? dateOfDeath = default(DateTime?),
            Address currentAddress = null, string placeOfBirth = null)
        {
            Oib = oib ?? throw new ArgumentNullException(nameof(oib));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            DateOfBirth = dateOfBirth;
            DateOfDeath = dateOfDeath;
            CurrentAddress = currentAddress ?? throw new ArgumentNullException(nameof(currentAddress));
            PlaceOfBirth = placeOfBirth ?? throw new ArgumentNullException(nameof(placeOfBirth));
        }
    }
}
