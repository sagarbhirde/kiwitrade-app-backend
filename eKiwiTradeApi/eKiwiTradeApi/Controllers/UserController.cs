using eKiwiTradeApi.Logic.Interface;
using eKiwiTradeApi.Logic.Model;
using Microsoft.AspNetCore.Mvc;

namespace eKiwiTradeApi.Command.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


       [HttpPost]
        public async Task<IActionResult> Create(UserModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
           return Ok(await _userService.CreateUserAsync(user).ConfigureAwait(false));
        }


        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, UserModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _userService.UpdateUserAsync(id, user).ConfigureAwait(false);
            return NoContent();
        }
    }
}
