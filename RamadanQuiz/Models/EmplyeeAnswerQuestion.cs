using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RamadanQuiz.Models
{
   

    public class EmplyeeAnswerQuestion
    {
        //[Key]
        //public int Id { get; set; }
        //public int EmployeeAnswerId { get; set; }
        //[ForeignKey(nameof(Question))]

  
        public int QuestionId { get; set; }
       
        //public int QuestionOptionID { get; set; }
        //public string QuestionOptionText { get; set; }

        //public bool IsCorrect { get; set; }


        public int? EmployeeId { get; set; }

        public int  EmployeeQuestionOptionId { get; set; }
        public string EmployeeQuestionOptionText { get; set; }


    }
}
