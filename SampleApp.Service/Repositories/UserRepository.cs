using SampleApp.DataAccess.Entities;
using SampleApp.Service.Contracts.Repositories;
using System.Linq;

namespace SampleApp.Service.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(SampleAppDbContext dbContext) : base(dbContext)
        {
        }

        public bool checkIfUserExist(string email, string password) 
        {
            var isExistUser = _dbContext.Users.Where(x => x.Email == email && x.Password == password).Any();

            return isExistUser;
        }
    }
}
