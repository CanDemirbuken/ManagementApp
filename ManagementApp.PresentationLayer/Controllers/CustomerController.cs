using FluentValidation.Results;
using ManagementApp.BusinessLayer.Concrete;
using ManagementApp.BusinessLayer.ValidationRules;
using ManagementApp.DataAccessLayer.EntityFramework;
using ManagementApp.Entities.Concrete;
using ManagementApp.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagementApp.PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDAL());
        public IActionResult Index()
        {
            var data = customerManager.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            CustomerValidator validations = new CustomerValidator();
            ValidationResult results = validations.Validate(customer);

            if (results.IsValid)
            {
                customerManager.Add(customer);
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
        public IActionResult EditCustomer(int id)
        {
            var value = customerManager.GetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditCustomer(Customer customer)
        {
            CustomerValidator validations = new CustomerValidator();
            ValidationResult results = validations.Validate(customer);

            if (results.IsValid)
            {
                customerManager.Update(customer);
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

        public IActionResult DeleteCustomer(int id)
        {
            var data = customerManager.GetByID(id);
            customerManager.Delete(data);
            return RedirectToAction("Index");
        }
    }
}
