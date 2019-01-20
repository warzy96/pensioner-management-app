using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Properties;

namespace Model
{
    public class Pensioner
    {
        public int Id { get; }
        public string Oib { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime MembershipStart { get; set; }
        public string PlaceOfBirth { get; set; }
        public Address CurrentAddress { get; set; }
        //History of payments made by this pensioner
        public IList<Payment> Payments { get; }
        //Types of payments this pensioner has to pay
        public IList<PaymentType> RequiredPayments { get; }

        public Pensioner()
        {
        }

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
            RequiredPayments.Add(new PaymentType(PaymentType.Membership, Settings.Default.MembershipFee));
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
