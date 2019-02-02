using System;
using DataAccessLayer;
using Model;
using NHibernate.Exceptions;
using NUnit.Framework;

namespace PensionerAssociationTests
{
    public class PensionerRepositoryTests
    {
        private SqliteDatabaseForTesting database;
        private PensionerRepository repository;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CountTest()
        {
            database = new SqliteDatabaseForTesting();
            repository = PensionerRepository.GetInstanceForTesting(database.sessionFactory);

            repository.AddPensioner(1, "11111111111", "Ivan", "Novak", DateTime.MinValue,
                DateTime.MinValue, "Zagreb",
                "Zagreb", "Zagreb", "Unska 3", 10000, 
                new PaymentType(PaymentType.TypeEnum.Membership, 40.0));

            Assert.AreEqual(repository.Count(), 1);
        }

        [Test]
        public void AddPensionerWithSameOibTest()
        {
            database = new SqliteDatabaseForTesting();
            repository = PensionerRepository.GetInstanceForTesting(database.sessionFactory);

            repository.AddPensioner(1, "11111111111", "Ivan", "Novak", DateTime.MinValue,
                DateTime.MinValue, "Zagreb",
                "Zagreb", "Zagreb", "Unska 3", 10000,
                new PaymentType(PaymentType.TypeEnum.Membership, 40.0));

           Assert.Throws<GenericADOException>(() => repository.AddPensioner(5, "11111111111", "Karlo", "Novak",
                DateTime.MinValue,
                DateTime.MinValue, "Zagreb",
                "Zagreb", "Zagreb", "Unska 3", 10000,
                new PaymentType(PaymentType.TypeEnum.Membership, 40.0)));

            Assert.AreEqual(repository.Count(), 1);
        }

        [Test]
        public void GetPensionerByOibTest()
        {
            database = new SqliteDatabaseForTesting();
            repository = PensionerRepository.GetInstanceForTesting(database.sessionFactory);

            var pensioner = repository.GetPensioner("xxxxxxxxxxx");

            Assert.IsNull(pensioner);

            repository.AddPensioner(1, "11111111111", "Ivan", "Novak", DateTime.MinValue,
                DateTime.MinValue, "Zagreb",
                "Zagreb", "Zagreb", "Unska 3", 10000,
                new PaymentType(PaymentType.TypeEnum.Membership, 40.0));
            pensioner = repository.GetPensioner("11111111111");

            Assert.NotNull(pensioner);
            Assert.AreEqual(1, pensioner.Id);
            Assert.AreEqual("11111111111", pensioner.Oib);
            Assert.AreEqual("Ivan", pensioner.Name);
            Assert.AreEqual("Novak", pensioner.Surname);
            Assert.AreEqual("Zagreb", pensioner.PlaceOfBirth);
        }

        [Test]
        public void GetPensionerByIdTest()
        {
            database = new SqliteDatabaseForTesting();
            repository = PensionerRepository.GetInstanceForTesting(database.sessionFactory);

            repository.AddPensioner(1, "11111111111", "Ivan", "Novak", DateTime.MinValue,
                DateTime.MinValue, "Zagreb",
                "Zagreb", "Zagreb", "Unska 3", 10000,
                new PaymentType(PaymentType.TypeEnum.Membership, 40.0));
            var pensioner = repository.GetPensioner(5);

            Assert.IsNull(pensioner);
            
            pensioner = repository.GetPensioner(1);

            Assert.NotNull(pensioner);
            Assert.AreEqual(1, pensioner.Id);
            Assert.AreEqual("11111111111", pensioner.Oib);
            Assert.AreEqual("Ivan", pensioner.Name);
            Assert.AreEqual("Novak", pensioner.Surname);
            Assert.AreEqual("Zagreb", pensioner.PlaceOfBirth);
        }

        [Test]
        public void RemovePensionerTest()
        {
            database = new SqliteDatabaseForTesting();
            repository = PensionerRepository.GetInstanceForTesting(database.sessionFactory);

            repository.AddPensioner(1, "11111111111", "Ivan", "Novak", DateTime.MinValue,
                DateTime.MinValue, "Zagreb",
                "Zagreb", "Zagreb", "Unska 3", 10000,
                new PaymentType(PaymentType.TypeEnum.Membership, 40.0));
            var pensioner = repository.GetPensioner(1);

            Assert.IsNotNull(pensioner);

            repository.RemovePensioner(pensioner.Oib);

            pensioner = repository.GetPensioner(1);

            Assert.IsNull(pensioner);
        }

        [Test]
        public void UpdatePensionerTest()
        {
            database = new SqliteDatabaseForTesting();
            repository = PensionerRepository.GetInstanceForTesting(database.sessionFactory);

            repository.AddPensioner(1, "11111111111", "Ivan", "Novak", DateTime.MinValue,
                DateTime.MinValue, "Zagreb",
                "Zagreb", "Zagreb", "Unska 3", 10000,
                new PaymentType(PaymentType.TypeEnum.Membership, 40.0));
            var oldPensioner = repository.GetPensioner(1);
            Assert.IsNotNull(oldPensioner);

            var pensioner = repository.GetPensioner(1);
            pensioner.Name = "Marko";
            pensioner.Surname = "Markovic";
            repository.UpdatePensioner(pensioner);

            var updatedPensioner = repository.GetPensioner(1);

            Assert.AreNotEqual(updatedPensioner, oldPensioner);
            Assert.AreEqual(updatedPensioner.Name, "Marko");
            Assert.AreEqual(updatedPensioner.Surname, "Markovic");
        }

        [Test]
        public void GetPensionerWithAllAttributesTest()
        {
            database = new SqliteDatabaseForTesting();
            repository = PensionerRepository.GetInstanceForTesting(database.sessionFactory);

            repository.AddPensioner(1, "11111111111", "Ivan", "Novak", DateTime.MinValue,
                DateTime.MinValue, "Zagreb",
                "Zagreb", "Zagreb", "Unska 3", 10000,
                new PaymentType(PaymentType.TypeEnum.Membership, 40.0));

            var pensioner = repository.GetPensionerWithAllAttributes("11111111111");

            Assert.IsNotNull(pensioner.RequiredPayments);
            Assert.IsNotNull(pensioner.Payments);
            Assert.IsEmpty(pensioner.Payments);
            Assert.IsNotEmpty(pensioner.RequiredPayments);
        }

        [Test]
        public void RemovePaymentTest()
        {
            database = new SqliteDatabaseForTesting();
            repository = PensionerRepository.GetInstanceForTesting(database.sessionFactory);

            repository.AddPensioner(1, "11111111111", "Ivan", "Novak", DateTime.MinValue,
                DateTime.MinValue, "Zagreb",
                "Zagreb", "Zagreb", "Unska 3", 10000,
                new PaymentType(PaymentType.TypeEnum.Membership, 40.0));

            var pensioner = repository.GetPensionerWithAllAttributes("11111111111");

            Assert.IsEmpty(pensioner.Payments);

            var payment = new Payment(pensioner, new PaymentType(PaymentType.TypeEnum.Membership, 40.0),
                DateTime.MinValue);
            pensioner.Payments.Add(payment);
            repository.UpdatePensioner(pensioner);

            pensioner = repository.GetPensionerWithAllAttributes("11111111111");

            Assert.IsNotNull(pensioner.Payments);
            Assert.IsNotEmpty(pensioner.Payments);

            repository.RemovePayment(payment);

            pensioner = repository.GetPensionerWithAllAttributes("11111111111");

            Assert.IsEmpty(pensioner.Payments);
        }
    }
}