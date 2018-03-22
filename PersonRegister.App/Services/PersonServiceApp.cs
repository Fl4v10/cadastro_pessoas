using PersonRegister.Domain.Entities;
using PersonRegister.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace PersonRegister.App.Services
{
    public class PersonService
    {
        private IPersonRepository _rep;

        public PersonService(IPersonRepository person)
        {
            _rep = person;
        }

        public List<Person> Get(string search, int pageSize)
        {
            try
            {
                return _rep.Get(search, pageSize) ?? null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Person Get(int id)
        {
            try
            {
                return _rep.Get(id) ?? null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Person person)
        {
            try
            {
                _rep.Insert(person);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Person person) {
            try
            {
                _rep.Update(person);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id) {
            try
            {
                _rep.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
