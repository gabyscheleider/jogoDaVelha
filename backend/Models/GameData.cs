using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class GameData
    {
        [Key]
        public int Id { get; set; }

        public string? Winner { get; set; }

        public bool Draw { get; set; }

        public string MarksJson { get; set; } = string.Empty;

        public DateTime PlayedAt { get; set; }

        [NotMapped]
        public Dictionary<string, string> Marks
        {
            get => string.IsNullOrEmpty(MarksJson)
                ? new Dictionary<string, string>()
                : System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(MarksJson) ?? new();

            set => MarksJson = System.Text.Json.JsonSerializer.Serialize(value);
        }
    }
}
