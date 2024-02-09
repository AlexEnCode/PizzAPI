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


        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredient { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*   modelBuilder.Entity<User>().HasKey(u => u.Id);

               modelBuilder.Entity<Ingredient>().HasKey(i => i.Id);

               modelBuilder.Entity<Pizza>().HasKey(p => p.Id);

               modelBuilder.Entity<PizzaIngredient>().HasKey(pi => new { pi.PizzaId, pi.IngredientId });*/


        }
    }
}

