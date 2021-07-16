using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Managers
{
    public class UserManager : IUser
    {
        IRepositoryWrapper _wrapper;
        public UserManager(IRepositoryWrapper wrapper)
        {
            _wrapper = wrapper;
        }
        public void AddUser(User user)
        {
            _wrapper.User.Create(user);
        }

        public void AddUsers(List<User> users)
        {
            foreach(User user in users)
            {
                _wrapper.User.Create(user);
            }
        }s

        public string GetUserPassword(string userName)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            return _wrapper.User.FindAll().ToList();
        }
    }
}
