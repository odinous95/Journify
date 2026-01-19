
namespace StepManagment.service.commands
{
    public class CreateJourneyCommand
    {
        public string JourneyName { get; }
        public CreateJourneyCommand(Guid userId, string journeyName)
        {
            JourneyName = journeyName;
        }
    }
}
