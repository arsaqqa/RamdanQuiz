using RamadanQuiz.Models;

namespace RamadanQuiz.ViewModels
{
    public class EmployeeAnswerViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public int QuestionOptionId { get; set; }
        QuestionOption QuestionOption { get; set; } = new QuestionOption();
        public DateTime AnswerDateTime { get; set; }

        
    }
}
