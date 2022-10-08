using AutoMapper;
using SuperTravel.Application.UseCases.Profiles;
using SuperTravel.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Application.UseCases.Cases
{
    public class UseCasePattern
    {
        protected IUnityOfWork unityOfWork;
        //protected ProfileMapper profileMapper;

        public UseCasePattern(IUnityOfWork unityOfWork)
        {
            this.unityOfWork = unityOfWork;
            //this.profileMapper = new ProfileMapper();
        }
    }
}
