using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models
{
   public class Pizza : IDbItem
   {
      public long Id { get; set; }
      public string Name { get; set; }
      public decimal Price
      {
         get
         {
            if (Crust == null || Size == null || PizzaToppings == null)
                return 0;

            return Crust.Price + Size.Price + PizzaToppings.Sum(pt => pt.Topping.Price);
         }
      }
      
      

      #region NAVIGATIONAL PROPERTIES

      public Crust Crust { get; set; }
      public Size Size { get; set; }
      public List<PizzaTopping> PizzaToppings { get; set; }
      public Order Order { get; set; }

      #endregion

      public Pizza(string name)
      {
         Name = name;
         Id = DateTime.Now.Ticks;
         PizzaToppings = new List<PizzaTopping>();
      }

      public override string ToString()
      {
         return $"{Name ?? "N/A"} | {Price} | {((Crust != null)?Crust.Name ?? "N/A":"N/A")} | {((Size != null) ? Size.Name ?? "N/A" : "N/A")} | {PizzaToppings.Count}";
      }
   }
}