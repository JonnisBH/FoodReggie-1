using Microsoft.AspNetCore.Mvc;
using FoodReggie_1.Models;
using FoodReggie_1.DAL;
using Microsoft.EntityFrameworkCore;

namespace FoodReggie_1.Controllers;

public class RegistrationController : Controller{
    private readonly FoodDbContext _foodDbContext;

    public RegistrationController(FoodDbContext foodDbContext){
        _foodDbContext = foodDbContext;
    }

    public async Task<IActionResult> Table(){
        List<Registration> registrations = await _foodDbContext.Registrations.ToListAsync();
        return View(registrations);
    }
}