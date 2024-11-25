namespace FoodReggie_1.Models;

public class RegistratedFood{
    public int RegistratedFoodId { get; set; }
    public int FoodId { get; set; }
    public virtual Food Food { get; set; } = default!;
    public int RegistrationId { get; set; }
    public virtual Registration Registration { get; set; } = default!;
}