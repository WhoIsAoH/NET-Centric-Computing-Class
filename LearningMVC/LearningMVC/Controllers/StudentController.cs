using LearningMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDetail()
        {
            StudentModel std = new StudentModel();
            std.FirstName = "John";
            std.LastName = "Hero";
            std.Address = "NoWhere";
            std.Age = "29";
            std.College = "BMC";
            return View(std);
        }
    }
}
