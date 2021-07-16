using Contracts;
using Entities.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Managers
{
    public class WishListManager : IWishListManager
    {
        IConfiguration config;
        public List<Offer> GetWishList()
        {
            throw new NotImplementedException();
        }
    }
}
