using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TanejaShoeStore.Controllers
{
    public class HelloWorldController : Controller
    {
        
        // to getting:/HelloWorld

        public IActionResult Index()
        {
            return View();
        }

          // to getting:/HelloWorld

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}




