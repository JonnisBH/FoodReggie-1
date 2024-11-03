using System;
namespace FoodReggie_1.Models
{
    public class Food{
        public int FoodId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }
        public string? ImageURL { get; set; }
    }
}