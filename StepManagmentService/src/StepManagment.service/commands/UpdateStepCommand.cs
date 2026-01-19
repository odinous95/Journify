namespace StepManagment.service.commands
{
    public class UpdateStepCommand
    {
        public Guid Id { get; }
        public string Title { get; }
        public string? Description { get; }

        public UpdateStepCommand(Guid id, string title, string? description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}