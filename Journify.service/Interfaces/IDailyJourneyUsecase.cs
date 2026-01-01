using Journify.core.Entities;

namespace Journify.service.Interfaces
{
    public interface IDailyJourneyUsecase
    {
        Task<DailyJourney> CreateJourneyAsync(DailyJourney journey);
        Task<IEnumerable<DailyJourney>> GetAllJourneysAsync();
        Task<DailyJourney> GetJourneyByIdAsync(Guid id);
    }
}
