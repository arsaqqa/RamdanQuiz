using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RamadanQuiz.Models

{
    public class QuestionOption
    {
        [Key]
        public int QuestionOptionID { get; set; }
 
        [ForeignKey(nameof(Question))]
        [Required]
        public int QuestionId { get; set; }
        public Question Question { get; set; }


        [MaxLength(1000)]
        public string QuestionOptionText { get; set; } = string.Empty;

        public bool IsCorrect { get; set; } 
        
   

    }
}
