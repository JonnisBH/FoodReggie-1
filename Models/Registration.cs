namespace FoodReggie_1.Models;

public class Registration{
    public int RegistrationId { get; set; }
    public String RegistrationDate { get; set; } = string.Empty;
    public int UserId { get; set; }
    public virtual User User { get; set; } = default!;
    public virtual List<RegistratedFood>? RegistratedFoods { get; set; }
}