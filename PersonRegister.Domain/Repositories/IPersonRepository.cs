using PersonRegister.Domain.Entities;
using System.Collections.Generic;

namespace PersonRegister.Domain.Repositories
{
    public interface IPersonRepository
    {
        ICollection<Person> Get();
        Person Get(int id);
        int Insert(Person person);
        Person Update(Person person);
        int Delete(int id);
    }
}
