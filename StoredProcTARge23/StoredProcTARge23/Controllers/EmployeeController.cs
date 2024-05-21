using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoredProcTARge23.Data;
using StoredProcTARge23.Models;

namespace StoredProcTARge23.Controllers
{
    public class EmployeeController : Controller
    {
        public StoredProcDbContext _context;
        
        public EmployeeController
            (
                StoredProcDbContext context
            )
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<Employee> SearchResult()
        {
            var result = _context.Employees
                .FromSqlRaw<Employee>("spSearchEmployees")
                .ToList();

            return result;
        }
    }
}
