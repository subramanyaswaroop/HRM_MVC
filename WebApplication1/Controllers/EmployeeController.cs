using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Data;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        HRMDbContext db=new HRMDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayEmployee(string searchFirstName, string searchSecondName)
        {
            List<EmployeeInfo> employees = null;
            if (searchFirstName==null && searchSecondName == null)
            {
                employees = db.Employees.ToList();
            }
            else
            {
                var res = (from emp in db.Employees
                           where emp.FirstName.Contains(searchFirstName) || emp.LastName.Contains(searchSecondName)
                           select emp);
                employees = res.ToList();
            }
            
            return View(employees);
        }

        public IActionResult Create(EmployeeInfo emp)
        {
            if (!ModelState.IsValid)
                return View("Create");

            db.Add(emp);
            db.SaveChanges();
            TempData["Message"] = $"Employee with Emplyee ID {emp.MMID} has been created";

            return RedirectToAction("DisplayEmployee");
        }
    }
}
