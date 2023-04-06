namespace TodoList.Models
{
    public abstract class TodoTask
    {
        private string description;
        private string priority;
        private bool isCompleted;

        public TodoTask(string description, string priority)
        {
            this.description = description;
            isCompleted = false;
            this.priority = priority;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void MarkAsCompleted()
        {
            isCompleted = true;
        }

        public string GetPriority()
        {
            return priority;
        }

        public void SetPriority(string priority)
        {
            this.priority = priority;
        }

        public virtual string GetDetails()
        {
            string details = $"Description: {description}\n" +
                             $"Priority: {priority}\n" +
                             $"Status: {(isCompleted ? "Complete" : "Incomplete")}\n";
            return details;
        }
    }
}