using Xunit;
using TaskManagerApp.Entities;

namespace TaskManagerApp.Tests
{
    public class TaskTests
    {
        [Fact]
        public void Task_Constructor_Should_Set_Properties()
        {
            
            int id = 1;
            string description = "Test task";

            
            TaskManagerApp.Entities.Task task = new TaskManagerApp.Entities.Task(id, description);

            
            Assert.Equal(id, task.Id);
            Assert.Equal(description, task.Description);
            Assert.False(task.Done);
            Assert.Null(task.Assignee);
        }

        [Fact]
        public void Description_Should_Throw_ArgumentNullException_If_Null()
        {
            
            int id = 1;

            
            Assert.Throws<ArgumentNullException>(() => new TaskManagerApp.Entities.Task(id, null!));
        }

        [Fact]
        public void Description_Should_Throw_ArgumentException_If_Empty()
        {
            
            int id = 1;

            
            Assert.Throws<ArgumentException>(() => new TaskManagerApp.Entities.Task(id, ""));
        }
    }
}
