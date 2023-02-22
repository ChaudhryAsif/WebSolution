using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebSolution.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Enrolled { get; set; }
        public IList<SelectListItem> Courses { get; set; }
    }
}
