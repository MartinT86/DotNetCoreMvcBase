using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;
using MvcMovie.Models;
using MvcMovie.Services;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetHomeModels _homeModelService;

        public HomeController (IGetHomeModels homeModelService)
        {
            _homeModelService = homeModelService;        
        }

        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            var model = _homeModelService.GetHomeModel();
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