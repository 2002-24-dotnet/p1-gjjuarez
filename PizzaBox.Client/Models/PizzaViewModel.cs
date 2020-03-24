using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Models
{
   public class PizzaViewModel
   {
      private PizzeriaRepository _pbr = new PizzeriaRepository();

      public SelectList CrustList { get; set; }
      public SelectList SizeList { get; set; }
      public SelectList ToppingList { get; set; }
      [Required]
      public string Name { get; set; }
      [Required]
      public string CrustId { get; set; }
      [Required]
      public string SizeId { get; set; }
      // public List<string> ToppingsId { get; set; }

      public PizzaViewModel()
      {
         CrustList = SelectList<Crust>();
         SizeList = SelectList<Size>();
         // ToppingList = SelectList<Topping>();
      }

      private SelectList SelectList<T>() where T : APizzaComponent
      {
         return new SelectList(_pbr.Get<T>().Select(x =>
                        new SelectListItem
                        {
                           Value = x.Id.ToString(),
                           Text = x.Name
                        }), "Value", "Text");
      }
   }
}
