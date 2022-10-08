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
    public class Logger : UseCasePattern, ILogIn
    {
        public Logger(IUnityOfWork unityOfWork) : base(unityOfWork)
        {
        }

        public UserOutput LogIn(string nickname, string password)
        {
            return UserProfileMapper
                .GetUserOutputByUser(base.unityOfWork.UserRepository.GetByNicknamePassword(nickname, password));
        }
    }
}
