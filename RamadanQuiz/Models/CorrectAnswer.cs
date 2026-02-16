using System.ComponentModel.DataAnnotations;

namespace RamadanQuiz.Models
{
    public class CorrectAnswer

    {
           public int QuestionOptionID { get; set; }
           public int QuestionId { get; set; }
           public string QuestionText { get; set; } = string.Empty;
           public string QuestionOptionText { get; set; } = string.Empty;
           public bool IsCorrect { get; set; }
           public DateTime QuestionToTime { get; set; } = DateTime.UtcNow;
           public string AnswerSource { get; set; }
           public string QuestionDay { get; set; }
           public DateOnly QuestionDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
           public DateTime QuestionFromTime { get; set; } = DateTime.UtcNow;

    }
}
