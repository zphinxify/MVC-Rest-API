using Microsoft.EntityFrameworkCore;
using skrr.Models;
namespace skrr.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands {get; set; }
    }
}