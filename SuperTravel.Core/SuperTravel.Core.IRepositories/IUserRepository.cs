using SuperTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.IRepositories
{
    public interface IUserRepository
    {
        User Add(User user);
        User Update(User user);
        User? GetByNicknamePassword(string nickname, string password);
        bool GetByNickname(string nickname);
        User? GetById(int id);
    }
}
