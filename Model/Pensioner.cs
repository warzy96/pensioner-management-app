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
        public virtual int Id { get; set; }
        public virtual string Oib { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual DateTime MembershipStart { get; set; }
        public virtual string PlaceOfBirth { get; set; }
        public virtual Address CurrentAddress { get; set; }
        //History of payments made by this pensioner
        public virtual IList<Payment> Payments { get; set; }
        //Types of payments this pensioner has to pay
        public virtual IList<PaymentType> RequiredPayments { get; set; }

        public Pensioner()
        {
            Payments = new List<Payment>();
            RequiredPayments = new List<PaymentType>
            {
                new PaymentType(PaymentType.TypeEnum.Membership, Settings.Default.MembershipFee, this)
            };
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
            RequiredPayments = new List<PaymentType>
            {
                new PaymentType(PaymentType.TypeEnum.Membership, Settings.Default.MembershipFee, this)
            };
        }

        //for future use with importing data from file
        public Pensioner(int id, string oib, string name, string surname, DateTime dateOfBirth,
            DateTime membershipStart, string placeOfBirth, Address currentAddress,
            IList<Payment> payments, IList<PaymentType> requiredPayments) :
            this(id, oib, name, surname, dateOfBirth, membershipStart, placeOfBirth, currentAddress)
        {
            Payments = payments;
            RequiredPayments = requiredPayments;
        }

        public Pensioner(int id, string oib, string name, string surname, DateTime dateOfBirth, DateTime membershipStart,
            string placeOfBirth, Address currentAddress, PaymentType requiredPayment) :
            this(id, oib, name, surname, dateOfBirth, membershipStart, placeOfBirth, currentAddress)
        {
            if (requiredPayment != null)
            {
                requiredPayment.Pensioner = this;
                RequiredPayments.Add(requiredPayment);
            }
        }

        public override bool Equals(object obj)
        {
            var pensioner = (Pensioner) obj;
            return pensioner != null && pensioner.Id == Id && pensioner.Oib.Equals(Oib);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public virtual string GetFullName()
        {
            return Name + " " + Surname;
        }

        public virtual string GetMembershipRequiredPaymentString()
        {
            return RequiredPayments.Any(requiredPayment => requiredPayment.Type == PaymentType.TypeEnum.Membership) ? Settings.Default.MembershipFee.ToString() : PaymentType.Empty;
        }

        public virtual string GetMutualAidRequiredPaymentString()
        {
            foreach (var requiredPayment in RequiredPayments)
            {
                if (requiredPayment.Type == PaymentType.TypeEnum.MutualAidHigh)
                {
                    return Settings.Default.MutualAidHighFee.ToString();
                }

                if (requiredPayment.Type == PaymentType.TypeEnum.MutualAidLow)
                {
                    return Settings.Default.MutualAidLowFee.ToString();
                }
            }

            return PaymentType.Empty;
        }
    }
}
