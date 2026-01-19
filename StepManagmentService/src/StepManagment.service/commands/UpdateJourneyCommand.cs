

namespace StepManagment.service.commands
{
    public class UpdateJourneyCommand
    {
        public Guid JourneyId { get; }
        public string JourneyName { get; }
        public UpdateJourneyCommand(Guid journeyId, string journeyName)
        {
            JourneyId = journeyId;
            JourneyName = journeyName;
        }
    }
}
