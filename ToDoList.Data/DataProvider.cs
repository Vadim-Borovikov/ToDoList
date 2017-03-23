using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Data
{
    public static class DataProvider
    {
        private static readonly ApplicationDbContext DB = new ApplicationDbContext();

        public static List<Task> GetSubtasks(Task parent) => DB.Tasks.Where(t => t.Parent == parent).ToList();
    }
}
