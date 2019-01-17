using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Pensioner
    {
        private int Id { get; }
        private string Oib { get; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private DateTime DateOfBirth { get; set; }
        private DateTime MembershipStart { get; }
        private string PlaceOfBirth { get; set; }
        private Address CurrentAddress { get; set; }
        private IList<Payment> Payments { get; }
        private IList<PaymentType> RequiredPayments { get; }

        public Pensioner(int id, string oib, string name, string surname, DateTime dateOfBirth,
            DateTime membershipStart, string placeOfBirth, Address address)
        {
            Id = id;
            Oib = oib;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            MembershipStart = membershipStart;
            PlaceOfBirth = placeOfBirth;
            CurrentAddress = address;
            Payments = new List<Payment>();
            RequiredPayments = new List<PaymentType>();
        }

        public Pensioner(int id, string oib, string name, string surname, DateTime dateOfBirth,
            DateTime membershipStart, string placeOfBirth, Address currentAddress,
            IList<Payment> payments, IList<PaymentType> requiredPayments) :
            this(id, oib, name, surname, dateOfBirth, membershipStart, placeOfBirth, currentAddress)
        {
            Payments = payments;
            RequiredPayments = requiredPayments;
        }
    }
}
