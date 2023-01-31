using Microsoft.AspNetCore.Mvc;

namespace WebSolution.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentBio()
        {
            return View();
        }
    }
}
