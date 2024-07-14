namespace TaskManagerApp.Data
{
    public class TaskSequencer
    {
        private static int taskId;

        public static int NextTaskId()
        {
            return ++taskId;
        }

        public static void Reset()
        {
            taskId = 0;
        }
    }
}

