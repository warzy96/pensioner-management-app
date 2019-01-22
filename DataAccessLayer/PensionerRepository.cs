using System;
using System.Collections.Generic;
using BaseLib;
using Model;

namespace DataAccessLayer
{
    public class PensionerRepository : Subject
    {
        private static readonly PensionerRepository Instance = null;
        private readonly List<Pensioner> _pensioners = new List<Pensioner>();

        private PensionerRepository()
        {
        }

        public static PensionerRepository GetInstance()
        {
            return Instance ?? new PensionerRepository();
        }

        public int Count()
        {
            return _pensioners.Count;
        }

        public Pensioner GetPensioner(int id)
        {
            var result = _pensioners.Find(pensioner => pensioner.Id == id);
            return result;
        }

        public Pensioner GetPensioner(string oib)
        {
            var result = _pensioners.Find(pensioner => pensioner.Oib.Equals(oib));
            return result;
        }

        public void AddPensioner(int id, string oib, string name, string surname, DateTime dateOfBirth, DateTime membershipStart, string placeOfBirth, string city, string town, string street, int postalCode)
        {
            using (var session = NHibernateService.OpenSession())
            {
                var transaction = session.BeginTransaction();
                var address = new Address(city, town, street, postalCode);
                var pensioner = new Pensioner(id, oib, name, surname, dateOfBirth, membershipStart, placeOfBirth, address);

                _pensioners.Add(pensioner);

                session.Save(pensioner);
                transaction.Commit();
            }

            NotifyObservers();
        }

        public void RemovePensioner(int id)
        {
            var pensioner = GetPensioner(id);
            _pensioners.Remove(pensioner);

            NotifyObservers();
        }

        public void UpdatePensioner(int id, string oib, string name, string surname, DateTime dateOfBirth,
            DateTime membershipStart, string placeOfBirth, string city, string town, string street, int postalCode)
        {
            var pensioner = GetPensioner(id);
            _pensioners.Remove(pensioner);

            pensioner.Name = name;
            pensioner.Surname = surname;
            pensioner.DateOfBirth = dateOfBirth;
            pensioner.MembershipStart = membershipStart;
            pensioner.PlaceOfBirth = placeOfBirth;
            pensioner.CurrentAddress = new Address(city, town, street, postalCode);

            _pensioners.Add(pensioner);
        }
    }
}
