
// using System.Collections.Generic;
// using SecureApi.Data;
// using SecureApi.Models;

// namespace SecureApi.Services
// {
//     public class MockCommanderRepo : ICommanderRepo
//     {
//         public void CreateCommand(Command cmd)
//         {
//             throw new System.NotImplementedException();
//         }

//         public void DeleteCommand(Command cmd)
//         {
//             throw new System.NotImplementedException();
//         }

//         public IEnumerable<Command> GetAllCommands()
//         {
//             var commands = new List<Command>
//             {
//                 new Command {Id = 0, HowTo= "How to run a program", Line= "dotnet run", Platform= ".Net Core"},
//                 new Command {Id = 1, HowTo="Check for errors" , Line= "dotnet build", Platform=".Net Core"},
//                 new Command {Id = 2, HowTo="Clear terminal screen" , Line= "cls", Platform= ".Net Core"},

//             };
//             return commands;
//         }

//         public Command GetCommandById(int id)
//         {
//             return new Command {Id = 0, HowTo= "How to run a program", Line= "dotnet run", Platform= ".Net Core"};

//         }
//           public bool SaveChanges()
//         {
//             throw new System.NotImplementedException();
//         }

//         public void UpdateCommand(Command cmd)
//         {
//             throw new System.NotImplementedException();
//         }
        
//     }
// }
