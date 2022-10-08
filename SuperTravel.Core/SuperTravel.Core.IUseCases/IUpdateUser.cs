using SuperTravel.Core.DTOs;
using SuperTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.IUseCases
{
    public interface IUpdateUser
    {
        UserOutput? UpdateUser(UserInputUpdate userInputUpdate);
    }
}
