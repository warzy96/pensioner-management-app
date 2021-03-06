﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IPensionerRepository
    {
        int Count();
        Pensioner GetPensioner(string oib);

        void AddPensioner(int id, string oib, string name, string surname, DateTime dateOfBirth,
            DateTime membershipStart, string placeOfBirth, string city, string town, string street,
            int postalCode, PaymentType requiredPayment);
        void RemovePensioner(string oib);

        IEnumerable<Pensioner> GetAll();

        Pensioner GetPensioner(int id);

        IEnumerable<Pensioner> GetAllWithPayments();

        IEnumerable<Pensioner> GetAllWithRequiredPayments();

        IEnumerable<Pensioner> GetAllWithAllAttributes();
        Pensioner GetPensionerWithAllAttributes(string oib);
        void GenerateMutualAidTransactions(DateTime forYear);
        void GenerateMembershipTransactions(DateTime forYear);
        void UpdatePensioner(Pensioner pensioner);
        void RemovePayment(Payment payment);
        IList<Payment> GetPayments(string pensionerOib);
    }
}
