using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Client.Singletons;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Controllers
{
   public class UserController : Controller
   {
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
            return RedirectToAction("Order");
         }

         return View("OrderPizza", pizzaViewModel);
      }

      [HttpGet]
      public IActionResult NewOrder()
      {
         Order order = new Order();
         return View();
      }
   }
}