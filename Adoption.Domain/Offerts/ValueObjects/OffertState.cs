using Adoption.Domain.Offerts.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Offerts.ValueObjects
{
    public abstract class OffertState
    {
        protected Offert offert { get; private set; }
        protected OffertState(Offert offert)
        {
            this.offert = offert;
        }

        public virtual bool CanPublish()
        {
            return false;
        }
        public virtual void Publish()
        {
            if (!CanPublish())
                throw new Exception("Can not publish the offert");

            offert.State = new InProgressOffertState(offert);

        }
        public virtual bool CanCloseWithAdoption()
        {
            return false;
        }
        public virtual void CloseWithAdoption()
        {
            if (!CanCloseWithAdoption())
                throw new Exception("Can not close the offert");

            offert.State = new CloseWithAdoptionOffertState(offert);
        }
        public virtual bool CanCloseWithoutAdoption()
        {
            return false;
        }
        public virtual void CloseWithoutAdoption()
        {
            if (!CanCloseWithoutAdoption())
                throw new Exception("Can not close the offert");

            offert.State = new CloseWithoutAdoptionOffertState(offert);
        }

    }
    internal class InDraftOffertState : OffertState
    {
        public InDraftOffertState(Offert offert) : base(offert)
        {
        }

        public override bool CanPublish()
            => true;
    }
    internal class InProgressOffertState : OffertState
    {
        public InProgressOffertState(Offert offert) : base(offert)
        {
        }

        public override bool CanCloseWithAdoption()
              => true;

        public override bool CanCloseWithoutAdoption()
             => true;
    }
    internal class CloseWithAdoptionOffertState : OffertState
    {
        public CloseWithAdoptionOffertState(Offert offert) : base(offert)
        {
        }

    }
    internal class CloseWithoutAdoptionOffertState : OffertState
    {
        public CloseWithoutAdoptionOffertState(Offert offert) : base(offert)
        {
        }
    }
}
