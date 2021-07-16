using AuthenticationService;
using Contracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Controllers
{
    [Route("api/wishList")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private IRepositoryWrapper _repositoryWrapper;
        private ILogger<RequestResponse> _logger;

        public WishListController(IRepositoryWrapper repositoryWrapper,ILogger<RequestResponse> logger)
        {
            _repositoryWrapper = repositoryWrapper;
            _logger = logger;
        }

        [HttpGet, Authorize]
        public List<string> GetOffers()
        {
            _logger.LogInformation("testOffer",new RequestResponse() { request = "test", response = "test" });
            List<string> offers = new List<string>();
            offers.Add("1");
            return offers;
        }
    }
}
