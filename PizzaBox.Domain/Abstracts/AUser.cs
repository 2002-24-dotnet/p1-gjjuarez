using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Abstracts
{
   public class AUser : IDbItem
   {
      public long Id { get; set; }
      public string Name { get; set; }
      public string Username { get; set; }
      public string Password { get; set; }
   }
}