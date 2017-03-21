using System.Collections.Generic;
using ToDoList.Data.Enums;
using ToDoList.Data.Tags;

namespace ToDoList.Data
{
    public class Task
    {
        public int Id { get; set; }

        public string Summary { get; set; }
        public string Description { get; set; }

        public bool? Urgent { get; set; }
        public bool? Important { get; set; }
        public Scope? Scope { get; set; }
        public Context Context { get; set; }
        public byte? Priority { get; set; }

        public Status Status { get; set; } = Status.Inbox;

        public List<Tag> Tags { get; set; }
        public List<Task> Subtasks { get; set; }
    }
}
