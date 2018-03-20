namespace PersonRegister.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string AddressName { get; set; }
        public string PostalCode { get; set; }
        public string Complement { get; set; }
    }
}
