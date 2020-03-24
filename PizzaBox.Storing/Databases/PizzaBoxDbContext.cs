using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Databases
{
   public class PizzaBoxDbContext : DbContext
   {
      public DbSet<Crust> Crust { get; set; }
      public DbSet<Pizza> Pizza { get; set; }
      public DbSet<Size> Size { get; set; }
      public DbSet<Topping> Topping { get; set; }
      public DbSet<PizzaTopping> PizzaTopping { get; set; }
      public DbSet<Order> Order { get; set; }
      public DbSet<Store> Store { get; set; }
      public DbSet<User> User { get; set; }

      public static PizzaBoxDbContext _pizzaboxdb;

      public static PizzaBoxDbContext Instance
      {
         get
         {
            if (_pizzaboxdb == null)
               _pizzaboxdb = new PizzaBoxDbContext();
            return _pizzaboxdb;
         }
      }

      public PizzaBoxDbContext()
      {

      }

      protected override void OnConfiguring(DbContextOptionsBuilder builder)
      {
         builder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345;");
      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
         builder.Entity<PizzaTopping>().HasKey(pt => new { pt.PizzaId, pt.ToppingId });
         builder.Entity<Topping>().HasKey(t => t.Id);
         builder.Entity<Store>().HasKey(s => s.Id);
         builder.Entity<Pizza>(b =>
         {
            b.Property(p => p.Id).ValueGeneratedNever();
         });
         builder.Entity<Order>(b =>
         {
            b.Property(o => o.Id).ValueGeneratedNever();
         });
         builder.Entity<User>(b =>
         {
            b.Property(u => u.Id).ValueGeneratedNever();
         });
         builder.Entity<Crust>(b =>
         {
            b.Property(c => c.Id).ValueGeneratedNever();
         });
         builder.Entity<Size>(b =>
         {
            b.Property(s => s.Id).ValueGeneratedNever();
         });

         builder.Entity<Crust>().HasMany(c => c.Pizzas).WithOne(p => p.Crust);
         builder.Entity<Pizza>().HasMany(p => p.PizzaToppings).WithOne(pt => pt.Pizza).HasForeignKey(pt => pt.PizzaId);
         builder.Entity<Size>().HasMany(s => s.Pizzas).WithOne(p => p.Size);
         builder.Entity<Topping>().HasMany(t => t.PizzaToppings).WithOne(pt => pt.Topping).HasForeignKey(pt => pt.ToppingId);

         builder.Entity<Order>().HasMany(o => o.Pizzas).WithOne(p => p.Order);
         builder.Entity<Store>().HasMany(s => s.Orders).WithOne(o => o.Store);
         builder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);

         builder.Entity<Crust>().HasData(new Crust[]
         {
            new Crust() { Name = "Stuffed Crust", Price = 3.00M },
            new Crust() { Name = "Hand Tossed", Price = 1.00M },
            new Crust() { Name = "Deep Dish", Price = 2.00M },
         });

         builder.Entity<Size>().HasData(new Size[]
         {
            new Size() { Name = "Large", Price = 17.95M },
            new Size() { Name = "Regular", Price = 12.95M },
            new Size() { Name = "Small", Price = 9.95M },
         });

         builder.Entity<Topping>().HasData(new Topping[]
         {
            new Topping() { ToppingType = toppingtype.Cheese, Name = "Mozzarella Cheese", Price = 0.25M },
            new Topping() { ToppingType = toppingtype.Cheese,Name = "Parmesan Cheese", Price = 0.50M },
            new Topping() { ToppingType = toppingtype.Sauce,Name = "Tomato Sauce", Price = 0.25M },
            new Topping() { ToppingType = toppingtype.Meat, Name = "Pepperoni", Price = 1.00M },
            new Topping() { ToppingType = toppingtype.Meat, Name = "Ham", Price = 1.50M },
            new Topping() { ToppingType = toppingtype.Meat, Name = "Beef", Price = 1.50M },
            new Topping() { ToppingType = toppingtype.Meat, Name = "Olive", Price = 1.50M },
         });

         builder.Entity<User>().HasData(new User[]
         {
            new User() { Name = "George", Username = "George", Password = "Password12345"}
         });

         builder.Entity<Store>().HasData(new Store[]
         {
            new Store() { Name = "Dominos", Address = "12345 Streat st, Arlington, Texas", Username = "store1", Password = "Password1" },
            new Store() { Name = "Papa Johns", Address = "12346 Streat st, Arlington, Texas", Username = "store2", Password = "Password2" },

         });
      }
   }
}
