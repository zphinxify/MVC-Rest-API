using AutoMapper;
using skrr.Dtos;
using skrr.Models;

namespace skrr.Profiles
{
    public class CommandsProfile : Profile
    { 
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}