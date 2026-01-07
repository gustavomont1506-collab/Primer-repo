using TaskManagerApp.Models;

namespace TaskManagerApp.Interfaces
{
    public interface ITaskRepository
    {
        void Add(TaskItem task);
        IEnumerable<TaskItem> GetAll();
        TaskItem? FindById(int id);
    }
}
