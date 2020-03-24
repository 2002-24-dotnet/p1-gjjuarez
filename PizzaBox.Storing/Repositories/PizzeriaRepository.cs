using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
   public class PizzeriaRepository
   {
      private static PizzaBoxDbContext _db = new PizzaBoxDbContext();

      public PizzeriaRepository()
      {
      }

      public PizzeriaRepository(PizzaBoxDbContext dbContext)
      {
         _db = dbContext;
      }

      public IEnumerable<T> Get<T>() where T : class
      {
         return _db.Set<T>();
      }

      public T Get<T>(long id) where T : class, IDbItem
      {
         return _db.Set<T>().SingleOrDefault(t => t.Id == id);
      }

      public bool Post<T>(T item) where T : class
      {
         _db.Set<T>().Add(item);
         return _db.SaveChanges() == 1;
      }

      public bool Put<T>(T item) where T : class, IDbItem
      {
         var i = Get<T>(item.Id);

         i = item;

         return _db.SaveChanges() == 1;
      }
   }
}