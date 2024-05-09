namespace SocialFeed.Models;

public class GlobalState
{
    public int UserId { get; set; }
    
    public string Name { get; set; } = null!;

    public int? RoleId { get; set; }

    public string? RoleName { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;
}