using Adoption.Domain.Persons.ValueObjects;


namespace Adoption.Domain.Persons.Entities
{
    public sealed class Person
    {
        public PersonId Id { get; private set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
