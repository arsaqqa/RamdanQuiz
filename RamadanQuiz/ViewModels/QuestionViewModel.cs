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
        [DataType(DataType.Time)]
        public string QuestionFromTime { get; set; } = string.Empty;
        [DataType(DataType.Time)]
        public string QuestionToTime { get; set; } = string.Empty;
        [Required]
        //public int QuestionOptionId { get; set; }


        public IEnumerable<SelectListItem> questionOption { get; set; } = Enumerable.Empty<SelectListItem>();
        //public int SelectedOptionId { get; set; } = 0;
    }
}
