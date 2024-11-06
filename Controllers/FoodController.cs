using System;
using FoodReggie_1.Models;
using FoodReggie_1.DAL;
using FoodReggie_1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace FoodReggie_1.Controllers;

public class FoodController : Controller{
    private readonly IFoodRepository _foodRepository;

    public FoodController(IFoodRepository foodRepository){
        _foodRepository = foodRepository;
    }
    public async Task<IActionResult> Table(){
        var foods = await _foodRepository.GetAll();
        var foodViewModel = new FoodViewModel(foods, "Table");
        return View(foodViewModel);
    }

    public async Task<IActionResult> Grid(){
        var foods = await _foodRepository.GetAll();
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
            await _foodRepository.Create(food);
            return RedirectToAction(nameof(Table));
        }
        return View(food);
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id){
        var food = await _foodRepository.GetFoodById(id);
        if (food == null){
            return NotFound();
        }
        return View(food);
    }

    [HttpPost]
    public async Task<IActionResult> Update(Food food){
        if (ModelState.IsValid){
            await _foodRepository.Update(food);
            return RedirectToAction(nameof(Table));
        }
        return View(food);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id){
        var food = await _foodRepository.GetFoodById(id);
        if(food == null){
            return NotFound();
        }
        return View(food);
    }

    [HttpPost]
    public async Task<IActionResult> ConfirmDelete(int id){
        await _foodRepository.Delete(id);
        return RedirectToAction(nameof(Table));
    }
}