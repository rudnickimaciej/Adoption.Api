using Adoption.Domain.Entities;
using Adoption.Domain.ValueObjects;

namespace Adoption.Domain.Entities
{
    //Aggregat

    //Typy aplikacji
    // - Chęć Adopcji (jakiekolwiek psa)
    // - Chęć Adopcji (konkretnego psa z Oferty)
    // - Chęć oddania zwierzęcia
    // - Chęć zgłoszenia znęcania się nad zwierzęciem
    //Czy chcemy tworzyć klasę bazowa? 

    // Na podstawie chęci Adopcji, generowany jest raport, w którym jest
    // opisane w jaki sposób dany Aplikant pasuje do danego zwięrzecia.
    // Niektóre z atrybutów dopasowania: rodzaj domu, ilośc zwierzat mieszkaniu,
    //posiadanie dzieci. 
    // Raport ten generowany jest na podstawie cech zwięrzęcia, które wypełniane 
    // sa przez Pracownika


    //Pytanie: czy często dochodzi do sytuacji, w której Aplikant spotyka się
    // z odmowa wynikajaca ze zbyt wielkiego niedopasowania?


    public class Application
    {
        public Guid Id { get; private set; }
        public Guid OffertId { get; private set; }
        public Contact Contact { get; private set; } //ValueObject
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public ApplicationStatus Status{ get; private set; }
    }
}
