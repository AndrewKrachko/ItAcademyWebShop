using ItAcademyWebShop.Items.Interfaces;
using ItAcademyWebShop.Views.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ItAcademyWebShop.Controllers
{
    public class HomeController : Controller
    {
        private IProcessor _processor;

        public HomeController(IProcessor processor)
        {
            _processor = processor;
        }

        public IActionResult Index(string name = "")
        {
            return View(new ItemModel(_processor.DataBroker) { ActiveCategory = name });
        }

        public IActionResult Contacts()
        {
            return View(new ItemModel(_processor.DataBroker));
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetUserNameViaCookie(string userName)
        {
            var cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Append("userName", userName ?? "", cookieOptions);

            return Redirect("Index");
        }
    }
}