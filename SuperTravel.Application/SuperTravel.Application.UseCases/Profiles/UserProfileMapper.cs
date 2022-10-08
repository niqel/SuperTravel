using SuperTravel.Core.DTOs;
using SuperTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Application.UseCases.Profiles
{
    public static class UserProfileMapper
    {
        public static User GetUserByUserInputCreate(UserInputCreate userInputCreate)
        {
            User user = new User()
            {
                Name = userInputCreate.Name,
                Nickname = userInputCreate.Nickname,
                Password = userInputCreate.Password,
                CreatedBy = -1,
                CreatedAt = DateTime.Now,
                UpdatedBy = -1,
                UpdatedAt = DateTime.Now,
                IsActive = true
            };
            return user;
        }

        public static void UpdateUserByUserInputUpdate(UserInputUpdate userInputUpdate, User user)
        {
            if (user != null)
            {
                user.Name = userInputUpdate.updatedUser.Name;
                user.Nickname = userInputUpdate.updatedUser.Nickname;
                user.Password = userInputUpdate.updatedUser.Password;
                user.UpdatedBy = userInputUpdate.UserIdToUpdate;
                user.UpdatedAt = DateTime.Now;
                user.IsActive = userInputUpdate.IsActive;
            }   
        }

        public static UserOutput? GetUserOutputByUser(User user)
        {
            if (user != null)
            {
                UserOutput userOutput = new UserOutput(user.UserId, user.Name, user.Nickname);
                return userOutput;
            }
            return null;
        }
    }
}
