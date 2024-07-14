using TaskManagerApp.Entities;

namespace TaskManagerApp.Data
{
    public class TaskService
    {
        private static Entities.Task[] tasks = new Entities.Task[0];

        public int Size()
        {
            return tasks.Length;
        }

        public Entities.Task[] FindAll()
        {
            return tasks;
        }

        public Entities.Task? FindById(int taskId)
        {
            foreach (var task in tasks)
            {
                if (task.Id == taskId)
                    return task;
            }
            return null;
        }

        public Entities.Task AddTask(string description)
        {
            int id = TaskSequencer.NextTaskId();
            Entities.Task newTask = new Entities.Task(id, description);
            Array.Resize(ref tasks, tasks.Length + 1);
            tasks[tasks.Length - 1] = newTask;
            return newTask;
        }

        public void Clear()
        {
            tasks = new Entities.Task[0];
        }

        public Entities.Task[] FindByDoneStatus(bool doneStatus)
        {
            Entities.Task[] result = Array.FindAll(tasks, task => task.Done == doneStatus);
            return result;
        }

        public Entities.Task[] FindByAssignee(int userId)
        {
            Entities.Task[] result = Array.FindAll(tasks, task => task.Assignee != null && task.Assignee.Id == userId);
            return result;
        }

        public Entities.Task[] FindByAssignee(User assignee)
        {
            Entities.Task[] result = Array.FindAll(tasks, task => task.Assignee == assignee);
            return result;
        }

        public Entities.Task[] FindUnassignedTasks()
        {
            Entities.Task[] result = Array.FindAll(tasks, task => task.Assignee == null);
            return result;
        }

        public bool RemoveTask(int taskId)
        {
            int index = Array.FindIndex(tasks, task => task.Id == taskId);
            if (index == -1) return false;

            for (int i = index; i < tasks.Length - 1; i++)
            {
                tasks[i] = tasks[i + 1];
            }
            Array.Resize(ref tasks, tasks.Length - 1);
            return true;
        }
    }
}
