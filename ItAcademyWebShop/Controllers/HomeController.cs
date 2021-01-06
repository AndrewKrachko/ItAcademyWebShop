using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ItAcademyWebShop.Items.Interfaces;
using ItAcademyWebShop.Views.Shared;

namespace ItAcademyWebShop.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(string name = "")
        {
            return View(new ItemModel(_repository) { ActiveCategory = name});
        }

        public IActionResult Contacts()
        {
            return View(new ItemModel(_repository));
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