using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUDApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
