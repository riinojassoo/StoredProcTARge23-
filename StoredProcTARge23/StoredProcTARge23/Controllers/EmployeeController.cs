using Microsoft.AspNetCore.Mvc;

namespace StoredProcTARge23.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
