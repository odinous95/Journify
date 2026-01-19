using Journify.core.Entities;
using StepManagment.service.commands;

namespace StepManagment.service.Interfaces
{
    public interface IDailyJourneyService
    {
        Task CreateJourneyAsync(CreateJourneyCommand command);
        Task<DailyJourney> UpdateJourneyAsync(UpdateJourneyCommand journey);
        //-===-------------------------------------------
        Task<IEnumerable<DailyJourney>> GetAllJourneysAsync();
        Task<DailyJourney> GetJourneyByIdAsync(Guid id);

        Task<bool> DeleteJourneyAsync(Guid id);
    }
}
