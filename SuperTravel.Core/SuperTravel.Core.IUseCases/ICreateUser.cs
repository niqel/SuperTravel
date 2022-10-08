using SuperTravel.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.IUseCases
{
    public interface ICreateUser
    {
        UserOutput CreateUser(UserInputCreate userInputCreate);
    }
}
