using RamadanQuiz.Models;

namespace RamadanQuiz.ViewModels
{
    public class EmployeeAnswerViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public int QuestionOptionId { get; set; }
      public  QuestionOption QuestionOption { get; set; } 
        public DateTime AnswerDateTime { get; set; }

        
    }
}
