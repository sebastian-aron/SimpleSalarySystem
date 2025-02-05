using Microsoft.AspNetCore.Mvc;
using SimpleSalarySystem.Models;

namespace SimpleSalarySystem.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<Employee> employees = new List<Employee>();

        public ActionResult Index()
        {
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            employee.CalculateTotalSalary();
            employees.Add(employee);
            return RedirectToAction("Index");
        }
    }
}
