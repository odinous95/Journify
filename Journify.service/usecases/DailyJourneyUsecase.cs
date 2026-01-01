using Journify.core.Entities;
using Journify.service.Interfaces;

namespace Journify.service.usecases
{
    public class DailyJourneyUsecase : IDailyJourneyUsecase
    {
        private readonly IDailyJourneyRepository _journeyRepository;
        public DailyJourneyUsecase(IDailyJourneyRepository journeyRepository)
        {
            _journeyRepository = journeyRepository;
        }
        public async Task<DailyJourney> CreateJourneyAsync(DailyJourney journey)
        {
            return await _journeyRepository.AddJourneyAsync(journey);
        }
        public async Task<IEnumerable<DailyJourney>> GetAllJourneysAsync()
        {
            return await _journeyRepository.GetAllJourneysAsync();
        }
        public async Task<DailyJourney> GetJourneyByIdAsync(Guid id)
        {
            return await _journeyRepository.GetJourneyById(id);
        }
    }
}
