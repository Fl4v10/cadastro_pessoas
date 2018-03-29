using System.ComponentModel.DataAnnotations;

namespace PersonRegister.Domain.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentificationDocument { get; set; }
        public bool Gender { get; set; }
        public System.DateTime BirthDate { get; set; }

        public Address Address  { get; set; }
        public int AddressId { get; set; }
    }
}
