using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TodoBlazor.Enums;

namespace TodoBlazor.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string Description { get; set; }
        public DateTime HoursToComplete { get; set; }
        public bool IsComplete { get; set; }

        public TodoDifficulty Difficulty { get; set; }
    }
}