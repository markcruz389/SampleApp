using SampleApp.Service.Services.Users;
using System.Collections.Generic;

namespace SampleApp.Service.Contracts.Services
{
    public interface IUserService
    {
        void CreateUser(UserDto userDto);
        IReadOnlyList<UserVm> GetAllUsers();
        UserVm GetById(int id);
        void UpdateUser(UserDto userDto);
        void DeleteUser(int id);
        bool UserLogin(string email, string password);
    }
}
