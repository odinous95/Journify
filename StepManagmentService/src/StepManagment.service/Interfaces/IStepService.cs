using Journify.core.Entities;
using StepManagment.service.commands;

namespace StepManagment.service.Interfaces
{
    public interface IStepService
    {

        Task AddStepAsync(CreateStepCommand command);




        Task<IEnumerable<Step>> GetAllStepsAsync();
        Task<Step> GetStepById(Guid id);
        Task<Step> UpdateStepAsync(Step step);
        Task<bool> DeleteStepAsync(Guid id);
    }
}
