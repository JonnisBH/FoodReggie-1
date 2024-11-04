using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace FoodReggie_1.Models;

public class FoodDbContext : DbContext{
    public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options){
        //Database.EnsureCreated();
    }

    public DbSet<Food> Foods { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Registration> Registrations { get; set; }
    public DbSet<RegistratedFood> RegistratedFoods { get; set; }
}