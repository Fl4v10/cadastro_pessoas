using PersonRegister.Domain.Entities;
using System.Collections.Generic;

namespace PersonRegister.Domain.Repositories
{
    public interface IPersonRepository
    {
        List<Person> Get(string search, int pageSize);
        Person Get(int id);
        void Insert(Person person);
        void Update(Person person);
        void Delete(int id);
    }
}
