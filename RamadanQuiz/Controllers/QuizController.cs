using Microsoft.AspNetCore.Mvc;

namespace RamadanQuiz.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
