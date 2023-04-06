using TodoList.Models;

namespace TodoList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TodoTask lowPriorityTask = new LowPriorityTask("Finish batch 1 of clickify");
            TodoTask mediumPriorityTask = new MediumPriorityTask("Escape the classroom");
            TodoTask highPriorityTask = new HighPriorityTask("Have a good grade");

            TodosList todosList = new();
            todosList.AddTask(lowPriorityTask);
            todosList.AddTask(mediumPriorityTask);
            todosList.AddTask(highPriorityTask);

            Console.WriteLine("--> Todo list:");
            List<TodoTask> tasks = todosList.GetTasks();
            foreach (TodoTask task in tasks)
            {
                Console.WriteLine(task.GetDetails());
            }

            lowPriorityTask.MarkAsCompleted();

            TodoTask reminderTask = new TaskReminder(highPriorityTask, "tomorrow at 10am");
            todosList.AddTask(reminderTask);

            Console.WriteLine("--> Updated todo list:");
            tasks = todosList.GetTasks();
            foreach (TodoTask task in tasks)
            {
                Console.WriteLine(task.GetDetails());
            }
        }
    }
}