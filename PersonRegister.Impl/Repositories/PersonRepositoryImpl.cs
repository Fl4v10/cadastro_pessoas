using Microsoft.EntityFrameworkCore;
using PersonRegister.Domain.Entities;
using PersonRegister.Domain.Repositories;
using PersonRegister.Impl.Context;
using System.Collections.Generic;
using System.Linq;

namespace PersonRegister.Impl.Repositories
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        private PersonDataContext _dbContext;

        public PersonRepositoryImpl(PersonDataContext context)
        {
            _dbContext = context;
        }

        public void Delete(int id)
        {
            var person = _dbContext.Set<Person>().Where(p => p.Id.Equals(id))
                .SingleOrDefault();

            _dbContext.Set<Person>().Remove(person);
            _dbContext.SaveChanges();
        }

        public List<Person> Get(string search)
        {
            if (string.IsNullOrEmpty(search))
                return _dbContext.Set<Person>().Include("Address").AsNoTracking()
                    .Where(p => p.Name.Contains(search)).ToList();

            return _dbContext.Set<Person>().Include("Address").AsNoTracking().ToList();
        }

        public Person Get(int id)
        {
            return _dbContext.Set<Person>().Include("Address").AsNoTracking()
                .Where(p => p.Id.Equals(id)).FirstOrDefault();
        }

        public void Insert(Person person)
        {
            _dbContext.Add(person);
            _dbContext.SaveChanges();
        }

        public void Update(Person person)
        {
            _dbContext.Update(person);
            _dbContext.SaveChanges();
        }
    }
}
