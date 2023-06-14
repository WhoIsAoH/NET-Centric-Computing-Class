using LabReportForMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LabReportForMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult MyAction()
        {
            return View(); 
        }
        public IActionResult Content()
        {
            return Content("This is the output returned when action return type is content");
        }
        public JsonResult json()
        {
            return Json(new { name = "Aarya", lastname = "Dangol" });
        }
        public IActionResult Partial()
        {
            return PartialView("Partial");
        }
        public IActionResult Download()
        {
            return File("~/myfile.txt","text/plain","myfile.txt");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}