using RamadanQuiz.Models;

namespace RamadanQuiz.ViewModels
{
    public class EmplyeeAnswerQuestionViewModel
    {

        public IEnumerable<CorrectAnswer> correctAnswer { get; set; } = Enumerable.Empty<CorrectAnswer >();
     
        public IEnumerable<EmplyeeAnswerQuestion> employeeAnswer { get; set; } = Enumerable.Empty<EmplyeeAnswerQuestion>();

     
    }
}
