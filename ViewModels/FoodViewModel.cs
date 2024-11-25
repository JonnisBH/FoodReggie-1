using FoodReggie_1.Models;

namespace FoodReggie_1.ViewModels
{
    public class FoodViewModel{
        public IEnumerable<Food> Foods;
        public string? CurrentViewName;

        public FoodViewModel(IEnumerable<Food> foods, string? currentViewName){
            Foods = foods;
            CurrentViewName = currentViewName;
        }
    }
}