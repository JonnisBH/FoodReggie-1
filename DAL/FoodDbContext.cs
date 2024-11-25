using FoodReggie_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FoodReggie_1.DAL;

public class FoodDbContext : IdentityDbContext{
    public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options){
        //Database.EnsureCreated();
    }

    public DbSet<Food> Foods { get; set; }
    public DbSet<User> Accounts { get; set; } //Could not use the name "Users" on the database because of the IdentityDbContext
    public DbSet<Registration> Registrations { get; set; }
    public DbSet<RegistratedFood> RegistratedFoods { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseLazyLoadingProxies();
    }
}