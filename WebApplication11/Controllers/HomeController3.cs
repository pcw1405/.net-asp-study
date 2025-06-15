using Microsoft.AspNetCore.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class HomeController3 : Controller
    {
        public IActionResult Index()
        {
            /*         ViewBag.Arr = new string[]
                     {
                         "alhpa",
                         "beta",
                         "gamma"

                     };*/
            ViewBag.book = new Book
            {
                Title="칼의 노래",
                Writer="김훈"

            };
            return View();
        }
    }
}
