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

                  .Where(x => x.QuestionFromTime >= DateTime.Now
                && x.QuestionToTime <= DateTime.Now)
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


            //    .Where(x => x.QuestionFromTime <= DateTime.Now
            //             && x.QuestionToTime >= DateTime.Now)
            //    .FirstOrDefaultAsync();
            // if (model == null)
            //{
            //    // Handle the case where no question is found (e.g., show a message or redirect)
            //    return View("NoQuestion");
            //}
            // viewmodel.QuestionId = model.QuestionId;
            // viewmodel.QuestionText = model.QuestionText;
            // viewmodel.questionOption = model.questionOption.Select(c => new QuestionOption
            // {
            //     QuestionId = c.QuestionId,
            //     QuestionOptionID = c.QuestionOptionID,
            //     QuestionOptionText = c.QuestionOptionText
            // }).ToList();



            ////Question question = await _QuizContext.Question;
            //viewmodel.QuestionId = question.QuestionId;
            //viewmodel.QuestionText = question.QuestionText;
            //viewmodel.questionOption = question.questionOption.Select(c => new QuestionOption
            //{
            //    QuestionId = c.QuestionId,
            //    QuestionOptionID = c.QuestionOptionID,
            //    QuestionOptionText = c.QuestionOptionText
            //}).ToList();





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
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task  SubmitAnswer(QuestionViewModel employeeAnswerViewModel)
        {
            if (employeeAnswerViewModel.QuestionOptionId == 0)
            { }
            //var model =  _QuizContext.Question
               

            //     .Where(x => x.QuestionId == employeeAnswerViewModel .que
            //   && x.QuestionToTime <= DateTime.Now)

            EmployeeAnswer employeeAnswer = new EmployeeAnswer();
            employeeAnswer.QuestionOptionId = employeeAnswerViewModel.QuestionOptionId;
            employeeAnswer.EmployeeId = 1;

            employeeAnswer.AnswerDateTime =DateTime.UtcNow ;
            _QuizContext.Add(employeeAnswer);
            _QuizContext.SaveChanges();
           


          //return View(employeeAnswerViewModel);


        }


    }
}
