using Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commands.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Cook", Line = "Make food", Platform = "Kitchen" },
                new Command { Id = 0, HowTo = "Cut bread", Line = "Use knife", Platform = "Knife" },
                new Command { Id = 0, HowTo = "Make tea", Line = "Better be good", Platform = "Kettle" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Cook", Line = "Make food", Platform = "Kitchen" };
        }

        void ICommanderRepo.CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.DeleteCommand(Command command)
        {
            throw new NotImplementedException();
        }

        bool ICommanderRepo.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
