using SampleApp.DataAccess.Entities;

namespace SampleApp.Service.Contracts.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        bool checkIfUserExist(string email, string password);
    }
}
