using System;

namespace PersonalGoalTrackerAPI.DTOs
{
    public class GoalDto
    {
        public int Id { get; set; }  // Hedefin benzersiz kimliği
        public string Title { get; set; }  // Hedefin başlığı
        public string Description { get; set; }  // Hedefin açıklaması
        public DateTime CreatedAt { get; set; }  // Hedefin oluşturulma tarihi
        public DateTime? DueDate { get; set; }  // Hedefin bitiş tarihi (opsiyonel)
        public bool IsCompleted { get; set; }  // Hedefin tamamlanma durumu
    }
}