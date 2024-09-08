using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalGoalTrackerAPI.Models;

namespace PersonalGoalTrackerAPI.Repositories
{
    public interface IGoalRepository
    {
        Task<IEnumerable<Goal>> GetAllGoalsAsync();  // Tüm hedefleri getir
        Task<Goal> GetGoalByIdAsync(int id);  // ID'ye göre hedef getir
        Task AddGoalAsync(Goal goal);  // Yeni hedef ekle
        Task UpdateGoalAsync(Goal goal);  // Hedefi güncelle
        Task DeleteGoalAsync(int id);  // Hedefi sil
    }
}
