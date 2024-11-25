namespace FoodReggie_1.Models;

public class User{
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public virtual List<Registration>? Registrations { get; set; }
}