namespace MealMatchAPI.Models.DTOs;

public class UserUpdateRequest
{
    public string? Name { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public List<string>? Favorites { get; set; }
    public List<string>? ProfileSettings { get; set; }
    public List<string>? DietLabels { get; set; }
    public List<string>? HealthLabels { get; set; }
}