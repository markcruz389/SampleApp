using AutoMapper;
using SampleApp.Service.Contracts.Repositories;
using SampleApp.Service.Contracts.Services;
using System.Collections.Generic;

namespace SampleApp.Service.Services.UserRoles
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IMapper _mapper;

        public UserRoleService(IUserRoleRepository userRoleRepository, IMapper mapper)
        {
            _userRoleRepository = userRoleRepository;
            _mapper = mapper;
        }

        public IReadOnlyList<UserRoleVm> GetAllUserRoles()
        {
            var userRoles = _userRoleRepository.ListAll();
            var userRoleVms = _mapper.Map<List<UserRoleVm>>(userRoles);

            return userRoleVms;
        }
    }
}
