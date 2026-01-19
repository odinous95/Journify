
namespace StepManagment.service.commands
{
    public class CreateStepCommand
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public CreateStepCommand(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
