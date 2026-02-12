using System.ComponentModel.DataAnnotations;

namespace RamadanQuiz.Models
{
    public class Question
    {
        [Key]
    public int QuestionId { get; set; }
        [MaxLength(2500)]
        public string QuestionText { get; set; } = string.Empty;
        [MaxLength(250)]
        public string QuestionDay { get; set; } = string.Empty;
        [MaxLength(2500)]
        public string AnswerSource { get; set; } = string.Empty;

        public DateOnly QuestionDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        [DataType(DataType.Time)]
        public DateTime QuestionFromTime { get; set; } = DateTime.UtcNow; 
        [DataType(DataType.Time)]
        public DateTime QuestionToTime { get; set; } = DateTime.UtcNow;


        public ICollection<QuestionOption> questionOption { get; set; } = new List<QuestionOption>();
    }


}
