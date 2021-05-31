using AutoMapper;
using SampleApp.DataAccess.Entities;
using SampleApp.Service.Contracts.Repositories;
using SampleApp.Service.Contracts.Services;
using System.Collections.Generic;

namespace SampleApp.Service.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void CreateUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _userRepository.Add(user);
        }

        public IReadOnlyList<UserVm> GetAllUsers()
        {
            var users = _userRepository.ListAll();
            var usersVm = _mapper.Map<List<UserVm>>(users);

            return usersVm;
        }

        public UserVm GetById(int id)
        {
            var user = _userRepository.GetById(id);
            var userVm = _mapper.Map<UserVm>(user);

            return userVm;
        }

        public void UpdateUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }

        public bool UserLogin(string email, string password) 
        {
            var userExists = _userRepository.checkIfUserExist(email, password);

            return userExists;
        }
    }

}
