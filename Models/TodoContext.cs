using Microsoft.EntityFrameworkCore;

namespace dotnet_keyvault_demo.Models 
{
    public class TodoContext : DbContext 
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        { 
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}