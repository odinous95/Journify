using System.ComponentModel.DataAnnotations;

namespace StepManagment.api.DTOS
{
    public class UpdateJourneyDTO
    {
        [Required]
        public required Guid JourneyId { get; set; }
        [Required, MaxLength(200)]
        public required string JourneyName { get; set; }
    }
}
