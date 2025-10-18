using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MudBlazor;

namespace UserTaskManager.Model;

public class UserTask
{
    [Key] public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Name { get; set; }
    public int? Priority { get; set; }
    public string? Description { get; set; }
    public Color? TaskColor { get; set; }
}