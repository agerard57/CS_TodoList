namespace TodoList.Models
{
    public class TaskReminder : TodoTask
    {
        private TodoTask task;
        private string reminderTime;

        public TaskReminder(TodoTask task, string reminderTime) : base(task.GetDescription(), task.GetPriority())
        {
            this.task = task;
            this.reminderTime = reminderTime;
        }

        public void SetReminderTime(string time)
        {
            reminderTime = time;
        }

        public string GetReminderTime()
        {
            return reminderTime;
        }

        public override string GetDetails()
        {
            string details = task.GetDetails() +
                             $"Reminder Time: {reminderTime}\n";
            return details;
        }
    }
}