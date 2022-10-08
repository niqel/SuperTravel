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
using System.Xml.Linq;

namespace SuperTravel.Application.UseCases.Cases
{
    public class UserCreator : UseCasePattern, ICreateUser
    {
        public UserCreator(IUnityOfWork unityOfWork) : base(unityOfWork)
        {
        }

        public UserOutput CreateUser(UserInputCreate userInputCreate)
        {
            User user = UserProfileMapper.GetUserByUserInputCreate(userInputCreate);
            this.unityOfWork.UserRepository.Add(user);
            this.unityOfWork.SaveChange();
            return UserProfileMapper.GetUserOutputByUser(user);
        }
    }
}
