using System.Collections.Generic;
using skrr.Models;

namespace skrr.Data 
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);
    }
}