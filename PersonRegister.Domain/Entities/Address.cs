using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonRegister.Domain.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public int Number { get; set; }
        public string Name { get; set; }
        public string Complement { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
