using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            var model = new Home()
            {
                ID = 123,
                Title = "Tester"
            };
            return View(model);
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the home Welcome action method...";
        }
    }
}