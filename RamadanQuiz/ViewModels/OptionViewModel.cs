namespace RamadanQuiz.ViewModels
{
    public class OptionViewModel
    {
        public int QuestionOptionID { get; set; }
        public string QuestionOptionText { get; set; } = string.Empty;
      
        public bool IsCorrect { get; set; }
            public int QuestionId { get; set; }
        public string QuestionName { get; set; } = string.Empty;



    }
}
