using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Crust : APizzaComponent
    {
       public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

       public Crust()
       {
         Id = DateTime.Now.Ticks;
       }

      public override string ToString()
      {
         return $"{Name} | {Price}";
      }
    }
}