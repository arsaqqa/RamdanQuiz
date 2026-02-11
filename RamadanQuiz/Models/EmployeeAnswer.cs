using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RamadanQuiz.Models
{
    public class EmployeeAnswer
    {
        [Key]
        public int EmployeeAnswerId { get; set; }
        public int EmployeeId { get; set; }
       
        [ForeignKey(nameof(QuestionOption))]
        [Required]
        public int QuestionOptionId { get; set; }
        public QuestionOption QuestionOption { get; set; }
   
        public DateTime AnswerDateTime { get; set; }


    }
}
