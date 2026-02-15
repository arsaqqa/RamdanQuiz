using RamadanQuiz.Models;

namespace RamadanQuiz.ViewModels
{
    public class EmplyeeAnswerQuestionViewModel
    {

        public IEnumerable<CorrectAnswerViewModel> correctAnswerViewModel { get; set; } = Enumerable.Empty<CorrectAnswerViewModel >();
        //public int QuestionId { get; set; }
        //public string QuestionText { get; set; }

        //public string QuestionDay { get; set; }

        //public DateOnly QuestionDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);

        //public DateTime QuestionToTime { get; set; } = DateTime.UtcNow;
        //public int QuestionOptionID { get; set; }
        //public string QuestionOptionText { get; set; }

        //public bool IsCorrect { get; set; }
        public IEnumerable<EmployeeAnswerViewModel> employeeAnswer { get; set; } = Enumerable.Empty<EmployeeAnswerViewModel>();

        //public int? EmployeeId { get; set; }

        //public int? EmployeeQuestionOptionId { get; set; }
        //public string? EmployeeQuestionOptionText { get; set; }
    }
}
