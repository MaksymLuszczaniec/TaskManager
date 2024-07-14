using System;

namespace TaskManagerApp.Entities
{
    public class Task
    {
        public int Id { get; }
        private string description = string.Empty; 
        public bool Done { get; set; }
        public User? Assignee { get; set; }

        public Task(int id, string description)
        {
            Id = id;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Done = false;
            Assignee = null;
        }

        public string Description
        {
            get => description;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Description must be provided");
                description = value;
            }
        }
    }
}
