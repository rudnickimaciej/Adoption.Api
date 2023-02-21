namespace Adoption.Shared.Time
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}
