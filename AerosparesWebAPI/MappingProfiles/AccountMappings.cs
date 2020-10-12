using AutoMapper;
using AerosparesWebAPI.Models;
using AerosparesWebAPI.Entities;

namespace AerosparesWebAPI.MappingProfiles
{
    public class AccountMappings : Profile
    {
        public AccountMappings()
        {
            CreateMap<AccountEntity, AccountDto>().ReverseMap();
            CreateMap<AccountEntity, AccountUpdateDto>().ReverseMap();
            CreateMap<AccountEntity, AccountCreateDto>().ReverseMap(); 
            CreateMap<AccountTypeEntity, AccountTypeDto>().ReverseMap();
        }
    }
}
