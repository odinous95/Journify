using System.ComponentModel.DataAnnotations;
namespace StepManagment.api.DTOS
{
    public class CreateJourneyDTO
    {
        [Required]
        public required Guid userId { get; set; }
        [Required, MaxLength(50)]
        public required string journeyName { get; set; }
    }
}
