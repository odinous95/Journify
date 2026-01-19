using Journify.core.Entities;

namespace StepManagment.service.Interfaces
{
    public interface IStepRepository
    {
        Task AddStepAsync(Step step);
        Task<Step> UpdateStepAsync(Step step);

        Task<IEnumerable<Step>> GetAllStepsAsync();
        Task<Step> GetStepById(Guid id);

        Task<bool> DeleteStepAsync(Guid id);
    }
}
