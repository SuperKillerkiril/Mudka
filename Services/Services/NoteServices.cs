using Services.Model;

namespace Services.Services;

public class NoteService
{
    public List<Note> UserNotes { get; set; } = new List<Note>();

    public List<Note> GetAllUserTasks(int quantity)
    {
        return UserNotes.Take(quantity).ToList();
    }

    public Note GetUserNoteById(string id)
    {
        var task = UserNotes.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return null!;
        }
        return task;
    }

    public void AddListUserTasks(List<Note> userNotes) //Создание нескольких
    {
        UserNotes.AddRange(userNotes);
    }

    public void AddUserNote(Note note) //Создание одной
    {
        UserNotes.Add(note);
    }

    public Note FindUserTaskById(string id) //Поиск по Id
    {
        var task = UserNotes.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return null!;
        }
        return task;
    }

    public void RemoveUserTaskById(string id) //Уаление по Id
    {
        var task = UserNotes.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            UserNotes.Remove(task);
        }
    }

    public void RedactUserTaskById( Note note) //Редактирование по Id
    {
        var index = UserNotes.FindIndex(t => t.Id == note.Id);
        UserNotes[index] = note;
    }
}