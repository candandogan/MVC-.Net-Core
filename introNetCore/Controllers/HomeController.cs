using introNetCore.Modals;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Candan";
            ViewBag.Hour = DateTime.Now.Hour;

            List<Product> products = new List<Product>();
            products.Add(new Product {Name= "Kazak", Price=125 });
            products.Add(new Product { Name = "Hırka", Price = 225 });
            products.Add(new Product { Name = "Kaban", Price = 325 });

            //ViewBag.Products = products;

            return View(products);
        }

        public IActionResult Davet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Davet (UserResponse userResponse)
        {
            if (ModelState.IsValid)
            {
                if (userResponse.IsAccepted)
                {
                    AcceptedUsers.Add(userResponse);
                }
                //TODO 1: Her şey doğruysa bu kısım çalışacak.
                return View("Tesekkur", userResponse);
            }
            return View();
        }

        public IActionResult Gelenler()
        {
            return View(AcceptedUsers.inComingUsers);
        }
    }

}
