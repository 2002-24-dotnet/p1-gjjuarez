using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models
{
   public class Order : IDbItem
   {
      public long Id { get; set; }
      public List<Pizza> Pizzas { get; }
      public Store Store { get; set; }
      public User User { get; set; }
      public DateTime TimeOrdered { get; set; } = DateTime.MinValue;

      public bool HasPizza(long pizzaid)
      {
         return Pizzas.Where(p => p.Id == pizzaid).Count() > 0;
      }

      public decimal Price
      {
         get
         {
            if (Pizzas == null)
               return 0;

            return Pizzas.Sum(p => p.Price);
         }
      }

      public Order()
      {
         Pizzas = new List<Pizza>();
         Id = DateTime.Now.Ticks;
      }

      public override string ToString()
      {
         return $"{Store.Name} | {TimeOrdered} | {Pizzas.Count}";
      }

      public string PizzasString()
      {
         string pizzastring = "";
         int i = 0;
         foreach(var p in Pizzas)
         {
            pizzastring += i + " | " + p.ToString() + "\n";
            i++;
         }
         return pizzastring;
      }
   }
}