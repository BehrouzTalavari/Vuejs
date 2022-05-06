using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

using VueJsProject.Models;

namespace VueJsProject.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }      
        public IActionResult Animation()
        {
            return View();
        }   
        
        public IActionResult FlipCards()
        {
            return View();
        }   
        
        public IActionResult FlipCardsByClick()
        {
            return View();
        }
        
        public IActionResult AjaxUsing()
        {
            return View();
        }

        public IActionResult EventBubbling()
        {
            return View();
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