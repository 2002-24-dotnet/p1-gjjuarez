using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;
using System.Linq;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Singletons
{
   public class PizzeriaSingleton
   {
      private static readonly PizzeriaRepository _pr = new PizzeriaRepository();

      private static readonly PizzeriaSingleton _ps = new PizzeriaSingleton();
      public Order Order { get; set; }
      public User User { get; set; }
      public Store Store { get; set; }

      public static PizzeriaSingleton Instance
      {
         get
         {
            return _ps;
         }
      }

      private PizzeriaSingleton() { }

      public List<T> Get<T>() where T : class
      {
         return _pr.Get<T>().ToList();
      }

      public T Get<T>(long Id) where T : class
      {
         return Get<T>(Id);
      }

      public void Post<T>(T item) where T : class
      {
         _pr.Post<T>(item);
      }

      public Pizza CreatePizza(PizzaViewModel pizzaViewModel)
      {
         long crustid = long.Parse(pizzaViewModel.CrustId);
         long sizeid = long.Parse(pizzaViewModel.SizeId);

         Crust crust = _pr.Get<Crust>(crustid);
         Size size = _pr.Get<Size>(sizeid);

         var pizza = new Pizza(pizzaViewModel.Name);

         Post<Pizza>(pizza);

         if(crust.Pizzas == null)
            crust.Pizzas = new List<Pizza>();
         crust.Pizzas.Add(pizza);
         _pr.Put<Crust>(crust);

         if(size.Pizzas == null)
            size.Pizzas = new List<Pizza>();
         size.Pizzas.Add(pizza);
         _pr.Put<Size>(size);

         // foreach(var t in toppings)
         // {
         //    PizzaTopping pt = new PizzaTopping();
         //    pt.Pizza = pizza;
         //    pt.Topping = t;
         //    pt.PizzaId = pizza.Id;
         //    pt.ToppingId = t.Id;
         //    _pr.Post<PizzaTopping>(pt);
         //    _pr.Put<Pizza>(pizza);
         //    _pr.Put<Topping>(t);
         // }

         return pizza;
      }
   }
}