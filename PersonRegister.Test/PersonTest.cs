using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using PersonRegister.App.Services;
using PersonRegister.Domain.Entities;
using PersonRegister.Domain.Repositories;
using PersonRegister.Impl.Context;
using PersonRegister.Impl.Repositories;
using PersonRegister.Test.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonRegister.Test
{
    [TestClass]
    public class PersonTest
    {
        private PersonRepositoryImpl _personRepo;
        private PersonDataContext _dbContextInMemory;

        public PersonTest()
        {
            _personRepo = Substitute.For<PersonRepositoryImpl>();

            _dbContextInMemory = new PersonDataContext(this.GetDBOptions());
        }

        [TestMethod]
        public void GetList()
        {
            var at = new Person() {
                Id = 1010,
                Name = "Giorgio Agamben",
                IdentificationDocument = "3019999",
                Gender = true,
                BirthDate = DateTime.MinValue.AddYears(1942),
                AddressId = 1,
                Address = new Address()
            };

            _dbContextInMemory.AddRange(at);
            _dbContextInMemory.SaveChanges();

            IPersonRepository personRepository = new PersonRepositoryImpl(_dbContextInMemory);
            var service = new PersonServiceApp(personRepository);

            IList<Person> people = service.Get(null, 10);

            Assert.IsNotNull(people);
            Assert.IsTrue(people.ToList().Count > 0);

            Assert.AreEqual(at.Id, people[0].Id);
            Assert.AreEqual(at.Name, people[0].Name);
            Assert.AreEqual(at.IdentificationDocument, people[0].IdentificationDocument);
            Assert.AreEqual(at.Gender, people[0].Gender);
            Assert.AreEqual(at.BirthDate, people[0].BirthDate);
            Assert.AreEqual(at.AddressId, people[0].AddressId);
        }
    }
}
