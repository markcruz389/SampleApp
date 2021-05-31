using SampleApp.DataAccess.Entities;
using SampleApp.Service.Contracts.Repositories;

namespace SampleApp.Service.Repositories
{
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(SampleAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
