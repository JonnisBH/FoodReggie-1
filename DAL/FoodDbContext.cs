using FoodReggie_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FoodReggie_1.DAL;

public class FoodDbContext : IdentityDbContext{
    //Constructor that accepts DbContextOptions to configure the context of the database.
    public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options){
    }

    //Dbsets representing the entities in the database
    public DbSet<Food> Foods { get; set; }
    public DbSet<User> Accounts { get; set; }
    public DbSet<Registration> Registrations { get; set; }
    public DbSet<RegistratedFood> RegistratedFoods { get; set; }

    //Overrides the OnConfiguring method to add additional configurations.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseLazyLoadingProxies();
    }
}