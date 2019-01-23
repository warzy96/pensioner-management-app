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
            DateTime membershipStart, string placeOfBirth, string city, string town, string street, int postalCode);
        void RemovePensioner(string oib);

        void UpdatePensioner(int id, string oib, string name, string surname, DateTime dateOfBirth,
            DateTime membershipStart, string placeOfBirth, string city, string town, string street, int postalCode);

        IEnumerable<Pensioner> GetAll();

        Pensioner GetPensioner(int id);
    }
}