using System;
using FoodReggie_1.Models;
using FoodReggie_1.DAL;
using FoodReggie_1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace FoodReggie_1.Controllers;

public class FoodController : Controller{
    private readonly IFoodRepository _foodRepository;
    private readonly ILogger<FoodController> _logger;

    public FoodController(IFoodRepository foodRepository, ILogger<FoodController> logger){
        _foodRepository = foodRepository;
        _logger = logger;
    }

    //Action method to display a list of food items in table view
    public async Task<IActionResult> Table(){
        var foods = await _foodRepository.GetAll();
        if(foods == null){
            _logger.LogError("[FoodController] Food list not found while executing _foodRepository.GetAll()");
            return NotFound();
        }
        var foodViewModel = new FoodViewModel(foods, "Table");
        return View(foodViewModel);

    }

    //Action method to display a list of food grid in table view
    public async Task<IActionResult> Grid(){
        var foods = await _foodRepository.GetAll();
        if(foods == null){
            _logger.LogError("[FoodController] Food list not found while executing _foodRepository.GetAll()");
            return NotFound();
        }
        var foodViewModel = new FoodViewModel(foods, "Grid");
        return View(foodViewModel);
    }

    //Http get action
    [HttpGet]
    [Authorize]
    public IActionResult Create(){
        return View();
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(Food food){ //Action method for creating a new food item
        if(ModelState.IsValid){
            bool returnOk = await _foodRepository.Create(food);
            if(returnOk){
                return RedirectToAction(nameof(Table));
            }
        }
        _logger.LogError("[FoodController] Error when creating a Food Item: {@food}", food);
        return View(food);
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Update(int id){
        var food = await _foodRepository.GetFoodById(id);
        if (food == null){
            _logger.LogError("[FoodController] error when updating Food. FoodId: {FoodId:0000}", id);
            return BadRequest("There is no Food matching the FoodId");
        }
        return View(food); 
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Update(Food food){
        if (ModelState.IsValid){
            bool returnOk = await _foodRepository.Update(food);
            if(returnOk){
                return RedirectToAction(nameof(Table));
            }
        }
        _logger.LogError("[FoodController] Error when updating Food. Food: {@food}", food);
        return View(food);
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Delete(int id){
        var food = await _foodRepository.GetFoodById(id);
        if(food == null){
            _logger.LogError("[FoodController] There is no food matching the FoodId: {FoodId:0000}", id);
            return BadRequest("There is no Food matching the FoodId");
        }
        return View(food);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> ConfirmDelete(int id){
        bool returnOk = await _foodRepository.Delete(id);
        if(!returnOk){
            _logger.LogError("[FoodController] Unable to delete Food with FoodId: {FoodId:0000}", id);
        }
        return RedirectToAction(nameof(Table));
    }
}