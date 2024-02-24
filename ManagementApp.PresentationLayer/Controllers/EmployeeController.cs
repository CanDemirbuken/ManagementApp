using FluentValidation;
using FluentValidation.Results;
using ManagementApp.BusinessLayer.Concrete;
using ManagementApp.BusinessLayer.ValidationRules;
using ManagementApp.DataAccessLayer.EntityFramework;
using ManagementApp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ManagementApp.PresentationLayer.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDAL());
        public IActionResult Index()
        {
            var data = employeeManager.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            EmployeeValidator validations = new EmployeeValidator();
            ValidationResult results = validations.Validate(employee);

            if (results.IsValid)
            {
                employeeManager.Add(employee);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            var value = employeeManager.GetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditEmployee(Employee employee)
        {
            EmployeeValidator validations = new EmployeeValidator();
            ValidationResult results = validations.Validate(employee);

            if (results.IsValid)
            {
                employeeManager.Update(employee);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeleteEmployee(int id)
        {
            var data = employeeManager.GetByID(id);
            employeeManager.Delete(data);
            return RedirectToAction("Index");
        }
    }
}
