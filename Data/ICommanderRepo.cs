using Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commands.Data
{
    public interface ICommanderRepo
    {
        public bool SaveChanges();
        public IEnumerable<Command> GetAllCommands();
        public Command GetCommandById(int id);
        public void CreateCommand(Command command);
        void UpdateCommand(Command command);
        void DeleteCommand(Command command);
    }
}
