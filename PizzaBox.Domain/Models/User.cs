using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
   public class User : AUser
   {
      public List<Order> Orders { get; set; }

      public User()
      {
         Id = DateTime.Now.Ticks;
         Orders = new List<Order>();
      }
   }
}