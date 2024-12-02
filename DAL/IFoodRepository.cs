using FoodReggie_1.Models;

namespace FoodReggie_1.DAL;

//Interface that defines the CRUD operations for the food items.
public interface IFoodRepository{
    Task<IEnumerable<Food>?> GetAll();
    Task<Food?> GetFoodById(int id);
    Task<bool> Create(Food food);
    Task<bool> Update(Food food);
    Task<bool> Delete(int id);
}