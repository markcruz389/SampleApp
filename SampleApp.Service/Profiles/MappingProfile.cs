using AutoMapper;
using SampleApp.DataAccess.Entities;
using SampleApp.Service.Services.UserRoles;
using SampleApp.Service.Services.Users;

namespace SampleApp.Service.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserVm>();
            CreateMap<UserDto, User>();
            CreateMap<UserRole, UserRoleVm>();
        }
    }
}
