namespace StepManagment.api.DTOS
{
    public class CreateJourneyDTO
    {
        public required Guid userId { get; set; }
        public required string journeyName { get; set; }

    }
}
