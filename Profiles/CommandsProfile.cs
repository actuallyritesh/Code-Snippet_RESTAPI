using AutoMapper;
using restapi.Dtos;
using restapi.Models;

namespace restapi.Profiiles
{
    public class CommandsProfile : Profile
    {   
        public CommandsProfile()
        {   
            CreateMap<Command,CommandReadDto>();
            CreateMap<CommandCreateDto,Command>();
            CreateMap<CommandUpdateeDto,Command>();
        }
    }
}