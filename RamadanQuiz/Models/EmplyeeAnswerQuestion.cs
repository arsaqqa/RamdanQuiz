using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RamadanQuiz.Models
{
   

    public class EmplyeeAnswerQuestion
    {
        //[Key]
        //public int EmployeeAnswerId { get; set; }
        //[ForeignKey(nameof(Question))]

        public int EmplyeeAnswerQuestionId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        
        public string QuestionDay { get; set; }

        public DateOnly QuestionDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
             
        public DateTime QuestionToTime { get; set; } = DateTime.UtcNow;
        public int  QuestionOptionID{ get; set; }
        public string QuestionOptionText { get; set; }
    
         public bool IsCorrect { get; set; }
    

        public int? EmployeeId { get; set; }

        public int? EmployeeQuestionOptionId { get; set; }
        public string? EmployeeQuestionOptionText { get; set; }


    }
}
