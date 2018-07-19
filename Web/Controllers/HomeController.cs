using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context;
        public HomeController(ApplicationDbContext _db) //Можно оставить так но по феншую используют репозиторий для доступа к базе
        {
            context=_db;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                
                return View(context.News_Table.ToList());
            }
            else
            {
               

                return View();
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Create_News()
        {           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create_News(Web.Models.News newss)
        {           
            if (User.Identity.IsAuthenticated)
            {
                newss._User = User.Identity.Name.ToString(); //имя авторизированного
                var name = User.Identity.Name.ToString();
                foreach (var i in context.Users) //ищем аватарку в данных о юзвере
                {
                    if (i.Email == name)
                    {
                        newss._Avatar_News= i.Avatar;
                    }
                }
            }            
            newss._Date = DateTime.Now.ToString();      //получаем текущее время     
            await context.News_Table.AddAsync(newss);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
