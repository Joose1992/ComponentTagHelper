using ComponentTagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComponentTagHelper.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentViewModel model = new StudentViewModel
            {
                ID = 1,
                StudentName = "Jose",
                StudentLastName = "Montanez"
            };

            return View(model);
        }
    }
}
