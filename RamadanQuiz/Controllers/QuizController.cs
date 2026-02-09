using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RamadanQuiz.ViewModels;

namespace RamadanQuiz.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            var model = new QuestionViewModel
            {
                QuestionId = 1,
                QuestionText = "ما اسم العيد الذي يأتي بعد شهر رمضان المبارك؟",
                questionOption = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "عيد الفطر." },
            new SelectListItem { Value = "2", Text = "عيد الاضحى." },
            new SelectListItem { Value = "3", Text = "عيد العمال." }
        }
            };

            return View(model);
        }

    }
}
