using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WishList.Managers;

namespace WishList.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CompanyController: ControllerBase
    {
        private IRepositoryWrapper _wrapper;
        private ILoggerManager _logger;
        private IUser _userManager;
        public CompanyController(IRepositoryWrapper wrapper, ILoggerManager logger,IUser userManager)
        {
            _wrapper = wrapper;
            _logger = logger;
            _userManager = userManager;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]Company record)
        {
            try
            {
                _wrapper.Company.Create(record);
                _userManager.AddUser(new User()
                {
                    CompanyName = record.Name,
                    Email = record.Email,
                    IsAdmin = true,
                    DateCreated = DateTime.Now,
                    Password = record.UserPassword
                });
                await _wrapper.SaveAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.StackTrace);
                return Content(e.Message) ;
            }
            return Ok();
        }
    }
}
