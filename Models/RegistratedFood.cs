namespace FoodReggie_1.Models;

public class RegistratedFood{
    public int RegistratedFoodId { get; set; }
    public int FoodId { get; set; }
    public Food Food { get; set; } = default!;
    public int RegistrationId { get; set; }
    public Registration Registration { get; set; } = default!;
}