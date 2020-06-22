using Microsoft.EntityFrameworkCore;

namespace skrr.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }
    }
}