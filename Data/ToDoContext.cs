using Microsoft.EntityFrameworkCore;

namespace ToDo.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext (DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo.Models.Tasks> Tasks { get; set; }
    }
}
