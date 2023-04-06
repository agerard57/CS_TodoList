using System;

namespace TodoList.Models
{
    public class HighPriorityTask : TodoTask
    {
        public HighPriorityTask(string description) : base(description, "High")
        {
        }
    }
}