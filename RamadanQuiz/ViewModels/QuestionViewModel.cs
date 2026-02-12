using Microsoft.AspNetCore.Mvc.Rendering;
using RamadanQuiz.Models;
using System.ComponentModel.DataAnnotations;

namespace RamadanQuiz.ViewModels
{
    public class QuestionViewModel
    {
        public int QuestionId { get; set; }
        [MaxLength(2500)]
        public string QuestionText { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public string QuestionDate { get; set; } = string.Empty;
        public string QuestionDay { get; set; } = string.Empty;
        [DataType(DataType.Time)]
        public string QuestionFromTime { get; set; } = string.Empty;
        [DataType(DataType.Time)]
        public string QuestionToTime { get; set; } = string.Empty;

        public string QuestionSource { get; set; } = string.Empty;

        [Required(ErrorMessage = "الرجاء اختيار الاجابة قبل الارسال")]
        public int QuestionOptionId { get; set; }
        public QuestionOption EmployeeOption  { get; set; }
        public int EmployeeId { get; set; }

        public IEnumerable<QuestionOption> questionOption { get; set; } = Enumerable.Empty<QuestionOption>();
        //public int SelectedOptionId { get; set; } = 0;

  

    }
}
