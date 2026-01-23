namespace Journify.core.Entities
{
    public class DailyJourney
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public string JourneyName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Step> Steps { get; set; } = new List<Step>();
    }
}
