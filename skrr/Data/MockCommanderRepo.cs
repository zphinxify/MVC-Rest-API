using System.Collections.Generic;
using skrr.Models;

// This repo could be deleted, but it's nice to have if
// needed in the future
namespace skrr.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> AppCommands => throw new System.NotImplementedException();

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                  new Command {Id=0, HowTo="Do the dishes", Line="Cleaning", Platform="Life"},
                  new Command {Id=1, HowTo="Walk the dog", Line="Excersice", Platform="Health"},
                  new Command {Id=2, HowTo="Do my homework", Line="Studies", Platform="Future me"}

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id=0, HowTo="Do Something", Line="Do stuff", Platform="Living"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}