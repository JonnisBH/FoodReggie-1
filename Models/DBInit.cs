using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace FoodReggie_1.Models;

public static class DBInit{
    public static void Seed(IApplicationBuilder app){
        using var serviceScope = app.ApplicationServices.CreateScope();
        FoodDbContext context = serviceScope.ServiceProvider.GetRequiredService<FoodDbContext>();
        //Deletion/Creation of the database
        //context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        if(!context.Foods.Any()){
            var foods = new List<Food>{
                new Food{
                    Name = "Chicken",
                    FoodGroup = "Meat",
                    Calories = 111,
                    Protein = 23,
                    Carbohydrates = 0,
                    Fats = 2.1,
                    ImageURL = "/images/chicken.jpg"
                },
                new Food{
                    Name = "Salmon Fillet",
                    FoodGroup = "Meat",
                    Calories = 224,
                    Protein = 20,
                    Carbohydrates = 0,
                    Fats = 16,
                    ImageURL = "/images/salmon.jpg"
                },
                new Food{
                    Name = "Ribeye Steak",
                    FoodGroup = "Meat",
                    Calories = 186,
                    Protein = 20.6,
                    Carbohydrates = 0,
                    Fats = 11.5,
                    ImageURL = "/images/ribeye.jpg"
                },
                new Food{
                    Name = "Basmati Rice",
                    FoodGroup = "Grains",
                    Calories = 120,
                    Protein = 6.7,
                    Carbohydrates = 77,
                    Fats = 0.1,
                    ImageURL = "/images/rice.jpg"
                },
                new Food{
                    Name = "Potatoes",
                    FoodGroup = "Vegetable",
                    Calories = 72,
                    Protein = 1.7,
                    Carbohydrates = 15.3,
                    Fats = 0.1,
                    ImageURL = "/images/potatoes.jpg"
                },
                new Food{
                    Name = "Pasta",
                    FoodGroup = "Grains",
                    Calories = 364,
                    Protein = 12,
                    Carbohydrates = 74,
                    Fats = 1.5,
                    ImageURL = "/images/pasta.jpg"
                },
            };
            context.AddRange(foods);
            context.SaveChanges();
        }

        if(!context.Users.Any()){
            var users = new List<User>{
                new User{
                    Name = "Petter Olsen",
                    Email = "petterolsen03@gmail.com"
                },
                new User{
                    Name = "Marthe Pettersen",
                    Email = "marthepettersen81@gmail.com"
                },
            };
            context.AddRange(users);
            context.SaveChanges();
        }

        if(!context.Registrations.Any()){
            var registrations = new List<Registration>{
                new Registration{
                    RegistrationDate = DateTime.Today.ToString(),
                    UserId = 1
                },
                new Registration{
                    RegistrationDate = DateTime.Today.ToString(),
                    UserId = 2
                },
            };
            context.AddRange(registrations);
            context.SaveChanges();
        }

        if(!context.RegistratedFoods.Any()){
            var registratedFoods = new List<RegistratedFood>{
                new RegistratedFood{
                    FoodId = 1,
                    RegistrationId = 1
                },
                new RegistratedFood{
                    FoodId = 2,
                    RegistrationId = 2
                },
            };
            context.AddRange(registratedFoods);
            context.SaveChanges();
        }
    }
}