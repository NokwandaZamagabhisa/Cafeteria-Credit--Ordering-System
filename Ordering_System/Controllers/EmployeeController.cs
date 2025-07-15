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
            employees = _context.Employees.ToList<Employee>();
            return View(employees);
        }
        public IActionResult EmployeeDetails(int id)
        {
            Employee singleEmployee = _context.Employees.SingleOrDefault(x => x.Id == id);
            return View(singleEmployee);
        }
        [HttpGet]
        public IActionResult Create() {
            Employee employee = new Employee();

            return View(employee);
        }
        [HttpPost]
        public IActionResult Create(Employee employee) {
            _context.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
