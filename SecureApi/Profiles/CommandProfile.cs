
using AutoMapper;
using SecureApi.Dtos;
using SecureApi.Models;

namespace SecureApi.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
          //Source-> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
         
        }

    }
    
}


