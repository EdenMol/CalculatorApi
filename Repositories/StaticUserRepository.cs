using CalculatorApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CalculatorApi.Repositories
{
    public class StaticUserRepository : IUserRepository
    {
        //TODO list of users should be fetch from DB
        private List<User> Users = new List<User>()
        {
            new User()
            {
                UserName = "LionKing1",
                Password = "LionKing1",
                Roles = new List<string>{"reader","writer"},
                Id = Guid.NewGuid(),
                EmailAddress="LionKing1@gmail.com",
                FirstName = "Lion1",
                LastName= "King1"
            },
            new User()
            {
                UserName = "LionKing2",
                Password = "LionKing2",
                Roles = new List<string>{"reader"},
                Id = Guid.NewGuid(),
                EmailAddress="LionKing2@gmail.com",
                FirstName = "Lion2",
                LastName= "King2"
            }
        };

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            var user = Users.Find(u => u.UserName.Equals(username, System.StringComparison.InvariantCultureIgnoreCase) &&
            u.Password == password);

            return user;
        }
    }
}
