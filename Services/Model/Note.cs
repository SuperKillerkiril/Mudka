using System.ComponentModel.DataAnnotations;
using Services.Enum;

namespace Services.Model;

public class Note
{
    [Key] public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Name { get; set; }
    public int Priority { get; set; }
    public string? Description { get; set; }
    public Color Color { get; set; }
}