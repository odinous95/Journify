
namespace StepManagment.service.commands
{
    public class CreateJourneyCommand
    {
        public Guid UserId { get; }
        public string JourneyName { get; }
        public CreateJourneyCommand(Guid userId, string journeyName)
        {
            UserId = userId;
            JourneyName = journeyName;
        }
    }
}
