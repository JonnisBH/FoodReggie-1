using System;
using FoodReggie_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodReggie_1.Controllers;

public class FoodController : Controller{
    public IActionResult Table(){
        var foods = new List<Food>();
        var food1 = new Food{
            FoodId = 1,
            Name = "Kebab",
            Price = 69
        };
        var food2 = new Food{
            FoodId = 2,
            Name = "Hamburger",
            Price = 89
        };
        foods.Add(food1);
        foods.Add(food2);
        ViewBag.CurrentViewName = "Food menu";
        return View(foods);
    }
}