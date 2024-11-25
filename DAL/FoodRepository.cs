using Microsoft.EntityFrameworkCore;
using FoodReggie_1.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace FoodReggie_1.DAL;

public class FoodRepository : IFoodRepository{
    private readonly FoodDbContext _db;
    private readonly ILogger<FoodRepository> _logger;

    public FoodRepository(FoodDbContext db, ILogger<FoodRepository> logger){
        _db = db;
        _logger = logger;
    }

    public async Task<IEnumerable<Food>?> GetAll(){
        try{
            return await _db.Foods.ToListAsync();
        }
        catch(Exception e){
            _logger.LogError("[FoodRepository] foods ToListAsync() failed when GetAll(), error message: {e}", e.Message);
            return null;
        }
        
    }

    public async Task<Food?> GetFoodById(int id){
        try{
            return await _db.Foods.FindAsync(id);
        }
        catch(Exception e){
            _logger.LogError("[FoodRepository] food FindAsync(id) failed when GetItemById for FoodId {FoodId:0000}, error message: {e}", id, e.Message);
            return null;
        }
    }

    public async Task<bool> Create(Food food){
        try{
            _db.Foods.Add(food);
            await _db.SaveChangesAsync();
            return true;
        }
        catch(Exception e){
            _logger.LogError("[FoodRepository] food creation failed for food {@food}, error message: {e}", food, e.Message);
            return false;
        }
        
    }

    public async Task<bool> Update(Food food){
        try{
            _db.Foods.Update(food);
            await _db.SaveChangesAsync();
            return true;
        }
        catch(Exception e){
            _logger.LogError("[FoodRepository] food FindAsync(id) failed when updating the FoodId {FoodId:0000}, error message: {e}", food, e.Message);
            return false;
        }
        
    }

    public async Task<bool> Delete(int id){
        try{
            var food = await _db.Foods.FindAsync(id);
            if(food == null){
                _logger.LogError("[FoodRepository] food not found for the FoodId {FoodId:0000}", id);
                return false;
            }

            _db.Foods.Remove(food);
            await _db.SaveChangesAsync();
            return true;
        }
        catch(Exception e){
            _logger.LogError("[FoodRepository] food deletion failed for the FoodId {FoodId:0000}, error message: {e}", id, e.Message);
            return false;
        }
    }
}