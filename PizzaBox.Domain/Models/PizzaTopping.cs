using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models
{
   public class PizzaTopping
   {
      public long PizzaId { get; set; }
      public Pizza Pizza { get; set; }
      public long ToppingId { get; set; }
      public Topping Topping { get; set; }
   }
}