using System.Data.Entity;

namespace ToDoList.Data
{
    // public class DbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    public class DbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var task1 = new Task { Summary = "Task1" };
            var task2 = new Task { Summary = "Task2" };
            var subtask = new Task
            {
                Summary = "Subtask",
                Parent = task2
            };

            task2.Subtasks.Add(subtask);

            context.Tasks.Add(task1);
            context.Tasks.Add(task2);
            context.SaveChanges();
        }
    }
}
