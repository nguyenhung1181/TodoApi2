﻿using Microsoft.EntityFrameworkCore;

namespace TodoApi2.Model
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
