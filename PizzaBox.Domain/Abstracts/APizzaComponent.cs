using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
   public abstract class APizzaComponent : IDbItem
   {
      public long Id { get; set; }
      public string Name { get; set; }
      public decimal Price { get; set; }
   }
}