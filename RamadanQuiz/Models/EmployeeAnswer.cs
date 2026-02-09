namespace RamadanQuiz.Models
{
    public class EmployeeAnswer
    {
        public int EmployeeAnswerId { get; set; }
        public int EmployeeId { get; set; }
        public int QuestionOptionId { get; set; }
        public DateTime AnswerDateTime { get; set; }
        public QuestionOption QuestionOption { get; set; } = new QuestionOption();

    }
}
