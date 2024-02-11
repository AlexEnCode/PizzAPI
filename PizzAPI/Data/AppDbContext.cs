using Microsoft.EntityFrameworkCore;
using PizzAPI.models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace PizzAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
#nullable disable
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredients { get; set; }
#nullable enable

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PizzaIngredient>().HasKey(pi => new { pi.PizzaId, pi.IngredientId });

            var adminRoot = new Utilisateur()
            {
                Id = 1,
                Prenom = "Jean",
                Nom = "Dupont",
                Email = "jd@gmail.com",
                Numero = "0606060606",
                Adresse = "rue de la rue, Rue",
                IsAdmin = true
            };
            modelBuilder.Entity<Utilisateur>().HasData(adminRoot);
        }
    }
}









/*public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }


    public DbSet<Pizza> Pizza { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Ingredient> Ingredient { get; set; }
    public DbSet<PizzaIngredient> PizzaIngredient { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(u => u.Id);

        modelBuilder.Entity<Ingredient>().HasKey(i => i.Id);

        modelBuilder.Entity<Pizza>().HasKey(p => p.Id);

        modelBuilder.Entity<PizzaIngredient>().HasKey(pi => new { pi.PizzaId, pi.IngredientId });


        modelBuilder.Entity<User>().HasData(
         new User()
         {
             Id = 1,
             FirstName = "John",
             LastName = "Doe",
             IsAdmin = false,
             Email = "john.doe@example.com",
             Password = "StrongPassword123!"
         },
        new User()
        {
            Id = 2,
            FirstName = "Alice",
            LastName = "Smith",
            IsAdmin = true,
            Email = "alice.smith@example.com",
            Password = "SecurePass789!"
        },
        new User()
        {
            Id = 3,
            FirstName = "Emma",
            LastName = "Johnson",
            IsAdmin = false,
            Email = "emma.johnson@example.com",
            Password = "Secret1234!"
        });

        modelBuilder.Entity<Ingredient>().HasData(
           new Ingredient { Id = 1, Name = "Tomato sauce", Description = "Freshly made tomato sauce" },
           new Ingredient { Id = 2, Name = "Mozzarella cheese", Description = "High-quality mozzarella cheese" },
           new Ingredient { Id = 3, Name = "Basil", Description = "Fresh basil leaves" });

        modelBuilder.Entity<Pizza>().HasData(
     new Pizza()
      {
       Id = 1,
       Name = "Margherita",
       Description = "Tomato sauce, mozzarella cheese, basil",
       Price = 9.99m,
       Image = "margherita.jpg",
       IsVegetarian = true,
       IsSpicy = false
      },
        new Pizza()
         {
       Id = 2,
       Name = "Pepperoni",
       Description = "Tomato sauce, mozzarella cheese, pepperoni slices",
       Price = 11.99m,
       Image = "pepperoni.jpg",
       IsVegetarian = false,
       IsSpicy = true
        },
         new Pizza()
         {
       Id = 3,
       Name = "Vegetarian Deluxe",
       Description = "Tomato sauce, mozzarella cheese, mushrooms, bell peppers, onions",
       Price = 12.99m,
       Image = "vegetarian_deluxe.jpg",
       IsVegetarian = true,
       IsSpicy = false
          });

        modelBuilder.Entity<PizzaIngredient>().HasData(
           new PizzaIngredient (){ PizzaId = 1, IngredientId = 1 },
           new PizzaIngredient() { PizzaId = 2, IngredientId = 2 },
           new PizzaIngredient() { PizzaId = 3, IngredientId = 3 }
        );
    }
}
}
*/
