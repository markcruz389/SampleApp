using Microsoft.EntityFrameworkCore;
using SampleApp.Data.Entities;

namespace SampleApp.Data
{
    public class SampleAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
