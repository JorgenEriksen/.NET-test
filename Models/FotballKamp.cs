using System.ComponentModel.DataAnnotations;

namespace QuizAPI.Models
{
    public class FotballKamp
    {
        public int Id { get; set; }

        [Required]
        public int Lag1id { get; set; }
        [Required]
        public int Lag2id { get; set; }

        public int VinnerLagId { get; set; }

        public string KampLand { get; set; }

    }
}