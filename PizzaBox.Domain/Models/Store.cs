using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
   public class Store : AUser
   {
      public string Address { get; set; }
      public List<Order> Orders { get; set; }

      public Store()
      {
          Id = DateTime.Now.Ticks;
          Orders = new List<Order>();
      }

      public override string ToString()
      {
         return $"{Name ?? "N/A"} | {Address}";
      }
   }
}