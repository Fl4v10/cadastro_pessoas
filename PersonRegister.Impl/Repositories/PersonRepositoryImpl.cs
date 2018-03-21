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
        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> Get(string search, string pageSize)
        {
            //using (var db = new PersonDataContext())
            //{
            //    //var livros = db.Livros.AsNoTracking().Where(x => x.Titulo.Contains("Domain")).ToList();
            //}
            return new List<Person>();
        }

        public Person Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(Person person)
        {
            throw new System.NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}
