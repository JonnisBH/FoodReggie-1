using Microsoft.EntityFrameworkCore;
using FoodReggie_1.Models;

namespace FoodReggie_1.DAL;

public class FoodRepository : IFoodRepository{
    private readonly FoodDbContext _db;

    public FoodRepository(FoodDbContext db){
        _db = db;
    }

    public async Task<IEnumerable<Food>> GetAll(){
        return await _db.Foods.ToListAsync();
    }

    public async Task<Food?> GetFoodById(int id){
        return await _db.Foods.FindAsync(id);
    }

    public async Task Create(Food food){
        _db.Foods.Add(food);
        await _db.SaveChangesAsync();
    }

    public async Task Update(Food food){
        _db.Foods.Update(food);
        await _db.SaveChangesAsync();
    }

    public async Task<bool> Delete(int id){
        var food = await _db.Foods.FindAsync(id);
        if(food == null){
            return false;
        }

        _db.Foods.Remove(food);
        await _db.SaveChangesAsync();
        return true;
    }
}