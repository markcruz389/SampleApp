using Microsoft.EntityFrameworkCore;
using SampleApp.DataAccess.Entities;

namespace SampleApp.DataAccess
{
    public class SampleAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
