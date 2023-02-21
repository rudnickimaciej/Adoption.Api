namespace Adoption.Shared.Abstractions.Domain
{
    public abstract class AggregateRoot<T>
    {
        private bool _versionIncremented = false;
        private readonly IList<IDomainEvent> _events;
        public IEnumerable<IDomainEvent> Events => _events;

        public T Id { get; protected set; }
        public int Version { get; protected set; }
        protected void IncrementVersion()
        {
            if (_versionIncremented)
            {
                return;
            }
            _versionIncremented = true;
            Version++;
        }

        protected void AddEvent(IDomainEvent @event)
        {
            if (!_events.Any())
            {
                IncrementVersion();
            }

            _events.Add(@event);
        }

        public void ClearEvents() => _events.Clear();
        }
    }
