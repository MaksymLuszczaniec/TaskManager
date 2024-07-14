namespace TaskManagerApp.Data
{
    public class UserSequencer
    {
        private static int userId;

        public static int NextUserId()
        {
            return ++userId;
        }

        public static void Reset()
        {
            userId = 0;
        }
    }
}
