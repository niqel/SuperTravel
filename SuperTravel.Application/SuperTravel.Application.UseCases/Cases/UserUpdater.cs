using AutoMapper;
using SuperTravel.Application.UseCases.Profiles;
using SuperTravel.Core.DTOs;
using SuperTravel.Core.Entities;
using SuperTravel.Core.IRepositories;
using SuperTravel.Core.IUseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Application.UseCases.Cases
{
    public class UserUpdater : UseCasePattern, IUpdateUser
    {
        public UserUpdater(IUnityOfWork unityOfWork) : base(unityOfWork)
        {
        }

        public UserOutput? UpdateUser(UserInputUpdate userInputUpdate)
        {
            var entityUser = this.unityOfWork.UserRepository.GetById(userInputUpdate.UserIdToUpdate);

            if (entityUser != null)
            {
                UserProfileMapper.UpdateUserByUserInputUpdate(userInputUpdate, entityUser);
                this.unityOfWork.UserRepository.Update(entityUser);
                this.unityOfWork.SaveChange();
                return UserProfileMapper.GetUserOutputByUser(entityUser);
            }
            return null;    
        }
    }
}
