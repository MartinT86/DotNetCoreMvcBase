using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my home default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the home Welcome action method...";
        }
    }
}