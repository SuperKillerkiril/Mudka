using UserTaskManager.Model;

namespace UserTaskManager.Client.Services;

public class MyUserTaskService
{
    public List<UserTask> UserTasks { get; set; } = new List<UserTask>();

    public List<UserTask> GetAllUserTasks(int quantity)
    {
        return UserTasks.Take(quantity).ToList();
    }

    public UserTask GetUserTaskById(string id)
    {
        var task = UserTasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return null!;
        }
        return task;
    }

    public void AddListUserTasks(List<UserTask> userTasks) //Создание нескольких
    {
        UserTasks.AddRange(userTasks);
    }

    public void AddUserTask(UserTask userTask) //Создание одной
    {
        UserTasks.Add(userTask);
    }

    public UserTask FindUserTaskById(string id) //Поиск по Id
    {
        var task = UserTasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return null!;
        }
        return task;
    }

    public void RemoveUserTaskById(string id) //Уаление по Id
    {
        var task = UserTasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            UserTasks.Remove(task);
        }
    }

    public void RedactUserTaskById( UserTask userTask) //Редактирование по Id
    {
        var index = UserTasks.FindIndex(t => t.Id == userTask.Id);
        UserTasks[index] = userTask;
    }
}