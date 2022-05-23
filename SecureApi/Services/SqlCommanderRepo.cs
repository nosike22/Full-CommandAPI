using System.Collections.Generic;
using System;
using SecureApi.Models;
using System.Linq;
using SecureApi.Contexts;

namespace SecureApi.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly ApplicationDbContext _context;
        public SqlCommanderRepo(ApplicationDbContext context)
        {
           _context = context;
        }
        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {

        
           if(cmd == null)  
        {
            throw new NotImplementedException();
        }
        _context.Commands.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands() 
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int Id)
        {
            return _context.Commands.FirstOrDefault(P => P.Id ==Id);
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
           
        }
        
    }
}