namespace TodoList.Models
{
    public class TodosList
    {
        private List<TodoTask> tasks;

        public TodosList()
        {
            tasks = new List<TodoTask>();
        }

        public void AddTask(TodoTask task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(TodoTask task)
        {
            tasks.Remove(task);
        }

        public List<TodoTask> GetTasks()
        {
            return tasks;
        }

        public void SetTasks(List<TodoTask> tasks)
        {
            this.tasks = tasks;
        }
    }
}