using Microsoft.AspNetCore.Mvc;
using Ordering_System.Data;
using Ordering_System.Models;

namespace Ordering_System.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Employee> employees;
            employees = new List<Employee>();
            return View(employees);
        }
    }
}
