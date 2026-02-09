using System.ComponentModel.DataAnnotations;
namespace RamadanQuiz.Models

{
    public class QuestionOption
    {
        public int QuestionOptionID { get; set; }
        [MaxLength(1000)]
        public string QuestionOptionText { get; set; } = string.Empty;
      
             public bool IsCorrect { get; set; }
            public int QuestionId { get; set; }
            //public Question Question { get; set; } = new Question();

    }
}
