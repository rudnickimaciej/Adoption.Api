namespace Adoption.Shared.Time
{
    internal class UtcTimeProvider : IDateTimeProvider
    {
        DateTime IDateTimeProvider.Now => DateTime.UtcNow;
    }
}
