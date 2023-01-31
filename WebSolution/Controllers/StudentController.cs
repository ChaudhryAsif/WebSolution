using Microsoft.AspNetCore.Mvc;

namespace WebSolution.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
