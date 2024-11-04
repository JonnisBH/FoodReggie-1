using System;
using FoodReggie_1.Models;
using FoodReggie_1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace FoodReggie_1.Controllers;

public class FoodController : Controller{
    private readonly FoodDbContext _foodDbContext;

    public FoodController(FoodDbContext foodDbContext){
        _foodDbContext = foodDbContext;
    }
    public async Task<IActionResult> Table(){
        List<Food> foods = await _foodDbContext.Foods.ToListAsync();
        var foodViewModel = new FoodViewModel(foods, "Table");
        return View(foodViewModel);
    }

    public async Task<IActionResult> Grid(){
        List<Food> foods = await _foodDbContext.Foods.ToListAsync();
        var foodViewModel = new FoodViewModel(foods, "Grid");
        return View(foodViewModel);
    }

    [HttpGet]
    public IActionResult Create(){
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Food food){
        if(ModelState.IsValid){
            _foodDbContext.Foods.Add(food);
            await _foodDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Table));
        }
        return View(food);
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id){
        var food = await _foodDbContext.Foods.FindAsync(id);
        if (food == null){
            return NotFound();
        }
        return View(food);
    }

    [HttpPost]
    public async Task<IActionResult> Update(Food food){
        if (ModelState.IsValid){
            _foodDbContext.Foods.Update(food);
           await _foodDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Table));
        }
        return View(food);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id){
        var food = await _foodDbContext.Foods.FindAsync(id);
        if(food == null){
            return NotFound();
        }
        return View(food);
    }

    [HttpPost]
    public async Task<IActionResult> ConfirmDelete(int id){
        var food = await _foodDbContext.Foods.FindAsync(id);
        if(food == null){
            return NotFound();
        }
        _foodDbContext.Foods.Remove(food);
        await _foodDbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Table));
    }
}