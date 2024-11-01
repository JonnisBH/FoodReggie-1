using System;
using FoodReggie_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodReggie_1.Controllers;

public class FoodController : Controller{
    public IActionResult Table(){
        var foods = GetFoods();
        ViewBag.CurrentViewName = "Table";
        return View(foods);
    }

    public IActionResult Grid(){
        var foods = GetFoods();
        ViewBag.CurrentViewName = "Grid";
        return View(foods);
    }

    public List<Food> GetFoods(){
        var foods = new List<Food>();
        var food1 = new Food{
            FoodId = 1,
            Name = "Kebab",
            Price = 69,
            Description = "Delicious kebab with homemade pita bread, fresh vegetables, meat and our own special kebab dressing.",
            ImageURL = "/images/kebab.jpg"
        };
        var food2 = new Food{
            FoodId = 2,
            Name = "Hamburger",
            Price = 89,
            Description = "Hamburger with bacon, cheddar cheese, lettuce, tomatoes, onions and our own special hamburger dressing.",
            ImageURL = "/images/hamburger.jpg"
        };
        var food3 = new Food{
            FoodId = 3,
            Name = "Fried chicken",
            Price = 79,
            Description = "Crispy fried chicken made with quality meat from local Norwegian farmers.",
            ImageURL = "/images/friedChicken.jpg"
        };
        var food4 = new Food{
            FoodId = 4,
            Name = "Tacos",
            Price = 59,
            Description = "Freshly made tacos with lettuce, tomatoes, corn, beef and sour cream. Optional: Guacamole.",
            ImageURL = "/images/tacos.jpg"
        };
        var food5 = new Food{
            FoodId = 5,
            Name = "Pancakes",
            Price = 99,
            Description = "Fluffy pancakes served with syrup and butter on top.",
            ImageURL = "/images/pancakes.jpg"
        };
        var food6 = new Food{
            FoodId = 6,
            Name = "Pizza",
            Price = 109,
            Description = "American pizza with tomato sauce, mozzarella and optional toppings",
            ImageURL = "/images/pizza.jpg"
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