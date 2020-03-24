using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Client.Singletons;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Controllers
{
   public class UserController : Controller
   {
      //public List<PizzaViewModel> orderlist; 
      private PizzeriaSingleton _ps = PizzeriaSingleton.Instance;
      private long OrderId = 637204345527094017;

      [HttpGet]
      public IActionResult OrderPizza()
      {
         return View(new PizzaViewModel());
      }

      [HttpPost]
      public IActionResult OrderPizza(PizzaViewModel pizzaViewModel)
      {
         if(ModelState.IsValid)
         {
            _ps.CreatePizza(pizzaViewModel);
            //orderlist.Add(pizzaViewModel);
            return RedirectToAction("Order", pizzaViewModel);
         }

         return View("OrderPizza", pizzaViewModel);
      }

      [HttpGet]
      public IActionResult NewOrder()
      {
         Order order = new Order();
         return View();
      }

      public IActionResult Order(PizzaViewModel pizzaViewModel)
      {
        return View(pizzaViewModel);
      }


   }
}