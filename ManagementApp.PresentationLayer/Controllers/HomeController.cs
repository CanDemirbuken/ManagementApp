using ManagementApp.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ManagementApp.PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
