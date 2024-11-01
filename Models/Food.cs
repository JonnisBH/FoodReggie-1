using System;
namespace FoodReggie_1.Models
{
    public class Food{
        public int FoodId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
    }
}