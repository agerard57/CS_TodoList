namespace TodoList.Models
{
    public class TaskFactory
    {
        public static TodoTask CreateTask(string description, string priority)
        {
            TodoTask? task = null;

            switch (priority.ToLower())
            {
                case "l":
                    task = new LowPriorityTask(description);
                    break;

                case "m":
                    task = new MediumPriorityTask(description);
                    break;

                case "h":
                    task = new HighPriorityTask(description);
                    break;

                default:
                    Console.WriteLine("Invalid priority specified. Defaulting to low priority.");
                    task = new LowPriorityTask(description);
                    break;
            }

            return task;
        }
    }
}