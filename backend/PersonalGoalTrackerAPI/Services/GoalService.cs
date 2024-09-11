using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalGoalTrackerAPI.Models;
using PersonalGoalTrackerAPI.DTOs;
using PersonalGoalTrackerAPI.Repositories;

namespace PersonalGoalTrackerAPI.Services
{
    public class GoalService : IGoalService
    {
        private readonly IGoalRepository _goalRepository;

        public GoalService(IGoalRepository goalRepository)
        {
            _goalRepository = goalRepository;
        }

        public async Task<IEnumerable<GoalDto>> GetAllGoalsAsync()
        {
            var goals = await _goalRepository.GetAllGoalsAsync();
            // Goal modelini GoalDto'ya dönüştürme işlemi burada yapılabilir
            return goals.Select(g => new GoalDto
            {
                Id = g.Id,
                Title = g.Title,
                Description = g.Description,
                CreatedAt = g.CreatedAt,
                DueDate = g.DueDate,
                IsCompleted = g.IsCompleted
            });
        }

        public async Task<GoalDto> GetGoalByIdAsync(int id)
        {
            var goal = await _goalRepository.GetGoalByIdAsync(id);
            if (goal == null) return null;

            return new GoalDto
            {
                Id = goal.Id,
                Title = goal.Title,
                Description = goal.Description,
                CreatedAt = goal.CreatedAt,
                DueDate = goal.DueDate,
                IsCompleted = goal.IsCompleted
            };
        }

        public async Task<GoalDto> AddGoalAsync(GoalDto goalDto)
        {
            var goal = new Goal
            {
                Title = goalDto.Title,
                Description = goalDto.Description,
                CreatedAt = goalDto.CreatedAt,
                DueDate = goalDto.DueDate,
                IsCompleted = goalDto.IsCompleted
            };

            await _goalRepository.AddGoalAsync(goal);
            goalDto.Id = goal.Id; // Yeni oluşturulan hedefin ID'sini ayarla
            return goalDto;
        }

        public async Task<GoalDto> UpdateGoalAsync(int id, GoalDto goalDto)
        {
            var existingGoal = await _goalRepository.GetGoalByIdAsync(id);
            if (existingGoal == null) return null;

            existingGoal.Title = goalDto.Title;
            existingGoal.Description = goalDto.Description;
            existingGoal.DueDate = goalDto.DueDate;
            existingGoal.IsCompleted = goalDto.IsCompleted;

            await _goalRepository.UpdateGoalAsync(existingGoal);
            return goalDto;
        }

        public async Task<bool> DeleteGoalAsync(int id)
        {
            var existingGoal = await _goalRepository.GetGoalByIdAsync(id);
            if (existingGoal == null) return false;

            await _goalRepository.DeleteGoalAsync(id);
            return true;
        }
    }
}