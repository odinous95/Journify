
namespace StepManagment.service.commands
{
    public class CreateStepCommand
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid JourneyId { get; set; }
        public CreateStepCommand(Guid journeyId, string title, string description)
        {
            Title = title;
            Description = description;
            JourneyId = journeyId;
        }
    }
}
