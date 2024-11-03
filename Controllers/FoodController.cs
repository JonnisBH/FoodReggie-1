using System;
using FoodReggie_1.Models;
using FoodReggie_1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodReggie_1.Controllers;

public class FoodController : Controller{
    public IActionResult Table(){
        var foods = GetFoods();
        var foodViewModel = new FoodViewModel(foods, "Table");
        return View(foodViewModel);
    }

    public IActionResult Grid(){
        var foods = GetFoods();
        var foodViewModel = new FoodViewModel(foods, "Grid");
        return View(foodViewModel);
    }

    public List<Food> GetFoods(){
        var foods = new List<Food>();
        var food1 = new Food{
            FoodId = 1,
            Name = "Chicken Breast",
            Calories = 111,
            Protein = 23,
            Carbohydrates = 0,
            Fats = 2.1,
            ImageURL = "/images/chicken.jpg"
        };
        var food2 = new Food{
            FoodId = 2,
            Name = "Salmon Fillet",
            Calories = 224,
            Protein = 20,
            Carbohydrates = 0,
            Fats = 16,
            ImageURL = "/images/salmon.jpg"
        };
        var food3 = new Food{
            FoodId = 3,
            Name = "Ribeye Steak",
            Calories = 186,
            Protein = 20.6,
            Carbohydrates = 0,
            Fats = 11.5,
            ImageURL = "/images/ribeye.jpg"
        };
        var food4 = new Food{
            FoodId = 4,
            Name = "Basmati Rice",
            Calories = 120,
            Protein = 6.7,
            Carbohydrates = 77,
            Fats = 0.5,
            ImageURL = "/images/rice.jpg"
        };
        var food5 = new Food{
            FoodId = 5,
            Name = "Potatoes",
            Calories = 72,
            Protein = 1.7,
            Carbohydrates = 15.3,
            Fats = 0.1,
            ImageURL = "/images/potatoes.jpg"
        };
        var food6 = new Food{
            FoodId = 6,
            Name = "Pasta",
            Calories = 364,
            Protein = 12,
            Carbohydrates = 74,
            Fats = 1.5,
            ImageURL = "/images/pasta.jpg"
        };
        foods.Add(food1);
        foods.Add(food2);
        foods.Add(food3);
        foods.Add(food4);
        foods.Add(food5);
        foods.Add(food6);
        return foods;
    }
}