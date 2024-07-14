using Xunit;
using TaskManagerApp.Entities;

namespace TaskManagerApp.Tests
{
    public class UserTests
    {
        [Fact]
        public void User_Constructor_Should_Set_Properties()
        {
            
            int id = 1;
            string firstName = "Alice";
            string lastName = "Smith";

            
            User user = new User(id, firstName, lastName);

            
            Assert.Equal(id, user.Id);
            Assert.Equal(firstName, user.FirstName);
            Assert.Equal(lastName, user.LastName);
        }

        [Fact]
        public void FirstName_Should_Throw_ArgumentNullException_If_Null()
        {
            
            int id = 1;

            
            Assert.Throws<ArgumentNullException>(() => new User(id, null!, "Smith"));
        }

        [Fact]
        public void FirstName_Should_Throw_ArgumentException_If_Empty()
        {
            
            int id = 1;

            
            Assert.Throws<ArgumentException>(() => new User(id, "", "Smith"));
        }

        [Fact]
        public void LastName_Should_Throw_ArgumentNullException_If_Null()
        {
            
            int id = 1;

            
            Assert.Throws<ArgumentNullException>(() => new User(id, "Alice", null!));
        }

        [Fact]
        public void LastName_Should_Throw_ArgumentException_If_Empty()
        {
            
            int id = 1;

            
            Assert.Throws<ArgumentException>(() => new User(id, "Alice", ""));
        }
    }
}
