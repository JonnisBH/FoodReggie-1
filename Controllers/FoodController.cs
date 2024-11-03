using System;
using FoodReggie_1.Models;
using FoodReggie_1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodReggie_1.Controllers;

public class FoodController : Controller{
    private readonly FoodDbContext _foodDbContext;

    public FoodController(FoodDbContext foodDbContext){
        _foodDbContext = foodDbContext;
    }
    public IActionResult Table(){
        List<Food> foods = _foodDbContext.Foods.ToList();
        var foodViewModel = new FoodViewModel(foods, "Table");
        return View(foodViewModel);
    }

    public IActionResult Grid(){
        List<Food> foods = _foodDbContext.Foods.ToList();
        var foodViewModel = new FoodViewModel(foods, "Grid");
        return View(foodViewModel);
    }
}