using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    // a class immplement the interface
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands= new List<Command>
            {
                new Command{Id=0, HowTo="Boild an egg", Line="Boild water", Platform="Kettle and Plan"},
                new Command{Id=1, HowTo="Boild an egg", Line="Boild water", Platform="Kettle and Plan"},
                new Command{Id=2, HowTo="Boild an egg", Line="Boild water", Platform="Kettle and Plan"},
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boild an egg", Line="Boild water", Platform="Kettle and Plan"};
        }
    }
}
