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

        public List<Person> Get(string search, string pageSize) {
            try
            {
                return _rep.Get(search, pageSize) ?? null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Person Get(int id) {
            try
            {
                return _rep.Get(id) ?? null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(Person person)
        {
            try
            {
                var response =  _rep.Insert(person);

                if (response == 0)
                    throw new Exception("Erro ao isserir registro");

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Person Update(Person person) {
            try
            {
                return _rep.Update(person);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(int id) {
            try
            {
                var response = _rep.Delete(id);

                if (response == 0)
                    throw new Exception("Erro durante o processo de exclusão do arquivo");

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
