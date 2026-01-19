using Journify.core.Entities;
using StepManagment.service.commands;

namespace StepManagment.service.Interfaces
{
    public interface IStepService
    {
        Task AddStepAsync(CreateStepCommand command);
        Task<Step> UpdateStepAsync(UpdateStepCommand command);
        Task<IEnumerable<Step>> GetAllStepsAsync();
        Task<Step> GetStepById(Guid id);
        Task<bool> DeleteStepAsync(Guid id);
    }
}
