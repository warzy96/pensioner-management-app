using System;
using System.Collections.Generic;
using System.Linq;
using BaseLib;
using Model;
using Model.Repositories;
using NHibernate;

namespace DataAccessLayer
{
    public class PensionerRepository : Subject, IPensionerRepository
    {
        private static PensionerRepository _instance;
        private ISession Session => NHibernateService.OpenSession();

        private PensionerRepository()
        {
        }

        public static PensionerRepository GetInstance()
        {
            return _instance ?? (_instance = new PensionerRepository());
        }

        public int Count()
        {
            using (var session = Session)
            {
                return session.Query<Pensioner>().Count();
            }
        }

        public Pensioner GetPensioner(string oib)
        {
            using (var session = Session)
            {
                return session.Get<Pensioner>(oib);
            }
        }

        public Pensioner GetPensioner(int id)
        {
            using (var session = Session)
            {
                var pensioners = session.Query<Pensioner>().Where(t => t.Id == id).ToList();

                return pensioners.FirstOrDefault();
            }
        }

        public void AddPensioner(int id, string oib, string name, string surname, DateTime dateOfBirth, DateTime membershipStart, string placeOfBirth, string city, string town, string street, int postalCode)
        {
            using (var session = Session)
            {
                var transaction = session.BeginTransaction();
                var address = new Address(city, town, street, postalCode);
                var pensioner = new Pensioner(id, oib, name, surname, dateOfBirth, membershipStart, placeOfBirth, address);

                session.Save(pensioner);
                transaction.Commit();
            }

            NotifyObservers();
        }

        public void RemovePensioner(string oib)
        {
            using (var session = Session)
            {
                var transaction = session.BeginTransaction();
                var pensioner = session.Get<Pensioner>(oib);

                session.Delete(pensioner);
                transaction.Commit();
            }

            NotifyObservers();
        }

        public void UpdatePensioner(int id, string oib, string name, string surname, DateTime dateOfBirth,
            DateTime membershipStart, string placeOfBirth, string city, string town, string street, int postalCode)
        {
            using (var session = Session)
            {
                var pensioner = GetPensioner(oib);
                var transaction = session.BeginTransaction();

                pensioner.Name = name;
                pensioner.Surname = surname;
                pensioner.DateOfBirth = dateOfBirth;
                pensioner.MembershipStart = membershipStart;
                pensioner.PlaceOfBirth = placeOfBirth;
                pensioner.CurrentAddress = new Address(city, town, street, postalCode);

                session.Update(pensioner);
                transaction.Commit();
            }
        }

        public IEnumerable<Pensioner> GetAll()
        {
            using (var session = Session)
            {
                var list = session.Query<Pensioner>().ToList();
                return list;
            }
        }

    }
}
