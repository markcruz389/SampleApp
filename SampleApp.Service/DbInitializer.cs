using SampleApp.DataAccess.Entities;
using System.Linq;

namespace SampleApp.Service
{
    public static class DbInitializer
    {
        public static void Initialize(SampleAppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.UserRoles.Any())
            {
                return;
            }

            var userRoles = new UserRole[]
            {
                new UserRole{ Role = "superAdmin" },
                new UserRole{ Role = "admin" },
                new UserRole{ Role = "user"}
            };

            foreach (UserRole role in userRoles)
            {
                context.Add(role);
            }

            var superAdmin = context.Users.Where(x => x.UserRoleId == 1).Any();
            if (!superAdmin)
            {
                var superAdminUser = new User 
                { 
                    FirstName = "super",
                    LastName = "admin",
                    Email = "superAdmin@sampleApp.com",
                    Password = "superadmin",
                    UserRoleId = 1
                };

                context.Add(superAdminUser);
            }

            context.SaveChanges();
        }
    }
}
