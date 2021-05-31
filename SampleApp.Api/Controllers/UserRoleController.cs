using Microsoft.AspNetCore.Mvc;
using SampleApp.Service.Contracts.Services;
using SampleApp.Service.Services.UserRoles;
using System.Collections.Generic;

namespace SampleApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : Controller
    {
        private readonly IUserRoleService _userRoleService;

        public UserRoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        [HttpGet("all", Name = "GetAllUserRoles")]
        public ActionResult<List<UserRoleVm>> GetAllUserRoles()
        {
            var dtos = _userRoleService.GetAllUserRoles();

            return Ok(dtos);
        }
    }
}
