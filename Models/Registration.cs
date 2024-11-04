namespace FoodReggie_1.Models;

public class Registration{
    public int RegistrationId { get; set; }
    public String RegistrationDate { get; set; } = string.Empty;
    public int UserId { get; set; }
    public User User { get; set; } = default!;
    public List<RegistratedFood>? RegistratedFoods { get; set; }
}