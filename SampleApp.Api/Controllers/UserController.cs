using Microsoft.AspNetCore.Mvc;
using SampleApp.Service.Contracts.Services;
using SampleApp.Service.Services.Users;
using System.Collections.Generic;

namespace SampleApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost(Name = "AddUser")]
        public ActionResult CreateUser([FromBody] UserDto user)
        {
            _userService.CreateUser(user);

            return Ok();
        }

        [HttpGet("all", Name = "GetAllUsers")]
        public ActionResult<List<UserVm>> GetAllUsers()
        {
            var dtos = _userService.GetAllUsers();

            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult<List<UserVm>> GetUserById(int id)
        {
            var result = _userService.GetById(id);

            return Ok(result);
        }

        [HttpPut("update", Name = "UpdateUser")]
        public ActionResult UpdateUser([FromBody] UserDto user)
        {
            _userService.UpdateUser(user);

            return Ok();
        }

        [HttpDelete("delete/{id}", Name = "DeleteUser")]
        public ActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);

            return Ok();
        }

        [HttpPost("login", Name = "Login")]
        public ActionResult<bool> UserLogin([FromBody] LoginDto loginDto)
        {
            var isExists = _userService.UserLogin(loginDto.Email, loginDto.Password);

            return Ok(isExists);
        }
    }
}
