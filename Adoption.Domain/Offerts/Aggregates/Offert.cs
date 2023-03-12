using Adoption.Domain.Applications.Entities;
using Adoption.Domain.Applications.Events;
using Adoption.Domain.Offerts.Events;
using Adoption.Domain.Offerts.ValueObjects;
using Adoption.Domain.Pets.ValueObjects;
using Adoption.Shared.Abstractions.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adoption.Domain.Offerts.Aggregates
{
    [Table("Oferty")]
    public class Offert : AggregateRoot<OffertId>
    {
        public PetId PetId { get; private set; }
        public OffertStatus OffertStatus { get; private set; } //jak to przemapować z EF? 
        public OffertState State { get; set; }

        public OffertDescription Description { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public int Papapap { get;private  set; }
        //public Application Application { get; private set; } //1-1 

        public IEnumerable<Application> Applications { get; private set; } //1-N
        
        //public Application? WonApplication{ get; private set; }

        private readonly ICollection<Application> _applications = new List<Application>();

        public Offert(PetId petId, OffertDescription description)
        {
            PetId = petId;
            Description = description;
            Id = new OffertId(Guid.NewGuid());
        }
        public Offert(PetId pet, OffertStatus offertStatus, ICollection<Application> applications)
        {
            PetId = pet;
            OffertStatus = offertStatus;
            _applications = applications;
        }

        public Offert(PetId pet, OffertStatus offertStatus)
        {
            PetId = pet;
            OffertStatus = offertStatus;

        }

        internal void AddApplication(Application a)
        {
            //if (_applications.Select(a => a.Contact.Equals(a.Contact)).Any())
            //{
            //    throw new ApplicationAlreadyAddedException(a);
            //}

            IncrementVersion();
            _applications.Add(a);
            AddEvent(new ApplicationAdded(a));
        }

        public void Publish()
        {
            State.Publish();
            AddEvent(new OffertPublished(this));
        }

        public void CloseWithAdoption(Application application)
        {
            State.CloseWithAdoption();


            //if (!Applications.Any(a => a.Id == application.Id))
            //{
            //    //throw new ApplicationIsNotConnectedToOffertException
            //}
            //WonApplication = application;
            AddEvent(new OffertClosedWithAdoption(this));
        }

        internal void CloseWithoutAdoption()
        {
            State.CloseWithoutAdoption();
            AddEvent(new OffertClosedWithoutAdoption(this));
        }
    }
}
