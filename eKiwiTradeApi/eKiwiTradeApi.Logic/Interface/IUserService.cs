using eKiwiTradeApi.Logic.Helper;
using eKiwiTradeApi.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKiwiTradeApi.Logic.Interface
{
    public interface IUserService
    {
        Task<Response<List<UserModel>>> GetAllUserAsync();

        Task<Response<UserModel>> GetUserByIdAsync(string id);

        Task<Response<UserModel>> CreateUserAsync(UserModel userModel);

        Task<Response<UserModel>> UpdateUserAsync(string id, UserModel userModel);

    }
}
