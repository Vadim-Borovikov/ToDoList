using System.Collections.Generic;
using System.Linq;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.BusinessLogic
{
    public static class DataManager
    {
        public static List<TaskInfo> GetSubtasks(Task parent = null)
        {
            return DataProvider.GetSubtasks(parent).Select(CreateTaskInfo).ToList();
        }

        private static TaskInfo CreateTaskInfo(Task task)
        {
            return new TaskInfo
            {
                Task = task,
                SubtaskAmount = task.Subtasks.Count
            };
        }
    }
}
