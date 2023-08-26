using Microsoft.AspNetCore.Mvc;
using QuizManagmentSystem.DataContext;
using QuizManagmentSystem.Models;
using QuizManagmentSystem.Services;
using System.Diagnostics;

namespace QuizManagmentSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserEntitiesRepositry userEntities;
        public HomeController(IUserEntitiesRepositry db)
        {
            userEntities = db;   
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {

            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(UserData userData)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();    
            }
           IEnumerable<UserData> response =userEntities.GetAll();
            foreach(UserData item in response)
            {
                if(userData.FName == item.FName || userData.MName==item.MName || userData.LName == item.LName)
                {
                    ViewBag.message = "You all ready register";
                    return View(item);
                }
            }
            if (userData.Password != userData.ConfirmPassword)
            {
                ViewBag.message = "Password And ConfirmPassword is Not Same";
                return View(userData);
            }
            else
            {
                userEntities.Add(userData);
                userEntities.sava();
            }
            return RedirectToAction("Login");
        }

    }
}