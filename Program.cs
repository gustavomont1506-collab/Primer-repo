using TaskManagerApp.Interfaces;
using TaskManagerApp.Repositories;
using TaskManagerApp.Services;

Console.WriteLine("--- SOLID Task Manager (C#) ---");

// Inyección de dependencias manual
ITaskRepository repository = new InMemoryTaskRepository();
var taskManager = new TaskManager(repository);

taskManager.CreateTask(1, "Aprender SOLID en C#");
taskManager.CreateTask(2, "Configurar Visual Studio");
taskManager.CreateTask(3, "Subir repositorio a GitHub");

var tasks = taskManager.ListTasks();

foreach (var task in tasks)
{
    string status = task.IsCompleted ? "[X]" : "[ ]";
    Console.WriteLine($"{status} {task.Id}: {task.Title}");
}
