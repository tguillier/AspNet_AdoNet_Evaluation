using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNet_AdoNet_Evaluation.Models
{
    public class SentenceWriterConfiguration
    {
        [Required(ErrorMessage = "Repeated sentence is required.")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Sentence must be 10 to 50 characters long.")]
        [Display(Name = "Repeated sentence")]
        public string Sentence { get; set; }

        [Range(5, 20, ErrorMessage = "Number of repetitions must be in a range of 5 to 20.")]
        [Display(Name = "Number of repetitions (default 10)")]
        public int? NumberOfRepetitions { get; set; } = 10;
    }
}