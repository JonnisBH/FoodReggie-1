using FoodReggie_1.Models;

namespace FoodReggie_1.ViewModels
{
    public class FoodViewModel{
        public IEnumerable<Food> Foods;
        public string? CurrentViewName;

        //This contstructor initializes the viewmodel with the food items and the view name
        public FoodViewModel(IEnumerable<Food> foods, string? currentViewName){
            Foods = foods;
            CurrentViewName = currentViewName;
        }
    }
}