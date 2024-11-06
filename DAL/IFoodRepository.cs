using FoodReggie_1.Models;

namespace FoodReggie_1.DAL;

public interface IFoodRepository{
    Task<IEnumerable<Food>> GetAll();
    Task<Food?> GetFoodById(int id);
    Task Create(Food food);
    Task Update(Food food);
    Task<bool> Delete(int id);
}