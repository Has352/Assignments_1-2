using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        int nu ;
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
        public IActionResult Reverse()
        {
            return View();
        }
        public IActionResult Math_Op(int N1,Char OpTy, int N2, object value)
        {
            ViewData["N1"] = N1;
            char op = OpTy;
            ViewData["N2"] = N2;
            switch(OpTy)
            {
                case '+':
                   nu = N1 + N2;
                    break;
                case '-':
                    nu = N1 - N2;
                    break;
                case '*':
                    nu = N1 * N2;
                    break;
                case '/':
                    nu = N1 / N2;
                    break;
            }
            ViewData["value"] = nu;
            ViewData["mo"]=op;
            return View();
        }
        public IActionResult Math()
        {
            return View();
        }

        public IActionResult ReverseValue(String Name)
        {
            var reserved = new string(Name.Reverse().ToArray());
            ViewData["fin"] = reserved;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}