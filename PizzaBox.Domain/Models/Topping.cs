using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
   public enum toppingtype
   {
      Cheese,
      Sauce,
      Meat,
      Veggie
   }

   public class Topping : APizzaComponent
   {
      public List<PizzaTopping> PizzaToppings { get; set; }
      public toppingtype ToppingType { get; set; }

      public Topping()
      {
         Id = DateTime.Now.Ticks;
      }

      public override string ToString()
      {
         return $"{Name ?? "N/A"} | {ToppingType} | {Price}";
      }
   }
}