using Journify.core.Entities;
using StepManagment.service.commands;
using StepManagment.service.Interfaces;

namespace StepManagment.service.usecases
{
    public class StepService : IStepService
    {
        private readonly IStepRepository _stepRepository;

        public StepService(IStepRepository stepRepository)
        {
            _stepRepository = stepRepository;
        }

        public async Task AddStepAsync(CreateStepCommand command)
        {
            var step = new Step
            {
                Title = command.Title,
                Description = command.Description,
                DailyJourneyId = command.JourneyId
            };

            await _stepRepository.AddStepAsync(step);
        }

        public async Task<Step> UpdateStepAsync(UpdateStepCommand command)
        {
            var existingStep = await _stepRepository.GetStepById(command.Id);

            if (existingStep == null)
                throw new KeyNotFoundException($"Step with ID {command.Id} not found.");

            existingStep.Title = command.Title;
            existingStep.Description = command.Description;

            return await _stepRepository.UpdateStepAsync(existingStep);
        }

        public async Task<IEnumerable<Step>> GetAllStepsAsync()
        {
            return await _stepRepository.GetAllStepsAsync();
        }

        public async Task<Step> GetStepById(Guid id)
        {
            var step = await _stepRepository.GetStepById(id);

            if (step == null)
                throw new KeyNotFoundException($"Step with ID {id} not found.");

            return step;
        }

        public async Task DeleteStepAsync(Guid id)
        {
            var deleted = await _stepRepository.DeleteStepAsync(id);

            if (!deleted)
                throw new KeyNotFoundException($"Step with ID {id} not found.");
        }
    }

}
