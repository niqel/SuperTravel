using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.DTOs
{
    public record UserInputUpdate(int UserIdToUpdate, bool IsActive, UserInputCreate updatedUser);
}
