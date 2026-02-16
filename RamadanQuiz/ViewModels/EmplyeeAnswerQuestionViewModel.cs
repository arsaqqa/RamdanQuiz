using RamadanQuiz.Models;

namespace RamadanQuiz.ViewModels
{
    public class EmplyeeAnswerQuestionViewModel
    {

        public IEnumerable<CorrectAnswerViewModel> correctAnswerViewModel { get; set; } = Enumerable.Empty<CorrectAnswerViewModel >();
     
        public IEnumerable<EmplyeeAnswerQuestion> employeeAnswer { get; set; } = Enumerable.Empty<EmplyeeAnswerQuestion>();

     
    }
}
