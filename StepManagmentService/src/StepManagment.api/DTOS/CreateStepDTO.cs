using System.ComponentModel.DataAnnotations;

namespace StepManagment.api.DTOS
{
    public class CreateStepDTO
    {
        [Required, MaxLength(50)]
        public required string Title { get; set; }
        [Required, MaxLength(50)]
        public required string Description { get; set; }
    }
}
