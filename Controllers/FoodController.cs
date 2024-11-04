using System;
using FoodReggie_1.Models;
using FoodReggie_1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Json;

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

    [HttpGet]
    public IActionResult Create(){
        return View();
    }

    [HttpPost]
    public IActionResult Create(Food food){
        if(ModelState.IsValid){
            _foodDbContext.Foods.Add(food);
            _foodDbContext.SaveChanges();
            return RedirectToAction(nameof(Table));
        }
        return View(food);
    }

    [HttpGet]
    public IActionResult Update(int id){
        var food = _foodDbContext.Foods.Find(id);
        if (food == null){
            return NotFound();
        }
        return View(food);
    }

    [HttpPost]
    public IActionResult Update(Food food){
        if (ModelState.IsValid){
            _foodDbContext.Foods.Update(food);
            _foodDbContext.SaveChanges();
            return RedirectToAction(nameof(Table));
        }
        return View(food);
    }

    [HttpGet]
    public IActionResult Delete(int id){
        var food = _foodDbContext.Foods.Find(id);
        if(food == null){
            return NotFound();
        }
        return View(food);
    }

    [HttpPost]
    public IActionResult ConfirmDelete(int id){
        var food = _foodDbContext.Foods.Find(id);
        if(food == null){
            return NotFound();
        }
        _foodDbContext.Foods.Remove(food);
        _foodDbContext.SaveChanges();
        return RedirectToAction(nameof(Table));
    }
}