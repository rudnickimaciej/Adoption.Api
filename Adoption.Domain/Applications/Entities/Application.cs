
using Adoption.Domain.Offerts.Aggregates;

namespace Adoption.Domain.Applications.Entities
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
        public Offert Offert { get; private set; }
        //public Contact Contact { get; private set; } //ValueObject
        public string ApplicantName { get; private set; }
        public string ApplicantLastName { get; private set; }
        //public ApplicationStatus Status{ get; private set; }
        public ApplicationStatus Status { get; private set; }
    }

    public enum ApplicationStatus
    {
        NotOpened,
        InProgress,
        InFinalization,
        RejectedByWorker,
        WithdrawedByApplicant,
        ClosedDueToAnotherApplicationSuccess
    }
}
