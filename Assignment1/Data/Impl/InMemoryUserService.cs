using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment1.Models;
using Assignment1.Persistence;

namespace Assignment1.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private readonly FileContext fileContext;

        public InMemoryUserService()
        {
            fileContext = new FileContext();
        }

        public User ValidateUser(string username, string password)
        {
            User first = fileContext.Users.FirstOrDefault(x => x.Username.Equals(username));
            if (first == null) throw new Exception("User not found");
            if (!first.Password.Equals(password)) throw new Exception("Invalid password");
            return first;
        }

        public void SaveChanges()
        {
            fileContext.SaveChanges();
        }

        public void Add(User user)
        {
            user.IsRegistered = true;
            fileContext.Users.Add(user);
            SaveChanges();
        }
    }
}
