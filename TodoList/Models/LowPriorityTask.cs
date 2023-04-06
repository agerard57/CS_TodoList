namespace TodoList.Models
{
    public class LowPriorityTask : TodoTask
    {
        public LowPriorityTask(string description) : base(description, "Low")
        {
        }
    }
}