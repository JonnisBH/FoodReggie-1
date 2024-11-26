using Microsoft.AspNetCore.Mvc;
using FoodReggie_1.Models;
using FoodReggie_1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace FoodReggie_1.Controllers;

public class RegistrationController : Controller{
    private readonly FoodDbContext _foodDbContext;
    private readonly ILogger<RegistrationController> _logger;

    public RegistrationController(FoodDbContext foodDbContext, ILogger<RegistrationController> logger){
        _foodDbContext = foodDbContext;
        _logger = logger;
    }

    [Authorize]
    public async Task<IActionResult> Table(){
        try{
            List<Registration> registrations = await _foodDbContext.Registrations.ToListAsync();
            return View(registrations);
        }
        catch{
            _logger.LogError("[RegistrationController] Food list not found while executing _foodDbContext.ToListAsync");
            return NotFound("Not registrations could be found");
        }
    }
}