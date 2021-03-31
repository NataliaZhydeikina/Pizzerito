using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizzerito.Models;

namespace Pizzerito.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

       /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }*/


        public DbSet<Category> Category { get; set; }
        public DbSet<Toppings> Toppings { get; set; }
        public DbSet<ToppingType> ToppingType { get; set; }
        public DbSet<PizzaCrustFlavor> PizzaCrustFlavor { get; set; }
        public DbSet<PizzaCrustType> PizzaCrustType { get; set; }
        public DbSet<PizzaSize> PizzaSize { get; set; }
        public DbSet<PizzaType> PizzaType { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<OrderHeader> OrderHeader { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }



    }
}
