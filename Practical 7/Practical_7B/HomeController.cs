using Microsoft.AspNetCore.Mvc;
using Practical_7A.Models;
using System.Diagnostics;

namespace Practical_7A.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student();

            s.RollNo = "T016";
            s.Name = "Himani Malankar";

            return View(s);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
