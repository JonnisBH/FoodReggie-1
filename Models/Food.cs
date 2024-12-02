using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodReggie_1.Models
{
    public class Food{
        public int FoodId { get; set; }

        //Input validation
        [RegularExpression(@"[a-zA-zæøåÆØÅ. \-]{2,20}", ErrorMessage = "The Name must be only letters and between 2 to 20 characters.")]
        public string Name { get; set; } = string.Empty;

        [RegularExpression(@"[a-zA-zæøåÆØÅ. \-]{2,20}", ErrorMessage = "The Food group must be only letters and between 2 to 20 characters.")]
        public string? FoodGroup { get; set; }

        [RegularExpression(@"[0-9.]{1,10}", ErrorMessage = "The Calories can only be numbers. Use '.' instead of ',' when the input is a decimal number")]
        public int Calories { get; set; }
        [RegularExpression(@"[0-9.]{1,10}", ErrorMessage = "The Calories can only be numbers. Use '.' instead of ',' when the input is a decimal number")]
        public double Protein { get; set; }

        [RegularExpression(@"[0-9.]{1,10}", ErrorMessage = "The Calories can only be numbers. Use '.' instead of ',' when the input is a decimal number")]
        public double Carbohydrates { get; set; }

        [RegularExpression(@"[0-9.]{1,10}", ErrorMessage = "The Calories can only be numbers. Use '.' instead of ',' when the input is a decimal number")]
        public double Fats { get; set; }
        public string? ImageURL { get; set; }
        public virtual List<RegistratedFood>? RegistratedFoods { get; set; } //Creates a relationship between Food and RegistratedFoods
    }
}