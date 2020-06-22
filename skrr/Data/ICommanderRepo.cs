using System.Collections.Generic;
using skrr.Models;

namespace skrr.Data 
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id);
    }
}