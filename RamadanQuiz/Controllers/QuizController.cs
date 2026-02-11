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

            DateOnly now = DateOnly.FromDateTime(DateTime.UtcNow);

            //Question question = await _QuizContext.Question
            //    .Where(q =>
            //        q.QuestionDate.Year == now.Year &&
            //        q.QuestionDate.Month == now.Month &&
            //        q.QuestionDate.Day == now.Day) // لو تريد اليوم فقط


            //Question question = await _QuizContext.Question.Include(q => q.questionOption).FirstOrDefaultAsync(q =>  q.QuestionDate.Year == now.Year && q.QuestionDate.Month == now.Month &&   q.QuestionDate.Day == now.Day); //must return server date

            //var questionMV = await _QuizContext.Question
            //    .Include(x => x.questionOption)
            //    .Where(x => x.QuestionFromTime >= DateTime.Now
            //             && x.QuestionToTime <= DateTime.Now)
            //    .FirstOrDefaultAsync();



            var model = await _QuizContext.Question
                .Include(x => x.questionOption)

                //  .Where(x => x.QuestionFromTime >= DateTime.Now
                //&& x.QuestionToTime <= DateTime.Now)
                .Select(x => new QuestionViewModel
                {
                    QuestionId = x.QuestionId,
                    QuestionText = x.QuestionText,
                    QuestionDay = x.QuestionDay,
                    QuestionDate = x.QuestionDate.ToString(),
                    QuestionFromTime = x.QuestionFromTime.ToString(),
                    QuestionToTime = x.QuestionToTime.ToString(),
                    questionOption = x.questionOption.Select(c => new QuestionOption
                    {
                        QuestionId = c.QuestionId,
                        QuestionOptionID = c.QuestionOptionID,
                        QuestionOptionText = c.QuestionOptionText
                    }).ToList()
                }


                ).FirstOrDefaultAsync();

            if (model == null)
            {
                ViewBag.ErrorMsg = "لا يوجد سؤال متاح حالياً";
                return View(new QuestionViewModel());
            }






            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitAnswer(QuestionViewModel questionViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(questionViewModel);
            }
            else
            {
                Submit(questionViewModel);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task  Submit(QuestionViewModel questionViewModel)

        {

                if (questionViewModel.QuestionOptionId == 0)
                {

                 }


                EmployeeAnswer employeeAnswer = new EmployeeAnswer();
                employeeAnswer.QuestionOptionId = questionViewModel.QuestionOptionId;
                employeeAnswer.EmployeeId = 1;

                employeeAnswer.AnswerDateTime = DateTime.UtcNow;
                _QuizContext.Add(employeeAnswer);
                _QuizContext.SaveChanges();


            }











        


    }
}
