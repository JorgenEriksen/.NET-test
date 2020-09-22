using System.ComponentModel.DataAnnotations;

namespace QuizAPI.Models
{
    public class FotballLag
    {
        [Key] // trengs egentlig ikke
        public int Id { get; set; }
        
        [Required]
        [MinLength(2)]
        [MaxLength(90)]
        public string Land { get; set; }

        
    }
}