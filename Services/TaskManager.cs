using TaskManagerApp.Interfaces;
using TaskManagerApp.Models;

namespace TaskManagerApp.Services
{
    public class TaskManager
    {
        private readonly ITaskRepository _repository;

        // Dependency Inversion (D in SOLID)
        public TaskManager(ITaskRepository repository)
        {
            _repository = repository;
        }

        public void CreateTask(int id, string title)
        {
            var task = new TaskItem { Id = id, Title = title };
            _repository.Add(task);
        }

        public IEnumerable<TaskItem> ListTasks()
        {
            return _repository.GetAll();
        }
    }
}
