using System.ComponentModel.DataAnnotations;
using Color = UserTaskManager.Enum.Color;

namespace UserTaskManager.Model;

public class UserTask
{
    [Key] public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Name { get; set; }
    public int Priority { get; set; }
    public string? Description { get; set; }
    public Color TaskColor { get; set; }
}