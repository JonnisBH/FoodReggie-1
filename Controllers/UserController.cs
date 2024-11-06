using Microsoft.AspNetCore.Mvc;
using FoodReggie_1.Models;
using FoodReggie_1.DAL;
using Microsoft.EntityFrameworkCore;

namespace FoodReggie_1.Controllers;

public class UserController : Controller{
    private readonly FoodDbContext _foodDbContext;

    public UserController(FoodDbContext foodDbContext){
        _foodDbContext = foodDbContext;
    }

    public async Task<IActionResult> Table(){
        List<User> users = await _foodDbContext.Users.ToListAsync();
        return View(users);
    }
}