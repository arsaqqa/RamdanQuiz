using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RamadanQuiz.Models
{
    public class EmplyeeAnswerQuestion
    {
        [Key]
        public int EmployeeAnswerId { get; set; }
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public int EmployeeId { get; set; }

     public EmployeeAnswer  EmployeeAnswer { get; set; }
        public int QuestionOptionId { get; set; }
        public QuestionOption QuestionOption { get; set; }
        public bool IsCorrect { get; set; }

    }
}
