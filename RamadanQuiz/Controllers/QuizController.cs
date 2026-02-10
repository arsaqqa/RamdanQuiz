using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RamadanQuiz.Data;
using RamadanQuiz.Models;
using RamadanQuiz.ViewModels;

namespace RamadanQuiz.Controllers
{
    public class QuizController : Controller
    {

        private readonly QuizContext _QuizContext;
        public QuizController(QuizContext context)
        {
            _QuizContext = context;
        }

        public async Task<IActionResult> Index(QuestionViewModel viewmodel)
        {



            //var now = DateOnly.FromDateTime(DateTime.Now.Date);

            //var questions = await _QuizContext.Question
            //    .Where(q =>
            //        q.QuestionDate.Year == now.Year &&
            //        q.QuestionDate.Month == now.Month)
            //    .ToListAsync();

            DateOnly now = DateOnly.FromDateTime(DateTime.Now);

            var questions = await _QuizContext.Question
                .Where(q =>
                    q.QuestionDate.Year == now.Year &&
               
                    q.QuestionDate.Day == now.Day) // لو تريد اليوم فقط
                .ToListAsync();
            //Question question = await _QuizContext.Question.Include(q => q.questionOption).FirstOrDefaultAsync(q => q.QuestionDate.ToString("yyyy-MM-dd") == today); //must return server date
            //Question question = await _QuizContext.Question;
            //viewmodel.QuestionId = question.QuestionId;
            //viewmodel.QuestionText = question.QuestionText;
            //  viewmodel.questionOption = question.questionOption.Select(c => new QuestionOption
            //  {
            //      QuestionId = c.QuestionId,
            //      QuestionOptionID = c.QuestionOptionID,
            //      QuestionOptionText = c.QuestionOptionText
            //  }) .ToList();





            //var questionOptions =
            //_QuizContext.QuestionOption.Select(c => new SelectListItem
            //{
            //    Text = c.QuestionOptionText,
            //    Value = c.QuestionOptionID.ToString()
            //}).ToList();


            //    var model = new QuestionViewModel
            //    {
            //        //QuestionId = question.,
            //        //QuestionId = 1,
            //        QuestionText = "ما اسم العيد الذي يأتي بعد شهر رمضان المبارك؟",
            //        questionOption = new List<SelectListItem>
            //{
            //    new SelectListItem { Value = "1", Text = "عيد الفطر." },
            //    new SelectListItem { Value = "2", Text = "عيد الاضحى." },
            //    new SelectListItem { Value = "3", Text = "عيد العمال." }
            //}
            //};
            //return ;
            return View(viewmodel);
        }

        //public IActionResult Option() {

        //    {
        //        return _dbContext.device.Select(d => new SelectListItem
        //        {
        //            Text = d.device_name,
        //            Value = d.id.ToString()
        //        }).ToList();
            
        //    return view();
        //}

    }
}
