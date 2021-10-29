using System.Collections.Generic;
using restapi.Dtos;
using restapi.Models;

namespace restapi.Data
{
    public interface Irestapirepo {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}