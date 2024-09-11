using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalGoalTrackerAPI.Models;
using PersonalGoalTrackerAPI.DTOs;

namespace PersonalGoalTrackerAPI.Services
{
    public interface IGoalService
    {
        Task<IEnumerable<GoalDto>> GetAllGoalsAsync(); // Tüm hedefleri getir
        Task<GoalDto> GetGoalByIdAsync(int id); // ID'ye göre hedef getir
        Task<GoalDto> AddGoalAsync(GoalDto goalDto); // Yeni hedef ekle
        Task<GoalDto> UpdateGoalAsync(int id, GoalDto goalDto); // Hedef güncelle
        Task<bool> DeleteGoalAsync(int id); // Hedef sil
    }
}