﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BaseLib;
using FluentNHibernate.Conventions;
using Model;
using Model.Repositories;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;

namespace DataAccessLayer
{
    public class PensionerRepository : Subject, IPensionerRepository
    {
        private static PensionerRepository _instance;

        private ISession Session => TestSessionFactory != null ? TestSessionFactory.OpenSession() : NHibernateService.OpenSession();
        private readonly ISessionFactory TestSessionFactory;

        private PensionerRepository()
        {
        }

        //Only for testing purposes
        private PensionerRepository(ISessionFactory sessionFactory)
        {
            TestSessionFactory = sessionFactory;
        }

        //Only for testing purposes
        public static PensionerRepository GetInstanceForTesting(ISessionFactory factory)
        {
            return _instance ?? (_instance = new PensionerRepository(factory));
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

        public void AddPensioner(int id, string oib, string name, string surname, DateTime dateOfBirth, DateTime membershipStart,
            string placeOfBirth, string city, string town, string street, int postalCode, PaymentType requiredPayment)
        {
            using (var session = Session)
            {
                var transaction = session.BeginTransaction();

                var address = new Address(city, town, street, postalCode);
                var pensioner = new Pensioner(id, oib, name, surname, dateOfBirth, membershipStart, placeOfBirth, address, requiredPayment);

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

        public IEnumerable<Pensioner> GetAll()
        {
            using (var session = Session)
            {
                return session.Query<Pensioner>().ToList();
            }
        }

        public IEnumerable<Pensioner> GetAllWithPayments()
        {
            using (var session = Session)
            {
                return session.Query<Pensioner>().FetchMany(t => t.Payments).ToList();
            }
        }

        public IEnumerable<Pensioner> GetAllWithRequiredPayments()
        {
            using (var session = Session)
            {
                return session.Query<Pensioner>().FetchMany(t => t.RequiredPayments).ToList();
            }
        }

        public IEnumerable<Pensioner> GetAllWithAllAttributes()
        {
            using (var session = Session)
            {
                var pensioners = GetAllWithPayments().ToList();
                foreach (var pensioner in pensioners)
                {
                    pensioner.RequiredPayments = session.Query<PaymentType>()
                        .Where(t => t.Pensioner.Oib.Equals(pensioner.Oib)).ToList();
                }

                return pensioners;
            }
        }

        public Pensioner GetPensionerWithAllAttributes(string oib)
        {
            using (var session = Session)
            {
                var pensioner = GetPensioner(oib);

                pensioner.RequiredPayments =
                    session.Query<PaymentType>().Where(t => t.Pensioner.Oib.Equals(pensioner.Oib)).ToList();
                pensioner.Payments =
                    session.Query<Payment>().Where(t => t.Pensioner.Oib.Equals(pensioner.Oib)).ToList();

                return pensioner;
            }
        }

        public void GenerateMutualAidTransactions(DateTime forYear)
        {
            using (var session = Session)
            {
                var transaction = session.BeginTransaction();
                var pensionerList = GetAllWithAllAttributes();

                foreach (var pensioner in pensionerList)
                {
                    Payment payment = null;
                    if (pensioner.RequiredPayments.Any(t => t.Type == PaymentType.TypeEnum.MutualAidLow))
                    {
                        //don't generate if payment already exists for this year
                        if (pensioner.Payments.Where(t => t.ForYear.Year.Equals(forYear.Year) && t.Type.Type == PaymentType.TypeEnum.MutualAidLow).IsEmpty())
                        {
                            payment = new Payment(pensioner,
                                new PaymentType(PaymentType.TypeEnum.MutualAidLow,
                                    Model.Properties.Settings.Default.MutualAidLowFee), forYear);
                        }
                    }
                    else if(pensioner.RequiredPayments.Any(t => t.Type == PaymentType.TypeEnum.MutualAidHigh))
                    {
                        //don't generate if payment already exists for this year
                        if (pensioner.Payments.Where(t => t.ForYear.Year.Equals(forYear.Year) && t.Type.Type == PaymentType.TypeEnum.MutualAidHigh).IsEmpty())
                        {
                            payment = new Payment(pensioner,
                                new PaymentType(PaymentType.TypeEnum.MutualAidHigh,
                                    Model.Properties.Settings.Default.MutualAidHighFee), forYear);
                        }
                    }
                    if(payment != null) pensioner.Payments.Add(payment);
                    session.Update(pensioner); 
                }

                transaction.Commit();
            }
        }

        public void GenerateMembershipTransactions(DateTime forYear)
        {
            using (var session = Session)
            {
                var transaction = session.BeginTransaction();
                var pensionerList = GetAllWithPayments();

                foreach (var pensioner in pensionerList)
                {
                    if (pensioner.Payments.Where(t =>
                            t.ForYear.Year.Equals(forYear.Year) && t.Type.Type == PaymentType.TypeEnum.Membership)
                        .IsEmpty())
                    {
                        var payment = new Payment(pensioner,
                            new PaymentType(PaymentType.TypeEnum.Membership,
                                Model.Properties.Settings.Default.MembershipFee), forYear);
                        pensioner.Payments.Add(payment);
                    }

                    session.Update(pensioner); 
                }

                transaction.Commit();
            }
        }

        public void UpdatePensioner(Pensioner pensioner)
        {
            using (var session = Session)
            {
                var transaction = session.BeginTransaction();
                
                session.Update(pensioner);

                transaction.Commit();
            }

            NotifyObservers();
        }

        public void RemovePayment(Payment payment)
        {
            using(var session = Session)
            {
                var transaction = session.BeginTransaction();

                session.Delete(payment);

                transaction.Commit();
            }

            NotifyObservers();
        }

        public IList<Payment> GetPayments(string pensionerOib)
        {
            using (var session = Session)
            {
                return session.Query<Payment>().Where(p => p.Pensioner.Oib.Equals(pensionerOib)).ToList();
            }
        }
    }
}
