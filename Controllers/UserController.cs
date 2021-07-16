using Contracts;
using Entities;
using Entities.Models;
using Entities.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IAuthService _authService;
        private ICrypto _crypto;
        private IRepositoryWrapper _wrapper;
        public UserController( IAuthService authService, ICrypto crypto, IRepositoryWrapper wrapper)
        {
            _authService = authService;
            _crypto = crypto;
            _wrapper = wrapper;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            IActionResult response = Unauthorized();
            if(_authService.Authenticate(user) != null)
            {
                string token = _authService.GenerateToken(user);
               
                return Ok(new { token = token });
            }
            return response;
        }
        [HttpPost("register")]
        public IActionResult Register([FromBody] Company company)
        {
            _wrapper.Company.Create(new Company() 
            { 
                ApiKey = company.ApiKey,
                ApiUrl = company.ApiUrl,
                Email = company.Email,
                Name = company.Name
            });
            return Ok();
        }
    }
}
