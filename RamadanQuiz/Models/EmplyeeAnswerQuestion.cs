using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RamadanQuiz.Models
{
   

    public class EmplyeeAnswerQuestion
    {
 
        public int QuestionId { get; set; }
        public int? EmployeeId { get; set; }
        public int  EmployeeQuestionOptionId { get; set; }
        public string EmployeeQuestionOptionText { get; set; }


    }
}
