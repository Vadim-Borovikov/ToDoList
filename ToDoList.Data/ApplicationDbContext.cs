﻿using System.Data.Entity;
using ToDoList.Data.Tags;

namespace ToDoList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Context> Contexts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
