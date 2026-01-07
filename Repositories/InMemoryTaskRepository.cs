using TaskManagerApp.Interfaces;
using TaskManagerApp.Models;

namespace TaskManagerApp.Repositories
{
    public class InMemoryTaskRepository : ITaskRepository
    {
        private readonly List<TaskItem> _tasks = new List<TaskItem>();

        public void Add(TaskItem task)
        {
            _tasks.Add(task);
        }

        public IEnumerable<TaskItem> GetAll()
        {
            return _tasks;
        }

        public TaskItem? FindById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }
    }
}
