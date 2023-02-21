using Adoption.Domain.DomainEvents;
using Adoption.Domain.Entities;
using Adoption.Domain.Exceptions;
using Adoption.Domain.ValueObjects;
using Adoption.Shared.Abstractions.Domain;
using dddAdoption.DomainExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Aggregates
{
    public class Offert : AggregateRoot<OffertId>
    {
        public PetId PetId { get; private set; }
        public OffertStatus OffertStatus { get; private set; }
        public OffertDescription Description { get; private set; }

        public IEnumerable<Application?> Applications { get; private set; }
        
        public Application? WonApplication{ get; private set; }

        private readonly ICollection<Application> _applications = new List<Application>();

        public Offert(PetId petId, OffertDescription description)
        {
            PetId = petId;
            Description = description;
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
            if (_applications.Select(a => a.Contact.Equals(a.Contact)).Any())
            {
                throw new ApplicationAlreadyAddedException(a);
            }

            IncrementVersion();
            _applications.Add(a);
            AddEvent(new ApplicationAdded(a));
        }

        internal void StartOffert()
        {
            if (!(OffertStatus.Value.Equals(OffertStatus.InProgress)))
                throw new OffertAlreadyOpenedException(this);

            OffertStatus = OffertStatus.InProgress;
            AddEvent(new OffertOpened(this));

        }

        internal void CloseWithAdoption(Application application)
        {
            if (!OffertStatus.Value.Equals(OffertStatus.InProgress))
                throw new CanNotCloseNotOpenedOffert(this);


            if (!Applications.Any(a => a.Id == application.Id))
            {
                //throw new ApplicationIsNotConnectedToOffertException
            }
            OffertStatus = OffertStatus.EndedWithAdoption;
            WonApplication = application;
            AddEvent(new OffertClosedWithAdoption(this));
        }

        internal void CloseWithoutAdoption()
        {
            if (!OffertStatus.Value.Equals(OffertStatus.InProgress))
                throw new CanNotCloseNotOpenedOffert(this);

            OffertStatus = OffertStatus.EndedWithoutAdoption;
            AddEvent(new OffertClosedWithoutAdoption(this));
        }
    }
}
