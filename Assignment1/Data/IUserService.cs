using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
        void SaveChanges();
        void Add(User user);
    }
}
