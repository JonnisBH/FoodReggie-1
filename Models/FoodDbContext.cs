using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace FoodReggie_1.Models;

public class FoodDbContext : DbContext{
    public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options){
        Database.EnsureCreated();
    }

    public DbSet<Food> Foods { get; set; }
}