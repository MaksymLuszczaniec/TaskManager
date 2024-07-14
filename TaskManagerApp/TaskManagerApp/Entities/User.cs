using System;

namespace TaskManagerApp.Entities
{
    public class User
    {
        public int Id { get; }
        private string? firstName;
        private string? lastName;

        public User(int id, string? firstName, string? lastName)
        {
            Id = id;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName), "First name is required");
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName), "Last name must be provided");
        }

        public string? FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First name is required");
                firstName = value;
            }
        }

        public string? LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name must be provided");
                lastName = value;
            }
        }
    }
}
