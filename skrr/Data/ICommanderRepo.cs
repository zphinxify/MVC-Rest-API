using System.Collections.Generic;
using skrr.Models;

namespace skrr.Data 
{
    public interface ICommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
    }
}