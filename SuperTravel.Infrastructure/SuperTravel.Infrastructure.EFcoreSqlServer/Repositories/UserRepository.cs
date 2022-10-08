using Microsoft.EntityFrameworkCore;
using SuperTravel.Core.Entities;
using SuperTravel.Core.IRepositories;
using SuperTravel.Infrastructure.EFcoreSqlServer.DataConfiguration;

namespace SuperTravel.Infrastructure.EFcoreSqlServer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private SuperTravelDbContext superTravelDbContext;

        public UserRepository(SuperTravelDbContext superTravelDbContext)
        {
            this.superTravelDbContext = superTravelDbContext;
        }

        public User Add(User user)
        {
            this.superTravelDbContext.Users.Add(user);
            return user;
        }

        public User? GetById(int id)
        {
            return this.superTravelDbContext.Users.Where(x => x.UserId == id).FirstOrDefault();
        }

        public bool GetByNickname(string nickname)
        {
            bool exist = this.superTravelDbContext.Users.Any(u => u.Nickname == nickname);
            return exist;
        }

        public User? GetByNicknamePassword(string nickname, string password)
        {
            User? user = this.superTravelDbContext.Users.Where(u => u.Nickname == nickname && u.Password == password).FirstOrDefault();
            return user;
        }

        public User Update(User user)
        {
            User newUser = this.superTravelDbContext.Users.Where(u => u.UserId == user.UserId).First();
            newUser.Name = user.Name;
            newUser.Nickname = user.Nickname;
            this.superTravelDbContext.Users.Update(newUser);
            return newUser;
        }
    }
}