using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service.Services.Users
{
    enum Role {
        SuperAdmin,
        Admin,
        User
    }

    public class UserVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserRoleId { get; set; }
        public string RoleName 
        {
            get 
            {
                return GetUserRole();
            }
        }

        private string GetUserRole()
        {
            var roleName = string.Empty;

            switch (UserRoleId) 
            {
                case 1:
                    roleName = Role.SuperAdmin.ToString();
                    break;
                case 2:
                    roleName = Role.Admin.ToString();
                    break;
                default:
                    roleName = Role.User.ToString();
                    break;
            }

            return roleName;
        }
    }
}
