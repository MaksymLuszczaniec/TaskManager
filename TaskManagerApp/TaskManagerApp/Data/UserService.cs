using TaskManagerApp.Entities;

namespace TaskManagerApp.Data
{
    public class UserService
    {
        private static User[] users = new User[0];

        public int Size()
        {
            return users.Length;
        }

        public User[] FindAll()
        {
            return users;
        }

        public User? FindById(int userId) 
        {
            foreach (var user in users)
            {
                if (user.Id == userId)
                    return user;
            }
            return null; 
        }

        public User AddUser(string firstName, string lastName)
        {
            int id = UserSequencer.NextUserId();
            User newUser = new User(id, firstName, lastName);
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = newUser;
            return newUser;
        }

        public void Clear()
        {
            users = new User[0];
        }

        public bool RemoveUser(int userId)
        {
            int index = Array.FindIndex(users, user => user.Id == userId);
            if (index == -1) return false;

            for (int i = index; i < users.Length - 1; i++)
            {
                users[i] = users[i + 1];
            }
            Array.Resize(ref users, users.Length - 1);
            return true;
        }
    }
}
