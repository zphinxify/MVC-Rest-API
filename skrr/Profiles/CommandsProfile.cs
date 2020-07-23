using AutoMapper;
using skrr.Dtos;
using skrr.Models;

namespace skrr.Profiles
{
    public class CommandsProfile : Profile
    { 
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>();
            
            //Target -> Source
            CreateMap<CommandCreateDto, Command>();
        }
    }
}