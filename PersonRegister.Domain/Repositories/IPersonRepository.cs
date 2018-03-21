using PersonRegister.Domain.Entities;
using System.Collections.Generic;

namespace PersonRegister.Domain.Repositories
{
    public interface IPersonRepository
    {
        List<Person> Get(string search, string pageSize);
        Person Get(int id);
        int Insert(Person person);
        Person Update(Person person);
        int Delete(int id);
    }
}
