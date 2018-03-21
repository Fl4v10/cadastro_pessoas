using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonRegister.Domain.Entities
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndentificationDocument { get; set; }
        public bool Gender { get; set; }

        public Address Addresses  { get; set; }
        public int AddressId { get; set; }
    }
}
