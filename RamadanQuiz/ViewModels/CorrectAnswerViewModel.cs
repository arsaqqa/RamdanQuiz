using System.ComponentModel.DataAnnotations;

namespace RamadanQuiz.ViewModels
{
    public class CorrectAnswerViewModel

    {
        [Key]
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }

        public string QuestionDay { get; set; }

        public DateOnly QuestionDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);

        public DateTime QuestionToTime { get; set; } = DateTime.UtcNow;
        public int QuestionOptionID { get; set; }
        public string QuestionOptionText { get; set; }

        public bool IsCorrect { get; set; }

    }
}
