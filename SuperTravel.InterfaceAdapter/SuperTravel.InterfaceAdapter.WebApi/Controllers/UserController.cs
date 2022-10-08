using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperTravel.Core.DTOs;
using SuperTravel.Core.IUseCases;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SuperTravel.InterfaceAdapter.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICreateUser userCreator;
        private readonly ILogIn logger;
        private readonly IUpdateUser userUpdater;

        public UserController(ICreateUser createUser, ILogIn logIn, IUpdateUser updateUser)
        {
            this.userCreator = createUser;
            this.logger = logIn;
            this.userUpdater = updateUser;
        }

        [HttpPost]
        public UserOutput CreateUser(UserInputCreate userInputCreate)
        {
            return this.userCreator.CreateUser(userInputCreate);
        }

        [HttpPut]
        public ActionResult<UserOutput> UpdateUser(UserInputUpdate userInputUpdate)
        {
            var userOutput = this.userUpdater.UpdateUser(userInputUpdate);
            if (userOutput != null)
            {
                return Ok(userOutput);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("{nickname}")]
        public ActionResult<UserOutput> LogIn([FromRoute][Required] string nickname, string password)
        {
            var userOutput = this.logger.LogIn(nickname, password);
            if (userOutput != null)
            {
                return Ok(userOutput);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
